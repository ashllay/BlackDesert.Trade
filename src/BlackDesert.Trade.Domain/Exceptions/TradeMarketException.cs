using BlackDesert.Trade.Domain.Enum;

namespace BlackDesert.Trade.Domain.Exceptions;

public class TradeMarketException : Exception
{
  public TradeMarketException() : base(MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue()) { }

  public TradeMarketException(MarketError error) : base(error.GetResourceValue()) { }

  public TradeMarketException(string message) : base(message) { }

  public TradeMarketException(string message,
                                  Exception innerException) : base(message, innerException) { }

  public TradeMarketException(Exception ex) : base(MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue(), ex) { }

 
}