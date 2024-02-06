using System.Net;
using System.Net.Sockets;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Business.Manager.Info;

public class ServerInfoManager : SingletonBase<ServerInfoManager>
{
  public Dictionary<string, XmlMarketServerInfo> ServerInfoList = new();
  private ServerInfoManager() {
    var stopwatch = Stopwatch.StartNew();
    ServerControlLogger.LogStart(nameof(ServerInfoManager));
    
    var xmlData = XmlModule.This.ReadXml<XmlMarketServerInfoList>();
    foreach (var serverInfo in xmlData.Servers)
      ServerInfoList.Add(serverInfo.Ip, serverInfo);

    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(ServerInfoManager), stopwatch.ElapsedMilliseconds);
  }

  public List<int> GetAllowMainGroup() {
    var serverInfo = GetServerInfo();
    if (serverInfo != null)
      return serverInfo.AllowMainGroupNo.Split("|").Select(int.Parse).ToList();
    Log.Warning("ServerInfoManager.GetAllowMainGroup info NULL");
    return null;
  }

  public List<string> GetIpList() {
    var ipList = new List<string>();
    foreach (var address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
      if (address.AddressFamily == AddressFamily.InterNetwork)
        ipList.Add(address.ToString());
    return ipList;
  }

  public XmlMarketServerInfo GetServerInfo() {
    var serverInfo1 = new XmlMarketServerInfo();
    var ipList = GetIpList();
    foreach (var str in ipList) {
      foreach (var serverInfo2 in ServerInfoList)
        if (serverInfo2.Value.Ip == str) {
          serverInfo1 = serverInfo2.Value;
          break;
        }
      if (serverInfo1 != null)
        break;
    }

    if (serverInfo1 == null) {
      Log.Warning("ServerInfoManager.GetServerInfo info NULL");
      return null;
    }

    if (serverInfo1.Ip != "")
      return serverInfo1;
    Log.Warning("ServerInfoManager.GetServerInfo info empty");
    return null;
  }
}