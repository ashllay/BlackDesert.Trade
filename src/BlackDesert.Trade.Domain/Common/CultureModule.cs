using System.Globalization;
using System.Resources;
using BlackDesert.Trade.Domain.Enum;

namespace BlackDesert.Trade.Domain.Common;

public static class CultureModule
{
  public static string GetResourceValue(string resKey) {
    try {
      var culture = new CultureInfo(ConstantContainer.DefaultCultureName);
      var resourceValue = GetResourceValue(resKey, culture)
                          ?? GetResourceValue("TRADE_MARKET_WEB_ERROR_" + resKey, culture)
                          ?? GetResourceValue("TRADE_MARKET_GAME_ERROR_" + resKey, culture)
                          ?? resKey;
      return resourceValue;
    }
    catch (Exception ex) {
      LogUtil.WriteLog("GetResourceValue Exception Error " + ex, "ERROR");
      return resKey;
    }
  }

  public static DateTime GetCustomTimeNow() {
    var utcNow = DateTime.UtcNow;
    try {
      return TimeZoneInfo.ConvertTime(DateTime.UtcNow,
                                      TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Utc.StandardName),
                                      ConstantContainer.IsServerTime
                                        ? TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id)
                                        : TimeZoneInfo.FindSystemTimeZoneById(ConstantContainer.UtcTimeZoneId));
    }
    catch (TimeZoneNotFoundException) {
      return utcNow;
    }
  }

  public static string? GetResourceValue(string resourceKey,
                                         CultureInfo cultureInfo) {
    try {
      var resourceManager = new ResourceManager(typeof(Resources.Resources));
      var resourceValue = resourceManager.GetString(resourceKey, cultureInfo);
      return resourceValue;
    }
    catch (Exception ex) {
      Log.Error(ex, "GetResourceValue Error : {resourceKey}", resourceKey);
      return null;
    }
  }
  // public static DateTime GetCustomTimeNow(CustomTimeModel model) {
  //   var utcNow = DateTime.UtcNow;
  //   var utcTimeZone = TimeZoneInfo.Utc;
  //   try {
  //     var timeZone = model.useServerTime
  //                      ? TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id)
  //                      : TimeZoneInfo.FindSystemTimeZoneById(model.utcTimeZoneID);
  //
  //     return TimeZoneInfo.ConvertTime(utcNow, utcTimeZone, timeZone);
  //   }
  //   catch (TimeZoneNotFoundException) {
  //     return utcNow;
  //   }
  // }

  public static string GetResourceValue(this MarketError error) {
    return GetResourceValue(error.ToString());
  }
}