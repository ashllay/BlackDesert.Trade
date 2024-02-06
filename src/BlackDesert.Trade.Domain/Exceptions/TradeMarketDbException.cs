namespace BlackDesert.Trade.Domain.Exceptions;

public class TradeMarketDbException : Exception
{
  public TradeMarketDbException(string message, params object[] args) : base(string.Format(message,args)) {
    
  } 
}