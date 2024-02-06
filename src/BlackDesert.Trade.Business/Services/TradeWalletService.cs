using BlackDesert.Trade.Business.Common;
using BlackDesert.Trade.Domain.DB.Context;
using BlackDesert.Trade.Domain.Models.Api;

namespace BlackDesert.Trade.Business.Services;

public sealed class TradeWalletService
{

  private readonly TradeDbContext _tradeDbContext;
  private readonly GameDbContext _gameDbContext;
  private readonly WorldDbContext _worldDbContext;
  private readonly LogDbContext _logDbContext;

  public TradeWalletService(
                            TradeDbContext tradeDbContext,
                            GameDbContext gameDbContext,
                            WorldDbContext worldDbContext,
                            LogDbContext logDbContext) {
    _tradeDbContext = tradeDbContext;
    _gameDbContext = gameDbContext;
    _worldDbContext = worldDbContext;
    _logDbContext = logDbContext;
  }

  public CommonResult CreateMyWallet(long userNo,
                                     string certifiedKey) {
    var user = TradeAuthService.AuthenticateForGame(userNo, certifiedKey);
    try {
      var userId = _worldDbContext.GetUserId_Unsafe(userNo);
      var isGameMaster = _worldDbContext.IsGameMaster_Safe(userNo);
      var valuePackageExpiration = _gameDbContext.GetValuePackageExpiration_Safe(userNo);
      var addWeightBuffExpiration = _gameDbContext.GetChargeBuffExpiration_Safe(userNo, 0);
      var familyPoint = _gameDbContext.GetFamilyPoint_Safe(userNo);
      var maidCount = _gameDbContext.GetMaidCount_Safe(userNo);
      var familySkillList = _gameDbContext.GetFamilySkillList_Safe(userNo);
      var tradeRingBuff = _gameDbContext.GetTradeRingBuff_Safe(userNo);

      var addPearlItemLimitedCount = VariedTradeCountManager.This.GetAddPearlItemLimitTradeCountByFamilyPoint(familyPoint);
      var addTaxDiscountRateByFamilyPoint = VariedTradeCountManager.This.GetAddTaxDiscountRateByFamilyPoint(familyPoint);
      var addTaxDiscountRateByFamilySkill = FamilySkillManager.This.GetAddTaxDiscountRateByFamilySkill(familySkillList);
      var increaseWeight = OptionManager.This.GetIncreaseWeightByFamilyPoint(familyPoint);
      var increaseWeightByBuff = OptionManager.This.GetIncreaseWeightByBuff(addWeightBuffExpiration);


      var dbResult = _tradeDbContext.CreateOrUpdateMyWallet_Unsafe(userId,
                                                                   userNo,
                                                                   user.userNickname,
                                                                   valuePackageExpiration,
                                                                   addWeightBuffExpiration,
                                                                   addPearlItemLimitedCount,
                                                                   maidCount,
                                                                   isGameMaster,
                                                                   addTaxDiscountRateByFamilyPoint,
                                                                   addTaxDiscountRateByFamilySkill,
                                                                   increaseWeight,
                                                                   increaseWeightByBuff,
                                                                   tradeRingBuff);
      var created = dbResult.Data;
      if (!dbResult.Status) return dbResult.ToCommonResult();
      if (dbResult.Data) {
        _logDbContext.Log_CreateMyWallet_Created(userNo);
      }

      var result = dbResult.ToCommonResult();
      var response = ResponseBuilder.BuildCreateMyWallet(created);
      result.resultMsg = response;
      return result;
    }
    catch (Exception ex) {
      Log.Error(ex, "[TRADE SERVICE EXCEPTION] CreateOrUpdateMyWallet_Unsafe({UserNo}/{CertifiedKey})", userNo, certifiedKey);
      return CommonResult.DbException(1);
    }
  }

  //COMPLETED
  public CommonResult GetMyWalletList(long userNo,
                                      string certifiedKey) {
    var user = TradeAuthService.AuthenticateForGame(userNo, certifiedKey);
    try {
      var myWalletList = _tradeDbContext.ListWorldMarketMyWallet_Unsafe(user.userNo);
      var responseWalletItemData = ResponseBuilder.BuildGetMyWalletList(myWalletList, out var totalWeight);
      _tradeDbContext.UpdateMyWalletWeight_Force_Unsafe(user.userNo, totalWeight);
      var walletInfo = _tradeDbContext.GetPearlItemTradeCount_Force_Unsafe(user.userNo);
      var lastOtpTimeUtc = _tradeDbContext.GetLastOtpTime_Safe(user.userNo);
      const string template
        = "{WalletItemData}+{PersonalTradeList}+{TotalWeight}_{MaxWeight}_{ItemLimitedMaxCount}_{AddPearlItemLimitedCount}_{CurrentPearlItemLimitedCount}_{AddWeight}_{RingBuffCount}_{LastOtpTimeUtc}";
      var sb = new StringBuilder();
      sb.Append(template);
      sb.Replace("{WalletItemData}", responseWalletItemData);
      sb.Replace("{PersonalTradeList}", "0");
      sb.Replace("{TotalWeight}", totalWeight.ToString());
      sb.Replace("{MaxWeight}", OptionManager.This.GetMaxWeight().ToString());
      sb.Replace("{ItemLimitedMaxCount}", OptionManager.This.GetPearlItemLimitedMaxCount().ToString());
      sb.Replace("{AddPearlItemLimitedCount}", walletInfo.AddPearlItemLimitedCount.ToString());
      sb.Replace("{CurrentPearlItemLimitedCount}", walletInfo.CurrentPearlItemLimitedCount.ToString());
      sb.Replace("{AddWeight}", walletInfo.AddWeight.ToString());
      sb.Replace("{RingBuffCount}", walletInfo.RingBuffCount.ToString());
      sb.Replace("{LastOtpTimeUtc}", lastOtpTimeUtc.ToString());
      return new CommonResult(0, sb.ToString());
    }
    catch (Exception ex) {
      Log.Error(ex, "[TRADE SERVICE EXCEPTION] GetMyWalletList({UserNo}/{CertifiedKey})", userNo, certifiedKey);
      return CommonResult.DbException(1);
    }
  }

  public CommonResult GetMyWallet(ViewRequestGetMyWallet model) {
    var user = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    var result = _tradeDbContext.GetCountMyWallet(user.userNo,
                                                  model.mainKey,
                                                  model.subKey,
                                                  model.isSealed);
    if (!result.Status)
      return result.ToCommonResult();
    const string template = "{KeyType}_{MainKey}_{SubKey}_{IsSealed}_{Count}";
    var sb = new StringBuilder();
    sb.Append(template);
    sb.Replace("{KeyType}", Convert.ToString(model.keyType));
    sb.Replace("{MainKey}", Convert.ToString(model.mainKey));
    sb.Replace("{SubKey}", Convert.ToString(model.subKey));
    sb.Replace("{IsSealed}", Convert.ToString(model.isSealed));
    sb.Replace("{Count}", result.Data.ToString());
    return CommonResult.Success(sb.ToString());
  }
}