// Type: System.ObjectExtensions


using System.ComponentModel;
using System.Globalization;

namespace BlackDesert.Trade.Domain.Extensions;

public static class ObjectExtensions
{
  private static readonly HashSet<string> BooleanValues = new(StringComparer.OrdinalIgnoreCase) {
    "true",
    "1",
    "on",
    "yes",
    "y"
  };

  public static T ConvertTo<T>(this object value) {
    return value.ConvertTo<T>(default);
  }

  public static T ConvertTo<T>(this object value,
                               T defaultValue) {
    return value.ConvertTo(defaultValue, true);
  }

  public static T ConvertTo<T>(this object value,
                               T defaultValue,
                               bool ignoreException) {
    if (!ignoreException)
      return value.Convert(defaultValue);
    try {
      return value.Convert(defaultValue);
    }
    catch {
      return typeof(T).Equals(typeof(string)) && defaultValue.IsNull()
               ? default
               : defaultValue;
    }
  }

  private static T Convert<T>(this object value,
                              T defaultValue) {
    var type = typeof(T);
    if (value.IsNull()) {
      if (type.Equals(typeof(string)) && defaultValue.IsNull())
        return default;
    }
    else {
      if (type.Equals(typeof(bool)))
        return default;
      if (type.Equals(typeof(decimal))) {
        decimal result;
        return !decimal.TryParse(value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out result)
                 ? default(T)
                 : default;
      }

      if (value.GetType() == type)
        return (T)value;
      var converter1 = TypeDescriptor.GetConverter(value);
      if (converter1.IsNotNull()) {
        if (converter1.CanConvertTo(type))
          return (T)converter1.ConvertTo(value, type);
        if (converter1.GetType() == typeof(EnumConverter) && type == typeof(int))
          return (T)value;
      }

      var converter2 = TypeDescriptor.GetConverter(type);
      if (converter2.IsNotNull() && converter2.CanConvertFrom(value.GetType()))
        return (T)converter2.ConvertFrom(value);
    }

    return defaultValue;
  }

  public static bool IsNull(this object target) {
    return target.IsNull<object>();
  }

  public static bool IsNull<T>(this T target) {
    return (object)target == DBNull.Value || target == null;
  }

  public static bool IsNotNull(this object target) {
    return !target.IsNull();
  }

  public static bool IsNullOrEmpty(this string target) {
    return string.IsNullOrEmpty(target);
  }

  public static bool IsNullOrWhiteSpace(this string target) {
    return string.IsNullOrWhiteSpace(target);
  }

  public static bool IsNotNullOrEmpty(this string target) {
    return !string.IsNullOrEmpty(target);
  }

  public static bool IsNotNullOrWhiteSpace(this string target) {
    return !string.IsNullOrWhiteSpace(target);
  }

  public static bool Contains(this string self,
                              string value,
                              StringComparison compare) {
    return !string.IsNullOrEmpty(self) && !string.IsNullOrEmpty(value) && 0 <= self.IndexOf(value, compare);
  }
}