namespace BlackDesert.Trade.Domain.Exceptions;


public class TradeMarketDbNotFoundException : TradeMarketException
{
  private TradeMarketDbNotFoundException(string name, params object[] param) : base($"Not found in db!! {name} ({string.Join("/",param)})")
  {
     
  }
  
  public static void ThrowIfNull(object obj, string name, params object[] param) 
  {
    if (obj is null)
      throw new TradeMarketDbNotFoundException(name, param);
  }
}