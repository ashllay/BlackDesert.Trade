namespace BlackDesert.Trade.Business.Models;

public class TradeMarketItemInfo
{
  public readonly int _accumulatePassCount;
  public readonly long _basePrice;
  public readonly int _enchantGroup;
  public readonly int _enchantMaterialKey;
  public readonly long _enchantNeedCount;
  public readonly int _grade;
  public readonly bool _isEnchantable;
  public readonly bool _isForceDisplay;
  public readonly bool _isPersonalTrade;
  public readonly int _keyType;
  public readonly int _mainGroupNo;
  public readonly int _mainKey;
  public readonly long _marketPriceGroup;
  public readonly long _maxPrice;
  public readonly long _maxRegisterForWorldMarket;
  public readonly long _maxStackCount;
  public readonly long _minPrice;
  public readonly bool _noticeAbleItemForWorldMarket;
  public readonly long _realMaxPrice;
  public readonly long _realMinPrice;
  public readonly int _subGroupNo;
  public readonly int _subKey;
  public readonly long _tradeCountToUpdate;
  public readonly long _weight;
  public KeyValuePair<int, int> _representativeItemEnchantKey;

  public TradeMarketItemInfo() {
    _keyType = 0;
    _mainKey = 0;
    _subKey = 0;
    _mainGroupNo = 0;
    _subGroupNo = 0;
    _maxPrice = 0L;
    _minPrice = 0L;
    _realMaxPrice = 0L;
    _realMinPrice = 0L;
    _basePrice = 0L;
    _isEnchantable = false;
    _enchantGroup = 0;
    _enchantNeedCount = 0L;
    _isPersonalTrade = false;
    _enchantMaterialKey = 0;
    _weight = 0L;
    _maxStackCount = 0L;
    _tradeCountToUpdate = 0L;
    _accumulatePassCount = 0;
    _maxRegisterForWorldMarket = 0L;
    _noticeAbleItemForWorldMarket = false;
    _grade = 0;
    _marketPriceGroup = 0L;
    _isForceDisplay = false;
    _representativeItemEnchantKey = new KeyValuePair<int, int>(0, 0);
  }

//TODO REMOVE ?? 
  public TradeMarketItemInfo(
    int keyType,
    int itemKey,
    int enchantLevel,
    int mainGroupNo,
    int subGroupNo,
    long enchantAddPercent,
    long maxPrice,
    long minPrice,
    long basePrice,
    bool isEnchantable,
    int enchantGroup,
    long enchantNeedCount,
    bool isPersonalTrade,
    int enchantMaterialKey,
    long weight,
    long maxStackCount,
    long tradeCountToUpdate,
    int accumulatePassCount,
    long maxRegisterForWorldMarket,
    bool noticeAbleItemForWorldMarket,
    int grade,
    long marketPriceGroup,
    bool isForceDisplay,
    long maxPriceNew,
    long minPriceNew) {
    _keyType = keyType;
    _mainKey = itemKey;
    _subKey = enchantLevel;
    _mainGroupNo = mainGroupNo;
    _subGroupNo = subGroupNo;
    _maxPrice = maxPrice;
    _minPrice = minPrice;
    _basePrice = basePrice;
    _isEnchantable = isEnchantable;
    if (enchantAddPercent == 0L)
      enchantAddPercent = 1000000L;
    if (maxPriceNew == 0L) {
      if (_maxPrice != 0L) {
        _maxPrice = _basePrice + (long)(_basePrice * (_maxPrice / 1000000.0));
        _maxPrice = (long)(_maxPrice * (enchantAddPercent / 1000000.0));
        _maxPrice = VariedPriceInfoManager.This.CalculatePrice(_maxPrice);
        if (_maxPrice == 0L)
          _maxPrice = _basePrice;
      }
      else {
        _maxPrice = _basePrice;
      }
    }
    else {
      _maxPrice = maxPriceNew;
    }

    _realMaxPrice = VariedPriceInfoManager.This.CalculatePrice((long)(_maxPrice / (1.0 + OptionManager.This.BiddingRatio)), "UP");
    if (minPriceNew == 0L) {
      if (_minPrice != 0L) {
        _minPrice = _basePrice - (long)(_basePrice * (_minPrice / 1000000.0));
        _minPrice = VariedPriceInfoManager.This.CalculatePrice(_minPrice);
        if (_minPrice == 0L)
          _minPrice = _basePrice;
      }
      else {
        _minPrice = _basePrice;
      }
    }
    else {
      _minPrice = minPriceNew;
    }

    _realMinPrice = VariedPriceInfoManager.This.CalculatePrice((long)(_minPrice / (1.0 - OptionManager.This.BiddingRatio)), "DOWN");
    _enchantGroup = enchantGroup;
    _enchantNeedCount = enchantNeedCount;
    _isPersonalTrade = isPersonalTrade;
    if (16 <= _subKey)
      enchantMaterialKey = 0;
    _enchantMaterialKey = enchantMaterialKey;
    _weight = weight;
    _maxStackCount = maxStackCount;
    _tradeCountToUpdate = tradeCountToUpdate;
    _accumulatePassCount = accumulatePassCount;
    _maxRegisterForWorldMarket = maxRegisterForWorldMarket;
    _noticeAbleItemForWorldMarket = noticeAbleItemForWorldMarket;
    _grade = grade;
    _marketPriceGroup = marketPriceGroup;
    _isForceDisplay = isForceDisplay;
    _representativeItemEnchantKey = new KeyValuePair<int, int>(0, 0);
  }

  public bool HasPriceGroup() {
    return 0L < _marketPriceGroup;
  }

  public bool IsValid() {
    return 0 < _mainKey && 0 <= _subKey;
  }
}