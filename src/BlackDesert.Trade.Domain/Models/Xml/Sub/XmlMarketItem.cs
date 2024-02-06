using System.Xml.Serialization;

namespace BlackDesert.Trade.Domain.Models.Xml.Sub;

public class XmlMarketItem
{
  // [XmlAttribute("KeyType")]
  // public int KeyType { get; set; }

  [XmlAttribute("ItemKey")]
  public int ItemKey { get; set; }

  [XmlAttribute("EnchantLevel")]
  public int EnchantLevel { get; set; }

  [XmlAttribute("MainCategory")]
  public int MainCategory { get; set; }

  [XmlAttribute("SubCategory")]
  public int SubCategory { get; set; }

  [XmlAttribute("BasePrice")]
  public long BasePrice { get; set; }

  [XmlAttribute("MarketKey")]
  public long MarketKey { get; set; }

  [XmlAttribute("MinPricePercent")]
  public long MinPricePercent { get; set; }

  [XmlAttribute("MaxPricePercent")]
  public long MaxPricePercent { get; set; }

  [XmlAttribute("RealMinPrice")]
  public long RealMinPrice { get; set; }

  [XmlAttribute("RealMaxPrice")]
  public long RealMaxPrice { get; set; }

  [XmlAttribute("EnchantAddPercent")]
  public long EnchantAddPercent { get; set; }

  [XmlAttribute("IsEnhanceable")]
  public bool IsEnhanceable { get; set; }

  [XmlAttribute("EnchantGroup")]
  public int EnchantGroup { get; set; }

  [XmlAttribute("EnchantNeedCount")]
  public long EnchantNeedCount { get; set; }

  [XmlAttribute("isPersonalTrade")]
  public bool IsPersonalTrade { get; set; }

  [XmlAttribute("EnchantMaterialKey")]
  public int EnchantMaterialKey { get; set; }

  [XmlAttribute("Weight")]
  public long Weight { get; set; }

  [XmlAttribute("MaxStackCount")]
  public long MaxStackCount { get; set; }

  [XmlAttribute("TradeCountToUpdate")]
  public int TradeCountToUpdate { get; set; }

  [XmlAttribute("AccumulatePassCount")]
  public int AccumulatePassCount { get; set; }

  [XmlAttribute("MaxRegisterCount")]
  public long MaxRegisterCount { get; set; }

  [XmlAttribute("Grade")]
  public int Grade { get; set; }

  [XmlAttribute("IsNoticeItem")]
  public bool IsNoticeItem { get; set; }

  [XmlAttribute("MarketPriceGroup")]
  public long MarketPriceGroup { get; set; }

  // [XmlAttribute("IsForceDisplay")]
  // public bool IsForceDisplay { get; set; }
}