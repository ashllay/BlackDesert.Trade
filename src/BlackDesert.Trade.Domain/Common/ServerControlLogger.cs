namespace BlackDesert.Trade.Domain.Common;

public class ServerControlLogger
{
  public static void LogStart(string name) {
    Log.Information($"[{name}] Open Start !");
  }

  public static void LogComplete(string name,
                                 long processTime) {
    Log.Information($"[{name}] Open Complete ! Processing ms = ({processTime})");
  }

  public static void LogAlready(string name) {
    Log.Information($"[{name}] Already Open !");
  }

  public static void LogImpossible(string name) {
    Log.Information($"[{name}] Impossible Open !");
  }

  public static void LogLoading(string name) {
    Log.Information($"[{name}] Loading... .");
  }

  public static void LogNotOpen(string name) {
    Log.Information($"[{name}] Not Open... .");
  }

  public static void LogRunTimer(string name) {
    Log.Debug($"[{name}] Run Timers");
  }

  public static void LogSetTimer(string name) {
    Log.Information($"[{name}] Set Timers");
  }

  public static void LogOpen(string name) {
    Log.Information($"[{name}] All Open!");
  }

  public static void LogNothing(string name) {
    Log.Information($"[{name}] Nothing");
  }

  public static void ServerErrorLogWrite(string name = "",
                                         int errorCode = 0,
                                         string errorSource = "") {
    Log.Fatal("[{name}] {ErrorSource} Slack_Alarm error!! An error occurred while processing!! {Rv}", name, errorSource, errorSource);
  }
}