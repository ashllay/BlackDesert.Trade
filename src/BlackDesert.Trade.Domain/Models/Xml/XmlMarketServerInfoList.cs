using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Domain.Models.Xml;

[XmlRoot("XmlMarketServerInfoList")]
public class XmlMarketServerInfoList : IXmlFile
{
  [XmlElement("XmlMarketServerInfo")]
  public List<XmlMarketServerInfo> Servers { get; set; }
}