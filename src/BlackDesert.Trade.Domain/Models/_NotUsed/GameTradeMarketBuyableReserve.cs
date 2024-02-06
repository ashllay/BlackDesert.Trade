namespace BlackDesert.Trade.Domain.Models._NotUsed;

public class GameTradeMarketBuyableReserve
{
  public GameTradeMarketBuyableReserve() {
    keyType = 0;
    mainKey = 0;
    subKey = 0;
    count = 0L;
    pricePerOne = 0L;
    nationCode = 0;
    serverNo = 0;
    userNo = 0L;
  }

  public int keyType { set; get; }

  public int mainKey { set; get; }

  public int subKey { set; get; }

  public long count { set; get; }

  public long pricePerOne { set; get; }

  public int nationCode { set; get; }

  public int serverNo { set; get; }

  public long userNo { set; get; }
}