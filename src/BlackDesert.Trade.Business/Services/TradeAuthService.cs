using BlackDesert.Trade.Domain.DB.Context;
using BlackDesert.Trade.Domain.Models.Api;

namespace BlackDesert.Trade.Business.Services;

public static class TradeAuthService
{
  public static ViewUser AuthenticateForGame(long userNo,
                                             string certifiedKey) {
    DataHelper.ValidateUserNo(userNo);
    DataHelper.ValidateCertifiedKey(certifiedKey);
    var authResult = new ViewUser();
    var dbResult = new WorldDbContext().CheckAuthKey(userNo, certifiedKey);
    if (!dbResult.Status) throw new TradeMarketUnauthorized();
    authResult.userNo = userNo;
    authResult.worldNo = dbResult.Data.WorldNo;
    authResult.nationCode = dbResult.Data.ServiceType;
    authResult.userNickname = dbResult.Data.UserNickname;
    return authResult;
  }
}