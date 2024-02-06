using System.Globalization;
using BlackDesert.Trade.Domain.Enum;
using BlackDesert.Trade.Domain.Extensions;

namespace BlackDesert.Trade.Domain.Common;

public static class ConstantContainer
{
  public const int RegisterQueueWaitMinutes = 15; //TODO IMPLEMENT CHECK EVERYWHERE
  public static readonly bool CheckAndLogPerformance = ConfigurationManager.AppSettings["checkAndLogPerformance"].ConvertTo(false);
  public static readonly int CheckAndLogPerformanceCheckMs = ConfigurationManager.AppSettings["checkAndLogPerformanceCheckMs"].ConvertTo(1000);
  public static readonly string CultureList = ConfigurationManager.AppSettings["cultureList"] ?? "en-US";
  public static readonly string LogLevel = ConfigurationManager.AppSettings["logLevel"] ?? "info";
  public static readonly string ServiceType = ConfigurationManager.AppSettings["serviceType"] ?? "NA";
  public static readonly int ServiceUtcTime = ConfigurationManager.AppSettings["ServiceUtcTime"].ConvertTo(0);
  public static readonly string UtcTimeZoneId = ConfigurationManager.AppSettings["UtcTimeZoneID"] ?? "Korea Standard Time";
  public static readonly bool IsServerTime = ConfigurationManager.AppSettings["isServerTime"].ConvertTo(false);
  public static readonly bool IsLive = ConfigurationManager.AppSettings["isLive"].ConvertTo(false);
  public static readonly string LanguageList = ConfigurationManager.AppSettings["languageList"] ?? string.Empty;

  public static DateTime DefaultDateTime = new(1970,
                                               1,
                                               1,
                                               0,
                                               0,
                                               0,
                                               DateTimeKind.Utc);

  public static int[] MaidCharacterNoList {
    get {
      var cfg = ConfigurationManager.AppSettings["maidCharacterNoList"];
      if (cfg == null || cfg == string.Empty || cfg == "") throw new Exception("maidCharacterNoList is null");
      var list = cfg.Split('|')
                    .Select(x => x.ConvertTo(0))
                    .Where(x => x != 0)
                    .ToArray();
      return list;
    }
  }

  public static string DefaultCultureName => DefaultCulture.Name;

  public static CultureInfo DefaultCulture {
    get {
      var culture = ConfigurationManager.AppSettings["defaultCulture"] ?? string.Empty;
      if (string.IsNullOrEmpty(culture)) culture = "en-US";
      return new CultureInfo(culture);
    }
  }

  public static string ContentsDirectory {
    get {
      var cfg = ConfigurationManager.AppSettings["contentsDirectoryPath"];
      if (cfg == null || cfg == string.Empty || cfg == "") throw new Exception("contentsDirectoryPath is null");
      var isDirectoryExists = Directory.Exists(cfg);
      if (!isDirectoryExists) throw new Exception("contentsDirectoryPath is not exists");
      return cfg;
    }
  }

  public static string ConfigDirectory {
    get {
      var cfg = ConfigurationManager.AppSettings["configDirectory"];
      if (cfg == null || cfg == string.Empty || cfg == "") throw new Exception("configDirectory is null");
      var isDirectoryExists = Directory.Exists(cfg);
      if (!isDirectoryExists) throw new Exception("configDirectory is not exists");
      return cfg;
    }
  }

  public static string LogsDirectory {
    get {
      var cfg = ConfigurationManager.AppSettings["logsDirectoryPath"];
      if (cfg == null || cfg == string.Empty || cfg == "") throw new Exception("logsDirectoryPath is null");
      var isDirectoryExists = Directory.Exists(cfg);
      if (!isDirectoryExists) Directory.CreateDirectory(cfg);
      return cfg;
    }
  }

  public static bool DoSendAlarm {
    get {
      try {
        var config = ConfigurationManager.AppSettings["doSendAlarm"];
        return config.ConvertTo(false);
      }
      catch (Exception) {
        return false;
      }
    }
  }

  public static KeyType KeyType => KeyType.eItem;
  public static int KeyTypeInt => (int)KeyType;
  
}