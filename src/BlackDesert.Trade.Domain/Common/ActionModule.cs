using BlackDesert.Trade.Domain.Exceptions;

namespace BlackDesert.Trade.Domain.Common;

public static class ActionModule
{
  public static void RunAndLogIfException(Action action,
                                          string logMessage) {
    try {
      action();
    }
    catch (Exception e) {
      Log.Error(e, logMessage);
      throw;
    }
  }

  public static void RunAndLogIfRvNotZero(Func<int> action,
                                          string logMessage) {
    try {
      var rv = action();
      if (rv != 0) {
        throw new Exception(logMessage + $" rv({rv}) != 0");
      }
    }
    catch (Exception ex) {
      Log.Error(ex, logMessage);
      throw;
    }
  }
}