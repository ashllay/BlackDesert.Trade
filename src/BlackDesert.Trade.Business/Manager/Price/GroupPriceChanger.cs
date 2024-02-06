namespace BlackDesert.Trade.Business.Manager.Price;

public class GroupPriceChanger
{
  public readonly TradeMarketItemInfo Info;
  public readonly ResultWorldMarketAccumulateTrade Record;
  public long _nextGraphPrice;
  public long _nextPrice;

  public GroupPriceChanger(ResultWorldMarketAccumulateTrade record,
    long nextPrice,
    long nextGraphPrice) {
    Record = record;
    Info = ItemInfoManager.This.GetInfo(record._mainKey, record._subKey);
    _nextPrice = nextPrice;
    _nextGraphPrice = nextGraphPrice;
  }

  public double PriceRatio => (Record._pricePerOne - Info._minPrice) / (double)(Info._maxPrice - Info._minPrice);

  public long Price => Record._pricePerOne;

  public long NextPrice {
    get => _nextPrice;
    set {
      var priceValue_1 = Math.Max((long)(Price * (1.0 - OptionManager.This.BiddingRatio)), Info._realMinPrice);
      var priceValue_2 = Math.Min((long)(Price * (1.0 + OptionManager.This.BiddingRatio)), Info._realMaxPrice);
      value = Math.Max(priceValue_1, value);
      var val2 = value;
      value = Math.Min(priceValue_2, val2);
      value = VariedPriceInfoManager.This.CalculatePrice(value);
      _nextPrice = value;
    }
  }

  public long NextGraphPrice {
    get => _nextGraphPrice;
    set => _nextGraphPrice = value;
  }

  public double NextPriceRatio {
    get => (NextPrice - Info._minPrice) / (double)(Info._maxPrice - Info._minPrice);
    set => NextPrice = Info._minPrice + (long)((Info._maxPrice - Info._minPrice) * value);
  }
}