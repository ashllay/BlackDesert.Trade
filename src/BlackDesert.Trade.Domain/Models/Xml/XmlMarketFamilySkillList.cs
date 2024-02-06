using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Domain.Models.Xml;

[XmlRoot("XmlMarketFamilySkillList")]
public class XmlMarketFamilySkillList : IXmlFile
{
  [XmlElement("XmlMarketFamilySkill")]
  public List<XmlMarketFamilySkill> FamilySkills { get; set; }
}