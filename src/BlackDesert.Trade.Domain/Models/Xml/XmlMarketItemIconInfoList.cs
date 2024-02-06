using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Domain.Models.Xml;

[XmlRoot("XmlMarketItemIconInfoList")]
public class XmlMarketItemIconInfoList : IXmlFile
{
  [XmlElement("XmlMarketItemIconInfo")]
  public List<XmlMarketItemIconInfo> ItemIconInfos { get; set; }
}