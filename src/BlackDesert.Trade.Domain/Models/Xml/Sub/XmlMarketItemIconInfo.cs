using System.Xml.Serialization;

namespace BlackDesert.Trade.Domain.Models.Xml.Sub;

public class XmlMarketItemIconInfo
{
  [XmlAttribute("ItemKey")]
  public string ItemKey { get; set; }

  [XmlAttribute("IconPathForWorldMarket")]
  public string IconPathForWorldMarket { get; set; }
}