namespace BlackDesert.Trade.Domain.Models.EfCore;

public class Result_GetPearlItemTradeCount
{
  public int AddPearlItemLimitedCount { get; set; }
  public long CurrentPearlItemLimitedCount { get; set; }
  public long AddWeight { get; set; }
  public int RingBuffCount { get; set; }
}