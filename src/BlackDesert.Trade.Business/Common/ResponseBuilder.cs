namespace BlackDesert.Trade.Business.Common;

public static class ResponseBuilder
{
  public static string BuildGetMyWalletList(List<ResultWorldMarketMyWallet> list,
                             out long totalWeight) {
    totalWeight = 0L;
    if (list.Count == 0) return "0";
    var sb = new StringBuilder();
    for (var index = 0; index < list.Count; ++index) {
      var item = list[index];
      if (item._keyType != (int)KeyType.eItem) continue; //TODO : Check if this is correct 
      var itemInfo = ItemInfoManager.This.GetInfo(item._mainKey, item._subKey);
      if (!itemInfo.IsValid() && 1 != item._mainKey) continue;
      totalWeight += itemInfo._weight * list[index]._count;
      sb.Append(list[index]._keyType.ToString());
      sb.Append("_");
      sb.Append(list[index]._mainKey.ToString());
      sb.Append("_");
      sb.Append(list[index]._subKey.ToString());
      sb.Append("_");
      sb.Append(list[index]._isSealed.ToString());
      sb.Append("_");
      sb.Append(list[index]._count.ToString());
      if (index < list.Count - 1) sb.Append("|");
    }
    return sb.ToString();
  }
  public static string BuildCreateMyWallet(bool isCreated) {
    const string template = "{Created}-{BiddingPercent}";
    var sb = new StringBuilder();
    sb.Append(template);
    sb.Replace("{Created}", isCreated ? "1" : "0");
    sb.Replace("{BiddingPercent}", OptionManager.This.GetBiddingPercent().ToString());
    return sb.ToString();
  }
}