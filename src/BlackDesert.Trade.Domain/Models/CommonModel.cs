namespace BlackDesert.Trade.Domain.Models;

public class CommonModel
{
  public class TradeMarketUserLogInfo
  {
    public TradeMarketUserLogInfo() {
      nationCode = 0;
      serverNo = 0;
      userNo = 0L;
    }

    public int nationCode { get; set; }

    public int serverNo { get; set; }

    public long userNo { get; set; }
  }

  public class TradeMarketItemLogInfo
  {
    public TradeMarketItemLogInfo() {
      keyType1 = 0;
      itemKey1 = 0;
      enchantLevel1 = 0;
      count1 = 0L;
      beforeCount1 = 0L;
      afterCount1 = 0L;
      keyType2 = 0;
      itemKey2 = 0;
      enchantLevel2 = 0;
      count2 = 0L;
      beforeCount2 = 0L;
      afterCount2 = 0L;
    }

    public int keyType1 { get; set; }

    public int itemKey1 { get; set; }

    public int enchantLevel1 { get; set; }

    public long count1 { get; set; }

    public long beforeCount1 { get; set; }

    public long afterCount1 { get; set; }

    public int keyType2 { get; set; }

    public int itemKey2 { get; set; }

    public int enchantLevel2 { get; set; }

    public long count2 { get; set; }

    public long beforeCount2 { get; set; }

    public long afterCount2 { get; set; }
  }
}