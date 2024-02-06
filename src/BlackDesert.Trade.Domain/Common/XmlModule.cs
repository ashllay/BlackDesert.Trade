using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Exceptions;
using BlackDesert.Trade.Domain.Models.Xml;


namespace BlackDesert.Trade.Domain.Common;

public class XmlModule : SingletonBase<XmlModule>
{
  private static readonly List<XmlFile> SupportedXmlFiles = new() {
    new XmlFile("Data\\{SERVICE_TYPE}\\Option.xml", typeof(XmlMarketOption)),
    new XmlFile("Data\\{SERVICE_TYPE}\\CategoryTickCountList.xml", typeof(XmlMarketCategoryTickCountList)),
    new XmlFile("Data\\{SERVICE_TYPE}\\ServerInfoList.xml", typeof(XmlMarketServerInfoList)),
    new XmlFile("Data\\{SERVICE_TYPE}\\ItemList.xml", typeof(XmlMarketItemList)),
    new XmlFile("Data\\{SERVICE_TYPE}\\ItemIconInfoList.xml", typeof(XmlMarketItemIconInfoList)),
    new XmlFile( "Data\\{SERVICE_TYPE}\\CategoryList.xml", typeof(XmlMarketCategoryList)),
    new XmlFile("Data\\{SERVICE_TYPE}\\VariedTradeCountList.xml", typeof(XmlMarketVariedTradeCountList)),
    new XmlFile( "Data\\{SERVICE_TYPE}\\VariedPriceInfoList.xml", typeof(XmlMarketVariedPriceInfoList)),
    new XmlFile("Data\\{SERVICE_TYPE}\\FamilySkillList.xml", typeof(XmlMarketFamilySkillList))
  };

  private IReadOnlyDictionary<Type, object> _container;

  private XmlModule() {
    ServerControlLogger.LogStart("XmlModule");
    var sw = Stopwatch.StartNew();
    var dic = new Dictionary<Type, object>();
    foreach (var xmlFile in SupportedXmlFiles) {
      try {
        var result = ReadXmlObject(xmlFile.Type);
        dic.Add(xmlFile.Type, result);
      }
      catch (Exception ex) {
        Log.Error(ex, "XmlModule.Init - Exception {XmlFile}", xmlFile.FileName);
        throw new TradeMarketServerInitException("XmlModule.Init", 0, $"XmlModule.Init - Exception", ex);
      }
    }

    _container = dic;
    sw.Stop();
    ServerControlLogger.LogComplete("XmlModule", sw.ElapsedMilliseconds);
  }

  public T ReadXml<T>() where T : IXmlFile {
    try {
      return (T)_container[typeof(T)];
    }
    catch (Exception ex) {
      throw new Exception($"Xml file for type {typeof(T).Name} not found.", ex);
    }
  }

  private static object ReadXmlObject(Type type) {
    var xmlFile = SupportedXmlFiles.Single(x => x.Type == type);
    var directory = ConstantContainer.ConfigDirectory;
    var filePath = Path.Combine(directory,
                                xmlFile.Path
                                       .Replace("{SERVICE_TYPE}", ConstantContainer.ServiceType));
    var serializer = new XmlSerializer(type);
    using var reader = new StreamReader(filePath);
    var obj = serializer.Deserialize(reader);
    var isValid = CommonModule.ValidateObjectInstance(obj, out var validationErrors);
    if (!isValid) {
      var errors = validationErrors.Select(x => new {
                                     PropName = string.Join("| ", x.MemberNames),
                                     Message = x.ErrorMessage
                                   })
                                   .ToList();
      throw new Exception($"Xml file for type {type.Name} is invalid. Errors: {string.Join(", ", errors)}");
    }
    return obj;
  }
}