namespace BlackDesert.Trade.Domain.Models.EfCore;

public record ResultRemoveItemFromMarketAndSendMail(long UserNo, long ItemKey, int EnchantLevel, long Count);
