namespace BlackDesert.Trade.Domain.Exceptions;

public class TradeMarketDbSaveException : TradeMarketException
{
  private TradeMarketDbSaveException(string action, params object[] param) : base($"DbSave Fail!! {action} ({string.Join("/",param)})")
  {
     
  }
  public static void ThrowIfNotSuccess(int result, string action, params object[] param) 
  {
    if (result <= 0)
      throw new TradeMarketDbSaveException(action, param);
  }
}