namespace BlackDesert.Trade.Business.Manager;

public static class WorldMarketValidator
{
  
  public static void ValidateItemMainKey(long mainKey) {
    if (!CheckValidItemMainKey(mainKey))
      throw new TradeMarketException("Invalid item main key value " + mainKey.ToString());
  }
  
  public static void ValidateItemSubKey(int subKey) {
    if (!CheckValidItemSubKey(subKey))
      throw new TradeMarketException("Invalid item sub key value " + subKey.ToString());
  }
   
  public static bool CheckValidItemMainKey(long mainKey) {
    return mainKey > 0L;
  }
  public static void MustBeHigherThanZero(long number,string message) {
    if (number <= 0) {
      throw new TradeMarketException(message);
    }
  }
  
  public static bool CheckValidItemSubKey(int subKey) {
    return subKey > 0;
  }
  public static int CheckValidCount<T1, T2>(T1 pricePerOne,
                                            T2 wantedCount)
    where T1 : IComparable
    where T2 : IComparable {
    var typeCode = Type.GetTypeCode(typeof(T2));
    switch (typeCode) {
      case TypeCode.Int32:
        var num1 = 1;
        if (wantedCount.CompareTo(num1) < 0)
          return -1;
        break;
      case TypeCode.Int64:
        long num2 = 1;
        if (wantedCount.CompareTo(num2) < 0)
          return -1;
        break;
      default:
        return -1;
    }

    switch (Type.GetTypeCode(typeof(T1))) {
      case TypeCode.Int32:
        var num3 = 1;
        if (pricePerOne.CompareTo(num3) < 0)
          return -1;
        if (TypeCode.Int64 == typeCode) {
          var num4 = long.MaxValue / ((object)pricePerOne as int?).Value;
          if (wantedCount.CompareTo(num4) >= 0)
            return -1;
          break;
        }

        if (TypeCode.Int32 == typeCode) {
          var num5 = int.MaxValue / ((object)pricePerOne as int?).Value;
          if (wantedCount.CompareTo(num5) >= 0)
            return -1;
        }

        break;
      case TypeCode.Int64:
        long num6 = 1;
        if (pricePerOne.CompareTo(num6) < 0)
          return -1;
        var num7 = long.MaxValue / ((object)pricePerOne as long?).Value;
        if (TypeCode.Int32 == typeCode) {
          long num8 = ((object)wantedCount as int?).Value;
          if (wantedCount.CompareTo(num8) >= 0)
            return -1;
          break;
        }

        if (TypeCode.Int64 == typeCode && wantedCount.CompareTo(num7) >= 0)
          return -1;
        break;
      default:
        return -1;
    }

    return 0;
  }



}