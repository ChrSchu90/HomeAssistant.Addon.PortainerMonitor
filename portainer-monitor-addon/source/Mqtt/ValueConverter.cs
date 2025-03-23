namespace HomeAssistant.Addon.PortainerMonitor.Mqtt;

using System;
using System.Globalization;

/// <inheritdoc cref="IValueConverter{T}"/>
internal class ValueConverter<T> : IValueConverter<T> where T : IConvertible
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ValueConverter{T}"/> class.
    /// </summary>
    /// <param name="formatProvider">The format provider.</param>
    internal ValueConverter(IFormatProvider? formatProvider = null)
    {
        FormatProvider = formatProvider ?? CultureInfo.InvariantCulture;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the format provider that will be used for formatting.
    /// </summary>
    internal IFormatProvider FormatProvider { get; }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    public T DataToValue(string data)
    {
        return (T)Convert.ChangeType(data, typeof(T), FormatProvider);
    }

    /// <inheritdoc />
    public string ValueToData(T value)
    {
        return value.ToString(FormatProvider);
    }

    #endregion

    #region Private Methods

    #endregion
}

/// <inheritdoc cref="IValueConverter{T}"/>
internal class DelegateConverter<T> : IValueConverter<T>
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    private readonly Func<string, T> _dataToValue;
    private readonly Func<T, string> _valueToData;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="DelegateConverter{T}"/> class.
    /// </summary>
    internal DelegateConverter(Func<string, T> dataToValue, Func<T, string> valueToData)
    {
        _dataToValue = dataToValue;
        _valueToData = valueToData;
    }

    #endregion

    #region Properties

    #endregion

    #region Public Methods

    /// <inheritdoc />
    T IValueConverter<T>.DataToValue(string data) => _dataToValue(data);

    /// <inheritdoc />
    public string ValueToData(T value) => _valueToData(value);

    #endregion

    #region Private Methods

    #endregion
}

/// <summary>
/// Converter for managed to MQTT value string conversion
/// </summary>
internal interface IValueConverter<T>
{
    /// <summary>
    /// Data string to managed value.
    /// </summary>
    /// <param name="data">The string data.</param>
    T DataToValue(string data);

    /// <summary>
    /// Value to data string.
    /// </summary>
    /// <param name="value">The managed value.</param>
    string ValueToData(T value);
}