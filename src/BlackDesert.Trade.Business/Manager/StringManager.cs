// .Web.Lib.Manager.StringManager
//
//
// using Serilog.Events;
//
// namespace BlackDesert.Trade.Domain.Manager;
//
// public class StringManager
// {
//   private const string ManagerName = "StringManager";
//   private static Dictionary<string, Dictionary<string, string>> _categoryStringResource;
//   private static Dictionary<string, Dictionary<string, string>> _itemStringResource;
//   private static volatile StringManager _singleton;
//   private static readonly object Locker = new();
//   private bool _isOpen;
//
//   public StringManager() {
//     _isOpen = false;
//     _categoryStringResource = new Dictionary<string, Dictionary<string, string>>();
//     _itemStringResource = new Dictionary<string, Dictionary<string, string>>();
//     throw new NotImplementedException();
//   }
//
//   public Dictionary<string, string> CategoryStringList {
//     get {
//       var str = CultureModule.GetCultureCode(ConstantContainer.DefaultCultureName).ToLower();
//       if (ConstantContainer.LanguageList.Contains(str).Equals(false))
//         str = ConstantContainer.DefaultCultureName;
//       return _categoryStringResource[str.ToUpper()];
//     }
//   }
//
//   public Dictionary<string, string> ItemStringList {
//     get {
//       var str = CultureModule.GetCultureCode(ConstantContainer.DefaultCultureName).ToLower();
//       if (ConstantContainer.LanguageList.Contains(str).Equals(false))
//         str = ConstantContainer.DefaultCultureName;
//       return _itemStringResource[str.ToUpper()];
//     }
//   }
//
//   public static StringManager This() {
//     if (_singleton == null)
//       lock (Locker) {
//         if (_singleton == null)
//           _singleton = new StringManager();
//       }
//
//     return _singleton;
//   }
//
//   public int Load() {
//     throw new NotImplementedException();
//     // var empty1 = string.Empty;
//     // var requestUriString = string.Empty;
//     // var empty2 = string.Empty;
//     // var empty3 = string.Empty;
//     // var empty4 = string.Empty;
//     // var empty5 = string.Empty;
//     // var empty6 = string.Empty;
//     // var stopwatch = new Stopwatch();
//     // lock (_locker) {
//     //   if (_isOpen) {
//     //     ServerControlLogger.serverLogWrite(ServerLogType.eAlready, nameof(StringManager));
//     //     return 0;
//     //   }
//     //
//     //   ServerControlLogger.serverLogWrite(ServerLogType.eStart, nameof(StringManager));
//     //   stopwatch.Start();
//     //   try {
//     //     var languageList = ConstantContainer._languageList;
//     //     if (string.IsNullOrEmpty(languageList))
//     //       return -10;
//     //     ServicePointManager.Expect100Continue = true;
//     //     ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
//     //     var str1 = languageList;
//     //     var chArray1 = new char[1] { ',' };
//     //     foreach (var str2 in str1.Split(chArray1)) {
//     //       string end;
//     //       
//     //       requestUriString = ConstantContainer._tradeXMLDomain + "/Common/xml/" + ConstantContainer._serviceProject + "WorldMarketTranslationData/" + ConstantContainer._serviceType.ToUpper() + "/" +
//     //                          ConstantContainer._serviceProject + "LocalizedStringWorldTradeMarket_" + str2.ToUpper() + ".txt";
//     //       var httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
//     //      
//     //       httpWebRequest.Timeout = 60000;
//     //       end = new StreamReader(httpWebRequest.GetResponse().GetResponseStream(), Encoding.UTF8).ReadToEnd();
//     //       var str3 = end;
//     //       var chArray2 = new char[1] { '\r' };
//     //       foreach (var str4 in str3.Split(chArray2))
//     //         if (!string.IsNullOrEmpty(str4)) {
//     //           var str5 = str4;
//     //           if (str4.Contains("\n"))
//     //             str5 = str4.Replace("\n", "");
//     //           if (str5.Split('\t').Length == 3) {
//     //             var str6 = str5.Split('\t')[0];
//     //             var key = str5.Split('\t')[1];
//     //             var str7 = str5.Split('\t')[2];
//     //             if (!string.IsNullOrEmpty(str6) && !string.IsNullOrEmpty(key)) {
//     //               if (string.IsNullOrEmpty(str7))
//     //                 str7 = "NoTranslation";
//     //               bool flag;
//     //               if (str6 == "Category") {
//     //                 flag = _categoryStringResource.ContainsKey(str2.ToUpper());
//     //                 if (flag.Equals(false))
//     //                   _categoryStringResource.Add(str2.ToUpper(), new Dictionary<string, string>());
//     //                 _categoryStringResource[str2.ToUpper()].Add(key, str7);
//     //               }
//     //               else {
//     //                 flag = _itemStringResource.ContainsKey(str2.ToUpper());
//     //                 if (flag.Equals(false))
//     //                   _itemStringResource.Add(str2.ToUpper(), new Dictionary<string, string>());
//     //                 _itemStringResource[str2.ToUpper()].Add(key, str7);
//     //               }
//     //             }
//     //           }
//     //         }
//     //     }
//     //   }
//     //   catch (Exception ex) {
//     //     LogUtil.WriteLog("StringManager fail load Info _filePath=" + requestUriString + " // Exception=" + ex, "ERROR");
//     //     return -19;
//     //   }
//     //
//     //   _isOpen = true;
//     // }
//     //
//     // stopwatch.Stop();
//     // ServerControlLogger.serverLogWrite(ServerLogType.eComplete, nameof(StringManager), stopwatch.ElapsedMilliseconds.ToString());
//     // return 0;
//   }
//
//   public string ItemName(int mainKey) {
//     var str = "-";
//     try {
//       if (ItemStringList.ContainsKey(mainKey.ToString()))
//         str = ItemStringList[mainKey.ToString()];
//     }
//     catch (Exception ex) {
//       Log.Error(ex, "StringManager key={MainKey} fail load xml", mainKey);
//     }
//
//     return str;
//   }
// }

