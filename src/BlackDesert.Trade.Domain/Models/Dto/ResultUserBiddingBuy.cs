namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultUserBiddingBuy
{
  public long _buyNo { get; set; }

  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public int _chooseSubKey { get; set; }

  public long _leftCount { get; set; }

  public long _boughtCount { get; set; }

  public long _pricePerOne { get; set; }

  public long _basePrice { get; set; }

  public long _minPrice { get; set; }

  public long _addEnchantPrice { get; set; }

  public long _registerMoneyCount { get; set; }
}