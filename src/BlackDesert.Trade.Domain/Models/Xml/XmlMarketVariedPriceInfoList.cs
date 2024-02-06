using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Domain.Models.Xml;

[XmlRoot("XmlMarketVariedPriceInfoList")]
public class XmlMarketVariedPriceInfoList : IXmlFile
{
  [XmlElement("XmlMarketVariedPriceInfo")]
  public List<XmlMarketVariedPriceInfo> VariedPriceInfoList { get; set; }
}