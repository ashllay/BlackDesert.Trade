using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Domain.Models.Xml;

[XmlRoot("XmlMarketItemList")]
public class XmlMarketItemList : IXmlFile
{
  [XmlElement("XmlMarketItem")]
  public List<XmlMarketItem> Items { get; set; }
}