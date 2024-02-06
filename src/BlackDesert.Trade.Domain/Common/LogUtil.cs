using Serilog.ConfigHelper;
using Serilog.ConfigHelper.Enricher;
using Serilog.ConfigHelper.Enricher.HttpRequestEnrichers;
using Serilog.Events;
using Serilog.Formatting.Compact;

// using log4net;
// using log4net.Appender;
// using log4net.Core;
// using log4net.Layout;
// using log4net.Layout.Pattern;
// using log4net.Repository.Hierarchy;

namespace BlackDesert.Trade.Domain.Common;

public static class LogUtil
{
  // public static string[] PermitHeadersArr = new string[20] {
  //   "HOST",
  //   "ORIGIN",
  //   "X-FORWARDED-FOR",
  //   "ACCEPT",
  //   "ACCESSTOKEN",
  //   "CONTENT-LENGTH",
  //   "CONTENT-TYPE",
  //   "COOKIE",
  //   "REFERER",
  //   "SEC-CH-UA",
  //   "SEC-CH-UA-MOBILE",
  //   "SEC-FETCH-SITE",
  //   "SERVERREGION",
  //   "USER-AGENT",
  //   "X-ORIGINAL-HOST",
  //   "X-ORIGINAL-URL",
  //   "X-ORIGINAL-IP",
  //   "X-FORWARDED-PORT",
  //   "X-FORWARDED-PROTO",
  //   "X-PA-IP"
  // };

  private static bool _isConfigured;

  public static void ConfigureSerilog() {
    if (_isConfigured)
      return;
    _isConfigured = true;
    var logPath = ConstantContainer.LogsDirectory + "\\BDTradeMarket_.json";
    var template = new SerilogTemplateBuilder()
                   .AddTimeStamp()
                   .AddLevel()
                   .AddMessage()
                   .AddProperty("IpAddress")
                   .AddException()
                   .Build();
    var configuration = new LoggerConfiguration()
                        .SetLogLevel(GetLogLevelFromConfig())
                        .Enrich.FromLogContext()
                        .Enrich.With(new HttpRequestIpAddressEnricher("CF-Connecting-IP"))
                        .Enrich.With(new HttpRequestPathEnricher())
                        .Enrich.With(new HttpRequestTraceIdentifiedEnricher())
                        .Enrich.With(new HttpRequestMethodEnricher())
                        .Enrich.With(new HttpRequestQueryStringEnricher())
                        .Enrich.With(new HostIpAddressEnricher())
                        .WriteTo.File(new CompactJsonFormatter(), logPath, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 14)
                        .WriteTo.Console(outputTemplate: template);
    Log.Logger = configuration.CreateLogger();
  }

  private static LogEventLevel GetLogLevelFromConfig() {
    var logLevelText = ConstantContainer.LogLevel;
    if (logLevelText.StartsWith("info", StringComparison.InvariantCultureIgnoreCase))
      return LogEventLevel.Information;
    if (logLevelText.StartsWith("warn", StringComparison.InvariantCultureIgnoreCase))
      return LogEventLevel.Warning;
    if (logLevelText.StartsWith("error", StringComparison.InvariantCultureIgnoreCase))
      return LogEventLevel.Error;
    if (logLevelText.StartsWith("fatal", StringComparison.InvariantCultureIgnoreCase))
      return LogEventLevel.Fatal;
    if (logLevelText.StartsWith("verbose", StringComparison.InvariantCultureIgnoreCase))
      return LogEventLevel.Verbose;
    return LogEventLevel.Information;
  }


  public static void WriteLog(
    string message,
    string level) {
    if (level.Equals("DEBUG")) {
      if (!ConstantContainer.IsLive.Equals(false))
        return;
      Log.Debug(message);
    }
    else if (level.Equals("INFO")) {
      Log.Information(message);
    }
    else if (level.Equals("WARN")) {
      Log.Warning(message);
    }
    else if (level.Equals("ERROR")) {
      Log.Error(message);
    }
    else {
      if (!level.Equals("FATAL"))
        return;
      Log.Fatal(message);
    }
  }
}