namespace BlackDesert.Trade.Domain.Models.EfCore;

public class ResultWorldMarketDetail
{
  public long PricePerOne { get; set; } = 0;
  public long Count { get; set; } = 0;
  public long MinPrice { get; set; } = 0;
  public long MaxPrice { get; set; } = 0;
  public long TotalTradeCount { get; set; } = 0;
  public long LastTradePrice { get; set; } = 0;
  public long LastTradeTime { get; set; } = CommonModule.ConvertDateTimeToUnixTimeStamp(CultureModule.GetCustomTimeNow());

}