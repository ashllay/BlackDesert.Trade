namespace BlackDesert.Trade.Business.Models;

public class TickCountCommon
{
  public static void enchantLevelCalc(
    long currentPrice,
    int enchantLevel,
    ref long beforeEnchantPrice) {
    beforeEnchantPrice = 0L;
    if (0 >= enchantLevel)
      return;
    beforeEnchantPrice = currentPrice;
  }

  public static void checkAndUpdateBeforePrice(long beforeEnchantPrice,
                                               ref long newPrice) {
    if (0L >= beforeEnchantPrice || beforeEnchantPrice >= newPrice)
      return;
    newPrice = beforeEnchantPrice;
  }

  public static void fluctuationCalc(
    long newPrice,
    long currentPrice,
    ref FluctuationType fluctuationType,
    ref long fluctuationPrice) {
    var num1 = (long)(currentPrice * (1.0 - OptionManager.This.BiddingRatio * 0.75));
    var num2 = (long)(currentPrice * (1.0 + OptionManager.This.BiddingRatio * 0.75));
    if (newPrice < num1) {
      fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Down;
      fluctuationPrice = currentPrice - newPrice;
    }
    else {
      if (num2 >= newPrice)
        return;
      fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Up;
      fluctuationPrice = newPrice - currentPrice;
    }
  }
}