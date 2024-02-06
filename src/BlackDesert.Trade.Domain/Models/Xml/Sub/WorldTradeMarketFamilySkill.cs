using System.Xml.Serialization;

namespace BlackDesert.Trade.Domain.Models.Xml.Sub;

public class XmlMarketFamilySkill
{
  [XmlAttribute("FamilySkillKey")]
  public int FamilySkillKey { get; set; }

  [XmlAttribute("TaxDiscountRate")]
  public int TaxDiscountRate { get; set; }
}