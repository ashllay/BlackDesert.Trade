namespace BlackDesert.Trade.Domain.Models.Api;

public class GameTradeMarketRequestPopItemRestorationInfoModel
{
  public GameTradeMarketRequestPopItemRestorationInfoModel() {
    userNo = 0L;
    certifiedKey = string.Empty;
    payload = 0L;
    mainKey = 0;
    subKey = 0;
    itemCount = 0L;
    isSealed = false;
    param0 = 0L;
    param1 = 0L;
    param2 = 0L;
    param3 = 0L;
    param4 = 0L;
  }

  public long userNo { set; get; }

  public string certifiedKey { get; set; }

  public long payload { set; get; }

  public int mainKey { set; get; }

  public int subKey { set; get; }

  public long itemCount { set; get; }

  public bool isSealed { set; get; }

  public long param0 { set; get; }

  public long param1 { set; get; }

  public long param2 { set; get; }

  public long param3 { set; get; }

  public long param4 { set; get; }
}