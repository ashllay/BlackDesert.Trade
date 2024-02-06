using BlackDesert.Trade.Business.Manager.Price;

namespace BlackDesert.Trade.Business.Manager.Data;

public class GroupWeaponPriceList
{
  public long _currentPrice;
  public bool _isChange;
  public List<GroupWeaponPriceChanger> _list;
  public long _passBiddingCount;
  public long _worldMarketPricePoint;

  public GroupWeaponPriceList() {
    _list = new List<GroupWeaponPriceChanger>();
    _passBiddingCount = 0L;
    _worldMarketPricePoint = 0L;
    _isChange = false;
    _currentPrice = 0L;
  }

  public void AverageCurrentPrice() {
    _currentPrice = (long)_list.Average((Func<GroupWeaponPriceChanger, long>)(info => info._record._pricePerOne));
  }
}