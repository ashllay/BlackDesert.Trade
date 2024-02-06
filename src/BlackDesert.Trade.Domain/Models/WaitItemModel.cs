using BlackDesert.Trade.Domain.Models.Db;

namespace BlackDesert.Trade.Domain.Models;

public class WaitItemModel
{
  public WaitItemModel() {
    waitNo = 0L;
    nationCode = 0;
    worldNo = 0;
    userNo = 0L;
    sellKeyType = 0;
    sellMainKey = 0;
    sellSubKey = 0;
    sellPrice = 0L;
    sellCount = 0L;
    sellChooseKey = 0;
    isSealed = false;
    isRingBuff = false;
  }

  public WaitItemModel(ResultWaitBiddingSell info) {
    waitNo = info._waitNo;
    nationCode = info._nationCode;
    worldNo = info._serverNo;
    userNo = info._userNo;
    sellKeyType = info._keyType;
    sellMainKey = info._mainKey;
    sellSubKey = info._subKey;
    sellPrice = info._pricePerOne;
    sellCount = info._leftCount;
    sellChooseKey = info._chooseSubKey;
    isSealed = info._isSealed;
    isRingBuff = info._isRingBuff;
  }

  public long waitNo { set; get; }

  public int nationCode { set; get; }

  public int worldNo { set; get; }

  public long userNo { set; get; }

  public int sellKeyType { set; get; }

  public int sellMainKey { set; get; }

  public int sellSubKey { set; get; }

  public long sellPrice { set; get; }

  public long sellCount { set; get; }

  public int sellChooseKey { set; get; }

  public bool isSealed { set; get; }

  public bool isRingBuff { set; get; }

  public override string ToString() {
    return string.Format("waitNo:{0}, ", waitNo) + string.Format("sellKeyType:{0},", sellKeyType) + string.Format("sellMainKey:{0},", sellMainKey) + string.Format("sellSubKey:{0},", sellSubKey) +
           string.Format("isSealed:{0},", isSealed) + string.Format("sellChooseKey:{0},", sellChooseKey) + string.Format("sellCount:{0},", sellCount) + string.Format("sellPrice:{0},", sellPrice) +
           string.Format("isRingBuff:{0},", isRingBuff) + string.Format("nationCode:{0},", nationCode) + string.Format("worldNo:{0},", worldNo) +
           string.Format("userNo:{0}", userNo);
  }
}