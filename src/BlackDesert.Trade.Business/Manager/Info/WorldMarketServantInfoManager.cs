namespace BlackDesert.Trade.Business.Manager.Info;
//TODO REMOVE
// public class WorldMarketServantInfoManager : StockInfoManger
// {
//   private static volatile WorldMarketServantInfoManager _singleton;
//   private static readonly object Locker = new();
//
//   public WorldMarketServantInfoManager(string managerName,
//                                        KeyType keyType)
//     : base(managerName, keyType) { }
//
//   public static WorldMarketServantInfoManager This() {
//     if (_singleton == null)
//       lock (Locker) {
//         if (_singleton == null)
//           _singleton = new WorldMarketServantInfoManager(nameof(WorldMarketServantInfoManager), KeyType.eServant);
//       }
//
//     return _singleton;
//   }
// }