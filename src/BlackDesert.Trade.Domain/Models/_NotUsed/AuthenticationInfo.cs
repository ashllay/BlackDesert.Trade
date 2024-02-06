// namespace BlackDesert.Trade.Domain.Models;
//
// public class AuthenticationInfo
// {
//   public AuthenticationInfo() {
//     userInfoModel = new UserInformationModel();
//   }
//
//   public long accountNo { get; set; }
//
//   public string certifiedKey { get; set; }
//
//   public string LoginIP { get; set; }
//
//   public string publisherID { get; set; }
//
//   public UserInformationModel userInfoModel { get; set; }
//
//   private DateTime loginTime { get; set; }
//
//   private DateTime authExpiration { get; set; }
//
//   public DateTime LoginTime {
//     get => loginTime;
//     set => loginTime = DateTime.SpecifyKind(value, DateTimeKind.Utc);
//   }
//
//   public DateTime AuthExpiration {
//     get => authExpiration;
//     set => authExpiration = DateTime.SpecifyKind(value, DateTimeKind.Utc);
//   }
// }