using BlackDesert.Trade.Domain.Models.Db;

namespace BlackDesert.Trade.Domain.Models.Process;

public class ProcessTradeMarketListUserBidding
{
  public List<ResultUserBiddingBuy> buylist { get; set; }

  public List<ResultUserBiddingSell> selllist { get; set; }
}