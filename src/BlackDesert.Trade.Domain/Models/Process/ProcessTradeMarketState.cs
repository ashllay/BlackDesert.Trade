namespace BlackDesert.Trade.Domain.Models.Process;

public class ProcessTradeMarketState
{
  public ProcessTradeMarketState() {
    state = 0;
    result = new CommonResult();
  }

  public int state { set; get; }

  public CommonResult result { set; get; }
}