namespace HomeAssistant.Addon.PortainerMonitor.Mqtt;

using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;

/// <summary>
/// Home Assistant Units of measurements for <see cref="HaSensor{T}.UnitOfMeasurement"/> see:
/// <see href="https://github.com/home-assistant/core/blob/d7ac4bd65379e11461c7ce0893d3533d8d8b8cbf/homeassistant/const.py#L384"/>
/// </summary>
public static class HaUnitOfMeasurement
{
    public const string POWER_WATT = "W";
    public const string POWER_KILO_WATT = "kW";
    public const string VOLT = "V";
    public const string ENERGY_WATT_HOUR = "Wh";
    public const string ENERGY_KILO_WATT_HOUR = "kWh";
    public const string ELECTRICAL_CURRENT_AMPERE = "A";
    public const string ELECTRICAL_VOLT_AMPERE = "VA";
    public const string DEGREE = "°";
    public const string CURRENCY_EURO = "€";
    public const string CURRENCY_DOLLAR = "$";
    public const string CURRENCY_CENT = "¢";
    public const string TEMP_CELSIUS = "°C";
    public const string TEMP_FAHRENHEIT = "°F";
    public const string TEMP_KELVIN = "K";
    public const string TIME_MICROSECONDS = "μs";
    public const string TIME_MILLISECONDS = "ms";
    public const string TIME_SECONDS = "s";
    public const string TIME_MINUTES = "min";
    public const string TIME_HOURS = "h";
    public const string TIME_DAYS = "d";
    public const string TIME_WEEKS = "w";
    public const string TIME_MONTHS = "m";
    public const string TIME_YEARS = "y";
    public const string LENGTH_MILLIMETERS = "mm";
    public const string LENGTH_CENTIMETERS = "cm";
    public const string LENGTH_METERS = "m";
    public const string LENGTH_KILOMETERS = "km";
    public const string LENGTH_INCHES = "in";
    public const string LENGTH_FEET = "ft";
    public const string LENGTH_YARD = "yd";
    public const string LENGTH_MILES = "mi";
    public const string FREQUENCY_HERTZ = "Hz";
    public const string FREQUENCY_GIGAHERTZ = "GHz";
    public const string PRESSURE_PA = "Pa";
    public const string PRESSURE_HPA = "hPa";
    public const string PRESSURE_BAR = "bar";
    public const string PRESSURE_MBAR = "mbar";
    public const string PRESSURE_INHG = "inHg";
    public const string PRESSURE_PSI = "psi";
    public const string VOLUME_LITERS = "L";
    public const string VOLUME_MILLILITERS = "mL";
    public const string VOLUME_CUBIC_METERS = "m³";
    public const string VOLUME_CUBIC_FEET = "ft³";
    public const string VOLUME_GALLONS = "gal";
    public const string VOLUME_FLUID_OUNCE = "fl. oz.";
    public const string VOLUME_FLOW_RATE_CUBIC_METERS_PER_HOUR = "m³/h";
    public const string VOLUME_FLOW_RATE_CUBIC_FEET_PER_MINUTE = "ft³/m";
    public const string AREA_SQUARE_METERS = "m²";
    public const string MASS_GRAMS = "g";
    public const string MASS_KILOGRAMS = "kg";
    public const string MASS_MILLIGRAMS = "mg";
    public const string MASS_MICROGRAMS = "µg";
    public const string MASS_OUNCES = "oz";
    public const string MASS_POUNDS = "lb";
    public const string CONDUCTIVITY = "µS/cm";
    public const string LIGHT_LUX = "lx";
    public const string UV_INDEX = "UV index";
    public const string PERCENTAGE = "%";
    public const string IRRADIATION_WATTS_PER_SQUARE_METER = "W/m²";
    public const string PRECIPITATION_MILLIMETERS_PER_HOUR = "mm/h";
    public const string CONCENTRATION_MICROGRAMS_PER_CUBIC_METER = "µg/m³";
    public const string CONCENTRATION_MILLIGRAMS_PER_CUBIC_METER = "mg/m³";
    public const string CONCENTRATION_PARTS_PER_CUBIC_METER = "p/m³";
    public const string CONCENTRATION_PARTS_PER_MILLION = "ppm";
    public const string CONCENTRATION_PARTS_PER_BILLION = "ppb";
    public const string SPEED_MILLIMETERS_PER_DAY = "mm/d";
    public const string SPEED_INCHES_PER_DAY = "in/d";
    public const string SPEED_METERS_PER_SECOND = "m/s";
    public const string SPEED_INCHES_PER_HOUR = "in/h";
    public const string SPEED_KILOMETERS_PER_HOUR = "km/h";
    public const string SPEED_MILES_PER_HOUR = "mph";
    public const string SIGNAL_STRENGTH_DECIBELS = "dB";
    public const string SIGNAL_STRENGTH_DECIBELS_MILLIWATT = "dBm";
    public const string DATA_BITS = "bit";
    public const string DATA_KILOBITS = "kbit";
    public const string DATA_MEGABITS = "Mbit";
    public const string DATA_GIGABITS = "Gbit";
    public const string DATA_BYTES = "B";
    public const string DATA_KILOBYTES = "kB";
    public const string DATA_MEGABYTES = "MB";
    public const string DATA_GIGABYTES = "GB";
    public const string DATA_TERABYTES = "TB";
    public const string DATA_PETABYTES = "PB";
    public const string DATA_EXABYTES = "EB";
    public const string DATA_ZETTABYTES = "ZB";
    public const string DATA_YOTTABYTES = "YB";
    public const string DATA_KIBIBYTES = "KiB";
    public const string DATA_MEBIBYTES = "MiB";
    public const string DATA_GIBIBYTES = "GiB";
    public const string DATA_TEBIBYTES = "TiB";
    public const string DATA_PEBIBYTES = "PiB";
    public const string DATA_EXBIBYTES = "EiB";
    public const string DATA_ZEBIBYTES = "ZiB";
    public const string DATA_YOBIBYTES = "YiB";
    public const string DATA_RATE_BITS_PER_SECOND = "bit/s";
    public const string DATA_RATE_KILOBITS_PER_SECOND = "kbit/s";
    public const string DATA_RATE_MEGABITS_PER_SECOND = "Mbit/s";
    public const string DATA_RATE_GIGABITS_PER_SECOND = "Gbit/s";
    public const string DATA_RATE_BYTES_PER_SECOND = "B/s";
    public const string DATA_RATE_KILOBYTES_PER_SECOND = "kB/s";
    public const string DATA_RATE_MEGABYTES_PER_SECOND = "MB/s";
    public const string DATA_RATE_GIGABYTES_PER_SECOND = "GB/s";
    public const string DATA_RATE_KIBIBYTES_PER_SECOND = "KiB/s";
    public const string DATA_RATE_MEBIBYTES_PER_SECOND = "MiB/s";
    public const string DATA_RATE_GIBIBYTES_PER_SECOND = "GiB/s";
}

/// <summary>
/// Home Assistant device classes for <see cref="HaEntityBase.DeviceClass"/> see:
/// <see href="https://github.com/home-assistant/core/blob/d7ac4bd65379e11461c7ce0893d3533d8d8b8cbf/homeassistant/const.py#L384"/>
/// </summary>
public static class HaDeviceClass
{
    public const string DEVICE_CLASS_BATTERY = "battery";
    public const string DEVICE_CLASS_CO = "carbon_monoxide";
    public const string DEVICE_CLASS_CO2 = "carbon_dioxide";
    public const string DEVICE_CLASS_HUMIDITY = "humidity";
    public const string DEVICE_CLASS_ILLUMINANCE = "illuminance";
    public const string DEVICE_CLASS_SIGNAL_STRENGTH = "signal_strength";
    public const string DEVICE_CLASS_TEMPERATURE = "temperature";
    public const string DEVICE_CLASS_TIMESTAMP = "timestamp";
    public const string DEVICE_CLASS_PRESSURE = "pressure";
    public const string DEVICE_CLASS_POWER = "power";
    public const string DEVICE_CLASS_CURRENT = "current";
    public const string DEVICE_CLASS_ENERGY = "energy";
    public const string DEVICE_CLASS_POWER_FACTOR = "power_factor";
    public const string DEVICE_CLASS_VOLTAGE = "voltage";
}

/// <summary>
/// Home Assistant Native Values for states
/// </summary>
public static class HaNativeValue
{
    public const string NONE = "None";
    public const string STRING = "str";
    public const string INT = "int";
    public const string FLOAT = "float";
    public const string DATE = "date";
    public const string DATETIME = "datetime";
    public const string DECIMAL = "Decimal";
}

/// <summary>
/// Home Assistant sensor state classes for <see cref="HaSensor{T}.StateClass"/> see:
/// <see href="https://developers.home-assistant.io/docs/core/entity/sensor/#available-state-classes"/>
/// </summary>
public static class HaSensorStateClass
{
    public const string MEASUREMENT = "measurement";
    public const string TOTAL = "total";
    public const string TOTAL_INCREASING = "total_increasing";
}

/// <summary>
/// Home Assistant availability states and modes
/// </summary>
public static class HaAvailability
{
    /// <summary>
    /// Entity is available
    /// </summary>
    public const string IsAvailable = "online";

    /// <summary>
    /// Entity is not available
    /// </summary>
    public const string IsUnavailable = "offline";

    /// <summary>
    /// The mode all.
    /// If set to all, payload_available must be received on all configured availability topics before the entity is marked as online.
    /// </summary>
    public const string ModeAll = "all";

    /// <summary>
    /// The availability mode Any.
    /// If set to any, payload_available must be received on at least one configured availability topic before the entity is marked as online.
    /// </summary>
    public const string ModeAny = "any";

    /// <summary>
    /// The availability mode latest (default).
    /// If set to latest, the last payload_available or payload_not_available received on any configured availability topic controls the availability.
    /// </summary>
    public const string ModeLatest = "latest";
}