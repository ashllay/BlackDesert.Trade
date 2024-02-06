

namespace BlackDesert.Trade.Business.Manager.DB;

public static class DbLogQueue
{
  private static readonly TaskQueue LogQueue = new();

  public static void Enqueue(Action action) {
    var tryCatch = new Action(() => {
      try {
        action();
      }
      catch (Exception e) {
        Log.Error(e, "DbLogQueue error");
      }
    });
    LogQueue.AddToQueue(tryCatch);
  }
}