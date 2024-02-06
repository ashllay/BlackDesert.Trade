using BlackDesert.Trade.Business.Manager.Server;

namespace BlackDesert.Trade.Business.Manager.Timers;

public class UpdateTickCountTimer
{
  private static readonly object _locker = new();
  private static bool _flag;

  public static void Execute(object? state) {
    lock (_locker) {
      if (_flag)
        return;
      _flag = true;
    }

    try {
      UpdateTickCount();
      ServerControlLogger.LogRunTimer(nameof(UpdateTickCountTimer));
    }
    catch (Exception ex) {
      Log.Error(ex, "[Timers Error] UpdateTickCountTimer Exception");
    }

    lock (_locker) {
      _flag = false;
    }
  }

  private static void UpdateTickCount() {
    if (OptionManager.This.IsSleepTime()) {
      LogUtil.WriteLog(string.Format("[Update INFO]updateTickCount() isSleepTime {0}", DateTime.Now.Hour), "INFO");
      return;
    }

    TickCountManager.This.UpdateTickCountXxx();
  }
}