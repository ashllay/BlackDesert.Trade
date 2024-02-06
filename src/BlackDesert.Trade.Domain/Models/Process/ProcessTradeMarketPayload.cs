namespace BlackDesert.Trade.Domain.Models.Process;

public class ProcessTradeMarketPayload
{
  public ProcessTradeMarketPayload() {
    payload = 0L;
    result = new CommonResult();
  }

  public long payload { set; get; }

  public CommonResult result { set; get; }
}