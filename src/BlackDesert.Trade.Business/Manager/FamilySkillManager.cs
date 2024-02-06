using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml;

namespace BlackDesert.Trade.Business.Manager;

public class FamilySkillManager : SingletonBase<FamilySkillManager>
{
  private readonly Dictionary<int, int> _familySkillList;

  private FamilySkillManager() {
    _familySkillList = new Dictionary<int, int>();
    
    var stopwatch = Stopwatch.StartNew();

    stopwatch.Start();
    var xmlData = XmlModule.This.ReadXml<XmlMarketFamilySkillList>();
    _familySkillList.Clear();
    xmlData.FamilySkills.ForEach(x => _familySkillList.TryAdd(x.FamilySkillKey, x.TaxDiscountRate));

    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(FamilySkillManager), stopwatch.ElapsedMilliseconds);
    
  }

  public int GetAddTaxDiscountRateByFamilySkill(
    List<int> familySkillList) {
    var rateByFamilySkill = 0;
    var num = 0;
    var count = familySkillList.Count;
    for (var index = 0; index < count; ++index)
      if (_familySkillList.TryGetValue(familySkillList[index], out num))
        rateByFamilySkill += num;
    return rateByFamilySkill;
  }
}




// public int GetAddTaxDiscountRateByFamilySkill(
//   List<uspFamilySKillListFromWorldMarket_Result> familySkillList) {
//   var rateByFamilySkill = 0;
//   var num = 0;
//   var count = familySkillList.Count;
//   for (var index = 0; index < count; ++index)
//     if (_familySkillList.TryGetValue(familySkillList[index]._skillNo, out num))
//       rateByFamilySkill += num;
//   return rateByFamilySkill;
// }  