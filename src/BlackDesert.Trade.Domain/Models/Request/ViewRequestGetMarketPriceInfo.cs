﻿namespace BlackDesert.Trade.Domain.Models.Api;

public class ViewRequestGetMarketPriceInfo
{
  public int keyType { get; set; }
  public int mainKey { get; set; }
  public int subKey { get; set; }
}