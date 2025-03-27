namespace HomeAssistant.Addon.PortainerMonitor.AddonModels;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Mqtt;
using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;
using HomeAssistant.Addon.PortainerMonitor.Portainer;

/// <summary>
/// Base class for all addon models
/// </summary>
internal abstract class ModelBase : IDisposable
{
    #region Static Fields

    /// <summary>
    /// Availability topic as string format to inject the topic name
    /// </summary>
    protected const string AvailabilityTopic = "portainermonitor/{0}_status";

    #endregion

    #region Private Fields

    private readonly ConcurrentDictionary<string, HaEntityBase> _haEntities = new();

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ModelBase" /> class.
    /// </summary>
    /// <param name="portainerApi">The portainer API.</param>
    /// <param name="mqttClient">The MQTT client.</param>
    /// <param name="device">The root device.</param>
    /// <param name="nameID">The MQTT identifier of this model without prefix.</param>
    /// <param name="parentMqttIdPrefix">The parent MQTT identifier prefix.</param>
    protected ModelBase(IPortainerApi portainerApi, IMqttClient mqttClient, HaDevice device, string nameID, string? parentMqttIdPrefix)
    {
        PortainerApi = portainerApi;
        MqttClient = mqttClient;
        Device = device;
        NameID = nameID;
        MqttIdPrefix = !string.IsNullOrWhiteSpace(parentMqttIdPrefix) ? 
                           HaEntityBase.BuildID(parentMqttIdPrefix, nameID) :
                           HaEntityBase.BuildID(nameID);
        MqttClient.ConnectionStateChanged += OnMqttConnectionStateChanged;
        MqttClient.HomeAssistantAvailabilityChanged += OnHomeAssistantAvailabilityChanged;
    }
    
    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the Home Assistant device.
    /// </summary>
    internal HaDevice Device { get; }

    /// <summary>
    /// Gets the portainer API.
    /// </summary>
    internal IPortainerApi PortainerApi { get; }

    /// <summary>
    /// Gets the MQTT client.
    /// </summary>
    internal IMqttClient MqttClient { get; }

    /// <summary>
    /// Gets the MQTT identifier prefix including the parent parts.
    /// </summary>
    internal string MqttIdPrefix { get; }

    /// <summary>
    /// Gets the MQTT identifier of this model without the prefix.
    /// </summary>
    internal string NameID { get; }

    /// <summary>
    /// Gets a value indicating whether the model is disposed.
    /// </summary>
    internal bool IsDisposed { get; private set; }

    /// <summary>
    /// Gets the child entities.
    /// </summary>
    protected IReadOnlyDictionary<string, HaEntityBase> Entities => _haEntities;

    #endregion

    #region Public Methods

    /// <inheritdoc />
    public void Dispose()
    {
        if(IsDisposed) return;
        IsDisposed = true;
        OnDispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Called before <see cref="OnUpdateStatesAsync"/> has been called.
    /// </summary>
    /// <param name="force">if set to <c>true</c> force update.</param>
    internal virtual Task OnBeforeUpdateStatesAsync(bool force)
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// Called when model should update the entity values <see cref="OnUpdateStatesAsync" />.
    /// </summary>
    /// <param name="force">if set to <c>true</c> force update.</param>
    /// <returns>If update was successful</returns>
    internal abstract Task<bool> OnUpdateStatesAsync(bool force);

    /// <summary>
    /// Called when <see cref="OnUpdateStatesAsync" /> has been completed.
    /// </summary>
    /// <param name="force">if set to <c>true</c> force update.</param>
    /// <param name="successful">if set to <c>true</c> if update was successful.</param>
    /// <remarks>Automatically calls the <see cref="HaEntityBase.SendStateAsync" /> for all created entities</remarks>
    internal virtual async Task OnUpdateStatesCompletedAsync(bool force, bool successful)
    {
        foreach (var entity in _haEntities.Values)
        {
            await entity.SendStateAsync(force).ConfigureAwait(false);
        }
    }

    /// <summary>
    /// Updates the model and syncs the model states with the Home Assistant entities.
    /// </summary>
    /// <param name="force">if set to <c>true</c> force update.</param>
    /// <returns>If update was successful</returns>
    internal async Task<bool> UpdateAsync(bool force = false)
    {
        await OnBeforeUpdateStatesAsync(force).ConfigureAwait(false);
        var successful = await OnUpdateStatesAsync(force).ConfigureAwait(false);
        await OnUpdateStatesCompletedAsync(force, successful).ConfigureAwait(false);
        return successful;
    }

    /// <summary>
    /// Creates a <see cref="HaSensor{T}"/> MQTT entity instance.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="id">The sensor MQTT identifier without prefix.</param>
    /// <param name="displayName">The display name of the sensor (e.g. Outdoor Temperature).</param>
    /// <param name="valueConverter">The value converter.</param>
    /// <remarks>The created entity gets disposed automatically when <see cref="OnDispose"/> will be called.</remarks>
    protected HaSensor<T> CreateSensorEntity<T>(string id, string displayName, IValueConverter<T>? valueConverter = null) where T : IConvertible
    {
        var entityId = HaEntityBase.BuildID(MqttIdPrefix, id);
        if (_haEntities.ContainsKey(entityId)) throw new ArgumentException($"Entity with ID `{entityId}` already exists");

        var haSensor = new HaSensor<T>(entityId, displayName, Device, MqttClient, valueConverter);
        _haEntities[entityId] = haSensor;
        return haSensor;
    }

    /// <summary>
    /// Creates a <see cref="HaSwitch"/> MQTT entity instance.
    /// </summary>
    /// <param name="id">The switch MQTT identifier without prefix.</param>
    /// <param name="displayName">The display name of the switch (e.g. Outdoor Temperature).</param>
    /// <remarks>The created entity gets disposed automatically.</remarks>
    protected HaSwitch CreateSwitchEntity(string id, string displayName)
    {
        var entityId = HaEntityBase.BuildID(MqttIdPrefix, id);
        if (_haEntities.ContainsKey(entityId)) throw new ArgumentException($"Entity with ID `{entityId}` already exists");

        var haSwitch = new HaSwitch(entityId, displayName, Device, MqttClient);
        _haEntities[entityId] = haSwitch;
        return haSwitch;
    }

    /// <summary>
    /// Creates a <see cref="HaUpdate"/>  MQTT entity instance.
    /// </summary>
    /// <param name="id">The update MQTT identifier without prefix.</param>
    /// <param name="displayName">The display name of the update (e.g. Device update available).</param>
    /// <remarks>The created entity gets disposed automatically.</remarks>
    protected HaUpdate CreateUpdateEntity(string id, string displayName)
    {
        var entityId = HaEntityBase.BuildID(MqttIdPrefix, id);
        if (_haEntities.ContainsKey(entityId)) throw new ArgumentException($"Entity with ID `{entityId}` already exists");

        var haUpdate = new HaUpdate(entityId, displayName, Device, MqttClient);
        _haEntities[entityId] = haUpdate;
        return haUpdate;
    }

    /// <summary>
    /// Creates a <see cref="HaButton"/>  MQTT entity instance.
    /// </summary>
    /// <param name="id">The button MQTT identifier without prefix.</param>
    /// <param name="displayName">The display name of the button (e.g. Start Robot).</param>
    /// <remarks>The created entity gets disposed automatically.</remarks>
    protected HaButton CreateButtonEntity(string id, string displayName)
    {
        var entityId = HaEntityBase.BuildID(MqttIdPrefix, id);
        if (_haEntities.ContainsKey(entityId)) throw new ArgumentException($"Entity with ID `{entityId}` already exists");

        var haButton = new HaButton(entityId, displayName, Device, MqttClient);
        _haEntities[entityId] = haButton;
        return haButton;
    }

    /// <summary>
    /// Removes the entity from the child <see cref="Entities" /> and disposes it.
    /// </summary>
    /// <param name="entity">The child entity to be deleted.</param>
    /// <returns><c>true</c> if the entity has been removed and disposed, otherwise <c>false</c></returns>
    protected bool RemoveEntity(HaEntityBase entity)
    {
        if (!_haEntities.TryRemove(entity.ID, out var childEntity)) return false;
        childEntity.Dispose();
        return true;
    }

    /// <summary>
    /// Called when MQTT connection state has changed.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">if set to <c>true</c> connected, otherwise <c>false</c>.</param>
    protected virtual void OnMqttConnectionStateChanged(object? sender, bool e)
    {
    }

    /// <summary>
    /// Called when home assistant availability has changed.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">if set to <c>true</c> available, otherwise <c>false</c>.</param>
    protected virtual void OnHomeAssistantAvailabilityChanged(object? sender, bool e)
    {
    }

    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
    protected virtual void OnDispose(bool disposing)
    {
        if (!disposing) return;
        MqttClient.ConnectionStateChanged -= OnMqttConnectionStateChanged;
        MqttClient.HomeAssistantAvailabilityChanged -= OnHomeAssistantAvailabilityChanged;
        foreach (var entity in _haEntities.Values) { entity.Dispose(); }
        _haEntities.Clear();
    }

    #endregion

    #region Private Methods

    #endregion
}

/// <summary>
/// Base class for all addon models with parent model access
/// </summary>
/// <typeparam name="T"></typeparam>
/// <seealso cref="System.IDisposable" />
internal abstract class ModelBase<T> : ModelBase where T : ModelBase
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ModelBase{T}"/> class.
    /// </summary>
    /// <param name="parent">The parent.</param>
    /// <param name="nameID">The MQTT identifier of this model without prefix.</param>
    protected ModelBase(T parent, string nameID)
        : base(parent.PortainerApi, parent.MqttClient, parent.Device, nameID, parent.MqttIdPrefix)
    {
        Parent = parent;
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <summary>
    /// Gets the parent.
    /// </summary>
    internal T Parent { get; }

    #endregion

    #region Public Methods

    #endregion

    #region Private Methods

    #endregion
}