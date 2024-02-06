using System.Reflection;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Common;
using Newtonsoft.Json;

namespace BlackDesert.Trade.Db;

public class DbConnectionContainer : SingletonBase<DbConnectionContainer>
{
  private const string ConfigFileName = "db-connection";

  public readonly ConnectionModel ConnectionStrings;

  private DbConnectionContainer() {
    var model = GetConnectionModel();
    if (model is null) throw new Exception("Could not read db-connection.json file");
    ConnectionStrings = model;
  }

  private ConnectionModel? GetConnectionModel() {
    var path = Path.Combine("Config", ConfigFileName + ".json");
    if (!ConstantContainer.IsLive) path = Path.Combine("Config", ConfigFileName + ".dev.json");
    if (!File.Exists(path)) {
      var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      Directory.SetCurrentDirectory(basePath);
      if (!File.Exists(path)) return null;
    }

    var json = File.ReadAllText(path);
    var model = JsonConvert.DeserializeObject<ConnectionModel>(json);
    return model;
  }
}