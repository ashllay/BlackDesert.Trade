using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Web;
using BlackDesert.Trade.Domain.Enum;
using BlackDesert.Trade.Domain.Extensions;

namespace BlackDesert.Trade.Domain.Common;

public static class CommonModule
{
  public const string HTTP_REQUEST_METHOD_GET = "GET";
  public const string HTTP_REQUEST_METHOD_DELETE = "DELETE";
  public const string HTTP_REQUEST_METHOD_POST = "POST";
  public const string HTTP_REQUEST_METHOD_PUT = "PUT";
  public const string HTTP_CONTENTS_TYPE_URL_ENC = "application/x-www-form-urlencoded";
  public const string HTTP_CONTENTS_TYPE_JSON = "text/json";
  public const string HTTP_CONTENTS_APP_TYPE_JSON = "application/json";

  public static string SerializeObjectToJsonString<T>(this T deserializeObject) {
    return JsonConvert.SerializeObject(deserializeObject);
  }

  public static T DeserializeObjectToJson<T>(this string serializeObject) {
    return JsonConvert.DeserializeObject<T>(serializeObject);
  }

  public static string SerializeObjectToQueryString<T>(T deserializeObject) {
    var empty = string.Empty;
    return string.Join("&",
                       deserializeObject.GetType()
                                        .GetProperties()
                                        .Where((Func<PropertyInfo, bool>)(param => param.GetValue((T)deserializeObject, null) != null))
                                        .Select((Func<PropertyInfo, string>)(param => param.Name + "=" + HttpUtility.UrlEncode(param.GetValue((T)deserializeObject, null).ToString())))
                                        .ToArray());
  }


  public static long ConvertUnixTime(this DateTime date) {
    return (long)(date - new DateTime(1970,
                                      1,
                                      1,
                                      0,
                                      0,
                                      0)).TotalSeconds;
  }

  public static long ConvertUnixTimeMs(this DateTime date) {
    return (long)(date - new DateTime(1970,
                                      1,
                                      1,
                                      0,
                                      0,
                                      0)).TotalMilliseconds;
  }


  public static string GetItemString(string itemName,
                                     int subKey) {
    var itemString = string.Empty;
    try {
      switch (subKey) {
        case 0:
          itemString = itemName ?? "";
          break;
        case 1:
          itemString = MarketError.TRADE_MARKET_ITEM_DEAD_ONE.GetResourceValue() + " " + itemName;
          break;
        case 2:
          itemString = MarketError.TRADE_MARKET_ITEM_DEAD_TWO.GetResourceValue() + " " + itemName;

          break;
        case 3:
          itemString = MarketError.TRADE_MARKET_ITEM_DEAD_THREE.GetResourceValue() + " " + itemName;

          break;
        case 4:
          itemString = MarketError.TRADE_MARKET_ITEM_DEAD_FOUR.GetResourceValue() + " " + itemName;

          break;
        case 5:
          itemString = MarketError.TRADE_MARKET_ITEM_DEAD_FIVE.GetResourceValue() + " " + itemName;

          break;
      }

      if (!itemString.Contains("TRADE_MARKET_ITEM_DEAD_ONE") && !itemString.Contains("TRADE_MARKET_ITEM_DEAD_TWO") && !itemString.Contains("TRADE_MARKET_ITEM_DEAD_THREE") &&
          !itemString.Contains("TRADE_MARKET_ITEM_DEAD_FOUR"))
        if (!itemString.Contains("TRADE_MARKET_ITEM_DEAD_FIVE"))
          goto label_12;

      itemString = itemName;
    }
    catch (Exception ex) {
      LogUtil.WriteLog("CommonModule GetItemString Exception=" + ex, "ERROR");
      return itemName;
    }

    label_12:
    return itemString;
  }

  public static string GetRandomString(int length = 16) {
    var charList = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
    var random = new Random(DateTime.UtcNow.Millisecond);
    return new string(Enumerable.Range(0, length).Select(x => charList[random.Next(0, charList.Length)]).ToArray());
  }

  public static DateTime ConvertUnixTimeStampToDateTime(long unixTimeStamp) {
    var dateTime = new DateTime(1970,
                                1,
                                1,
                                0,
                                0,
                                0,
                                0,
                                DateTimeKind.Utc);
    dateTime = dateTime.AddSeconds(Convert.ToDouble(unixTimeStamp, CultureInfo.InvariantCulture));
    return dateTime;
  }

  public static long ConvertDateTimeToUnixTimeStamp(DateTime dateTime) {
    var unixTimeStamp = 0.0;
    if (dateTime.IsNotNull())
      unixTimeStamp = dateTime.ToUniversalTime()
                              .Subtract(new DateTime(1970,
                                                     1,
                                                     1,
                                                     0,
                                                     0,
                                                     0,
                                                     DateTimeKind.Utc))
                              .TotalSeconds;
    return Convert.ToInt64(unixTimeStamp);
  }

  public static bool ValidateObjectInstance(object instance,
                                            out List<ValidationResult> results) {
    results = new List<ValidationResult>();
    var validationContext = new ValidationContext(instance, null, null);
    return Validator.TryValidateObject(instance, validationContext, results, true);
  }
}