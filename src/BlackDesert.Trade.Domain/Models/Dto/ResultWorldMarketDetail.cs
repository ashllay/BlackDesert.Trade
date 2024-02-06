﻿namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldMarketDetail
{
  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public long? _pricePerOne { get; set; }

  public long? _count { get; set; }

  public long? _totalTradeCount { get; set; }

  public long _minPrice { get; set; }

  public long _maxPrice { get; set; }

  public DateTime _lastTradeTime { get; set; }

  public long _lastTradePrice { get; set; }

  public int? _isDisplay { get; set; }
}