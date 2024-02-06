namespace BlackDesert.Trade.Domain.Models.EfCore;

public class UpdateItemInfoData
{
  public int KeyType { get; set; }
  
  public int MainKey { get; set; }
  public int SubKey { get; set; }
  
  public int MainGroupNo { get; set; }
  public int SubGroupNo { get; set; }

  // public int BaseCount { get; set; } = 0;
  // public int MinCount { get; set; } = 0;
  // public int MaxCount { get; set; } = 0;

  public long BasePrice { get; set; }
  public long MinPrice { get; set; }
  public long MaxPrice { get; set; }  
  public long RealMinPrice { get; set; }
  public long RealMaxPrice { get; set; }
  
  public long MarketPriceGroupKey { get; set; }

  // public bool IsForceDisplay { get; set; } = false;
}