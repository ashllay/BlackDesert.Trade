namespace BlackDesert.Trade.Domain.Common;

public static class RetryHelper
{
  public static void RunWithRetry(Action action,
                                  int retryCount = 3,
                                  int delayMs = 1000,
                                  string description = "") {
    var retry = 0;
    while (true)
      try {
        action();
        return;
      }
      catch (Exception ex) {
        if (retry >= retryCount) throw;
        retry++;
        Log.Error(ex, $"RunWithRetry - {description} - Retry {retry}/{retryCount}");
        Thread.Sleep(delayMs);
      }
  }

  public static void RunWithRetryAsync(Action action,
                                       int retryCount = 3,
                                       int delayMs = 1000,
                                       string description = "") {
    Task.Run(() => RunWithRetry(action, retryCount, delayMs, description));
  }
}