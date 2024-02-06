using BlackDesert.Trade.Domain.Enum;

namespace BlackDesert.Trade.Domain.Exceptions;

public class TradeMarketUnauthorized : TradeMarketException
{
  public TradeMarketUnauthorized() : base(MarketError.TRADE_MARKET_ERROR_MSG_UNAUTHORIZED) { }
}