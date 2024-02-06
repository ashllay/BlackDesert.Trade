namespace BlackDesert.Trade.Business.Manager.Price;

public class GroupWeaponPriceChanger
{
  public readonly TradeMarketItemInfo _itemInfo;
  public readonly ResultWorldMarketAccumulateTrade _record;

  public GroupWeaponPriceChanger(
    ResultWorldMarketAccumulateTrade record,
    TradeMarketItemInfo itemInfo) {
    _record = record;
    _itemInfo = itemInfo;
  }
}