using BlackDesert.Trade.Db.Entities.GameEntities;

namespace BlackDesert.Trade.Domain.DB.Context;

public partial class GameDbContext : DbContext
{
  public GameDbContext() { }

  public GameDbContext(DbContextOptions<GameDbContext> options)
    : base(options) { }

  public virtual DbSet<DimGuildItemKey> DimGuildItemKeys { get; set; }

  public virtual DbSet<DimInstancefieldKey> DimInstancefieldKeys { get; set; }

  public virtual DbSet<DimItemKeyNeedContribute> DimItemKeyNeedContributes { get; set; }

  public virtual DbSet<DimItemOptionBlunt> DimItemOptionBlunts { get; set; }

  public virtual DbSet<DimItemOptionLongSword> DimItemOptionLongSwords { get; set; }

  public virtual DbSet<DimItemOptionTwoHandSword> DimItemOptionTwoHandSwords { get; set; }

  public virtual DbSet<DimMentalCardList> DimMentalCardLists { get; set; }

  public virtual DbSet<DimNodeNeedContribute> DimNodeNeedContributes { get; set; }

  public virtual DbSet<DimVariousNo> DimVariousNos { get; set; }

  public virtual DbSet<DimVariousNo1> DimVariousNos1 { get; set; }

  public virtual DbSet<DimWaypointKey> DimWaypointKeys { get; set; }

  public virtual DbSet<TabnormalPayloadBak> TabnormalPayloadBaks { get; set; }

  public virtual DbSet<TargetItem> TargetItems { get; set; }

  public virtual DbSet<TargetQuest> TargetQuests { get; set; }

  public virtual DbSet<TblAbsolutePower> TblAbsolutePowers { get; set; }

  public virtual DbSet<TblAbsolutePowerHistory> TblAbsolutePowerHistories { get; set; }

  public virtual DbSet<TblAcoinChargeNumbersByWeb> TblAcoinChargeNumbersByWebs { get; set; }

  public virtual DbSet<TblAddFriendList> TblAddFriendLists { get; set; }

  public virtual DbSet<TblAlchemyRecord> TblAlchemyRecords { get; set; }

  public virtual DbSet<TblAlchemyRecordNoOverlap> TblAlchemyRecordNoOverlaps { get; set; }

  public virtual DbSet<TblAltarOfBloodRank> TblAltarOfBloodRanks { get; set; }

  public virtual DbSet<TblAreaOfHadum> TblAreaOfHada { get; set; }

  public virtual DbSet<TblAttendPersonalBattle> TblAttendPersonalBattles { get; set; }

  public virtual DbSet<TblAttendance> TblAttendances { get; set; }

  public virtual DbSet<TblAuctionBidderVer2> TblAuctionBidderVer2s { get; set; }

  public virtual DbSet<TblAuctionBidderVer2GuildHouseBak> TblAuctionBidderVer2GuildHouseBaks { get; set; }

  public virtual DbSet<TblAuctionBuyGoodsVer2> TblAuctionBuyGoodsVer2s { get; set; }

  public virtual DbSet<TblAuctionGoodsVer2> TblAuctionGoodsVer2s { get; set; }

  public virtual DbSet<TblAuctionInfo> TblAuctionInfos { get; set; }

  public virtual DbSet<TblAutoChessDeck> TblAutoChessDecks { get; set; }

  public virtual DbSet<TblBadPlayerList> TblBadPlayerLists { get; set; }

  public virtual DbSet<TblBarterInfoList> TblBarterInfoLists { get; set; }

  public virtual DbSet<TblBarterUserInfo> TblBarterUserInfos { get; set; }

  public virtual DbSet<TblBattleHeroRanking> TblBattleHeroRankings { get; set; }

  public virtual DbSet<TblBattlePass> TblBattlePasses { get; set; }

  public virtual DbSet<TblBattleRoyaleItemsInfo> TblBattleRoyaleItemsInfos { get; set; }

  public virtual DbSet<TblBattleRoyalePlayTime> TblBattleRoyalePlayTimes { get; set; }

  public virtual DbSet<TblBattleRoyaleSmuggledItemsInfo> TblBattleRoyaleSmuggledItemsInfos { get; set; }

  public virtual DbSet<TblBattleRoyaleUserInfo> TblBattleRoyaleUserInfos { get; set; }

  public virtual DbSet<TblBattleRoyaleUserPlayTimeLog> TblBattleRoyaleUserPlayTimeLogs { get; set; }

  public virtual DbSet<TblBlackMarble> TblBlackMarbles { get; set; }

  public virtual DbSet<TblBlackSpiritAdventure> TblBlackSpiritAdventures { get; set; }

  public virtual DbSet<TblBlackSpiritAdventureItem> TblBlackSpiritAdventureItems { get; set; }

  public virtual DbSet<TblBlackSpiritAdventureMonster> TblBlackSpiritAdventureMonsters { get; set; }

  public virtual DbSet<TblBlackSpiritAdventureQuest> TblBlackSpiritAdventureQuests { get; set; }

  public virtual DbSet<TblBlackSpiritAdventureRegion> TblBlackSpiritAdventureRegions { get; set; }

  public virtual DbSet<TblBlackSpiritForm> TblBlackSpiritForms { get; set; }

  public virtual DbSet<TblBlockByKeyOrUserNo> TblBlockByKeyOrUserNos { get; set; }

  public virtual DbSet<TblBlockItem> TblBlockItems { get; set; }

  public virtual DbSet<TblBlockItemForTrade> TblBlockItemForTrades { get; set; }

  public virtual DbSet<TblBlockQuest> TblBlockQuests { get; set; }

  public virtual DbSet<TblBlockQuestLog> TblBlockQuestLogs { get; set; }

  public virtual DbSet<TblBlockUsingPointByUser> TblBlockUsingPointByUsers { get; set; }

  public virtual DbSet<TblBlockedChat> TblBlockedChats { get; set; }

  public virtual DbSet<TblBlockedItemLog> TblBlockedItemLogs { get; set; }

  public virtual DbSet<TblBossSpawn> TblBossSpawns { get; set; }

  public virtual DbSet<TblBranchQuest> TblBranchQuests { get; set; }

  public virtual DbSet<TblBriefUserInformation> TblBriefUserInformations { get; set; }

  public virtual DbSet<TblBuff> TblBuffs { get; set; }

  public virtual DbSet<TblBuffCount> TblBuffCounts { get; set; }

  public virtual DbSet<TblBuffExpirationDate> TblBuffExpirationDates { get; set; }

  public virtual DbSet<TblBusinessInstallation> TblBusinessInstallations { get; set; }

  public virtual DbSet<TblCacheSeq> TblCacheSeqs { get; set; }

  public virtual DbSet<TblCandidateList> TblCandidateLists { get; set; }

  public virtual DbSet<TblCaphrasBonusSlot> TblCaphrasBonusSlots { get; set; }

  public virtual DbSet<TblCashItemBuyCount> TblCashItemBuyCounts { get; set; }

  public virtual DbSet<TblCashItemBuyCountBak> TblCashItemBuyCountBaks { get; set; }

  public virtual DbSet<TblChallengeReward> TblChallengeRewards { get; set; }

  public virtual DbSet<TblChangeContentsOptionUser> TblChangeContentsOptionUsers { get; set; }

  public virtual DbSet<TblCharacterCustomizing> TblCharacterCustomizings { get; set; }

  public virtual DbSet<TblCharacterDetailInformation> TblCharacterDetailInformations { get; set; }

  public virtual DbSet<TblCharacterExpLoan> TblCharacterExpLoans { get; set; }

  public virtual DbSet<TblCharacterExpLoanLog> TblCharacterExpLoanLogs { get; set; }

  public virtual DbSet<TblCharacterInformation> TblCharacterInformations { get; set; }

  public virtual DbSet<TblCharacterLifeStat> TblCharacterLifeStats { get; set; }

  public virtual DbSet<TblCharacterMemo> TblCharacterMemos { get; set; }

  public virtual DbSet<TblCharacterNameModStr> TblCharacterNameModStrs { get; set; }

  public virtual DbSet<TblCharacterSpecialInformation> TblCharacterSpecialInformations { get; set; }

  public virtual DbSet<TblCharacterUicustomizing> TblCharacterUicustomizings { get; set; }

  public virtual DbSet<TblChatBlockByUser> TblChatBlockByUsers { get; set; }

  public virtual DbSet<TblChatBlockListByUser> TblChatBlockListByUsers { get; set; }

  public virtual DbSet<TblCheckItemForRemoveCharacter> TblCheckItemForRemoveCharacters { get; set; }

  public virtual DbSet<TblClearedBattlePass> TblClearedBattlePasses { get; set; }

  public virtual DbSet<TblClearedNewQuest> TblClearedNewQuests { get; set; }

  public virtual DbSet<TblClearedQuestList> TblClearedQuestLists { get; set; }

  public virtual DbSet<TblCommonBoardReport> TblCommonBoardReports { get; set; }

  public virtual DbSet<TblCommonContentsScoreRecord> TblCommonContentsScoreRecords { get; set; }

  public virtual DbSet<TblCommonSkillNo> TblCommonSkillNos { get; set; }

  public virtual DbSet<TblCompletedChallenge> TblCompletedChallenges { get; set; }

  public virtual DbSet<TblCompletedGuildBattle> TblCompletedGuildBattles { get; set; }

  public virtual DbSet<TblCompletedGuildDuel> TblCompletedGuildDuels { get; set; }

  public virtual DbSet<TblCompletedPersonalBattle> TblCompletedPersonalBattles { get; set; }

  public virtual DbSet<TblCompositionNote> TblCompositionNotes { get; set; }

  public virtual DbSet<TblCompositionNotesCount> TblCompositionNotesCounts { get; set; }

  public virtual DbSet<TblCompositionNotesReply> TblCompositionNotesReplies { get; set; }

  public virtual DbSet<TblConsignmentSale> TblConsignmentSales { get; set; }

  public virtual DbSet<TblContentsSeason> TblContentsSeasons { get; set; }

  public virtual DbSet<TblCoolTime> TblCoolTimes { get; set; }

  public virtual DbSet<TblCopyUserDate> TblCopyUserDates { get; set; }

  public virtual DbSet<TblCoupon> TblCoupons { get; set; }

  public virtual DbSet<TblCouponTargetUser> TblCouponTargetUsers { get; set; }

  public virtual DbSet<TblCrew> TblCrews { get; set; }

  public virtual DbSet<TblCrewMember> TblCrewMembers { get; set; }

  public virtual DbSet<TblCustomBarteringInfo> TblCustomBarteringInfos { get; set; }

  public virtual DbSet<TblCustomGuildWarHistory> TblCustomGuildWarHistories { get; set; }

  public virtual DbSet<TblCustomName> TblCustomNames { get; set; }

  public virtual DbSet<TblCustomizedKey> TblCustomizedKeys { get; set; }

  public virtual DbSet<TblCustomizingDownloadLog> TblCustomizingDownloadLogs { get; set; }

  public virtual DbSet<TblCustomizingGallery> TblCustomizingGalleries { get; set; }

  public virtual DbSet<TblCustomizingGalleryAuthRank> TblCustomizingGalleryAuthRanks { get; set; }

  public virtual DbSet<TblCustomizingGalleryAuthRankSnap> TblCustomizingGalleryAuthRankSnaps { get; set; }

  public virtual DbSet<TblCustomizingGalleryAuthRankTemp> TblCustomizingGalleryAuthRankTemps { get; set; }

  public virtual DbSet<TblCustomizingGalleryBlind> TblCustomizingGalleryBlinds { get; set; }

  public virtual DbSet<TblCustomizingGalleryComment> TblCustomizingGalleryComments { get; set; }

  public virtual DbSet<TblCustomizingLikeLog> TblCustomizingLikeLogs { get; set; }

  public virtual DbSet<TblCustomizingReportLog> TblCustomizingReportLogs { get; set; }

  public virtual DbSet<TblDailyBattlePassPoint> TblDailyBattlePassPoints { get; set; }

  public virtual DbSet<TblDailyPlayInfo> TblDailyPlayInfos { get; set; }

  public virtual DbSet<TblDeletedCharacterInformation> TblDeletedCharacterInformations { get; set; }

  public virtual DbSet<TblDeletedItemRepository> TblDeletedItemRepositories { get; set; }

  public virtual DbSet<TblDeletedNameExchange> TblDeletedNameExchanges { get; set; }

  public virtual DbSet<TblDeletedPet> TblDeletedPets { get; set; }

  public virtual DbSet<TblDeliveryRepository> TblDeliveryRepositories { get; set; }

  public virtual DbSet<TblDuelCharacterInfo> TblDuelCharacterInfos { get; set; }

  public virtual DbSet<TblEmoticon> TblEmoticons { get; set; }

  public virtual DbSet<TblEmployeeRepository> TblEmployeeRepositories { get; set; }

  public virtual DbSet<TblEmployeeSpawnInformation> TblEmployeeSpawnInformations { get; set; }

  public virtual DbSet<TblEncyclopedium> TblEncyclopedia { get; set; }

  public virtual DbSet<TblEventBuff> TblEventBuffs { get; set; }

  public virtual DbSet<TblEventMarbleGame> TblEventMarbleGames { get; set; }

  public virtual DbSet<TblEventMarbleGameDiceItem> TblEventMarbleGameDiceItems { get; set; }

  public virtual DbSet<TblEventMarbleGameMap> TblEventMarbleGameMaps { get; set; }

  public virtual DbSet<TblExcaliburUserInfo> TblExcaliburUserInfos { get; set; }

  public virtual DbSet<TblExpeditionResultItem> TblExpeditionResultItems { get; set; }

  public virtual DbSet<TblExpeditionaryUnit> TblExpeditionaryUnits { get; set; }

  public virtual DbSet<TblExplorationPoint> TblExplorationPoints { get; set; }

  public virtual DbSet<TblExtendSlotRepository> TblExtendSlotRepositories { get; set; }

  public virtual DbSet<TblFairyLook> TblFairyLooks { get; set; }

  public virtual DbSet<TblFameCoolTime> TblFameCoolTimes { get; set; }

  public virtual DbSet<TblFameInfo> TblFameInfos { get; set; }

  public virtual DbSet<TblFamePreSeasonRank> TblFamePreSeasonRanks { get; set; }

  public virtual DbSet<TblFameSeasonRank> TblFameSeasonRanks { get; set; }

  public virtual DbSet<TblFameSeasonRankNew> TblFameSeasonRankNews { get; set; }

  public virtual DbSet<TblFameTotalRank> TblFameTotalRanks { get; set; }

  public virtual DbSet<TblFameTotalRankNew> TblFameTotalRankNews { get; set; }

  public virtual DbSet<TblFamilySkill> TblFamilySkills { get; set; }

  public virtual DbSet<TblFamilySkillPoint> TblFamilySkillPoints { get; set; }

  public virtual DbSet<TblFamilySpecialInformation> TblFamilySpecialInformations { get; set; }

  public virtual DbSet<TblFeverPoint> TblFeverPoints { get; set; }

  public virtual DbSet<TblFindHiddenRecipe> TblFindHiddenRecipes { get; set; }

  public virtual DbSet<TblFishTopRanking> TblFishTopRankings { get; set; }

  public virtual DbSet<TblFitnessExperience> TblFitnessExperiences { get; set; }

  public virtual DbSet<TblFixedBusinessInformation> TblFixedBusinessInformations { get; set; }

  public virtual DbSet<TblFixedConsignmentSale> TblFixedConsignmentSales { get; set; }

  public virtual DbSet<TblFixedVendingMachine> TblFixedVendingMachines { get; set; }

  public virtual DbSet<TblFriend> TblFriends { get; set; }

  public virtual DbSet<TblFriendGroup> TblFriendGroups { get; set; }

  public virtual DbSet<TblFuelInsertCharacterInfo> TblFuelInsertCharacterInfos { get; set; }

  public virtual DbSet<TblFuelInsertCharacterSettingInfo> TblFuelInsertCharacterSettingInfos { get; set; }

  public virtual DbSet<TblFuelInsertInfo> TblFuelInsertInfos { get; set; }

  public virtual DbSet<TblGeneralRepository> TblGeneralRepositories { get; set; }

  public virtual DbSet<TblGetGuildGiveawayUser> TblGetGuildGiveawayUsers { get; set; }

  public virtual DbSet<TblGreatSeaRepository> TblGreatSeaRepositories { get; set; }

  public virtual DbSet<TblGrowStep> TblGrowSteps { get; set; }

  public virtual DbSet<TblGrowthPassCategoryReward> TblGrowthPassCategoryRewards { get; set; }

  public virtual DbSet<TblGrowthPassTotalReward> TblGrowthPassTotalRewards { get; set; }

  public virtual DbSet<TblGuild> TblGuilds { get; set; }

  public virtual DbSet<TblGuildAlliance> TblGuildAlliances { get; set; }

  public virtual DbSet<TblGuildAllianceInformation> TblGuildAllianceInformations { get; set; }

  public virtual DbSet<TblGuildApplicant> TblGuildApplicants { get; set; }

  public virtual DbSet<TblGuildBattleRanking> TblGuildBattleRankings { get; set; }

  public virtual DbSet<TblGuildBoard> TblGuildBoards { get; set; }

  public virtual DbSet<TblGuildCapital> TblGuildCapitals { get; set; }

  public virtual DbSet<TblGuildComment> TblGuildComments { get; set; }

  public virtual DbSet<TblGuildGathering> TblGuildGatherings { get; set; }

  public virtual DbSet<TblGuildGiveaway> TblGuildGiveaways { get; set; }

  public virtual DbSet<TblGuildHouseLargeCraft> TblGuildHouseLargeCrafts { get; set; }

  public virtual DbSet<TblGuildHouseLargeCraftDailyCount> TblGuildHouseLargeCraftDailyCounts { get; set; }

  public virtual DbSet<TblGuildInformation> TblGuildInformations { get; set; }

  public virtual DbSet<TblGuildInformationComment> TblGuildInformationComments { get; set; }

  public virtual DbSet<TblGuildInformationCommentBlock> TblGuildInformationCommentBlocks { get; set; }

  public virtual DbSet<TblGuildJournal> TblGuildJournals { get; set; }

  public virtual DbSet<TblGuildLifeRankingInfo> TblGuildLifeRankingInfos { get; set; }

  public virtual DbSet<TblGuildManufacture> TblGuildManufactures { get; set; }

  public virtual DbSet<TblGuildManufactureDailyCount> TblGuildManufactureDailyCounts { get; set; }

  public virtual DbSet<TblGuildMember> TblGuildMembers { get; set; }

  public virtual DbSet<TblGuildPendingReward> TblGuildPendingRewards { get; set; }

  public virtual DbSet<TblGuildPendingRewardLog> TblGuildPendingRewardLogs { get; set; }

  public virtual DbSet<TblGuildPendingRewardUser> TblGuildPendingRewardUsers { get; set; }

  public virtual DbSet<TblGuildPoint> TblGuildPoints { get; set; }

  public virtual DbSet<TblGuildPr> TblGuildPrs { get; set; }

  public virtual DbSet<TblGuildQuestList> TblGuildQuestLists { get; set; }

  public virtual DbSet<TblGuildRankingInfo> TblGuildRankingInfos { get; set; }

  public virtual DbSet<TblGuildRecommend> TblGuildRecommends { get; set; }

  public virtual DbSet<TblGuildSkill> TblGuildSkills { get; set; }

  public virtual DbSet<TblGuildSkillCoolTime> TblGuildSkillCoolTimes { get; set; }

  public virtual DbSet<TblGuildVolunteerMember> TblGuildVolunteerMembers { get; set; }

  public virtual DbSet<TblGuildWar> TblGuildWars { get; set; }

  public virtual DbSet<TblGuildWarHistory> TblGuildWarHistories { get; set; }

  public virtual DbSet<TblGuildWareHouseHistory> TblGuildWareHouseHistories { get; set; }

  public virtual DbSet<TblHarvestInstallation> TblHarvestInstallations { get; set; }

  public virtual DbSet<TblHiddenDrop> TblHiddenDrops { get; set; }

  public virtual DbSet<TblHorseRacingPreRecordRank> TblHorseRacingPreRecordRanks { get; set; }

  public virtual DbSet<TblHorseRacingPreTotalRank> TblHorseRacingPreTotalRanks { get; set; }

  public virtual DbSet<TblHorseRacingRank> TblHorseRacingRanks { get; set; }

  public virtual DbSet<TblHorseRacingRecordRank> TblHorseRacingRecordRanks { get; set; }

  public virtual DbSet<TblHorseRacingRecordRankNew> TblHorseRacingRecordRankNews { get; set; }

  public virtual DbSet<TblHorseRacingTotalRank> TblHorseRacingTotalRanks { get; set; }

  public virtual DbSet<TblHorseRacingTotalRankNew> TblHorseRacingTotalRankNews { get; set; }

  public virtual DbSet<TblHouseLargeCraft> TblHouseLargeCrafts { get; set; }

  public virtual DbSet<TblHouseListForTownManagement> TblHouseListForTownManagements { get; set; }

  public virtual DbSet<TblHouseholdFixed> TblHouseholdFixeds { get; set; }

  public virtual DbSet<TblHouseholdSpec> TblHouseholdSpecs { get; set; }

  public virtual DbSet<TblHouseholdTent> TblHouseholdTents { get; set; }

  public virtual DbSet<TblInstallation> TblInstallations { get; set; }

  public virtual DbSet<TblInstallationTempRealItemList> TblInstallationTempRealItemLists { get; set; }

  public virtual DbSet<TblInstallationTempVirtualItemList> TblInstallationTempVirtualItemLists { get; set; }

  public virtual DbSet<TblInstalledInstanceObject> TblInstalledInstanceObjects { get; set; }

  public virtual DbSet<TblInstanceContentReward> TblInstanceContentRewards { get; set; }

  public virtual DbSet<TblInstanceFieldCurruetServerNo> TblInstanceFieldCurruetServerNos { get; set; }

  public virtual DbSet<TblInstanceFieldCustomRoomOption> TblInstanceFieldCustomRoomOptions { get; set; }

  public virtual DbSet<TblInstanceFieldMatching> TblInstanceFieldMatchings { get; set; }

  public virtual DbSet<TblInstanceFieldNormalDatum> TblInstanceFieldNormalData { get; set; }

  public virtual DbSet<TblInstanceFieldOnlineUserRanking> TblInstanceFieldOnlineUserRankings { get; set; }

  public virtual DbSet<TblInstanceFieldOnlineUserRankingNew> TblInstanceFieldOnlineUserRankingNews { get; set; }

  public virtual DbSet<TblInstanceFieldRankDatum> TblInstanceFieldRankData { get; set; }

  public virtual DbSet<TblInstanceFieldReadyUser> TblInstanceFieldReadyUsers { get; set; }

  public virtual DbSet<TblInstrumentInfo> TblInstrumentInfos { get; set; }

  public virtual DbSet<TblInvestGuildPointInformation> TblInvestGuildPointInformations { get; set; }

  public virtual DbSet<TblItemCollectionScroll> TblItemCollectionScrolls { get; set; }

  public virtual DbSet<TblItemDeliverer> TblItemDeliverers { get; set; }

  public virtual DbSet<TblItemMarketMaster> TblItemMarketMasters { get; set; }

  public virtual DbSet<TblItemMarketReservation> TblItemMarketReservations { get; set; }

  public virtual DbSet<TblItemMarketSell> TblItemMarketSells { get; set; }

  public virtual DbSet<TblItemMarketSellByParty> TblItemMarketSellByParties { get; set; }

  public virtual DbSet<TblItemMarketSellByReservation> TblItemMarketSellByReservations { get; set; }

  public virtual DbSet<TblItemNaming> TblItemNamings { get; set; }

  public virtual DbSet<TblItemOptionRepository> TblItemOptionRepositories { get; set; }

  public virtual DbSet<TblItemRental> TblItemRentals { get; set; }

  public virtual DbSet<TblItemRepository> TblItemRepositories { get; set; }

  public virtual DbSet<TblItemRepositoryGuildMoneyBak> TblItemRepositoryGuildMoneyBaks { get; set; }

  public virtual DbSet<TblItemRestoreWaiting> TblItemRestoreWaitings { get; set; }

  public virtual DbSet<TblItemToInventoryRequest> TblItemToInventoryRequests { get; set; }

  public virtual DbSet<TblItemToWarehouseRequest> TblItemToWarehouseRequests { get; set; }

  public virtual DbSet<TblJournal> TblJournals { get; set; }

  public virtual DbSet<TblLeaveBriefUserInformation> TblLeaveBriefUserInformations { get; set; }

  public virtual DbSet<TblLeaveLog> TblLeaveLogs { get; set; }

  public virtual DbSet<TblLifeExperience> TblLifeExperiences { get; set; }

  public virtual DbSet<TblLimitedCashProduct> TblLimitedCashProducts { get; set; }

  public virtual DbSet<TblLogoutPlayerWorking> TblLogoutPlayerWorkings { get; set; }

  public virtual DbSet<TblLoverList> TblLoverLists { get; set; }

  public virtual DbSet<TblMacroKeyInputCheckLog> TblMacroKeyInputCheckLogs { get; set; }

  public virtual DbSet<TblMaid> TblMaids { get; set; }

  public virtual DbSet<TblMail> TblMails { get; set; }

  public virtual DbSet<TblMailItemWhiteList> TblMailItemWhiteLists { get; set; }

  public virtual DbSet<TblMailPs4sub> TblMailPs4subs { get; set; }

  public virtual DbSet<TblMailWaitingQueue> TblMailWaitingQueues { get; set; }

  public virtual DbSet<TblMainQuestGroupInfo> TblMainQuestGroupInfos { get; set; }

  public virtual DbSet<TblMansionListForTownManagement> TblMansionListForTownManagements { get; set; }

  public virtual DbSet<TblMarbleGame> TblMarbleGames { get; set; }

  public virtual DbSet<TblMarbleGameCard> TblMarbleGameCards { get; set; }

  public virtual DbSet<TblMarbleGameDiceItem> TblMarbleGameDiceItems { get; set; }

  public virtual DbSet<TblMarbleGameMap> TblMarbleGameMaps { get; set; }

  public virtual DbSet<TblMassMail> TblMassMails { get; set; }

  public virtual DbSet<TblMassMailInfo> TblMassMailInfos { get; set; }

  public virtual DbSet<TblMassMailRequest> TblMassMailRequests { get; set; }

  public virtual DbSet<TblMassMailUserInfo> TblMassMailUserInfos { get; set; }

  public virtual DbSet<TblMassPlayerTitleRequest> TblMassPlayerTitleRequests { get; set; }

  public virtual DbSet<TblMasterySkillInfo> TblMasterySkillInfos { get; set; }

  public virtual DbSet<TblMentalCardList> TblMentalCardLists { get; set; }

  public virtual DbSet<TblMessengerInfo> TblMessengerInfos { get; set; }

  public virtual DbSet<TblMessengerMessage> TblMessengerMessages { get; set; }

  public virtual DbSet<TblMilitiaMember> TblMilitiaMembers { get; set; }

  public virtual DbSet<TblMiniGameUserInformation> TblMiniGameUserInformations { get; set; }

  public virtual DbSet<TblMusicLevelInfo> TblMusicLevelInfos { get; set; }

  public virtual DbSet<TblMusicScore> TblMusicScores { get; set; }

  public virtual DbSet<TblNameChange> TblNameChanges { get; set; }

  public virtual DbSet<TblNameChangeComplete> TblNameChangeCompletes { get; set; }

  public virtual DbSet<TblNameExchange> TblNameExchanges { get; set; }

  public virtual DbSet<TblNameExchangeComplete> TblNameExchangeCompletes { get; set; }

  public virtual DbSet<TblNewDeliveryRepository> TblNewDeliveryRepositories { get; set; }

  public virtual DbSet<TblNpcProposeDialog> TblNpcProposeDialogs { get; set; }

  public virtual DbSet<TblNpcShopItemBuyCount> TblNpcShopItemBuyCounts { get; set; }

  public virtual DbSet<TblOperationReport> TblOperationReports { get; set; }

  public virtual DbSet<TblPalette> TblPalettes { get; set; }

  public virtual DbSet<TblParty> TblParties { get; set; }

  public virtual DbSet<TblPartyMatching> TblPartyMatchings { get; set; }

  public virtual DbSet<TblPartyMatchingMember> TblPartyMatchingMembers { get; set; }

  public virtual DbSet<TblPcWorking> TblPcWorkings { get; set; }

  public virtual DbSet<TblPearlCashProductList> TblPearlCashProductLists { get; set; }

  public virtual DbSet<TblPearlInventoryDeletedItemRestoreLog> TblPearlInventoryDeletedItemRestoreLogs { get; set; }

  public virtual DbSet<TblPearlItemList> TblPearlItemLists { get; set; }

  public virtual DbSet<TblPearlUsedAmount> TblPearlUsedAmounts { get; set; }

  public virtual DbSet<TblPearlUsedChallengeResetCount> TblPearlUsedChallengeResetCounts { get; set; }

  public virtual DbSet<TblPearlUsedLastMonthAmount> TblPearlUsedLastMonthAmounts { get; set; }

  public virtual DbSet<TblPenaltyEscape> TblPenaltyEscapes { get; set; }

  public virtual DbSet<TblPendingReward> TblPendingRewards { get; set; }

  public virtual DbSet<TblPendingRewardLog> TblPendingRewardLogs { get; set; }

  public virtual DbSet<TblPersonalBattleRanking> TblPersonalBattleRankings { get; set; }

  public virtual DbSet<TblPersonalDuelRanking> TblPersonalDuelRankings { get; set; }

  public virtual DbSet<TblPersonalMonsterInformation> TblPersonalMonsterInformations { get; set; }

  public virtual DbSet<TblPersonalMonsterUserInfo> TblPersonalMonsterUserInfos { get; set; }

  public virtual DbSet<TblPet> TblPets { get; set; }

  public virtual DbSet<TblPlantRepository> TblPlantRepositories { get; set; }

  public virtual DbSet<TblPlayerTitle> TblPlayerTitles { get; set; }

  public virtual DbSet<TblPostBoxTemplate> TblPostBoxTemplates { get; set; }

  public virtual DbSet<TblPriorityGuildPr> TblPriorityGuildPrs { get; set; }

  public virtual DbSet<TblPrizeLottery> TblPrizeLotteries { get; set; }

  public virtual DbSet<TblProgressChallenge> TblProgressChallenges { get; set; }

  public virtual DbSet<TblProgressExpedition> TblProgressExpeditions { get; set; }

  public virtual DbSet<TblProgressingGuildDuel> TblProgressingGuildDuels { get; set; }

  public virtual DbSet<TblProgressingNewQuest> TblProgressingNewQuests { get; set; }

  public virtual DbSet<TblProposeList> TblProposeLists { get; set; }

  public virtual DbSet<TblPs4cashInfoLog> TblPs4cashInfoLogs { get; set; }

  public virtual DbSet<TblPurchasedClassType> TblPurchasedClassTypes { get; set; }

  public virtual DbSet<TblPurchasedSkin> TblPurchasedSkins { get; set; }

  public virtual DbSet<TblQuizEventUserInfo> TblQuizEventUserInfos { get; set; }

  public virtual DbSet<TblRandomPartyMatching> TblRandomPartyMatchings { get; set; }

  public virtual DbSet<TblRecordGuildVolunteerScore> TblRecordGuildVolunteerScores { get; set; }

  public virtual DbSet<TblRegionGroup> TblRegionGroups { get; set; }

  public virtual DbSet<TblRentInstanceField> TblRentInstanceFields { get; set; }

  public virtual DbSet<TblRentInstanceFieldPass> TblRentInstanceFieldPasses { get; set; }

  public virtual DbSet<TblRequestGuildInviteList> TblRequestGuildInviteLists { get; set; }

  public virtual DbSet<TblReservationArsha> TblReservationArshas { get; set; }

  public virtual DbSet<TblRestoreItemRepository> TblRestoreItemRepositories { get; set; }

  public virtual DbSet<TblRestoreItemUserInfo> TblRestoreItemUserInfos { get; set; }

  public virtual DbSet<TblRestoreServantList> TblRestoreServantLists { get; set; }

  public virtual DbSet<TblReturnStone> TblReturnStones { get; set; }

  public virtual DbSet<TblScreenShot> TblScreenShots { get; set; }

  public virtual DbSet<TblScreenShotBlind> TblScreenShotBlinds { get; set; }

  public virtual DbSet<TblScreenShotComment> TblScreenShotComments { get; set; }

  public virtual DbSet<TblScreenShotCommentReport> TblScreenShotCommentReports { get; set; }

  public virtual DbSet<TblScreenShotLikeLog> TblScreenShotLikeLogs { get; set; }

  public virtual DbSet<TblSeasonChangeLog> TblSeasonChangeLogs { get; set; }

  public virtual DbSet<TblSeasonCharacter> TblSeasonCharacters { get; set; }

  public virtual DbSet<TblSeasonCloseChallenge> TblSeasonCloseChallenges { get; set; }

  public virtual DbSet<TblSeasonCloseChallengeInfo> TblSeasonCloseChallengeInfos { get; set; }

  public virtual DbSet<TblSeasonCloseChallengeWithReward> TblSeasonCloseChallengeWithRewards { get; set; }

  public virtual DbSet<TblSeasonCloseChangeItem> TblSeasonCloseChangeItems { get; set; }

  public virtual DbSet<TblSeasonCloseCharacterType> TblSeasonCloseCharacterTypes { get; set; }

  public virtual DbSet<TblSeasonCloseDeleteItem> TblSeasonCloseDeleteItems { get; set; }

  public virtual DbSet<TblSeasonCloseItemInfo> TblSeasonCloseItemInfos { get; set; }

  public virtual DbSet<TblSeasonCloseQuest> TblSeasonCloseQuests { get; set; }

  public virtual DbSet<TblSeasonCloseQuestInfo> TblSeasonCloseQuestInfos { get; set; }

  public virtual DbSet<TblSeasonCloseQuestWithReward> TblSeasonCloseQuestWithRewards { get; set; }

  public virtual DbSet<TblSeasonInfo> TblSeasonInfos { get; set; }

  public virtual DbSet<TblSeasonParam> TblSeasonParams { get; set; }

  public virtual DbSet<TblSeasonResetMail> TblSeasonResetMails { get; set; }

  public virtual DbSet<TblSeasonReward> TblSeasonRewards { get; set; }

  public virtual DbSet<TblServantMating> TblServantMatings { get; set; }

  public virtual DbSet<TblServantRepository> TblServantRepositories { get; set; }

  public virtual DbSet<TblServantStallionSkillInfo> TblServantStallionSkillInfos { get; set; }

  public virtual DbSet<TblServantTierInfo> TblServantTierInfos { get; set; }

  public virtual DbSet<TblShaBriefUserInfoNewTagTargetUser> TblShaBriefUserInfoNewTagTargetUsers { get; set; }

  public virtual DbSet<TblShaFreeClassType> TblShaFreeClassTypes { get; set; }

  public virtual DbSet<TblShadowArenaAbusingUser> TblShadowArenaAbusingUsers { get; set; }

  public virtual DbSet<TblShadowArenaAttendance> TblShadowArenaAttendances { get; set; }

  public virtual DbSet<TblShadowArenaAttendanceOption> TblShadowArenaAttendanceOptions { get; set; }

  public virtual DbSet<TblShadowArenaBriefUserInformation> TblShadowArenaBriefUserInformations { get; set; }

  public virtual DbSet<TblShadowArenaCharacter> TblShadowArenaCharacters { get; set; }

  public virtual DbSet<TblShadowArenaClanApplicant> TblShadowArenaClanApplicants { get; set; }

  public virtual DbSet<TblShadowArenaClanAssembleFlag> TblShadowArenaClanAssembleFlags { get; set; }

  public virtual DbSet<TblShadowArenaClanChat> TblShadowArenaClanChats { get; set; }

  public virtual DbSet<TblShadowArenaDodgePanelty> TblShadowArenaDodgePanelties { get; set; }

  public virtual DbSet<TblShadowArenaFriendChat> TblShadowArenaFriendChats { get; set; }

  public virtual DbSet<TblShadowArenaLastBattleResultInfo> TblShadowArenaLastBattleResultInfos { get; set; }

  public virtual DbSet<TblShadowArenaOption> TblShadowArenaOptions { get; set; }

  public virtual DbSet<TblShadowArenaPurchasedProfileIcon> TblShadowArenaPurchasedProfileIcons { get; set; }

  public virtual DbSet<TblShadowArenaRestrictMode> TblShadowArenaRestrictModes { get; set; }

  public virtual DbSet<TblShadowArenaShopPreset> TblShadowArenaShopPresets { get; set; }

  public virtual DbSet<TblShadowArenaSkillAwakenList> TblShadowArenaSkillAwakenLists { get; set; }

  public virtual DbSet<TblShadowArenaSkillAwakenSelect> TblShadowArenaSkillAwakenSelects { get; set; }

  public virtual DbSet<TblShadowArenaSkillStone> TblShadowArenaSkillStones { get; set; }

  public virtual DbSet<TblShadowArenaSkinDyingInfo> TblShadowArenaSkinDyingInfos { get; set; }

  public virtual DbSet<TblShadowArenaUserTitle> TblShadowArenaUserTitles { get; set; }

  public virtual DbSet<TblSiege> TblSieges { get; set; }

  public virtual DbSet<TblSiegeBuildingHistory> TblSiegeBuildingHistories { get; set; }

  public virtual DbSet<TblSiegeColor> TblSiegeColors { get; set; }

  public virtual DbSet<TblSiegeHistory> TblSiegeHistories { get; set; }

  public virtual DbSet<TblSiegeScore> TblSiegeScores { get; set; }

  public virtual DbSet<TblSiegeSecondRoundScore> TblSiegeSecondRoundScores { get; set; }

  public virtual DbSet<TblSiegeTaxTime> TblSiegeTaxTimes { get; set; }

  public virtual DbSet<TblSiegeVote> TblSiegeVotes { get; set; }

  public virtual DbSet<TblSimpleGuildInviteList> TblSimpleGuildInviteLists { get; set; }

  public virtual DbSet<TblSkill> TblSkills { get; set; }

  public virtual DbSet<TblSkillAwakeningVersion2> TblSkillAwakeningVersion2s { get; set; }

  public virtual DbSet<TblSkillPreset> TblSkillPresets { get; set; }

  public virtual DbSet<TblSkillPresetLastUpdateTime> TblSkillPresetLastUpdateTimes { get; set; }

  public virtual DbSet<TblSkillPresetSlot> TblSkillPresetSlots { get; set; }

  public virtual DbSet<TblStatementTemp> TblStatementTemps { get; set; }

  public virtual DbSet<TblStockMarketBuy> TblStockMarketBuys { get; set; }

  public virtual DbSet<TblStockMarketSell> TblStockMarketSells { get; set; }

  public virtual DbSet<TblSupplyCount> TblSupplyCounts { get; set; }

  public virtual DbSet<TblSupportPoint> TblSupportPoints { get; set; }

  public virtual DbSet<TblSyncGuildInformation> TblSyncGuildInformations { get; set; }

  public virtual DbSet<TblSyncGuildInformationSnap> TblSyncGuildInformationSnaps { get; set; }

  public virtual DbSet<TblSyncGuildInformationTran> TblSyncGuildInformationTrans { get; set; }

  public virtual DbSet<TblSyncLifeExperience> TblSyncLifeExperiences { get; set; }

  public virtual DbSet<TblSyncLifeExperienceSnap> TblSyncLifeExperienceSnaps { get; set; }

  public virtual DbSet<TblSyncLifeExperienceTran> TblSyncLifeExperienceTrans { get; set; }

  public virtual DbSet<TblSyncWebUserInformation> TblSyncWebUserInformations { get; set; }

  public virtual DbSet<TblSyncWebUserInformationSnap> TblSyncWebUserInformationSnaps { get; set; }

  public virtual DbSet<TblSyncWebUserInformationTran> TblSyncWebUserInformationTrans { get; set; }

  public virtual DbSet<TblTax> TblTaxes { get; set; }

  public virtual DbSet<TblTeleportableUser> TblTeleportableUsers { get; set; }

  public virtual DbSet<TblTeleportationPoint> TblTeleportationPoints { get; set; }

  public virtual DbSet<TblTerritoryTradeAuthority> TblTerritoryTradeAuthorities { get; set; }

  public virtual DbSet<TblTerritoryTradeItem> TblTerritoryTradeItems { get; set; }

  public virtual DbSet<TblThumbsUpCountInformation> TblThumbsUpCountInformations { get; set; }

  public virtual DbSet<TblThumbsUpInformation> TblThumbsUpInformations { get; set; }

  public virtual DbSet<TblTimeAttackRanking> TblTimeAttackRankings { get; set; }

  public virtual DbSet<TblTradeCompany> TblTradeCompanies { get; set; }

  public virtual DbSet<TblTradeCompanyLog> TblTradeCompanyLogs { get; set; }

  public virtual DbSet<TblTradeCompanyObtainItem> TblTradeCompanyObtainItems { get; set; }

  public virtual DbSet<TblTradeGroupList> TblTradeGroupLists { get; set; }

  public virtual DbSet<TblTroller> TblTrollers { get; set; }

  public virtual DbSet<TblTutorial> TblTutorials { get; set; }

  public virtual DbSet<TblTutorialCharacterInfo> TblTutorialCharacterInfos { get; set; }

  public virtual DbSet<TblUserEnchantStackInfo> TblUserEnchantStackInfos { get; set; }

  public virtual DbSet<TblUserEnchantStackSlot> TblUserEnchantStackSlots { get; set; }

  public virtual DbSet<TblUserGameOptionType> TblUserGameOptionTypes { get; set; }

  public virtual DbSet<TblUserItemLoan> TblUserItemLoans { get; set; }

  public virtual DbSet<TblUserItemLoanLog> TblUserItemLoanLogs { get; set; }

  public virtual DbSet<TblUserLanguage> TblUserLanguages { get; set; }

  public virtual DbSet<TblUserNpcCustomizing> TblUserNpcCustomizings { get; set; }

  public virtual DbSet<TblUserPlayTimeLog> TblUserPlayTimeLogs { get; set; }

  public virtual DbSet<TblUserProfileInfo> TblUserProfileInfos { get; set; }

  public virtual DbSet<TblUserSeasonState> TblUserSeasonStates { get; set; }

  public virtual DbSet<TblUserSocialActionConfig> TblUserSocialActionConfigs { get; set; }

  public virtual DbSet<TblUserUsePearlForCashProduct> TblUserUsePearlForCashProducts { get; set; }

  public virtual DbSet<TblUsingHiredNpc> TblUsingHiredNpcs { get; set; }

  public virtual DbSet<TblVendingMachine> TblVendingMachines { get; set; }

  public virtual DbSet<TblVendorTempVirtualItemList> TblVendorTempVirtualItemLists { get; set; }

  public virtual DbSet<TblVote> TblVotes { get; set; }

  public virtual DbSet<TblWantedList> TblWantedLists { get; set; }

  public virtual DbSet<TblWarehouseSlotCount> TblWarehouseSlotCounts { get; set; }

  public virtual DbSet<TblWarningItemList> TblWarningItemLists { get; set; }

  public virtual DbSet<TblWarningItemMailList> TblWarningItemMailLists { get; set; }

  public virtual DbSet<TblWeatherDynamicFactor> TblWeatherDynamicFactors { get; set; }

  public virtual DbSet<TblWeatherFactor> TblWeatherFactors { get; set; }

  public virtual DbSet<TblWebBenefit> TblWebBenefits { get; set; }

  public virtual DbSet<TblWebContentsOption> TblWebContentsOptions { get; set; }

  public virtual DbSet<TblWindDirection> TblWindDirections { get; set; }

  public virtual DbSet<TblWorker> TblWorkers { get; set; }

  public virtual DbSet<TblWorkerWorking> TblWorkerWorkings { get; set; }

  public virtual DbSet<TblWorldBoss> TblWorldBosses { get; set; }

  public virtual DbSet<TblWorldMarketCurrentPrice> TblWorldMarketCurrentPrices { get; set; }

  public virtual DbSet<TblWorldMarketNoticeItem> TblWorldMarketNoticeItems { get; set; }

  public virtual DbSet<TblWorldMarketPayloadGameDb> TblWorldMarketPayloadGameDbs { get; set; }

  public virtual DbSet<TblWorldMarketPayloadGameDbOld> TblWorldMarketPayloadGameDbOlds { get; set; }

  public virtual DbSet<TblWorldMarketTicket> TblWorldMarketTickets { get; set; }

  public virtual DbSet<TblWorldQuestLimit> TblWorldQuestLimits { get; set; }

  public virtual DbSet<TblXboxCashInfo> TblXboxCashInfos { get; set; }

  public virtual DbSet<TblXboxCashInfoLog> TblXboxCashInfoLogs { get; set; }

  public virtual DbSet<TexplorationExpTable> TexplorationExpTables { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    optionsBuilder.UseSqlServer(DbConnectionContainer.This.ConnectionStrings.Game);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    modelBuilder.Entity<DimGuildItemKey>(entity => {
      entity.HasKey(e => e.ItemKey).HasName("PK__Dim_Guil__552FC81C9AD6E5B5");

      entity.Property(e => e.ItemKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<DimItemKeyNeedContribute>(entity => {
      entity.HasKey(e => e.ItemKey).HasName("PK__Dim_item__552FC81CFA00E35C");

      entity.Property(e => e.ItemKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<TargetItem>(entity => {
      entity.HasKey(e => e.ItemKey).HasName("PKTargetItem");

      entity.Property(e => e.ItemKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<TargetQuest>(entity => { entity.HasKey(e => new { e.QuestGroupNo, e.QuestNo }).HasName("PKTargetQuest"); });

    modelBuilder.Entity<TblAbsolutePower>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CurseType })
            .HasName("PkTblAbsolutePower")
            .IsClustered(false);

      entity.ToTable("TblAbsolutePower", "PaGamePrivate", tb => tb.HasComment("절대권력"));

      entity.Property(e => e.UserNo).HasComment("저주 걸린 사용자 번호");
      entity.Property(e => e.CurseType).HasComment("저주 타입");
      entity.Property(e => e.ExpirationTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("만기 시간");
    });

    modelBuilder.Entity<TblAbsolutePowerHistory>(entity => {
      entity.ToTable("TblAbsolutePowerHistory", "PaGamePrivate", tb => tb.HasComment("절대권력이력"));

      entity.Property(e => e.Comment).HasComment("저주 건 사유");
      entity.Property(e => e.CurseTime).HasComment("저주 종료 시간");
      entity.Property(e => e.Curses).HasComment("적용된 저주 들");
      entity.Property(e => e.OperatorNo).HasComment("운영자 번호");
      entity.Property(e => e.RegisterTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 시간");
      entity.Property(e => e.TargetUserNo).HasComment("대상 유저");
    });

    modelBuilder.Entity<TblAcoinChargeNumbersByWeb>(entity => {
      entity.Property(e => e.ItemNo).ValueGeneratedNever();
      entity.Property(e => e.RegDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblAddFriendList>(entity => {
      entity.HasKey(e => new { e.UserNo, e.RequestUserNo }).HasName("PkTblAddFriendList");

      entity.ToTable("TblAddFriendList", "PaGamePrivate", tb => tb.HasComment("친구 요청 리스트"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.RequestUserNo).HasComment("친구요청 유저번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblAlchemyRecord>(entity => {
      entity.ToTable("TblAlchemyRecord", "PaGamePrivate", tb => tb.HasComment("연금(요리) 기록 테이블"));

      entity.Property(e => e.ItemCount0).HasComment("아이템의갯수0");
      entity.Property(e => e.ItemCount1).HasComment("아이템의갯수1");
      entity.Property(e => e.ItemCount2).HasComment("아이템의갯수2");
      entity.Property(e => e.ItemCount3).HasComment("아이템의갯수3");
      entity.Property(e => e.ItemCount4).HasComment("아이템의갯수4");
      entity.Property(e => e.ItemCount5).HasComment("아이템의갯수5");
      entity.Property(e => e.ItemCount6).HasComment("아이템의갯수6");
      entity.Property(e => e.ItemCount7).HasComment("아이템의갯수7");
      entity.Property(e => e.ItemKey0).HasComment("아이템키값0");
      entity.Property(e => e.ItemKey1).HasComment("아이템키값1");
      entity.Property(e => e.ItemKey2).HasComment("아이템키값2");
      entity.Property(e => e.ItemKey3).HasComment("아이템키값3");
      entity.Property(e => e.ItemKey4).HasComment("아이템키값4");
      entity.Property(e => e.ItemKey5).HasComment("아이템키값5");
      entity.Property(e => e.ItemKey6).HasComment("아이템키값6");
      entity.Property(e => e.ItemKey7).HasComment("아이템키값7");
      entity.Property(e => e.MentalCardKey).HasComment("지식의키");
      entity.Property(e => e.RegisterDate).HasComment("기록일");
      entity.Property(e => e.ResultItemKey).HasComment("지식을 얻을때 나온 결과 아이템");
      entity.Property(e => e.Type).HasComment("타입(연금,요리)");
      entity.Property(e => e.UserNo).HasComment("유저번호");
    });

    modelBuilder.Entity<TblAreaOfHadum>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblAreaOfHadum");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblAttendPersonalBattle>(entity => {
      entity.HasKey(e => new { e.UserNo, e.BattleNo }).HasName("PkTblAttendPersonalBattle");

      entity.ToTable("TblAttendPersonalBattle", "PaGamePrivate", tb => tb.HasComment("개인 결전 참여 정보"));

      entity.Property(e => e.UserNo).HasComment("유저 번호");
      entity.Property(e => e.BattleNo).HasComment("결전 번호");
      entity.Property(e => e.TeamNo).HasComment("참여 상태");
    });

    modelBuilder.Entity<TblAttendance>(entity => {
      entity.HasKey(e => new { e.UserNo, e.AttendanceKey })
            .HasName("PkTblAttendance")
            .IsClustered(false);

      entity.ToTable("TblAttendance", "PaGamePrivate", tb => tb.HasComment("출석 테이블(매달 초기화됨)"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.AttendanceKey).HasComment("출석키");
      entity.Property(e => e.AttendanceCount).HasComment("출석일수(한달간)");
      entity.Property(e => e.OnAttendanceTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("출석한 시간");
      entity.Property(e => e.OverlapCount).HasComment("중복 출석 횟수");
      entity.Property(e => e.ReceivedReward).HasComment("출석 보상수령");
    });

    modelBuilder.Entity<TblAuctionBidderVer2>(entity => {
      entity.HasKey(e => new { e.UserNo, e.AuctionKey, e.AuctionGoodsNo }).HasName("PkTblAuctionBidderVer2");

      entity.ToTable("TblAuctionBidderVer2", "PaGamePrivate", tb => tb.HasComment("경매 입찰 테이블"));

      entity.Property(e => e.UserNo).HasComment("입찰자 유져 번호(입찰 완료)");
      entity.Property(e => e.AuctionKey).HasComment("경매장 번호");
      entity.Property(e => e.AuctionGoodsNo).HasComment("경매상품 번호");
      entity.Property(e => e.BidPrice).HasComment("입찰가");
      entity.Property(e => e.BidPriceOwnerNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.CharacterNo).HasComment("입찰자 유져 번호(입찰 완료)");
      entity.Property(e => e.DeletedDate).HasComment("삭제일");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.SuccessBidder)
            .HasDefaultValueSql("((-1))")
            .HasComment("낙찰자(-1 입찰중,돈찾아가면 삭제)");
    });

    modelBuilder.Entity<TblAuctionBuyGoodsVer2>(entity => {
      entity.HasKey(e => e.AuctionGoodsNo).HasName("PkTblAuctionBuyGoodsVer2");

      entity.ToTable("TblAuctionBuyGoodsVer2", "PaGamePrivate", tb => tb.HasComment("경매 구매 테이블(삽니다)"));

      entity.Property(e => e.AuctionGoodsNo).HasComment("경매상품 번호");
      entity.Property(e => e.AuctionKey).HasComment("경매장 번호");
      entity.Property(e => e.CharacterNo).HasComment("매입자");
      entity.Property(e => e.CurrentItemCount).HasComment("구매한 아이템 갯수");
      entity.Property(e => e.Deposit).HasComment("보증금");
      entity.Property(e => e.ExpireTime).HasComment("구매 종료 시간");
      entity.Property(e => e.IsAuctionEnd).HasComment("경매종료(경매종료 1)");
      entity.Property(e => e.ItemKey).HasComment("구매할 아이템 키");
      entity.Property(e => e.ItemPrice).HasComment("개당 아이템 갯수");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.TotalItemCount).HasComment("구매할 아이템 갯수");
      entity.Property(e => e.UserNo).HasComment("매입자");
    });

    modelBuilder.Entity<TblAuctionGoodsVer2>(entity => {
      entity.HasKey(e => e.AuctionGoodsNo).HasName("PkTblAuctionGoodsVer2");

      entity.ToTable("TblAuctionGoodsVer2", "PaGamePrivate", tb => tb.HasComment("경매 판매 테이블(팝니다)"));

      entity.Property(e => e.AuctionGoodsNo).HasComment("경매상품 번호");
      entity.Property(e => e.AuctionKey).HasComment("경매장 번호");
      entity.Property(e => e.CharacterNo).HasComment("판매자 캐릭터 번호");
      entity.Property(e => e.ExpireLimitTime).HasComment("경매 종료 최대 시간");
      entity.Property(e => e.ExpireTime).HasComment("경매 종료 시간( 1분 이하 일 때 입찰되면 시간 증가 남은 최대시간을 초과할 수는 없다.)");
      entity.Property(e => e.GoodsCount).HasComment("상품 갯수");
      entity.Property(e => e.GoodsKey).HasComment("상품 키");
      entity.Property(e => e.GoodsType).HasComment("상품 종류");
      entity.Property(e => e.IsAuctionEnd).HasComment("경매종료(경매종료 1)");
      entity.Property(e => e.MaxPrice).HasComment("즉시 구매가");
      entity.Property(e => e.MinPrice).HasComment("최소 입찰가격");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.SuccessBidPrice).HasComment("낙찰가");
      entity.Property(e => e.SuccessBidder)
            .HasDefaultValueSql("((-1))")
            .HasComment("낙찰자 TUserNo (입찰진행중 -1 낙찰자가 찾아가면 0)");
      entity.Property(e => e.TransferNo).HasComment("입찰(구매) 제한");
      entity.Property(e => e.TransferType).HasComment("입찰(구매) 제한");
      entity.Property(e => e.UserNo).HasComment("판매자 유져 번호");
    });

    modelBuilder.Entity<TblAuctionInfo>(entity => {
      entity.HasKey(e => e.AuctionKey).HasName("PkTblAuctionInfo");

      entity.ToTable("TblAuctionInfo", "PaGamePrivate", tb => tb.HasComment("경매장 정보 ( 집 경매 및 용병 경매를 위함 )"));

      entity.Property(e => e.AuctionKey)
            .ValueGeneratedNever()
            .HasComment("경매장 번호");
      entity.Property(e => e.NextStartTime).HasComment("다음 경매 시간");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblAutoChessDeck>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CardKey })
            .HasName("PkTblTblCardBattleInfo")
            .IsClustered(false);

      entity.Property(e => e.CardKey).ValueGeneratedOnAdd();
      entity.Property(e => e.Hp).HasDefaultValueSql("((1))");
      entity.Property(e => e.Level).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblBadPlayerList>(entity => {
      entity.HasKey(e => new { e.CharacterNo, e.BadCharacterNo, e.DeadTime }).HasName("PkBadPlayerList");

      entity.Property(e => e.DeadTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblBarterInfoList>(entity => {
      entity.HasKey(e => new { e.UserNo, e.IsSpecial, e.RegionKey }).HasName("PkTblBarterInfoList");

      entity.Property(e => e.BarterSeed).HasDefaultValueSql("((0))");
    });

    modelBuilder.Entity<TblBarterUserInfo>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblBarterUserInfo");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.LastResetTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UseAddCountItemTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UseItemTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblBattlePass>(entity => { entity.HasKey(e => new { e.UserNo, e.SeasonKey }).HasName("PKTblBattlePass"); });

    modelBuilder.Entity<TblBattleRoyaleItemsInfo>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ItemKey })
            .HasName("PkTblBattleRoyaleItemsInfo")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblBattleRoyalePlayTime>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblBattleRoyalePlayTime");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.LastAccumulateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.LastSoloGameTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.LastTeamGameTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblBattleRoyaleSmuggledItemsInfo>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ItemNo })
            .HasName("PkTblBattleRoyaleSmuggledItemsInfo")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblBattleRoyaleUserInfo>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblBattleRoyaleUserInfo");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.InstanceFieldKey).HasDefaultValueSql("((-1))");
    });

    modelBuilder.Entity<TblBlackMarble>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblBlackMarble");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblBlackSpiritAdventure>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblBlackSpiritAdventure");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.LastPlayDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.Level).HasDefaultValueSql("((1))");
      entity.Property(e => e.MapPiece).HasDefaultValueSql("('')");
      entity.Property(e => e.MoveCountUpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblBlackSpiritAdventureItem>(entity => { entity.HasKey(e => new { e.UserNo, e.WebItemKey }).HasName("PkTblBlackSpiritAdventureItem"); });

    modelBuilder.Entity<TblBlackSpiritAdventureMonster>(entity => {
      entity.HasKey(e => new { e.UserNo, e.MonsterKey, e.SpawnDate, e.Status }).HasName("PkTblBlackSpiritAdventureMonster");

      entity.Property(e => e.SpawnDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblBlackSpiritAdventureQuest>(entity => { entity.HasKey(e => new { e.UserNo, e.QuestNo }).HasName("PkTblBlackSpiritAdventureQuest"); });

    modelBuilder.Entity<TblBlackSpiritAdventureRegion>(entity => { entity.HasKey(e => new { e.UserNo, e.RegionKey, e.MenuType }).HasName("PkTblBlackSpiritAdventureTerritory"); });

    modelBuilder.Entity<TblBlackSpiritForm>(entity => {
      entity.ToTable("TblBlackSpiritForm", "PaGamePrivate", tb => tb.HasComment("흑정령외형변경"));

      entity.Property(e => e.BlackSpiritFormIndex).HasComment("흑정령외형 인덱스");
      entity.Property(e => e.CharacterNo).HasComment("소유 캐릭터");
    });

    modelBuilder.Entity<TblBlockByKeyOrUserNo>(entity => {
      entity.ToTable("TblBlockByKeyOrUserNo", "PaGamePrivate", tb => tb.HasComment("블록 통합 테이블"));

      entity.Property(e => e.BlockNo).ValueGeneratedOnAdd();
      entity.Property(e => e.Param1).HasDefaultValueSql("((0))");
      entity.Property(e => e.Param2).HasDefaultValueSql("((0))");
      entity.Property(e => e.Param3).HasDefaultValueSql("((0))");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.RegisterUserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.Type).HasComment("블록 타입 - BlockedTbl.proc.sql에 기록");
    });

    modelBuilder.Entity<TblBlockItem>(entity => {
      entity.HasKey(e => e.BlockNo)
            .HasName("PKTblBlockItem")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblBlockItemForTrade>(entity => {
      entity.HasKey(e => e.BlockNo)
            .HasName("PKTblBlockItemForTrade")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblBlockQuest>(entity => {
      entity.HasKey(e => e.BlockNo)
            .HasName("PKTblBlockQuest")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblBlockUsingPointByUser>(entity => {
      entity.HasKey(e => e.BlockNo)
            .HasName("PKTblBlockUsingPointByUser")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblBlockedChat>(entity => {
      entity.HasKey(e => e.BlockNo)
            .HasName("PkTblBlockedChat")
            .IsClustered(false);

      entity.ToTable("TblBlockedChat", "PaGamePrivate", tb => tb.HasComment("운영 관련 그룹의 역할 테이블"));

      entity.Property(e => e.BlockNo).HasComment("블록 고유 번호");
      entity.Property(e => e.EndDate).HasComment("블록 종료 시간");
      entity.Property(e => e.ReasonMemo).HasComment("블록 사유");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("블록 등록 시간");
      entity.Property(e => e.UserNo).HasComment("블록 유저 번호");
    });

    modelBuilder.Entity<TblBossSpawn>(entity => {
      entity.HasKey(e => new { e.SummonerNo, e.SpawnKey })
            .HasName("PkTblBossSpawn")
            .IsClustered(false);

      entity.Property(e => e.ResetDateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblBranchQuest>(entity => {
      entity.HasKey(e => new { e.IsUserBaseQuest, e.QuestGroupNo, e.QuestNo })
            .HasName("PkTblBranchQuest")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblBriefUserInformation>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblBriefUserInformation");

      entity.ToTable("TblBriefUserInformation", "PaGamePrivate", tb => tb.HasComment("게임서버를 위한 간단한 유저정보"));

      entity.Property(e => e.UserNo)
            .ValueGeneratedNever()
            .HasComment("게임내 고유 유저번호");
      entity.Property(e => e.AccumulatePcRoomPlayTime).HasComment("PC방 누적 플레이 시간(초)");
      entity.Property(e => e.AccumulatedAdvantageofTrade).HasComment("하룻동안 무역으로번 수익");
      entity.Property(e => e.AccumulatedLoginCount)
            .HasDefaultValueSql("((1))")
            .HasComment("누적 접속 횟수");
      entity.Property(e => e.AdventureEnd)
            .HasDefaultValueSql("((-1))")
            .HasComment("");
      entity.Property(e => e.AdventureExpiration)
            .HasDefaultValueSql("((0))")
            .HasComment("");
      entity.Property(e => e.AdventureNo).HasComment("");
      entity.Property(e => e.AdventureTotalScore).HasComment("");
      entity.Property(e => e.AffiliatedTerritoryKey)
            .HasDefaultValueSql("((-1))")
            .HasComment("소속영지");
      entity.Property(e => e.CashItemSaleCount).HasComment("캐시 아이템 거래소 판매 개수");
      entity.Property(e => e.CashItemSaleCountResetTime)
            .HasDefaultValueSql("((0))")
            .HasComment("캐시 아이템 거래소 판매 개수 초기화 시간");
      entity.Property(e => e.CharacterCreationCount).HasComment("캐릭터를 생성한 횟수");
      entity.Property(e => e.CustomizationPackageBuffExpiration).HasComment("커스터마이징 패키지 버프 만료일시(널이거나 과거면 버프없음)");
      entity.Property(e => e.DdTerritoryKey).HasComment("소속 영지(NULL 이면 소속 없음)");
      entity.Property(e => e.EnterServerNo).HasComment("현재 서버 No");
      entity.Property(e => e.ExpeditionSupplyPoint).HasComment("토벌게임 재화");
      entity.Property(e => e.ExplorationPoint).HasComment("탐험포인트");
      entity.Property(e => e.GuildJoinableTime).HasComment("길드 가입 가능한 날짜.최초 길드 가입할때부터 설정됨,클랜은 해당안됨");
      entity.Property(e => e.IsFirstLogin)
            .HasDefaultValueSql("((1))")
            .HasComment("참이면 최초 접속자");
      entity.Property(e => e.IsGhostMode)
            .HasDefaultValueSql("((0))")
            .IsFixedLength()
            .HasComment("사생활 모드 로그인");
      entity.Property(e => e.IsPcSwitching).HasComment("참이면 PC전환중임");
      entity.Property(e => e.IsPvpAble).HasComment("PVP가능상태");
      entity.Property(e => e.KeepItemKey).HasComment("랜덤 상점 예약 아이템");
      entity.Property(e => e.KeepItemPriceRate).HasComment("랜덤 상점 예약 아이템 가격배율");
      entity.Property(e => e.LastCharacterNo)
            .HasDefaultValueSql("((-1))")
            .HasComment("최근 (플레이)캐릭터 번호");
      entity.Property(e => e.LastFairyRespawnTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("요정 부활(0이면 사용한적 없음)");
      entity.Property(e => e.LastIp)
            .HasDefaultValueSql("(' ')")
            .HasComment("최근 IP");
      entity.Property(e => e.LastLoginTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("최근 로그인시간");
      entity.Property(e => e.LastLogoutTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("최근 로그아웃시간");
      entity.Property(e => e.LastServantBuyTime).HasComment("마지막으로 말 구매한 시간");
      entity.Property(e => e.LastServantMixTime).HasComment("마지막으로 말 교환을 진행한 시간");
      entity.Property(e => e.NewFriend).HasComment("새 친구 여부");
      entity.Property(e => e.NewRequestFriend).HasComment("친구 요청 여부");
      entity.Property(e => e.PcRoomPlayTimePerDay).HasComment("PC방 플레이 시간(초)");
      entity.Property(e => e.PearlPackageBuffRemainMinute).HasComment("펄버프 남은 분=> TOdbcRemainTime 와 연결됨");
      entity.Property(e => e.PlayResetTimePerDay)
            .HasDefaultValueSql("((0))")
            .HasComment("PC방 리셋 시간");
      entity.Property(e => e.PlayTimePerDay).HasComment("플레이 시간 (초)(하루 동안)");
      entity.Property(e => e.PlunderGameVoteCount).HasComment("약탈게임 투표가능 횟수");
      entity.Property(e => e.PreGuildActivity).HasComment("과거 길드 활동 점수");
      entity.Property(e => e.PremiumPackageBuffExpiration).HasComment("프리미엄패키지 버프 만료일시(널이거나 과거면 버프없음)");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("간단 유저정보 최초 등록일시");
      entity.Property(e => e.RemainKeepTime)
            .HasDefaultValueSql("((0))")
            .HasComment("랜덤 상점 예약 아이템 남은 분");
      entity.Property(e => e.StarterPackageBuffExpiration).HasComment("스타터 패키지 버프 만료일시(널이거나 과거면 버프없음)");
      entity.Property(e => e.TotalPlayTime).HasComment("총 플레이 시간");
      entity.Property(e => e.TradeSupplyCount).HasComment("요리/연금 판매 가능 갯수");
      entity.Property(e => e.UserBasicCacheSeqNo).HasComment("유저정보 갱신번호");
      entity.Property(e => e.UserId).HasComment("퍼블리셔에서 넘어온 유저번호");
      entity.Property(e => e.UserNickname).HasComment("유저별명");
      entity.Property(e => e.VariedCharacterSlotCount).HasComment("증가된 캐릭터 슬롯 갯수");
    });

    modelBuilder.Entity<TblBuff>(entity => {
      entity.ToTable("TblBuff", "PaGamePrivate", tb => tb.HasComment("버프를 저장하기 위한 테이블"));

      entity.Property(e => e.BuffKey).HasComment("서버에서 사용하는 버프키");
      entity.Property(e => e.CharacterNo).HasComment("버프가 적용되는 캐릭터의 번호");
      entity.Property(e => e.LeftApplyingCount).HasComment("버프의 남은 적용 횟수");
      entity.Property(e => e.RemainTime).HasComment("버프의 남은 시간");
    });

    modelBuilder.Entity<TblBuffCount>(entity => { entity.HasKey(e => new { e.UserNo, e.Type }).HasName("PkTblBuffCount"); });

    modelBuilder.Entity<TblBuffExpirationDate>(entity => {
      entity.ToTable("TblBuffExpirationDate", "PaGamePrivate", tb => tb.HasComment("버프의 유효시간"));

      entity.Property(e => e.ExpirationDate).HasComment("버프 만료일시(절대시간임) => NULL 이거나 과거면 버프 없음.");
      entity.Property(e => e.Level).HasComment("버프 레벨.");
      entity.Property(e => e.Type).HasComment("버프 종류 => enum값과 연결됨");
      entity.Property(e => e.UserNo).HasComment("게임내 고유 유저번호");
    });

    modelBuilder.Entity<TblBusinessInstallation>(entity => {
      entity.HasKey(e => e.InstallationNo)
            .HasName("PkTblBusinessInstallation")
            .IsClustered(false);

      entity.ToTable("TblBusinessInstallation", "PaGamePrivate", tb => tb.HasComment("하우징 설치오브젝트 사업정보"));

      entity.Property(e => e.InstallationNo)
            .ValueGeneratedNever()
            .HasComment("설치 오브젝트 번호");
      entity.Property(e => e.BusinessType).HasComment("0자동판매1위탁판매");
      entity.Property(e => e.CommissionRate).HasComment("판매수수료");
      entity.Property(e => e.HoldingMoney).HasComment("보유금액");
      entity.Property(e => e.HouseholdNo).HasComment("집 번호");
      entity.Property(e => e.IsActive).HasComment("액티브여부");
      entity.Property(e => e.MinRegisterMoney).HasComment("최소등록비");
      entity.Property(e => e.SaleTime).HasComment("판매기간");
    });

    modelBuilder.Entity<TblCacheSeq>(entity => {
      entity.HasKey(e => new { e.Key, e.CacheType }).HasName("PkTblCacheSeq");

      entity.ToTable("TblCacheSeq", "PaGamePrivate", tb => tb.HasComment("캐싱관련 변경회수"));

      entity.Property(e => e.Key).HasComment("_cacheType 에 따라서 의미가 다름");
      entity.Property(e => e.CacheType).HasComment("OdbcCacheType 참고");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.SeqNo).HasComment("CacheSeq 참고");
    });

    modelBuilder.Entity<TblCandidateList>(entity => {
      entity.ToTable("TblCandidateList", "PaGamePrivate", tb => tb.HasComment("후보자 리스트 테이블"));

      entity.Property(e => e.CharacterNo).HasComment("후보자 캐릭터번호");
      entity.Property(e => e.ClassType).HasComment("클래스 타입");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.UserNo).HasComment("후보자 유저번호");
      entity.Property(e => e.VoteCount).HasComment("투표 수");
    });

    modelBuilder.Entity<TblCaphrasBonusSlot>(entity => { entity.HasKey(e => new { e.UserNo, e.EquipSlotNo }).HasName("PkTblCaphrasBonusSlot"); });

    modelBuilder.Entity<TblCashItemBuyCount>(entity => {
      entity.HasKey(e => new { e.IsUserNo, e.UserCharacterNo, e.CashProductNo, e.Type })
            .HasName("PkTblCashItemBuyCount")
            .IsClustered(false);

      entity.ToTable("TblCashItemBuyCount", "PaGamePrivate", tb => tb.HasComment("아이템 구매 갯수 저장"));

      entity.Property(e => e.IsUserNo).HasComment("유저번호인가?");
      entity.Property(e => e.UserCharacterNo).HasComment("유저번호&캐릭터번호(_isUserNo가 참이면 유저번호임)");
      entity.Property(e => e.CashProductNo).HasComment("캐시상품키");
      entity.Property(e => e.Count).HasComment("구매량");
    });

    modelBuilder.Entity<TblCashItemBuyCountBak>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblChallengeReward>(entity => {
      entity.ToTable("TblChallengeReward", "PaGamePrivate", tb => tb.HasComment("도전과제 및 pc방 정액제"));

      entity.Property(e => e.ChallengeKey).HasComment("도전과제 키 -DataSheet_Challenge$Challenge_Table");
      entity.Property(e => e.Count).HasComment("횟수");
      entity.Property(e => e.IsOverlapable).HasComment("보상을 중복해서 줄수 있는가 여부");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UserNo).HasComment("유저번호");
    });

    modelBuilder.Entity<TblChangeContentsOptionUser>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblChangeConOptionUser");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblCharacterCustomizing>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("PkTblCharacterCustomizing");

      entity.ToTable("TblCharacterCustomizing", "PaGamePrivate", tb => tb.HasComment("캐릭터 커스터마이징"));

      entity.Property(e => e.CharacterNo)
            .ValueGeneratedNever()
            .HasComment("캐릭터 번호");
      entity.Property(e => e.Author).HasComment("원저작자");
      entity.Property(e => e.AuthorUserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.Bone).HasComment("뼈대");
      entity.Property(e => e.Decoration).HasComment("장식");
      entity.Property(e => e.Expression)
            .HasDefaultValueSql("(0x0064)")
            .HasComment("표정");
      entity.Property(e => e.HairMesh).HasComment("헤어 스타일");
      entity.Property(e => e.HeadMesh).HasComment("두상 모양");
      entity.Property(e => e.IsEditable).HasDefaultValueSql("((1))");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.Version)
            .HasDefaultValueSql("((20))")
            .HasComment("캐릭터 커스터마이징 버전");
      entity.Property(e => e.VoiceType).HasDefaultValueSql("((1))");
      entity.Property(e => e.ZodiacSignKey)
            .HasDefaultValueSql("((1))")
            .HasComment("별자리 키");
    });

    modelBuilder.Entity<TblCharacterDetailInformation>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("PKTblCharacterDetailInformation");

      entity.Property(e => e.CharacterNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblCharacterExpLoan>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CharacterNo }).HasName("PkTblCharacterExpLoan");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblCharacterExpLoanLog>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblCharacterInformation>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("PkTblCharacterInformation");

      entity.ToTable("TblCharacterInformation", "PaGamePrivate", tb => tb.HasComment("유저캐릭기본정보"));

      entity.Property(e => e.CharacterNo).HasComment("캐릭터번호");
      entity.Property(e => e.AquiredProductSkillPoint).HasComment("총 획득한 스킬포인트");
      entity.Property(e => e.AquiredSkillPoint).HasComment("총 획득한 스킬포인트");
      entity.Property(e => e.ArrivalRegionKey).HasComment("이동될 지역 번호");
      entity.Property(e => e.ArrivalTime).HasComment("도착 시간");
      entity.Property(e => e.AwakenValue).HasComment("캐릭터 각성공격력");
      entity.Property(e => e.CharacterName).HasComment("캐릭터명");
      entity.Property(e => e.ClassType).HasComment("클래스타입 0 워리어 4 엘프레인저 8 위저드 12 자이언트");
      entity.Property(e => e.CreationIndex).HasComment("계정내의 캐릭터 생성순서");
      entity.Property(e => e.CurrentFieldIndex).HasComment("TFieldIndex");
      entity.Property(e => e.CurrentFieldNo).HasComment("TFieldNo");
      entity.Property(e => e.CurrentPositionX).HasComment("_currentPositionX");
      entity.Property(e => e.CurrentPositionY).HasComment("_currentPositionY");
      entity.Property(e => e.CurrentPositionZ).HasComment("_currentPositionZ");
      entity.Property(e => e.DefenceValue).HasComment("캐릭터 방어력");
      entity.Property(e => e.DeletedDate).HasComment("삭제될 날짜(NULL이면 삭제시도없는것)");
      entity.Property(e => e.DuelCharacterNo)
            .HasDefaultValueSql("((-1))")
            .HasComment("듀얼캐릭터");
      entity.Property(e => e.EnchantFailCount).HasComment("인챈트실패횟수");
      entity.Property(e => e.EnchantFailCountExp).HasComment("강화 스택 경험치");
      entity.Property(e => e.EnchantPcRoomCount).HasComment("PC방 인챈트 카운트");
      entity.Property(e => e.EnchantProtectBrokenCount).HasComment("강화실패시 장비 파괴 보호");
      entity.Property(e => e.Experience).HasComment("레벨경험치");
      entity.Property(e => e.Hp)
            .HasDefaultValueSql("((1))")
            .HasComment("현재hp");
      entity.Property(e => e.InventorySlotCount).HasComment("추가 인벤 슬롯 숫자");
      entity.Property(e => e.IsOnTypeServant).HasComment("내가 올라가 있는 탈것의 타입");
      entity.Property(e => e.IsRideTypeServant).HasComment("내가 탑승(인터렉션을 통한) 중인 탈것의 타입");
      entity.Property(e => e.IsSpecialCharacter).HasComment("특별 케릭터인가");
      entity.Property(e => e.IsValid)
            .HasDefaultValueSql("((1))")
            .HasComment("참인 경우에만 선택할 수 있는 캐릭임");
      entity.Property(e => e.KillRewardCount).HasComment("킬 보상(블랙스톤)");
      entity.Property(e => e.LastLoginTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("최근로그인시간");
      entity.Property(e => e.LastLogoutTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("최근로그아웃시간");
      entity.Property(e => e.Level)
            .HasDefaultValueSql("((1))")
            .HasComment("레벨");
      entity.Property(e => e.Mp).HasComment("현재mp");
      entity.Property(e => e.NewFriend).HasComment("내가 친구를 요청한 것중 상대가 수락한게 개수");
      entity.Property(e => e.NewMail).HasComment("내게 도착한 새로운 멜 개수");
      entity.Property(e => e.NewRequestFriend).HasComment("나에게 친구를 요청한 개수");
      entity.Property(e => e.OffenceValue).HasComment("캐릭터 공격력");
      entity.Property(e => e.OnVariousNo).HasComment("내가 올라가 있는 탈것의 고유 번호");
      entity.Property(e => e.PcBasicCacheSeqNo).HasComment("캐릭터 정보 갱신번호");
      entity.Property(e => e.ProductSkillPointExperience).HasComment("스킬포인트경험치");
      entity.Property(e => e.QuestLevelLog).HasComment("퀘스트 보상레벨에 따라 보상을 받아간 마지막 로그");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("캐릭터 생성일");
      entity.Property(e => e.RemainedProductSkillPoint).HasComment("남은 스킬포인트");
      entity.Property(e => e.RemainedSkillPoint).HasComment("남은 스킬포인트");
      entity.Property(e => e.ReservedLearningSkillKey).HasComment("배우려는 예약 스킬의 키값");
      entity.Property(e => e.ReturnFieldIndex).HasComment("TFieldIndex");
      entity.Property(e => e.ReturnFieldNo).HasComment("TFieldNo");
      entity.Property(e => e.ReturnPositionX).HasComment("_returnPositionX");
      entity.Property(e => e.ReturnPositionY).HasComment("_returnPositionY");
      entity.Property(e => e.ReturnPositionZ).HasComment("_returnPositionZ");
      entity.Property(e => e.RewardPoint).HasComment("퀘스트 보상 통합 포인트");
      entity.Property(e => e.RideSeatIndex).HasComment("내가 탑승(인터렉션을 통한) 중인 탈것의 시트 번호");
      entity.Property(e => e.RideVariousNo).HasComment("내가 탑승(인터렉션을 통한) 중인 탈것의 고유 번호");
      entity.Property(e => e.SkillAwakeningCount).HasComment("일반 스킬 각성한 횟수");
      entity.Property(e => e.SkillPointExperience).HasComment("스킬포인트경험치");
      entity.Property(e => e.SkillPointLevel).HasComment("스킬포인트레벨");
      entity.Property(e => e.SlotNo).HasComment("생성된 슬롯번호");
      entity.Property(e => e.Sp).HasComment("현재sp");
      entity.Property(e => e.SuccessionSkillAwakeningCount).HasComment("전승 스킬 각성한 횟수");
      entity.Property(e => e.Tendency).HasComment("성향");
      entity.Property(e => e.TitleKey).HasComment("적용한 칭호키(0은 칭호 없음)");
      entity.Property(e => e.TotalPlayTime).HasComment("총 play시간(단위:분)");
      entity.Property(e => e.UserNo).HasComment("캐릭을 소유한 사용자번호");
      entity.Property(e => e.VariedDirectDv).HasComment("증감되는 근거리Dv");
      entity.Property(e => e.VariedDirectHit).HasComment("증감되는 근거리Hit");
      entity.Property(e => e.VariedDirectPv).HasComment("증감되는 근거리Pv");
      entity.Property(e => e.VariedMagicalDv).HasComment("증감되는 MagicalHit");
      entity.Property(e => e.VariedMagicalHit).HasComment("증감되는 MagicalHit");
      entity.Property(e => e.VariedMagicalPv).HasComment("증감되는 MagicalHit");
      entity.Property(e => e.VariedMaxHp).HasComment("증감되는 hp통");
      entity.Property(e => e.VariedMaxMp).HasComment("증감되는 mp통");
      entity.Property(e => e.VariedRangeDv).HasComment("증감되는 원거리Dv");
      entity.Property(e => e.VariedRangeHit).HasComment("증감되는 원거리Hit");
      entity.Property(e => e.VariedRangePv).HasComment("증감되는 원거리Pv");
      entity.Property(e => e.VariedWeight).HasComment("영구적으로 늘어난 무게");
      entity.Property(e => e.WeaponSkillAwakeningCount).HasComment("각성무기 스킬 각성한 횟수");
      entity.Property(e => e.Wp).HasComment("현재wp");
    });

    modelBuilder.Entity<TblCharacterMemo>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("PkTblCharacterMemo");

      entity.ToTable("TblCharacterMemo", "PaGamePrivate", tb => tb.HasComment("유저캐릭 메모"));

      entity.Property(e => e.CharacterNo)
            .ValueGeneratedNever()
            .HasComment("캐릭터 번호");
      entity.Property(e => e.CurrentFindExchangeItemEnchantKey).HasComment("아이템 교환 길찾기 중이던 ItemEnchantKey");
      entity.Property(e => e.CurrentQuestGroupNo).HasComment("현재 수행중이던 퀘스트 그룹번호");
      entity.Property(e => e.CurrentQuestNo).HasComment("현재 수행중이던 퀘스트 번호");
      entity.Property(e => e.CurrentQuestPositionX).HasComment("현재 수행중이던 퀘스트 좌표");
      entity.Property(e => e.CurrentQuestPositionY).HasComment("현재 수행중이던 퀘스트 좌표");
      entity.Property(e => e.CurrentQuestPositionZ).HasComment("현재 수행중이던 퀘스트 좌표");
      entity.Property(e => e.LastQuestGroupNo0).HasComment("마지막 수행중이던 퀘스트 그룹번호");
      entity.Property(e => e.LastQuestGroupNo1).HasComment("마지막-1 수행중이던 퀘스트 그룹번호");
      entity.Property(e => e.LastQuestNo0).HasComment("마지막 수행중이던 퀘스트 번호");
      entity.Property(e => e.LastQuestNo1).HasComment("마지막-1 수행중이던 퀘스트 번호");
      entity.Property(e => e.Memo).HasComment("OdbcUserMemo와 연결됨");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.UserTargetPositionX).HasComment("현재 유저가 설정한 목표 좌표");
      entity.Property(e => e.UserTargetPositionY).HasComment("현재 유저가 설정한 목표 좌표");
      entity.Property(e => e.UserTargetPositionZ).HasComment("현재 유저가 설정한 목표 좌표");
    });

    modelBuilder.Entity<TblCharacterNameModStr>(entity => { entity.Property(e => e.Str).IsFixedLength(); });

    modelBuilder.Entity<TblCharacterSpecialInformation>(entity => { entity.HasKey(e => new { e.UserNo, e.CharacterNo }).HasName("PkTblCharacterSpecialInformation"); });

    modelBuilder.Entity<TblCharacterUicustomizing>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("PkTblCharacterUICustomizing");

      entity.ToTable("TblCharacterUICustomizing", "PaGamePrivate", tb => tb.HasComment("유저 캐릭을 위한 UI Customizing정보"));

      entity.Property(e => e.CharacterNo)
            .ValueGeneratedNever()
            .HasComment("캐릭터번호");
      entity.Property(e => e.QuestSelectType)
            .HasDefaultValueSql("('')")
            .HasComment("퀘스트 선택 타입");
      entity.Property(e => e.QuestSerializedData)
            .HasDefaultValueSql("('')")
            .HasComment("퀘스트 데이터");
      entity.Property(e => e.QuestSortType)
            .HasDefaultValueSql("('')")
            .HasComment("퀘스트 정렬 타입");
      entity.Property(e => e.QuickSlotSerializedData)
            .HasDefaultValueSql("('')")
            .HasComment("퀵슬롯 데이터");
    });

    modelBuilder.Entity<TblChatBlockByUser>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblChatBlockByUser");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblChatBlockListByUser>(entity => {
      entity.HasKey(e => new { e.FromUserNo, e.ToUserNo })
            .HasName("PkTblChatBlockListByUser")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblCheckItemForRemoveCharacter>(entity => {
      entity.HasKey(e => e.ItemKey)
            .HasName("PkTblCheckItemForRemoveCharacter")
            .IsClustered(false);

      entity.Property(e => e.ItemKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblClearedBattlePass>(entity => { entity.HasKey(e => new { e.UserNo, e.Key }).HasName("PKTblClearedBattlePass"); });

    modelBuilder.Entity<TblClearedNewQuest>(entity => {
      entity.HasKey(e => new { e.UserCharacterNo, e.IsUserBaseQuest, e.QuestGroupNo, e.QuestNo })
            .HasName("PkTblClearedNewQuest")
            .IsClustered(false);

      entity.ToTable("TblClearedNewQuest", "PaGamePrivate", tb => tb.HasComment("퀘스트 완료 목록"));

      entity.Property(e => e.UserCharacterNo).HasComment("유저캐릭터번호");
      entity.Property(e => e.IsUserBaseQuest).HasComment("1이면 유저 0이면 캐릭터 기반");
      entity.Property(e => e.QuestGroupNo).HasComment("_questGroupNo");
      entity.Property(e => e.QuestNo).HasComment("퀘스트번호");
      entity.Property(e => e.ClearedTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("쾌스트 완료 시간");
      entity.Property(e => e.ResetTime).HasComment("반복 퀘스트일 경우 초기화될 시간");
    });

    modelBuilder.Entity<TblCommonBoardReport>(entity => {
      entity.HasKey(e => new { e.BoardType, e.BoardNo, e.UserNo }).HasName("PKTblCommonBoardReport");

      entity.Property(e => e.RegDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ReportType).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblCommonContentsScoreRecord>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CharacterNo, e.ContentsType, e.Mode, e.Stage })
            .HasName("PkTblCommonContentsScoreRecord")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblCommonSkillNo>(entity => {
      entity.HasKey(e => new { e.UserNo, e.Idx })
            .HasName("PKTblCommonSkillNo")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblCompletedChallenge>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ChallengeKey })
            .HasName("PkTblCompletedChallenge")
            .IsClustered(false);

      entity.ToTable("TblCompletedChallenge", "PaGamePrivate", tb => tb.HasComment("완료-도전과제 및 pc방 정액제"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.ChallengeKey).HasComment("도전과제 키 -DataSheet_Challenge$Challenge_Table");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ResetTime).HasComment("초기화 시간");
    });

    modelBuilder.Entity<TblCompletedGuildBattle>(entity => {
      entity.HasKey(e => e.BattleNo).HasName("PkTblCompletedGuildBattle");

      entity.ToTable("TblCompletedGuildBattle", "PaGamePrivate", tb => tb.HasComment("결전 종료 정보"));

      entity.Property(e => e.BattleNo).HasComment("결전 고유 번호");
      entity.Property(e => e.EndDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("종료 시간");
      entity.Property(e => e.LoseGuildNo).HasComment("패배 길드 번호");
      entity.Property(e => e.Season).HasComment("시즌");
      entity.Property(e => e.State).HasComment("해당 결전 상금");
      entity.Property(e => e.WinGuildNo).HasComment("이긴 길드 번호");
    });

    modelBuilder.Entity<TblCompletedGuildDuel>(entity => {
      entity.HasKey(e => e.DuelNo).HasName("PkTblCompletedGuildDuel");

      entity.ToTable("TblCompletedGuildDuel", "PaGamePrivate", tb => tb.HasComment("길드 결전 정보"));

      entity.Property(e => e.DuelNo)
            .ValueGeneratedNever()
            .HasComment("길드 결전 번호");
      entity.Property(e => e.AcceptGuildKill).HasComment("수락한 길드가 죽인 횟수");
      entity.Property(e => e.AcceptGuildNo).HasComment("결전 수락한 길드 번호");
      entity.Property(e => e.Deadline)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("마감 시간");
      entity.Property(e => e.DeclareGuildKill).HasComment("선포한 길드가 죽인 횟수");
      entity.Property(e => e.DeclareGuildNo).HasComment("결전 선포한 길드 번호");
      entity.Property(e => e.EndDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("종료 시간");
      entity.Property(e => e.Prize).HasComment("상금");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.TargetKill).HasComment("목표 킬수");
    });

    modelBuilder.Entity<TblCompletedPersonalBattle>(entity => {
      entity.HasKey(e => e.BattleNo).HasName("PkTblCompletedPersonalBattle");

      entity.ToTable("TblCompletedPersonalBattle", "PaGamePrivate", tb => tb.HasComment("결전 종료 정보"));

      entity.Property(e => e.BattleNo).HasComment("결전 고유 번호");
      entity.Property(e => e.EndDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("종료 시간");
      entity.Property(e => e.LoseTeamNo).HasComment("패배 팀 번호");
      entity.Property(e => e.Season).HasComment("시즌");
      entity.Property(e => e.State).HasComment("결전 결과");
      entity.Property(e => e.WinTeamNo).HasComment("이긴 팀 번호");
    });

    modelBuilder.Entity<TblCompositionNote>(entity => {
      entity.HasKey(e => e.NoteNo)
            .HasName("PKTblCompositionNotes")
            .IsClustered(false);

      entity.Property(e => e.IsEdit).HasDefaultValueSql("((1))");
      entity.Property(e => e.RegDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UpdDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblCompositionNotesReply>(entity => {
      entity.HasKey(e => e.ReplyNo)
            .HasName("PKTblCompositionNotesReply")
            .IsClustered(false);

      entity.Property(e => e.RegDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UpdDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblConsignmentSale>(entity => {
      entity.HasKey(e => e.ConsignmentNo).HasName("PkTblConsignmentSale");

      entity.ToTable("TblConsignmentSale", "PaGamePrivate", tb => tb.HasComment("위탁 판매 정보"));

      entity.Property(e => e.ConsignmentNo).HasComment("_consignmentNo");
      entity.Property(e => e.CommissionRate).HasComment("수수료(등록시 저장)");
      entity.Property(e => e.ExpireTime).HasComment("판매 종료일");
      entity.Property(e => e.GatherMoney).HasComment("판매후 모아진 돈(수수료 뺀 금액)");
      entity.Property(e => e.HouseholdNo).HasComment("_householdNo");
      entity.Property(e => e.InstallationNo).HasComment("_installationNo");
      entity.Property(e => e.IsStackable).HasComment("_isStackable");
      entity.Property(e => e.ItemKey).HasComment("_itemKey");
      entity.Property(e => e.ItemNo).HasComment("_itemNo");
      entity.Property(e => e.OwnerCharacterNo).HasComment("_ownerCharacterNo");
      entity.Property(e => e.PricePerOne).HasComment("개당 가격");
      entity.Property(e => e.RegisterMoney).HasComment("등록비");
      entity.Property(e => e.SaleEnd).HasComment("아이템이 모두팔리면 1");
    });

    modelBuilder.Entity<TblContentsSeason>(entity => {
      entity.HasKey(e => new { e.ContentsType, e.Season }).HasName("PkTblContentsSeason");

      entity.Property(e => e.Season).HasDefaultValueSql("((1))");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblCoolTime>(entity => {
      entity.ToTable("TblCoolTime", "PaGamePrivate", tb => tb.HasComment("쿨타임을 저장하기 위한 테이블"));

      entity.Property(e => e.OwnerNo).HasComment("skillType 에 따라 캐릭터No, 길드 No로 사용된다.");
      entity.Property(e => e.ReuseGroup).HasComment("재사용그룹의 넘버");
      entity.Property(e => e.SkillLevel).HasComment("재사용 대기중인 스킬의 레벨");
      entity.Property(e => e.SkillNo).HasComment("재사용 대기중인 스킬의 넘버");
      entity.Property(e => e.SkillType).HasComment(" pc 스킬의 쿨타임인지 길드 스킬의 쿨타임인지 구분하는 타입 ( 0 = PC, 1= guild)");
    });

    modelBuilder.Entity<TblCopyUserDate>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblCoupon>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CouponNo })
            .HasName("PkTblCoupon")
            .IsClustered(false);

      entity.ToTable("TblCoupon", "PaGamePrivate", tb => tb.HasComment("쿠폰 테이블"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.CouponNo)
            .ValueGeneratedOnAdd()
            .HasComment("쿠폰번호");
      entity.Property(e => e.CouponKey).HasComment("쿠폰키");
      entity.Property(e => e.ExpirationDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("쿠폰 만료 일시");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
      entity.Property(e => e.State).HasComment("쿠폰 상태");
      entity.Property(e => e.UseDate).HasComment("쿠폰 사용 일시");
    });

    modelBuilder.Entity<TblCrew>(entity => {
      entity.HasKey(e => e.CrewNo).HasName("PkTblCrew");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblCrewMember>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblCrewMember")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblCustomBarteringInfo>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PK__TblCusto__D84CDD5FD88D3D1A");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblCustomGuildWarHistory>(entity => {
      entity.HasKey(e => e.Id).HasName("PK__TblCusto__DED88B1C96E9D20A");

      entity.Property(e => e.Death).HasComment("사망수");
      entity.Property(e => e.GuildNo).HasComment("길드 번호");
      entity.Property(e => e.Kill).HasComment("킬수");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("전쟁 시작 시간");
      entity.Property(e => e.TargetGuildNo).HasComment("전쟁 선포한 길드 번호");
    });

    modelBuilder.Entity<TblCustomName>(entity => {
      entity.HasKey(e => new { e.Type, e.Param }).HasName("PkTblCustomName");

      entity.ToTable("TblCustomName", "PaGamePrivate", tb => tb.HasComment("커스터마이징 된 이름 TABLE"));

      entity.Property(e => e.Type).HasComment("타입");
      entity.Property(e => e.Param).HasComment("파라메터");
      entity.Property(e => e.Name).HasComment("유저가 작성한 이름");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("생성/변경일");
    });

    modelBuilder.Entity<TblCustomizedKey>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("PkTblCustomizedKey");

      entity.ToTable("TblCustomizedKey", "PaGamePrivate", tb => tb.HasComment("유저 캐릭을 위한 key 설정 정보"));

      entity.Property(e => e.CharacterNo)
            .ValueGeneratedNever()
            .HasComment("캐릭터번호");
      entity.Property(e => e.KeyActionInputSerializedData)
            .HasDefaultValueSql("('')")
            .HasComment("키보드 ActionInputType 설정 데이터");
      entity.Property(e => e.KeyUiInputSerializedData)
            .HasDefaultValueSql("('')")
            .HasComment("키보드 UiInputType 설정 데이터");
      entity.Property(e => e.PadActionInputSerializedData)
            .HasDefaultValueSql("('')")
            .HasComment("패드 ActionInputType 설정 데이터");
      entity.Property(e => e.PadFunctionInput1).HasComment("패드 기능키 1");
      entity.Property(e => e.PadFunctionInput2).HasComment("패드 기능키 2");
      entity.Property(e => e.PadUiInputSerializedData)
            .HasDefaultValueSql("('')")
            .HasComment("패드 UiInputType 설정 데이터");
    });

    modelBuilder.Entity<TblCustomizingDownloadLog>(entity => { entity.Property(e => e.DownloadDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblCustomizingGallery>(entity => {
      entity.HasKey(e => e.CustomizingNo).HasName("PkTblCustomizingGallery");

      entity.Property(e => e.CharacterName).HasDefaultValueSql("('')");
      entity.Property(e => e.CharacterNo).HasDefaultValueSql("((0))");
      entity.Property(e => e.IsEdit).HasDefaultValueSql("((1))");
      entity.Property(e => e.Regdate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblCustomizingGalleryAuthRankTemp>(entity => { entity.Property(e => e.CustomizingNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblCustomizingGalleryBlind>(entity => { entity.Property(e => e.BlindDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblCustomizingGalleryComment>(entity => {
      entity.HasKey(e => e.CustomizingCommentNo).HasName("PkTblCustomizingGalleryComment");

      entity.Property(e => e.CharacterName).HasDefaultValueSql("('')");
      entity.Property(e => e.CharacterNo).HasDefaultValueSql("((0))");
      entity.Property(e => e.CommentRegdate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.CommentUpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblCustomizingLikeLog>(entity => { entity.Property(e => e.LikeDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblCustomizingReportLog>(entity => { entity.Property(e => e.ReportDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblDailyBattlePassPoint>(entity => {
      entity.HasKey(e => new { e.UserNo, e.Type }).HasName("PKTblDailyBattlePassPoint");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblDailyPlayInfo>(entity => {
      entity.HasKey(e => new { e.UserNo, e.InstanceFieldKey }).HasName("PKTblDailyPlayInfo");

      entity.Property(e => e.NextResetTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblDeletedItemRepository>(entity => {
      entity.HasKey(e => e.ItemNo)
            .HasName("PkTblDeletedItemRepository")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblDeletedNameExchange>(entity => {
      entity.Property(e => e.DeletedDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.No).ValueGeneratedOnAdd();
    });

    modelBuilder.Entity<TblDeletedPet>(entity => { entity.Property(e => e.DeletedDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblDeliveryRepository>(entity => {
      entity.HasKey(e => e.ItemNo).HasName("PkTblDeliveryRepository");

      entity.ToTable("TblDeliveryRepository", "PaGamePrivate", tb => tb.HasComment("아이템 운송 정보"));

      entity.Property(e => e.ItemNo)
            .ValueGeneratedNever()
            .HasComment("아이템 번호");
      entity.Property(e => e.DelivererNo).HasComment("운송하는 객체 번호");
      entity.Property(e => e.DelivererType).HasComment("운송하는 객체 타입");
      entity.Property(e => e.DeliveryRoute).HasComment("운송 노선 번호");
      entity.Property(e => e.From).HasComment("출발 지역 번호");
      entity.Property(e => e.Progress).HasComment("운송 상태");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 시간");
      entity.Property(e => e.To).HasComment("도착 지역 번호");
      entity.Property(e => e.UserNo).HasComment("유저 고유 번호");
    });

    modelBuilder.Entity<TblDuelCharacterInfo>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CharacterNo, e.DuelCharacterNo })
            .HasName("PkTblDuelCharacterInfo")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblEmoticon>(entity => {
      entity.HasKey(e => new { e.OwnerUserNo, e.EmoticonPackageKey }).HasName("RkTblEmoticon");

      entity.ToTable("TblEmoticon", "PaGamePrivate", tb => tb.HasComment("이모티콘"));

      entity.Property(e => e.OwnerUserNo).HasComment("소유자번호");
      entity.Property(e => e.EmoticonPackageKey).HasComment("이모티콘패키지 키 ");
      entity.Property(e => e.EmoticonType).HasComment("이모티콘 상품 타입");
      entity.Property(e => e.PackageExpirationDate)
            .HasDefaultValueSql("((0))")
            .HasComment("기간제 이모티콘 유통기한");
    });

    modelBuilder.Entity<TblEmployeeRepository>(entity => {
      entity.HasKey(e => new { e.UserNo, e.EmployeeNo })
            .HasName("PkTblEmployeeRepository")
            .IsClustered(false);

      entity.Property(e => e.EmployeeNo).ValueGeneratedOnAdd();
    });

    modelBuilder.Entity<TblEmployeeSpawnInformation>(entity => {
      entity.HasKey(e => new { e.UserNo, e.PositionIndex })
            .HasName("PkTblEmployeeSpawnInformation")
            .IsClustered(false);

      entity.Property(e => e.NextSpawnTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.SpawnTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblEncyclopedium>(entity => {
      entity.HasKey(e => new { e.UserNo, e.Key }).HasName("PkTblEncyclopedia");

      entity.ToTable("TblEncyclopedia", "PaGamePrivate", tb => tb.HasComment("백과사전(어류도감)"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.Key).HasComment("어종키 (DataSheet_Encyclopedia$Encyclopedia_Table)");
      entity.Property(e => e.Count).HasComment("잡은 수량");
      entity.Property(e => e.Value).HasComment("최대크기");
    });

    modelBuilder.Entity<TblEventBuff>(entity => {
      entity.HasKey(e => new { e.ServerNo, e.BuffType }).HasName("PkTblEventBuff");

      entity.ToTable("TblEventBuff", "PaGamePrivate", tb => tb.HasComment("이벤트 버프를 저장하기 위한 테이블"));

      entity.Property(e => e.ServerNo).HasComment("서버 번호");
      entity.Property(e => e.BuffType).HasComment("버프 타입");
      entity.Property(e => e.BuffPercent).HasComment("버프의 퍼센트");
      entity.Property(e => e.ExpirationDate).HasComment("버프의 남은 시간");
      entity.Property(e => e.Param1).HasComment("범용 변수1");
      entity.Property(e => e.Param2).HasComment("범용 변수2");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblEventMarbleGame>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblEventMarbleGame");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblEventMarbleGameDiceItem>(entity => {
      entity.HasKey(e => new { e.UserNo, e.DiceItemKey }).HasName("PkTblEventMarbleGameDiceItem");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblEventMarbleGameMap>(entity => {
      entity.HasKey(e => new { e.UserNo, e.MarbleKey }).HasName("PkTblEventMarbleGameMap");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblExcaliburUserInfo>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblExcaliburUserInfo");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ResetTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblExpeditionResultItem>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ItemEnchantKey }).HasName("PkTblExpeditionResultItem");

      entity.ToTable("TblExpeditionResultItem", "PaGamePrivate", tb => tb.HasComment("토벌결과아이템"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.ItemEnchantKey).HasComment("아이템키");
      entity.Property(e => e.ItemCount).HasComment("아이템 갯수");
      entity.Property(e => e.RegisterDateDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록된 시간");
    });

    modelBuilder.Entity<TblExpeditionaryUnit>(entity => {
      entity.HasKey(e => e.UnitNo).HasName("PkTblExpeditionaryUnits");

      entity.ToTable("TblExpeditionaryUnits", "PaGamePrivate", tb => tb.HasComment("부대"));

      entity.Property(e => e.UnitNo).HasComment("유닛 번호");
      entity.Property(e => e.Experience).HasComment("부대 경험치");
      entity.Property(e => e.Level)
            .HasDefaultValueSql("((1))")
            .HasComment("부대레벨");
      entity.Property(e => e.UnitGrade).HasDefaultValueSql("((1))");
      entity.Property(e => e.UnitKey).HasComment("유닛키");
      entity.Property(e => e.UserNo).HasComment("유저번호");
    });

    modelBuilder.Entity<TblExplorationPoint>(entity => {
      entity.HasKey(e => new { e.UserNo, e.TerritoryKey }).HasName("PkTblExplorationPoint");

      entity.ToTable("TblExplorationPoint", "PaGamePrivate", tb => tb.HasComment("탐험 포인트(지역별 공헌도)"));

      entity.Property(e => e.UserNo).HasComment("유저 고유번호");
      entity.Property(e => e.TerritoryKey).HasComment("지역번호");
      entity.Property(e => e.AquiredPoint).HasComment("총 획득 포인트");
      entity.Property(e => e.Experience).HasComment("경험치");
      entity.Property(e => e.RemainedPoint).HasComment("남은 포인트");
    });

    modelBuilder.Entity<TblExtendSlotRepository>(entity => {
      entity.HasKey(e => new { e.Type, e.OwnerNo, e.VariousNo }).HasName("PkTblExtendSlotRepository");

      entity.ToTable("TblExtendSlotRepository", "PaGamePrivate", tb => tb.HasComment("확장 슬롯 정보"));

      entity.Property(e => e.Type).HasComment("슬롯 타입");
      entity.Property(e => e.OwnerNo).HasComment("유저 혹은 캐릭터 고유 번호");
      entity.Property(e => e.VariousNo).HasComment("지역번호 등 값");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 일시");
      entity.Property(e => e.Slot).HasComment("확장 슬롯 개수");
    });

    modelBuilder.Entity<TblFairyLook>(entity => {
      entity.ToTable("TblFairyLook", "PaGamePrivate", tb => tb.HasComment("요정 외형"));

      entity.Property(e => e.ActionIndex).HasComment("바꿀외형 번호");
      entity.Property(e => e.OwnerUserNo).HasComment("소유 사용자번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
    });

    modelBuilder.Entity<TblFameCoolTime>(entity => {
      entity.HasKey(e => new { e.CharacterNo, e.BadCharacterNo }).HasName("PkTblFameCoolTime");

      entity.Property(e => e.LastFameUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblFameInfo>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("PkTblFameInfo");

      entity.Property(e => e.CharacterNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblFamePreSeasonRank>(entity => {
      entity.HasKey(e => new { e.Season, e.UserNo, e.CharacterNo })
            .HasName("PkTblFamePreSeasonRank")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblFameSeasonRank>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CharacterNo })
            .HasName("PkTblFameSeasonRank")
            .IsClustered(false);

      entity.Property(e => e.UpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblFameSeasonRankNew>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CharacterNo })
            .HasName("PkTblFameSeasonRankNew")
            .IsClustered(false);

      entity.Property(e => e.UpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblFameTotalRank>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CharacterNo })
            .HasName("PkTblFameTotalRank")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblFameTotalRankNew>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CharacterNo })
            .HasName("PkTblFameTotalRankNew")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblFamilySkill>(entity => { entity.HasKey(e => new { e.UserNo, e.SkillNo }).HasName("PKTblFamilySkills"); });

    modelBuilder.Entity<TblFamilySkillPoint>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PKTblFamilySkillPoint")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblFamilySpecialInformation>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblFamilySpecialInformation");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblFeverPoint>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblFeverPoint");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.IsUseFeverSkill).HasDefaultValueSql("((1))");
      entity.Property(e => e.LastAddPointTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblFindHiddenRecipe>(entity => {
      entity.HasKey(e => e.Recipe)
            .HasName("PKTblFindHiddenRecipe")
            .IsClustered(false);

      entity.Property(e => e.Recipe).ValueGeneratedNever();
      entity.Property(e => e.FindTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblFishTopRanking>(entity => {
      entity.HasKey(e => new { e.EncyclopediaKey, e.UserNo }).HasName("PkTblFishTopRanking");

      entity.ToTable("TblFishTopRanking", "PaGamePrivate", tb => tb.HasComment("낚시 TOP 랭킹"));

      entity.Property(e => e.EncyclopediaKey).HasComment("어류도감 키");
      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.CharacterName).HasComment("캐릭터명");
      entity.Property(e => e.CharacterNo).HasComment("캐릭터번호");
      entity.Property(e => e.FishLength).HasComment("어류도감 키");
      entity.Property(e => e.LastUpdateDate).HasComment("낚은 시간");
      entity.Property(e => e.PositionX).HasComment("_positionX");
      entity.Property(e => e.PositionY).HasComment("_positionY");
      entity.Property(e => e.PositionZ).HasComment("_positionZ");
      entity.Property(e => e.UserNickname).HasComment("가문명");
    });

    modelBuilder.Entity<TblFitnessExperience>(entity => {
      entity.HasKey(e => new { e.CharacterNo, e.Type }).HasName("PkTblFitnessExperience");

      entity.ToTable("TblFitnessExperience", "PaGamePrivate", tb => tb.HasComment("건강 경험치"));

      entity.Property(e => e.CharacterNo).HasComment("캐릭터 번호");
      entity.Property(e => e.Type).HasComment("0 호흡,1 힘,2 건강");
      entity.Property(e => e.Experience).HasComment("경험치");
      entity.Property(e => e.Level).HasComment("레벨");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblFixedBusinessInformation>(entity => {
      entity.HasKey(e => new { e.VendorCharacterKey, e.OwnerUserNo })
            .HasName("PkTblFixedBusinessInformation")
            .IsClustered(false);

      entity.ToTable("TblFixedBusinessInformation", "PaGamePrivate", tb => tb.HasComment("자판기_위탁판매"));

      entity.Property(e => e.VendorCharacterKey).HasComment("해당지역 자판기_위탁판매기 번호");
      entity.Property(e => e.OwnerUserNo).HasComment("주인");
      entity.Property(e => e.BusinessType).HasComment("0자동판매1위탁판매");
      entity.Property(e => e.CommissionRate).HasComment("판매수수료(위탁판매시)");
      entity.Property(e => e.HoldingMoney).HasComment("보유금액");
      entity.Property(e => e.IsActive).HasComment("액티브여부");
      entity.Property(e => e.MinRegisterMoney).HasComment("최소등록비(위탁판매시)");
      entity.Property(e => e.SaleTime).HasComment("판매기간(위탁판매시)");
      entity.Property(e => e.TownRegionKey).HasComment("기간이 만료되어 아이템돌려줄때 사용");
    });

    modelBuilder.Entity<TblFixedConsignmentSale>(entity => {
      entity.HasKey(e => e.ConsignmentNo).HasName("PkTblFixedConsignmentSale");

      entity.ToTable("TblFixedConsignmentSale", "PaGamePrivate", tb => tb.HasComment("위탁 판매 정보"));

      entity.Property(e => e.ConsignmentNo).HasComment("위탁판매 고유번호");
      entity.Property(e => e.CommissionRate).HasComment("수수료");
      entity.Property(e => e.ExpireTime).HasComment("판매종료일");
      entity.Property(e => e.GatherMoney).HasComment("판매후 모아진 돈");
      entity.Property(e => e.IsStackable).HasComment("스택여부");
      entity.Property(e => e.ItemKey).HasComment("아이템키");
      entity.Property(e => e.ItemNo).HasComment("아이템번호");
      entity.Property(e => e.OwnerCharacterNo).HasComment("소유자캐릭터번호");
      entity.Property(e => e.PricePerOne).HasComment("개당 가격");
      entity.Property(e => e.RegisterMoney).HasComment("등록비");
      entity.Property(e => e.SaleEnd).HasComment("아이템이 모두 팔리면 1");
      entity.Property(e => e.VendorCharacterKey).HasComment("해당지역 자판기_위탁판매기 번호");
    });

    modelBuilder.Entity<TblFixedVendingMachine>(entity => {
      entity.HasKey(e => new { e.VendorCharacterKey, e.VendingIndex }).HasName("PkTblFixedVendingMachine");

      entity.ToTable("TblFixedVendingMachine", "PaGamePrivate", tb => tb.HasComment("자판기 정보"));

      entity.Property(e => e.VendorCharacterKey).HasComment("해당지역 자판기_위탁판매기 번호");
      entity.Property(e => e.VendingIndex).HasComment("자판기 내부 물건 구분");
      entity.Property(e => e.BuyFromUserPrice).HasComment("구매가격");
      entity.Property(e => e.Count).HasComment("갯수");
      entity.Property(e => e.EnchantLevel).HasComment("강화레벨");
      entity.Property(e => e.IsStackable).HasComment("스택여부");
      entity.Property(e => e.ItemKey).HasComment("아이템키");
      entity.Property(e => e.MaxStackCount).HasComment("최대 스택갯수");
      entity.Property(e => e.SellToUserPrice).HasComment("판매가격");
    });

    modelBuilder.Entity<TblFriend>(entity => {
      entity.HasKey(e => new { e.UserNo, e.FriendUserNo }).HasName("PkTblFriends");

      entity.ToTable("TblFriends", "PaGamePrivate", tb => tb.HasComment("친구 목록"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.FriendUserNo).HasComment("친구 유저번호");
      entity.Property(e => e.FriendType).HasComment("0 일반,1 파티");
      entity.Property(e => e.GroupNo)
            .HasDefaultValueSql("((-1))")
            .HasComment("그룹번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblFriendGroup>(entity => {
      entity.HasKey(e => new { e.UserNo, e.GroupNo }).HasName("PkTblFriendGroup");

      entity.ToTable("TblFriendGroup", "PaGamePrivate", tb => tb.HasComment("친구 그룹"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.GroupNo)
            .ValueGeneratedOnAdd()
            .HasComment("그룹번호");
      entity.Property(e => e.GroupName).HasComment("그룹이름");
    });

    modelBuilder.Entity<TblFuelInsertCharacterInfo>(entity => {
      entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblFuelInsertCharacterSettingInfo>(entity => {
      entity.HasKey(e => e.ObjectNo).HasName("PkTblFuelInsertCharacterSettingInfo");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblFuelInsertInfo>(entity => {
      entity.HasKey(e => new { e.ObjectNo, e.ItemKey }).HasName("PkTblFuelInsertInfo");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGeneralRepository>(entity => {
      entity.HasKey(e => new { e.Type, e.MainKey, e.SubKey }).HasName("PkTblGeneralRepository");

      entity.ToTable("TblGeneralRepository", "PaGamePrivate", tb => tb.HasComment("범용 저장소"));

      entity.Property(e => e.Type).HasComment("타입별로 아래 분류");
      entity.Property(e => e.MainKey).HasComment("캐릭터번호");
      entity.Property(e => e.SubKey).HasComment("WayPoint 또는 캐릭터키");
      entity.Property(e => e.DateTime).HasComment("발견또는 레벨변경일시 또는 미사용");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
      entity.Property(e => e.Value).HasComment("탐험lv 또는 친밀도");
    });

    modelBuilder.Entity<TblGetGuildGiveawayUser>(entity => {
      entity.HasKey(e => new { e.Index, e.UserNo })
            .HasName("PkTblGetGuildGiveawayUser")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGreatSeaRepository>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblGreatSeaRepository");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.EventTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.SupriseEventTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGrowStep>(entity => {
      entity.HasKey(e => new { e.UserNo, e.GrowStepKey })
            .HasName("PkTblGrowStep")
            .IsClustered(false);

      entity.ToTable("TblGrowStep", "PaGamePrivate", tb => tb.HasComment("성장 단계 테이블"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.GrowStepKey).HasComment("성장 단계 키");
      entity.Property(e => e.IsOpen).HasComment("성장 단계 오픈여부");
    });

    modelBuilder.Entity<TblGrowthPassCategoryReward>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CategoryKey, e.RewardIndex })
            .HasName("PkTblGrowthPassCategoryReward")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGrowthPassTotalReward>(entity => {
      entity.HasKey(e => new { e.UserNo, e.TotalRewardKey })
            .HasName("PkTblGrowthPassTotalReward")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGuild>(entity => {
      entity.HasKey(e => e.GuildNo).HasName("PkTblGuild");

      entity.ToTable("TblGuild", "PaGamePrivate", tb => tb.HasComment("길드기본정보"));

      entity.Property(e => e.GuildNo).HasComment("길드번호");
      entity.Property(e => e.AccumulateHouseCost).HasComment("길드하우스유지비");
      entity.Property(e => e.AccumulateTax).HasComment("미납된 누적 법인세");
      entity.Property(e => e.AdviserUserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.AquiredSkillPoint).HasComment("_aquiredSkillPoint");
      entity.Property(e => e.AvailableGuildQuestCount)
            .HasDefaultValueSql("((10))")
            .HasComment("일일 가능 길드 퀘스트");
      entity.Property(e => e.GuildBasicCacheSeqNo).HasComment("길드 기본 정보 캐쉬");
      entity.Property(e => e.GuildGrade).HasComment("길드등급");
      entity.Property(e => e.GuildMainServerGroupNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.GuildMainServerRegisterDate).HasDefaultValueSql("('2000-01-01')");
      entity.Property(e => e.GuildMark).HasComment("길드마크");
      entity.Property(e => e.GuildMarkSeqNo).HasComment("_guildMarkSeqNo");
      entity.Property(e => e.GuildName).HasComment("길드명");
      entity.Property(e => e.GuildNotice).HasComment("길드 공지사항");
      entity.Property(e => e.GuildWelfare).HasComment("길드 복지자금 전달");
      entity.Property(e => e.IncentiveDate).HasComment("인센티브 지급날짜");
      entity.Property(e => e.IsOccupyLastWeek)
            .HasDefaultValueSql("((0))")
            .IsFixedLength()
            .HasComment("지난 주 점령전 점령 여부");
      entity.Property(e => e.LastActiveDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.MasterUserNickname).HasComment("길드마스터 가문명");
      entity.Property(e => e.MasterUserNo).HasComment("길드마스터 사용자번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.RemainedSkillPoint).HasComment("_remainedSkillPoint");
      entity.Property(e => e.SiegeDecreaseHpStack)
            .HasDefaultValueSql("((0))")
            .IsFixedLength()
            .HasComment("점령전 체력 감소 스택");
      entity.Property(e => e.SkillExperience).HasComment("_skillExperience");
      entity.Property(e => e.SkillPointLevel).HasComment("_skillPointLevel");
      entity.Property(e => e.TaxWarningCount).HasComment("법인세를 못 낸 경고 횟수(법인세 납부시 0으로 초기화됨)");
      entity.Property(e => e.Tendency).HasComment("길드성향");
      entity.Property(e => e.VariedMemberCount).HasComment("길드인원변화량");
      entity.Property(e => e.VariedProtectMemberCount).HasComment("길드보호인원변화량");
    });

    modelBuilder.Entity<TblGuildAlliance>(entity => {
      entity.ToTable("TblGuildAlliance", "PaGamePrivate", tb => tb.HasComment("길드연합"));

      entity.Property(e => e.ChairGuildNo).HasComment("연합길드번호");
      entity.Property(e => e.GuildNo).HasComment("길드번호");
      entity.Property(e => e.LimitMemberCount)
            .HasDefaultValueSql("((30))")
            .HasComment("길드인원 제한");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일(길드연합장의 등록일)");
      entity.Property(e => e.TaxRate).HasComment("길드인원 세금 상수");
    });

    modelBuilder.Entity<TblGuildAllianceInformation>(entity => {
      entity.ToTable("TblGuildAllianceInformation", "PaGamePrivate", tb => tb.HasComment("연합 정보"));

      entity.Property(e => e.AllianceBasicSeqNo).HasComment("기본 정보 동기화 번호");
      entity.Property(e => e.AllianceMark).HasComment("연합 마크");
      entity.Property(e => e.AllianceMarkRegisterTime).HasComment("마크 등록 시간");
      entity.Property(e => e.AllianceMarkSeqNo).HasComment("마크 동기화 번호");
      entity.Property(e => e.AllianceName).HasComment("연합 이름");
      entity.Property(e => e.AllianceNo).HasComment("연합 번호");
      entity.Property(e => e.AllianceNotice).HasComment("연합 공지사항");
    });

    modelBuilder.Entity<TblGuildApplicant>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.UserNo }).HasName("PkTblGuildApplicants");

      entity.Property(e => e.Level).HasDefaultValueSql("((1))");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGuildBattleRanking>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.Season }).HasName("PkTblGuildBattleRanking");

      entity.ToTable("TblGuildBattleRanking", "PaGamePrivate", tb => tb.HasComment("결전 랭크 정보"));

      entity.Property(e => e.GuildNo).HasComment("길드 넘버");
      entity.Property(e => e.Season).HasComment("시즌");
      entity.Property(e => e.GuildBattleRating).HasComment("길드 점수");
      entity.Property(e => e.Lose).HasComment("패배");
      entity.Property(e => e.Win).HasComment("승리");
    });

    modelBuilder.Entity<TblGuildBoard>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.BoardType }).HasName("PkTblGuildBoard");

      entity.ToTable("TblGuildBoard", "PaGamePrivate", tb => tb.HasComment("길드 게시판 정보"));

      entity.Property(e => e.GuildNo).HasComment("길드번호");
      entity.Property(e => e.BoardType).HasComment("게시판 타입");
      entity.Property(e => e.BoardMessage).HasComment("게시판 내용");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.UserNo).HasComment("사용자번호");
    });

    modelBuilder.Entity<TblGuildCapital>(entity => {
      entity.HasKey(e => e.GuildNo).HasName("PkTblGuildCapital");

      entity.Property(e => e.GuildNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblGuildComment>(entity => {
      entity.Property(e => e.CommentNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGuildGathering>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.Index }).HasName("PkTblGuildGathering");

      entity.ToTable("TblGuildGathering", "PaGamePrivate", tb => tb.HasComment("길드 수집"));

      entity.Property(e => e.GuildNo).HasComment("길드번호");
      entity.Property(e => e.Index).HasComment("목록 번호");
      entity.Property(e => e.ProductItemCount).HasComment("가공아이템갯수");
      entity.Property(e => e.ProductItemKey).HasComment("가공아이템");
      entity.Property(e => e.RequiredItemCount0).HasComment("재료아이템갯수0");
      entity.Property(e => e.RequiredItemCount1).HasComment("재료아이템갯수1");
      entity.Property(e => e.RequiredItemCount2).HasComment("재료아이템갯수2");
      entity.Property(e => e.RequiredItemCount3).HasComment("재료아이템갯수3");
      entity.Property(e => e.RequiredItemCount4).HasComment("재료아이템갯수4");
      entity.Property(e => e.RequiredItemCount5).HasComment("재료아이템갯수5");
      entity.Property(e => e.RequiredItemKey0).HasComment("재료아이템0");
      entity.Property(e => e.RequiredItemKey1).HasComment("재료아이템1");
      entity.Property(e => e.RequiredItemKey2).HasComment("재료아이템2");
      entity.Property(e => e.RequiredItemKey3).HasComment("재료아이템3");
      entity.Property(e => e.RequiredItemKey4).HasComment("재료아이템4");
      entity.Property(e => e.RequiredItemKey5).HasComment("재료아이템5");
      entity.Property(e => e.SyncCount).HasComment("동기화 카운트");
    });

    modelBuilder.Entity<TblGuildGiveaway>(entity => {
      entity.HasKey(e => e.Index).HasName("PkTblGuildGiveaway");

      entity.Property(e => e.DeleteDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGuildHouseLargeCraft>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.ReceipeKey })
            .HasName("PkTblGuildHouseLargeCraft")
            .IsClustered(false);

      entity.ToTable("TblGuildHouseLargeCraft", "PaGamePrivate", tb => tb.HasComment("길드하우스 대량제작"));

      entity.Property(e => e.GuildNo).HasComment("대량생산의 주체번호");
      entity.Property(e => e.ReceipeKey).HasComment("집의 레시피타입키 / 0은 용도없음");
      entity.Property(e => e.CompletePoint0).HasComment("대량생산 남은 수 0");
      entity.Property(e => e.CompletePoint1).HasComment("대량생산 남은 수 1");
      entity.Property(e => e.CompletePoint2).HasComment("대량생산 남은 수 2");
      entity.Property(e => e.CompletePoint3).HasComment("대량생산 남은 수 3");
      entity.Property(e => e.CompletePoint4).HasComment("대량생산 남은 수 4");
      entity.Property(e => e.CompletePoint5).HasComment("대량생산 남은 수 5");
      entity.Property(e => e.LargeExchangeKey).HasComment("대량생산 exchange키");
    });

    modelBuilder.Entity<TblGuildHouseLargeCraftDailyCount>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.ReceipeKey, e.LargeExchangeKey })
            .HasName("PkTblGuildHouseLargeCraftDailyCount")
            .IsClustered(false);

      entity.ToTable("TblGuildHouseLargeCraftDailyCount", "PaGamePrivate", tb => tb.HasComment("길드하우스 대량제작"));

      entity.Property(e => e.GuildNo).HasComment("대량생산의 주체번호");
      entity.Property(e => e.ReceipeKey).HasComment("집의 레시피타입키 / 0은 용도없음");
      entity.Property(e => e.LargeExchangeKey).HasComment("대량생산 exchange키");
      entity.Property(e => e.CompleteCount).HasComment("오늘 수행한대량생산 수");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGuildInformation>(entity => {
      entity.Property(e => e.GuildCommentCount).HasDefaultValueSql("((0))");
      entity.Property(e => e.GuildCommentUsed).HasDefaultValueSql("((1))");
      entity.Property(e => e.IsBlind).HasDefaultValueSql("((0))");
    });

    modelBuilder.Entity<TblGuildInformationComment>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.GuildCommentNo, e.UserNo })
            .HasName("PkTblGuildInformationComment")
            .IsClustered(false);

      entity.Property(e => e.GuildCommentNo).ValueGeneratedOnAdd();
      entity.Property(e => e.Regdate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGuildInformationCommentBlock>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.GuildCommentBlockNo })
            .HasName("PkTblGuildInformationCommentBlock")
            .IsClustered(false);

      entity.Property(e => e.GuildCommentBlockNo).ValueGeneratedOnAdd();
      entity.Property(e => e.IsBlock).HasDefaultValueSql("((1))");
      entity.Property(e => e.Regdate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGuildJournal>(entity => {
      entity.ToTable("TblGuildJournal", "PaGamePrivate", tb => tb.HasComment("나의 일지 시스템"));

      entity.Property(e => e.DateKey).HasComment("날짜키");
      entity.Property(e => e.GuildName).HasComment("길드 이름");
      entity.Property(e => e.JournalType).HasComment("일지타입(JournalType-0칭호획득, 1 강화성공...)");
      entity.Property(e => e.OwnerCharacterNo).HasComment("캐릭터 번호");
      entity.Property(e => e.OwnerMasterUserNickname).HasComment("길마 가문명");
      entity.Property(e => e.OwnerMasterUserNo).HasComment("길마 유저번호");
      entity.Property(e => e.OwnerMemberGrade).HasComment("owner의 GuildMemberGrade");
      entity.Property(e => e.OwnerName).HasComment("캐릭터 이름");
      entity.Property(e => e.OwnerNickname).HasComment("가문명");
      entity.Property(e => e.OwnerNo).HasComment("길드 번호");
      entity.Property(e => e.OwnerType).HasComment("소유자타입(0 캐릭터,1길드)");
      entity.Property(e => e.OwnerUserNo).HasComment("UserNo");
      entity.Property(e => e.ParameterNo1).HasComment("인자1");
      entity.Property(e => e.ParameterNo2).HasComment("인자2");
      entity.Property(e => e.ParameterString).HasComment("문자열");
      entity.Property(e => e.PositionX)
            .HasDefaultValueSql("((0))")
            .HasComment("위치값");
      entity.Property(e => e.PositionY)
            .HasDefaultValueSql("((0))")
            .HasComment("위치값");
      entity.Property(e => e.PositionZ)
            .HasDefaultValueSql("((0))")
            .HasComment("위치값");
      entity.Property(e => e.RegisterDate).HasComment("등록일");
      entity.Property(e => e.ServerNo).HasComment("서버 번호");
      entity.Property(e => e.TargetCharacterName).HasComment("target의 캐릭터 이름");
      entity.Property(e => e.TargetCharacterNo).HasComment("target의 캐릭터 번호");
      entity.Property(e => e.TargetGuildName).HasComment("target의 길드 이름");
      entity.Property(e => e.TargetGuildNo).HasComment("target의 길드 번호");
      entity.Property(e => e.TargetMasterUserNickname).HasComment("길마 가문명");
      entity.Property(e => e.TargetMasterUserNo).HasComment("길마 유저번호");
      entity.Property(e => e.TargetMemberGrade).HasComment("target의 GuildMemberGrade");
      entity.Property(e => e.TargetUserNickname).HasComment("targer의 가문명");
      entity.Property(e => e.TargetUserNo).HasComment("targer의 UserNo");
    });

    modelBuilder.Entity<TblGuildLifeRankingInfo>(entity => { entity.HasKey(e => new { e.Type, e.GuildNo }).HasName("PKTblGuildLifeRankingInfo"); });

    modelBuilder.Entity<TblGuildManufacture>(entity => {
      entity.ToTable("TblGuildManufacture", "PaGamePrivate", tb => tb.HasComment("길드가공"));

      entity.Property(e => e.CompleteDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("완료일");
      entity.Property(e => e.GuildNo).HasComment("길드번호");
      entity.Property(e => e.Index).HasComment("슬롯번호");
      entity.Property(e => e.ProductItemCount).HasComment("가공아이템갯수");
      entity.Property(e => e.ProductItemKey).HasComment("가공아이템");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.RequiredItemCount0).HasComment("재료아이템갯수0");
      entity.Property(e => e.RequiredItemCount1).HasComment("재료아이템갯수1");
      entity.Property(e => e.RequiredItemCount2).HasComment("재료아이템갯수2");
      entity.Property(e => e.RequiredItemCount3).HasComment("재료아이템갯수3");
      entity.Property(e => e.RequiredItemCount4).HasComment("재료아이템갯수4");
      entity.Property(e => e.RequiredItemCount5).HasComment("재료아이템갯수5");
      entity.Property(e => e.RequiredItemKey0).HasComment("재료아이템0");
      entity.Property(e => e.RequiredItemKey1).HasComment("재료아이템1");
      entity.Property(e => e.RequiredItemKey2).HasComment("재료아이템2");
      entity.Property(e => e.RequiredItemKey3).HasComment("재료아이템3");
      entity.Property(e => e.RequiredItemKey4).HasComment("재료아이템4");
      entity.Property(e => e.RequiredItemKey5).HasComment("재료아이템5");
    });

    modelBuilder.Entity<TblGuildManufactureDailyCount>(entity => {
      entity.ToTable("TblGuildManufactureDailyCount", "PaGamePrivate", tb => tb.HasComment("길드가공일일횟수"));

      entity.Property(e => e.CompleteCount).HasComment("가공아이템완료갯수");
      entity.Property(e => e.GuildNo).HasComment("길드번호");
      entity.Property(e => e.ProductItemKey).HasComment("가공아이템");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("마지막 등록일");
    });

    modelBuilder.Entity<TblGuildMember>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblGuildMember")
            .IsClustered(false);

      entity.ToTable("TblGuildMember", "PaGamePrivate", tb => tb.HasComment("길드멤버정보"));

      entity.Property(e => e.UserNo)
            .ValueGeneratedNever()
            .HasComment("사용자 번호");
      entity.Property(e => e.Benefit).HasComment("수당(실버)	( 길드가 동아리 등급이면 NULL일 수 있다.)");
      entity.Property(e => e.Bonus).HasComment("길드 상여금");
      entity.Property(e => e.ContractableDate).HasComment("다음 계약이 가능한 날짜(길드가 동아리 등급이면 NULL일 수 있다.)");
      entity.Property(e => e.ContractedDay).HasComment("계약한 일 수");
      entity.Property(e => e.ContractedExpiration).HasComment("계약기간 만료(길드가 동아리 등급이면 NULL일 수 있다.)");
      entity.Property(e => e.ContributedTendency).HasComment("멤버가 기여한 길드 성향치");
      entity.Property(e => e.Grade).HasComment("길드원 등급");
      entity.Property(e => e.GuildNo).HasComment("길드번호");
      entity.Property(e => e.IncentiveGrade)
            .HasDefaultValueSql("((1))")
            .HasComment("최근 길드인센티브 지급등급");
      entity.Property(e => e.IsCollectable).HasComment("수당(일당) 수금이 가능한지? 1이면 가능, NULL 이거나, 0이면 안됨");
      entity.Property(e => e.IsPriceLimit)
            .HasDefaultValueSql("((1))")
            .HasComment("길드 자금 사용 한도 검사 유/무");
      entity.Property(e => e.IsProtectable).HasComment("보호 여부? 1이면 보호, NULL 이거나, 0이면 비보호");
      entity.Property(e => e.IsSiegeParticipant).HasComment("공성전에 참여 가능한 전투원");
      entity.Property(e => e.IsVacation).HasComment("휴가중인지");
      entity.Property(e => e.IsVoiceChatListen).HasComment("음성 채팅 듣기 on/off");
      entity.Property(e => e.IsVoiceChatSpeak).HasComment("음성 채팅 말하기 on/off");
      entity.Property(e => e.LastSiegeRewardDate).HasComment("공성전 보상 지급 시간.");
      entity.Property(e => e.MyPriceLimit).HasComment("길드 자금 사용 한도");
      entity.Property(e => e.Penalty).HasComment(" 위약금		(길드가 동아리 등급이면 NULL일 수 있다.)");
      entity.Property(e => e.ProtectableDate).HasComment("다음 보호 여부 변경이 가능한 날짜(길드가 동아리 등급이면 NULL일 수 있다.)");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("길드가입일");
      entity.Property(e => e.SiegeCombatant)
            .HasDefaultValueSql("((5))")
            .HasComment("공성전에 참여 가능한 전투원");
      entity.Property(e => e.SiegeMedalCount).HasComment("공성전 훈장 보상.");
      entity.Property(e => e.SiegeTopItemKey).HasComment("공성전 1등 보상.");
      entity.Property(e => e.TotalActivity).HasComment("총 활동 점수");
      entity.Property(e => e.UsableActivity).HasComment("사용 가능한 활동 점수(고용계약시 수당 갱신에 사용)");
    });

    modelBuilder.Entity<TblGuildPendingReward>(entity => {
      entity.HasKey(e => e.RewardNo).HasName("PkTblGuildPendingReward");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGuildPendingRewardLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblGuildPendingRewardUser>(entity => { entity.HasKey(e => new { e.UserNo, e.GuildNo, e.RewardNo }).HasName("PkTblGuildPendingRewardUser"); });

    modelBuilder.Entity<TblGuildPoint>(entity => {
      entity.HasKey(e => e.TerritoryKey).HasName("PkTblGuildPoint");

      entity.Property(e => e.TerritoryKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblGuildPr>(entity => {
      entity.HasKey(e => e.GuildNo)
            .HasName("PkTblGuildPR")
            .IsClustered(false);

      entity.Property(e => e.GuildNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblGuildQuestList>(entity => {
      entity.HasKey(e => e.GuildNo)
            .HasName("PkTblGuildQuestList")
            .IsClustered(false);

      entity.ToTable("TblGuildQuestList", "PaGamePrivate", tb => tb.HasComment("길드 쾌스트 진행 목록"));

      entity.Property(e => e.GuildNo)
            .ValueGeneratedNever()
            .HasComment("길드번호");
      entity.Property(e => e.Count1).HasComment("_count1");
      entity.Property(e => e.Count2).HasComment("_count2");
      entity.Property(e => e.Count3).HasComment("_count3");
      entity.Property(e => e.Count4).HasComment("_count4");
      entity.Property(e => e.Count5).HasComment("_count5");
      entity.Property(e => e.GuildQuestNo).HasComment("길드 쾌스트 번호");
      entity.Property(e => e.IsPreoccupancy).HasComment("선점여부");
      entity.Property(e => e.LimitTime).HasComment("제한시간");
      entity.Property(e => e.OrderTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("쾌스트수락일시");
    });

    modelBuilder.Entity<TblGuildRankingInfo>(entity => {
      entity.HasKey(e => e.GuildNo).HasName("PKTblGuildRankingInfo");

      entity.Property(e => e.GuildNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblGuildRecommend>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblGuildRecommend");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblGuildSkill>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.SkillNo }).HasName("PkTblGuildSkill");

      entity.ToTable("TblGuildSkill", "PaGamePrivate", tb => tb.HasComment("길드 스킬 정보"));

      entity.Property(e => e.GuildNo).HasComment("길드번호");
      entity.Property(e => e.SkillNo).HasComment("습득한 길드 스킬 번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.SkillLevel).HasComment("습득한 길드 스킬 레벨");
      entity.Property(e => e.UserNo).HasComment("스킬을 활성한 시킨 유저 정보");
    });

    modelBuilder.Entity<TblGuildSkillCoolTime>(entity => { entity.HasKey(e => new { e.GuildNo, e.SkillNo }).HasName("PkTblGuildSkillCoolTime"); });

    modelBuilder.Entity<TblGuildVolunteerMember>(entity => {
      entity.ToTable("TblGuildVolunteerMember", "PaGamePrivate", tb => tb.HasComment("길드 용병 리스트"));

      entity.Property(e => e.ContractAmount).HasComment("용병 계약 금액");
      entity.Property(e => e.ContractBenefit).HasComment("용병 계약 혜택");
      entity.Property(e => e.IsPriceLimit)
            .HasDefaultValueSql("((1))")
            .HasComment("길드 자금 사용 한도 검사 유/무");
      entity.Property(e => e.IsSiegeParticipant)
            .HasDefaultValueSql("((0))")
            .HasComment("용병 거점전 참여");
      entity.Property(e => e.MyPriceLimit).HasComment("길드 자금 사용 한도");
      entity.Property(e => e.UserNo).HasComment("등록일(길드연합장의 등록일)");
      entity.Property(e => e.VolunteerGuilNo).HasComment("용병 길드 넘버");
    });

    modelBuilder.Entity<TblGuildWar>(entity => {
      entity.HasKey(e => new { e.GuildNo, e.TargetGuildNo }).HasName("PkTblGuildWar");

      entity.ToTable("TblGuildWar", "PaGamePrivate", tb => tb.HasComment("길드 전쟁 정보"));

      entity.Property(e => e.GuildNo).HasComment("길드 번호");
      entity.Property(e => e.TargetGuildNo).HasComment("전쟁 선포한 길드 번호");
      entity.Property(e => e.Death).HasComment("사망수");
      entity.Property(e => e.Kill).HasComment("킬수");
      entity.Property(e => e.LastUpdatePenaltyDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("전쟁 페널티 마지막 갱신 시간");
      entity.Property(e => e.PenaltyCount).HasComment("전쟁 페널티 누적 수치");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("전쟁 시작 시간");
    });

    modelBuilder.Entity<TblGuildWarHistory>(entity => { entity.HasKey(e => new { e.OwnerGuildNo, e.TargetGuildNo }).HasName("PkTblGuildWarHistory"); });

    modelBuilder.Entity<TblGuildWareHouseHistory>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblHarvestInstallation>(entity => {
      entity.HasKey(e => e.InstallationNo)
            .HasName("PkTblHarvestInstallation")
            .IsClustered(false);

      entity.Property(e => e.InstallationNo).ValueGeneratedNever();
      entity.Property(e => e.NextType).HasDefaultValueSql("((-1))");
    });

    modelBuilder.Entity<TblHiddenDrop>(entity => {
      entity.HasKey(e => new { e.UserNo, e.HiddenDropNo }).HasName("PkTblHiddenDrop");

      entity.ToTable("TblHiddenDrop", "PaGamePrivate", tb => tb.HasComment("히든 드랍"));

      entity.Property(e => e.UserNo).HasComment("캐릭터 번호");
      entity.Property(e => e.HiddenDropNo).HasComment("드랍 고유 번호");
      entity.Property(e => e.CompleteDate).HasComment("완료 시간");
      entity.Property(e => e.HiddenDropCount).HasComment("진행 정도");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblHorseRacingPreRecordRank>(entity => { entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey }).HasName("PkTblHorseRacingPreRecordRank"); });

    modelBuilder.Entity<TblHorseRacingPreTotalRank>(entity => { entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey }).HasName("PkTblHorseRacingPreTotalRank"); });

    modelBuilder.Entity<TblHorseRacingRank>(entity => {
      entity.HasKey(e => new { e.UserNo, e.RankIndex, e.MapKey }).HasName("PkTblHorseRacingRank");

      entity.Property(e => e.UserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.RankIndex).HasDefaultValueSql("((-1))");
      entity.Property(e => e.MapKey).HasDefaultValueSql("((-1))");
    });

    modelBuilder.Entity<TblHorseRacingRecordRank>(entity => { entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey }).HasName("PkTblHorseRacingRecordRank"); });

    modelBuilder.Entity<TblHorseRacingRecordRankNew>(entity => { entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey }).HasName("PkTblHorseRacingRecordRankNew"); });

    modelBuilder.Entity<TblHorseRacingTotalRank>(entity => { entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey }).HasName("PkTblHorseRacingTotalRank"); });

    modelBuilder.Entity<TblHorseRacingTotalRankNew>(entity => { entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey }).HasName("PkTblHorseRacingTotalRankNew"); });

    modelBuilder.Entity<TblHouseLargeCraft>(entity => {
      entity.HasKey(e => new { e.UserNo, e.HouseKey }).HasName("PkTblHouseLargeCraft");

      entity.ToTable("TblHouseLargeCraft", "PaGamePrivate", tb => tb.HasComment("집의 대량생산기능을 위한 데이터 목록"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.HouseKey).HasComment("_houseKey");
      entity.Property(e => e.CompletePoint0).HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");
      entity.Property(e => e.CompletePoint1).HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");
      entity.Property(e => e.CompletePoint2).HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");
      entity.Property(e => e.CompletePoint3).HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");
      entity.Property(e => e.CompletePoint4).HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");
      entity.Property(e => e.CompletePoint5).HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");
      entity.Property(e => e.LargeExchangeKey).HasComment("집 대량생산 키");
    });

    modelBuilder.Entity<TblHouseListForTownManagement>(entity => {
      entity.HasKey(e => new { e.UserNo, e.HouseKey }).HasName("PkTblHouseListForTownManagement");

      entity.ToTable("TblHouseListForTownManagement", "PaGamePrivate", tb => tb.HasComment("마을 관리 유저가 소유한 집 목록"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.HouseKey).HasComment("_houseKey");
      entity.Property(e => e.Level)
            .HasDefaultValueSql("((1))")
            .HasComment("현재레벨");
      entity.Property(e => e.PrevLevel).HasComment("이전레벨");
      entity.Property(e => e.ReturnExplorePoint).HasComment("돌려받을 탐험포인트");
      entity.Property(e => e.TerritoryKey).HasComment("돌려받을 탐험포인트 지역키");
      entity.Property(e => e.UsableTime)
            .HasDefaultValueSql("((0))")
            .HasComment("사용 가능한 시간(용도 변경시 세팅)");
      entity.Property(e => e.UseType).HasComment("0은 용도없음");
    });

    modelBuilder.Entity<TblHouseholdFixed>(entity => {
      entity.HasKey(e => e.HouseholdNo).HasName("PkTblHouseholdFixed");

      entity.ToTable("TblHouseholdFixed", "PaGamePrivate", tb => tb.HasComment("하우징 하우스홀드 고정집 테이블"));

      entity.Property(e => e.HouseholdNo)
            .ValueGeneratedNever()
            .HasComment("하우징홀드 번호");
      entity.Property(e => e.InteriorSensePoint).HasComment("설치물 점수 합산");
      entity.Property(e => e.IsOpenedForAlliance).HasComment("참이면 가입연합원에게 오픈됨");
      entity.Property(e => e.IsOpenedForEverybody).HasComment("참이면 모든 사람에게 오픈됨");
      entity.Property(e => e.IsOpenedForGuild).HasComment("참이면 가입길드원에게 오픈됨");
      entity.Property(e => e.SuccessBidPrice).HasComment("길드하우스 일 경우 경매 낙찰 가격");
    });

    modelBuilder.Entity<TblHouseholdSpec>(entity => {
      entity.HasKey(e => e.HouseholdNo)
            .HasName("PkTblHouseholdSpec")
            .IsClustered(false);

      entity.ToTable("TblHouseholdSpec", "PaGamePrivate", tb => tb.HasComment("하우징 하우스홀드 기본 테이블"));

      entity.Property(e => e.HouseholdNo).HasComment("_householdNo");
      entity.Property(e => e.CharacterKey).HasComment("텐트나 고정집에 대응하는 캐릭터키");
      entity.Property(e => e.CharacterNo).HasComment("소유자 사용자 캐릭터번호");
      entity.Property(e => e.Expiration).HasComment("현재는 만료기간이 Auction 에서 하고 있음");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.TownRegionKey).HasComment("집/텐트가 설치된 구역의 레지온키");
      entity.Property(e => e.Type).HasComment("household의 타입 - 0개인텐트,1고정집,2하우징설치물,3장애물,4공성텐트,5마을의 여관방,6성채 텐트7함정,8촌장텐트");
      entity.Property(e => e.UserNo).HasComment("캐릭을 소유한 사용자번호");
    });

    modelBuilder.Entity<TblHouseholdTent>(entity => {
      entity.HasKey(e => e.HouseholdNo).HasName("PkTblHouseholdTent");

      entity.ToTable("TblHouseholdTent", "PaGamePrivate", tb => tb.HasComment("하우징 하우스홀드 텐트 테이블"));

      entity.Property(e => e.HouseholdNo)
            .ValueGeneratedNever()
            .HasComment("_householdNo");
      entity.Property(e => e.BuildCreatedDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.BuildProgressPoint0).HasComment("_buildProgressPoint0");
      entity.Property(e => e.BuildProgressPoint1).HasComment("_buildProgressPoint1");
      entity.Property(e => e.BuildProgressPoint2).HasComment("_buildProgressPoint2");
      entity.Property(e => e.BuildProgressPoint3).HasComment("_buildProgressPoint3");
      entity.Property(e => e.BuildProgressPoint4).HasComment("_buildProgressPoint4");
      entity.Property(e => e.BuildRegionKey).HasComment("설치한 곳의 지역 키");
      entity.Property(e => e.DestroyerCharacterName).HasComment("파괴한 캐릭터 명");
      entity.Property(e => e.DestroyerCharacterNo).HasComment("파괴한 캐릭터 번호");
      entity.Property(e => e.DirX).HasComment("_dirX");
      entity.Property(e => e.DirY).HasComment("_dirY");
      entity.Property(e => e.DirZ).HasComment("_dirZ");
      entity.Property(e => e.FieldIndex).HasComment("_fieldIndex");
      entity.Property(e => e.FieldNo).HasComment("_fieldNo");
      entity.Property(e => e.GrowingRate0).HasComment("_growingRate0");
      entity.Property(e => e.GrowingRate1).HasComment("_growingRate1");
      entity.Property(e => e.GrowingRate2).HasComment("_growingRate2");
      entity.Property(e => e.ItemKey).HasComment("설치하기 전에 사용한 텐트 아이템 키");
      entity.Property(e => e.ItemNo).HasComment("아이템번호(아이템테이블과 연결)");
      entity.Property(e => e.PosX).HasComment("_posX");
      entity.Property(e => e.PosY).HasComment("_posY");
      entity.Property(e => e.PosZ).HasComment("_posZ");
      entity.Property(e => e.RegionTaxLevel).HasComment("지역의 세금 단계");
    });

    modelBuilder.Entity<TblInstallation>(entity => {
      entity.HasKey(e => e.InstallationNo).HasName("PkTblInstallation");

      entity.ToTable("TblInstallation", "PaGamePrivate", tb => tb.HasComment("하우징 설치오브젝트 텐트 테이블"));

      entity.Property(e => e.InstallationNo).HasComment("_installationNo");
      entity.Property(e => e.DecreaseYieldPercent).HasComment("설비도구가 작물일때, 작물 수확량 감소%");
      entity.Property(e => e.FieldIndex).HasComment("_fieldIndex");
      entity.Property(e => e.FieldNo).HasComment("_fieldNo");
      entity.Property(e => e.InstallDate).HasComment("설비도구가 처음 설치된 시간");
      entity.Property(e => e.IsErase).HasComment("고정집이 반납될때 삭제되는 설비도구");
      entity.Property(e => e.ItemNo).HasComment("배치된 설치물 아이템 번호");
      entity.Property(e => e.NeedLop).HasComment("설비도구가 작물일때, 가지치기가 필요한 상태");
      entity.Property(e => e.NeedPestControl).HasComment("설비도구가 작물일때, 병충해정리가 필요한 상태");
      entity.Property(e => e.NeedWaterPercent).HasComment("설비도구가 작물일때, 시듦 수치");
      entity.Property(e => e.Param0).HasComment("설비도구 타입에 따라서 맞춰서 사용");
      entity.Property(e => e.Param1).HasComment("설비도구 타입에 따라서 맞춰서 사용");
      entity.Property(e => e.PosX).HasComment("_posX");
      entity.Property(e => e.PosY).HasComment("_posY");
      entity.Property(e => e.PosZ).HasComment("_posZ");
      entity.Property(e => e.PrivateFlag).HasComment("설비도구 공개설정: 0(공개), 1:(고정집안에서공개) 2:(여관안에서 공개)");
      entity.Property(e => e.ProgressPercent).HasComment("설비도구가 작물일때, 성장정도");
      entity.Property(e => e.QuatW).HasComment("_quatW");
      entity.Property(e => e.QuatX).HasComment("_quatX");
      entity.Property(e => e.QuatY).HasComment("_quatY");
      entity.Property(e => e.QuatZ).HasComment("_quatZ");
      entity.Property(e => e.RelativeInstallationNo).HasComment("인테리어 추가 점수에 따른 연관 설비도구 번호");
    });

    modelBuilder.Entity<TblInstallationTempRealItemList>(entity => {
      entity.ToTable("TblInstallationTempRealItemList", "PaGamePrivate", tb => tb.HasComment("집이 기간 만료 후 남아있는 위탁판매기의 위탁판매물 임시저장소(0408안씀)"));

      entity.Property(e => e.Count).HasComment("수량");
      entity.Property(e => e.IsStackable).HasComment("스택여부");
      entity.Property(e => e.ItemKey).HasComment("아이템키");
      entity.Property(e => e.ItemNo).HasComment("아이템번호");
      entity.Property(e => e.TownRegionKey).HasComment("_townRegionKey");
      entity.Property(e => e.UserNo).HasComment("유저번호");
    });

    modelBuilder.Entity<TblInstallationTempVirtualItemList>(entity => {
      entity.ToTable("TblInstallationTempVirtualItemList", "PaGamePrivate", tb => tb.HasComment("집이 기간 만료 후 남아있는 자판기 및 위탁판매용 아이템 임시 저장소(0408안씀)"));

      entity.Property(e => e.Count).HasComment("수량");
      entity.Property(e => e.EnchantLevel).HasComment("강화레벨");
      entity.Property(e => e.IsStackable).HasComment("스택여부");
      entity.Property(e => e.ItemKey).HasComment("아이템키");
      entity.Property(e => e.TownRegionKey).HasComment("_townRegionKey");
      entity.Property(e => e.UserNo).HasComment("유저번호");
    });

    modelBuilder.Entity<TblInstalledInstanceObject>(entity => {
      entity.HasKey(e => e.InstanceObjectNo).HasName("PkTblInstalledInstanceObject");

      entity.ToTable("TblInstalledInstanceObject", "PaGamePrivate", tb => tb.HasComment("하우징 설치 InstanceObject 테이블"));

      entity.Property(e => e.InstanceObjectNo).HasComment("설치된 설치물의 고유번호");
      entity.Property(e => e.CharacterKey).HasComment("설치된 설치물의 캐릭터키");
      entity.Property(e => e.DirX).HasComment("_dirX");
      entity.Property(e => e.DirY).HasComment("_dirY");
      entity.Property(e => e.DirZ).HasComment("_dirZ");
      entity.Property(e => e.FieldIndex).HasComment("_fieldIndex");
      entity.Property(e => e.FieldNo).HasComment("_fieldNo");
      entity.Property(e => e.GuildNo).HasComment("소속 길드번호");
      entity.Property(e => e.ObjectType).HasComment("설치된 설치물의 종류");
      entity.Property(e => e.PosX).HasComment("_posX");
      entity.Property(e => e.PosY).HasComment("_posY");
      entity.Property(e => e.PosZ).HasComment("_posZ");
      entity.Property(e => e.UserCharacterNo).HasComment("소유자 사용자캐릭터번호");
      entity.Property(e => e.UserNo).HasComment("캐릭을 소유한 사용자번호(정상적인 캐릭터라면 TUserNoDefault 이면 안됨)	");
    });

    modelBuilder.Entity<TblInstanceContentReward>(entity => {
      entity.HasKey(e => e.RewardNo)
            .HasName("PkTblInstanceContentReward")
            .IsClustered(false);

      entity.Property(e => e.UpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblInstanceFieldCurruetServerNo>(entity => {
      entity.HasKey(e => new { e.InstanceFieldKey, e.SessionLevel, e.AiLevel }).HasName("PkTblIFCurruetServerNo");

      entity.Property(e => e.InstanceFieldKey).HasDefaultValueSql("((-1))");
    });

    modelBuilder.Entity<TblInstanceFieldCustomRoomOption>(entity => {
      entity.HasKey(e => new { e.InstanceFieldKey, e.ServerNo, e.UniqueIndex }).HasName("PkTblInstanceFieldCustomRoomOption");

      entity.Property(e => e.InstanceFieldKey).HasDefaultValueSql("((-1))");
      entity.Property(e => e.HostUserNo).HasDefaultValueSql("((-1))");
    });

    modelBuilder.Entity<TblInstanceFieldMatching>(entity => {
      entity.HasKey(e => new { e.InstanceFieldKey, e.ServerNo, e.UniqueIndex }).HasName("PkTblInstanceFieldMatching");

      entity.Property(e => e.InstanceFieldKey).HasDefaultValueSql("((-1))");
      entity.Property(e => e.BotCount).HasDefaultValueSql("((0))");
      entity.Property(e => e.GameStartTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.HostUserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.InstanceFieldMapKey).HasDefaultValueSql("((-1))");
      entity.Property(e => e.MatchedCount).HasDefaultValueSql("((0))");
      entity.Property(e => e.PartyId).HasDefaultValueSql("((0))");
    });

    modelBuilder.Entity<TblInstanceFieldNormalDatum>(entity => { entity.HasKey(e => new { e.InstanceFieldKey, e.SeasonKey, e.RankPoint, e.UserNo }).HasName("PKTblInstanceFieldNormalData"); });

    modelBuilder.Entity<TblInstanceFieldOnlineUserRanking>(entity => { entity.HasKey(e => new { e.Ranking, e.InstanceFieldKey, e.IsNormal }).HasName("PKTblInstanceFieldOnlineUserRanking"); });

    modelBuilder.Entity<TblInstanceFieldOnlineUserRankingNew>(entity => { entity.HasKey(e => new { e.Ranking, e.InstanceFieldKey, e.IsNormal }).HasName("PKTblInstanceFieldOnlineUserRanking_New"); });

    modelBuilder.Entity<TblInstanceFieldRankDatum>(entity => { entity.HasKey(e => new { e.InstanceFieldKey, e.SeasonKey, e.Mmr, e.UserNo }).HasName("PKTblInstanceFieldRankData"); });

    modelBuilder.Entity<TblInstanceFieldReadyUser>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblInstanceFieldReadyUser");

      entity.Property(e => e.UserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.InstanceFieldKey).HasDefaultValueSql("((-1))");
    });

    modelBuilder.Entity<TblInstrumentInfo>(entity => { entity.HasKey(e => new { e.UserNo, e.InstrumentNo }).HasName("PkTblTblInstrumentInfo"); });

    modelBuilder.Entity<TblInvestGuildPointInformation>(entity => {
      entity.HasKey(e => e.InvestKey).HasName("PkTblInvestGuildPointInformation");

      entity.Property(e => e.InvestKey).ValueGeneratedNever();
      entity.Property(e => e.UseDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblItemCollectionScroll>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblICScroll");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblItemDeliverer>(entity => {
      entity.HasKey(e => new { e.ServerNo, e.DelivererNo }).HasName("PkTblItemDeliverer");

      entity.ToTable("TblItemDeliverer", "PaGamePrivate", tb => tb.HasComment("아이템 운송을 담당하는 객체 정보"));

      entity.Property(e => e.DelivererNo).HasComment("운송 객체 고유 번호");
      entity.Property(e => e.Destination).HasComment("목적지 웨이포인트 이름");
      entity.Property(e => e.DestinationKey).HasComment("목적지 웨이포인트 키");
      entity.Property(e => e.PositionX).HasComment("현재 좌표(x)");
      entity.Property(e => e.PositionY).HasComment("현재 좌표(y)");
      entity.Property(e => e.PositionZ).HasComment("현재 좌표(z)");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 일시");
      entity.Property(e => e.UpdateTime).HasComment("갱신 시간");
    });

    modelBuilder.Entity<TblItemMarketMaster>(entity => {
      entity.HasKey(e => e.ItemKey).HasName("PkTblItemMarketMaster");

      entity.ToTable("TblItemMarketMaster", "PaGamePrivate", tb => tb.HasComment("아이템거래소 master"));

      entity.Property(e => e.ItemKey).ValueGeneratedNever();
      entity.Property(e => e.LastUpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblItemMarketReservation>(entity => {
      entity.HasKey(e => new { e.ItemEnchantKey, e.RegisterUserNo }).HasName("PkTblItemMarketReservation");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblItemMarketSell>(entity => {
      entity.HasKey(e => e.ItemMarketNo).HasName("PkTblItemMarketSell");

      entity.ToTable("TblItemMarketSell", "PaGamePrivate", tb => tb.HasComment("아이템거래소 판매"));

      entity.Property(e => e.BidderUserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblItemMarketSellByParty>(entity => { entity.HasKey(e => e.ItemMarketNo).HasName("PkTblItemMarketSellByParty"); });

    modelBuilder.Entity<TblItemMarketSellByReservation>(entity => {
      entity.HasKey(e => e.ItemMarketNo)
            .HasName("PkTblItemMarketSellByReservation")
            .IsClustered(false);

      entity.Property(e => e.ItemMarketNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblItemNaming>(entity => {
      entity.HasKey(e => e.ItemNo)
            .HasName("PkTblItemNaming")
            .IsClustered(false);

      entity.ToTable("TblItemNaming", "PaGamePrivate", tb => tb.HasComment("유저 아이템 네이밍"));

      entity.Property(e => e.ItemNo)
            .ValueGeneratedNever()
            .HasComment("아이템 넘버");
      entity.Property(e => e.MailNo).HasComment("작성자 이름");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 시간");
      entity.Property(e => e.UserNickname).HasComment("작성자 이름");
      entity.Property(e => e.UserNo).HasComment("유저 넘버");
    });

    modelBuilder.Entity<TblItemOptionRepository>(entity => {
      entity.HasKey(e => e.ItemNo)
            .HasName("PkTblItemOptionRepository")
            .IsClustered(false);

      entity.Property(e => e.ItemNo).ValueGeneratedNever();
      entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblItemRental>(entity => {
      entity.HasKey(e => e.ItemNo).HasName("PkTblItemRental");

      entity.Property(e => e.ItemNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblItemRepository>(entity => {
      entity.HasKey(e => e.ItemNo)
            .HasName("PkTblItemRepository")
            .IsClustered(false);

      entity.ToTable("TblItemRepository", "PaGamePrivate", tb => tb.HasComment("아이템&돈 저장소"));

      entity.Property(e => e.ItemNo).HasComment("아이템 고유번호");
      entity.Property(e => e.BuyingPrice).HasComment("구매가격(무역아이템/경매 에서 의미가 있음)");
      entity.Property(e => e.Count).HasComment("아이템 개수");
      entity.Property(e => e.EnchantLevel).HasComment("_enchantLevel");
      entity.Property(e => e.Endurance).HasComment("내구도");
      entity.Property(e => e.ExpirationDate).HasComment("유통기한(NULL이면 무기한임)");
      entity.Property(e => e.IsExpirationDyeing).HasComment("true 면 기간제 염색이 적용된 아이템임");
      entity.Property(e => e.IsSealed)
            .HasDefaultValueSql("((1))")
            .HasComment("참이면 각인된 것임");
      entity.Property(e => e.IsSeized).HasComment("참이면 압류임");
      entity.Property(e => e.IsValid)
            .HasDefaultValueSql("((1))")
            .HasComment("참인 경우에만 정상적인 아이템임");
      entity.Property(e => e.IsVested).HasComment("참이면 귀속된 것임");
      entity.Property(e => e.ItemKey).HasComment("_itemKey");
      entity.Property(e => e.ItemWhereType).HasComment("아이템위치");
      entity.Property(e => e.MaxEndurance).HasComment("최대 내구도");
      entity.Property(e => e.OwnerNo).HasComment("_itemWhereType에 따라 의미 다름");
      entity.Property(e => e.ProductionRegionKey).HasComment("최초로 만들어진/생산되어진 지역번호");
      entity.Property(e => e.PushedItemKey0).HasComment("_pushedItemKey0");
      entity.Property(e => e.PushedItemKey1).HasComment("_pushedItemKey1");
      entity.Property(e => e.PushedItemKey2).HasComment("_pushedItemKey2");
      entity.Property(e => e.PushedItemKey3).HasComment("_pushedItemKey3");
      entity.Property(e => e.PushedItemKey4).HasComment("_pushedItemKey4");
      entity.Property(e => e.PushedItemKey5).HasComment("_pushedItemKey5");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
      entity.Property(e => e.VariableDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_variableDate");
      entity.Property(e => e.VariousNo).HasComment("_itemWhereType에 따라 의미 다름");
    });

    modelBuilder.Entity<TblItemRestoreWaiting>(entity => {
      entity.Property(e => e.IsSealed).HasDefaultValueSql("((1))");
      entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");
      entity.Property(e => e.RestoreNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RestoreRegDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.VariableDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblItemToInventoryRequest>(entity => {
      entity.Property(e => e.RequestNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RequestedDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblItemToWarehouseRequest>(entity => {
      entity.Property(e => e.IsSealed).HasDefaultValueSql("((1))");
      entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");
      entity.Property(e => e.RequestNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RequestedDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.VariableDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblJournal>(entity => {
      entity.ToTable("TblJournal", "PaGamePrivate", tb => tb.HasComment("나의 일지 시스템"));

      entity.Property(e => e.DateKey).HasComment("날짜키");
      entity.Property(e => e.JournalType).HasComment("일지타입(JournalType-0칭호획득, 1 강화성공...)");
      entity.Property(e => e.OwnerName).HasComment("캐릭터 이름");
      entity.Property(e => e.OwnerNickname).HasComment("가문명");
      entity.Property(e => e.OwnerNo).HasComment("캐릭터 번호");
      entity.Property(e => e.OwnerType).HasComment("소유자타입(0 캐릭터,1길드)");
      entity.Property(e => e.OwnerUserNo).HasComment("UserNo");
      entity.Property(e => e.ParameterNo1).HasComment("인자1");
      entity.Property(e => e.ParameterNo2).HasComment("인자2");
      entity.Property(e => e.ParameterString).HasComment("문자열");
      entity.Property(e => e.PositionX)
            .HasDefaultValueSql("((0))")
            .HasComment("위치값");
      entity.Property(e => e.PositionY)
            .HasDefaultValueSql("((0))")
            .HasComment("위치값");
      entity.Property(e => e.PositionZ)
            .HasDefaultValueSql("((0))")
            .HasComment("위치값");
      entity.Property(e => e.RegisterDate).HasComment("등록일");
      entity.Property(e => e.ServerNo).HasComment("서버 번호");
      entity.Property(e => e.TargetCharacterName).HasComment("target 캐릭터 이름");
      entity.Property(e => e.TargetCharacterNo).HasComment("target 캐릭터 번호");
      entity.Property(e => e.TargetUserNickname).HasComment("target 가문명");
      entity.Property(e => e.TargetUserNo).HasComment("target UserNo");
    });

    modelBuilder.Entity<TblLeaveLog>(entity => { entity.Property(e => e.MDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblLifeExperience>(entity => {
      entity.HasKey(e => new { e.CharacterNo, e.Type }).HasName("PkTblLifeExperience");

      entity.ToTable("TblLifeExperience", "PaGamePrivate", tb => tb.HasComment("생활 숙련도 정보"));

      entity.Property(e => e.CharacterNo).HasComment("캐릭터번호");
      entity.Property(e => e.Type).HasComment("타입");
      entity.Property(e => e.Experience).HasComment("경험치");
      entity.Property(e => e.Level).HasComment("숙련도");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 시간");
    });

    modelBuilder.Entity<TblLogoutPlayerWorking>(entity => {
      entity.HasKey(e => e.CharacterNo)
            .HasName("PkTblLogoutPlayerWorking")
            .IsClustered(false);

      entity.ToTable("TblLogoutPlayerWorking", "PaGamePrivate", tb => tb.HasComment("로그아웃중인 플레이어의 작업목록"));

      entity.Property(e => e.CharacterNo)
            .ValueGeneratedNever()
            .HasComment("캐릭의 고유한 번호(OdbcCharacterNo)");
      entity.Property(e => e.OwnerUserNo).HasComment("소유 사용자번호");
      entity.Property(e => e.ProcessType).HasComment("작업의 종류(0: 없음, 1: 수리, 2: 마을이동)");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("작업 시작일");
      entity.Property(e => e.RepairItemNo).HasComment("해당 작업에 관련된 아이템 번호(OdbcItemNo) (수리시에는 수리할 아이템, 마을 이동시에는 운송화된 아이템번호)");
      entity.Property(e => e.ToWaypoint)
            .HasDefaultValueSql("((0))")
            .HasComment("해당 작업으로 이동할 Waypoint 번호이다. (현재 마을이동 이외의 경우에는 NULL)");
    });

    modelBuilder.Entity<TblLoverList>(entity => {
      entity.HasKey(e => e.NpcKey).HasName("PkTblLoverList");

      entity.ToTable("TblLoverList", "PaGamePrivate", tb => tb.HasComment("연인 테이블"));

      entity.Property(e => e.NpcKey)
            .ValueGeneratedNever()
            .HasComment("npc 번호");
      entity.Property(e => e.UserNo).HasComment("npc의 연인 유저 번호");
    });

    modelBuilder.Entity<TblMacroKeyInputCheckLog>(entity => { entity.Property(e => e.StartDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblMaid>(entity => {
      entity.HasKey(e => e.MaidNo)
            .HasName("PkTblMaid")
            .IsClustered(false);

      entity.ToTable("TblMaid", "PaGamePrivate", tb => tb.HasComment("메이드"));

      entity.Property(e => e.MaidNo).HasComment("메이드 고유번호");
      entity.Property(e => e.CharacterKey).HasComment("메이드 식별자");
      entity.Property(e => e.OwnerUserNo).HasComment("소유 사용자 번호");
      entity.Property(e => e.ReuseTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("재사용 가능시간");
    });

    modelBuilder.Entity<TblMail>(entity => {
      entity.HasKey(e => e.MailNo)
            .HasName("PkTblMail")
            .IsClustered(false);

      entity.ToTable("TblMail", "PaGamePrivate", tb => tb.HasComment("편지 정보"));

      entity.Property(e => e.MailNo).HasComment("편지 고유 번호");
      entity.Property(e => e.ChargeNo).HasDefaultValueSql("('')");
      entity.Property(e => e.Contents).HasComment("편지 내용");
      entity.Property(e => e.DeletedDate).HasComment("편지 삭제 시간");
      entity.Property(e => e.EnchantLevel).HasComment("첨부된 아이템 인챈트 레벨");
      entity.Property(e => e.ExpirationDate).HasComment("첨부된 아이템 유통기한");
      entity.Property(e => e.ItemCount).HasComment("첨부된 아이템 개수");
      entity.Property(e => e.MailType).HasComment("편지 타입");
      entity.Property(e => e.ReceiverName).HasComment("받는 캐릭터 이름");
      entity.Property(e => e.ReceiverUserNo).HasComment("받는 사용자번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 일시");
      entity.Property(e => e.SenderName).HasComment("보낸 캐릭터 이름");
      entity.Property(e => e.SenderUserNo).HasComment("보낸 사용자번호");
      entity.Property(e => e.Title).HasComment("편지 제목");
      entity.Property(e => e.VariousNo).HasComment("_mailType에 따라 의미 다름");
      entity.Property(e => e.WebItemType).HasComment("우편발송 웹창고 아이템 구분 (0:인게임메일, 1:쿠폰지급 아이템, 2:패키지, 3:웹샵 아이템, 그외 추가 가능)");
    });

    modelBuilder.Entity<TblMailItemWhiteList>(entity => {
      entity.HasKey(e => e.ItemKey)
            .HasName("PkTblMailItemWhiteList")
            .IsClustered(false);

      entity.Property(e => e.ItemKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblMailPs4sub>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblMailWaitingQueue>(entity => { entity.Property(e => e.WaitingNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblMainQuestGroupInfo>(entity => {
      entity.HasKey(e => e.QuestGroupNo)
            .HasName("PkTblTblMainQuestGroupInfo")
            .IsClustered(false);

      entity.Property(e => e.QuestGroupNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblMansionListForTownManagement>(entity => {
      entity.HasKey(e => new { e.UserNo, e.LandKey, e.BuildingKey })
            .HasName("PkTblMansionListForTownManagement")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblMarbleGame>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblMarbleGame");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblMarbleGameCard>(entity => { entity.HasKey(e => new { e.UserNo, e.CardKey }).HasName("PkTblMarbleGameCard"); });

    modelBuilder.Entity<TblMarbleGameDiceItem>(entity => {
      entity.HasKey(e => new { e.UserNo, e.DiceItemKey }).HasName("PkTblMarbleGameDiceItem");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblMarbleGameMap>(entity => {
      entity.HasKey(e => new { e.UserNo, e.MarbleKey }).HasName("PkTblMarbleGameMap");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblMassMail>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblMassMailRequest>(entity => {
      entity.Property(e => e.IsComplete).HasDefaultValueSql("((0))");
      entity.Property(e => e.MailRequestNo).ValueGeneratedOnAdd();
      entity.Property(e => e.SendingWaitingNo).HasDefaultValueSql("((0))");
    });

    modelBuilder.Entity<TblMassMailUserInfo>(entity => {
      entity.HasKey(e => new { e.MassMailNo, e.UserNo })
            .HasName("PkTblMassMailUserInfo")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblMassPlayerTitleRequest>(entity => {
      entity.Property(e => e.No).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblMentalCardList>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CardKey }).HasName("PkTblMentalCardList");

      entity.ToTable("TblMentalCardList", "PaGamePrivate", tb => tb.HasComment("카드 목록 테이블"));

      entity.Property(e => e.UserNo).HasComment("소유 유저번호");
      entity.Property(e => e.CardKey).HasComment("카드키");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblMessengerInfo>(entity => {
      entity.HasKey(e => new { e.RoomNo, e.UserNo })
            .HasName("PkTblMessengerInfo")
            .IsClustered(false);

      entity.Property(e => e.AlarmIsOn).HasDefaultValueSql("((1))");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblMessengerMessage>(entity => {
      entity.HasKey(e => new { e.RoomNo, e.MessageIndex }).HasName("PkTblMessengerMessage");

      entity.Property(e => e.MessageIndex).ValueGeneratedOnAdd();
      entity.Property(e => e.MessageContent).HasDefaultValueSql("('')");
      entity.Property(e => e.MessageDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.MessageRealIndex).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblMilitiaMember>(entity => {
      entity.ToTable("TblMilitiaMember", "PaGamePrivate", tb => tb.HasComment("민병대 정보"));

      entity.Property(e => e.AdSummary).HasComment("공방 합");
      entity.Property(e => e.CharacterNo).HasComment("캐릭터 번호");
      entity.Property(e => e.GuildNo).HasComment("길드 번호");
      entity.Property(e => e.IsAttackTeam).HasComment("공격 팀 신청");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 시간");
      entity.Property(e => e.State)
            .HasDefaultValueSql("((1))")
            .HasComment("신청 상태");
      entity.Property(e => e.UserNo).HasComment("유저 번호");
    });

    modelBuilder.Entity<TblMiniGameUserInformation>(entity => { entity.HasKey(e => new { e.UserNo, e.Type }).HasName("PkTblMiniGameUserInformation"); });

    modelBuilder.Entity<TblMusicLevelInfo>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblMusicLevelInfo");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblMusicScore>(entity => {
      entity.HasKey(e => e.MusicScoreNo).HasName("PkTblMusicScore");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblNameChange>(entity => {
      entity.HasKey(e => new { e.OwnerNo, e.NameChangeType })
            .HasName("PkTblNameChange")
            .IsClustered(false);

      entity.ToTable("TblNameChange", "PaGamePrivate", tb => tb.HasComment("이름 변경 요청"));

      entity.Property(e => e.OwnerNo).HasComment("변경을 요청한 유저 번호");
      entity.Property(e => e.NameChangeType).HasComment("이름 변경 타입");
      entity.Property(e => e.BeforeName).HasComment("변경전 이름");
      entity.Property(e => e.IsBadName).HasComment("불건전한 이름 확인 여부");
      entity.Property(e => e.Name).HasComment("변경할 이름");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("신청 날짜");
    });

    modelBuilder.Entity<TblNameChangeComplete>(entity => {
      entity.HasKey(e => new { e.OwnerNo, e.Name, e.ChangedDate })
            .HasName("PkTblNameChangeComplete")
            .IsClustered(false);

      entity.ToTable("TblNameChangeComplete", "PaGamePrivate", tb => tb.HasComment("이름 변경 완료"));

      entity.Property(e => e.OwnerNo).HasComment("변경을 요청한 유저 번호");
      entity.Property(e => e.Name).HasComment("변경할 이름");
      entity.Property(e => e.ChangedDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("변경된 날짜");
      entity.Property(e => e.BeforeName).HasComment("변경된 날짜");
      entity.Property(e => e.NameChangeType).HasComment("이름 변경 타입");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("신청 날짜");
    });

    modelBuilder.Entity<TblNameExchange>(entity => {
      entity.HasKey(e => e.OwnerNo)
            .HasName("PkTblNameExchange")
            .IsClustered(false);

      entity.Property(e => e.OwnerNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblNameExchangeComplete>(entity => {
      entity.HasKey(e => new { e.CharacterNo1, e.CharacterNo2, e.ChangedDate })
            .HasName("PkTblNameExchangeComplete")
            .IsClustered(false);

      entity.Property(e => e.ChangedDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblNewDeliveryRepository>(entity => {
      entity.HasKey(e => e.ItemNo).HasName("PkTblNewDeliveryRepository");

      entity.Property(e => e.ItemNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblNpcProposeDialog>(entity => {
      entity.HasKey(e => e.Index).HasName("PkTblNpcProposeDialog");

      entity.ToTable("TblNpcProposeDialog", "PaGamePrivate", tb => tb.HasComment("NPC 고백 시 대사 테이블"));

      entity.Property(e => e.Index).HasComment("index 번호");
      entity.Property(e => e.Fail).HasComment("실패 시 메시지");
      entity.Property(e => e.Farewell).HasComment("헤어질 때 메시지");
      entity.Property(e => e.NpcKey).HasComment("npc 번호");
      entity.Property(e => e.SenderName).HasComment("이름");
      entity.Property(e => e.Success).HasComment("성공 시 메시지");
      entity.Property(e => e.Title).HasComment("타이틀");
    });

    modelBuilder.Entity<TblNpcShopItemBuyCount>(entity => {
      entity.HasKey(e => new { e.IsUserNo, e.UserCharacterNo, e.ItemSubGroupKey, e.ItemEnchantKey })
            .HasName("PkTblNpcShopItemBuyCount")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblOperationReport>(entity => {
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.Report).HasDefaultValueSql("(' ')");
    });

    modelBuilder.Entity<TblPalette>(entity => {
      entity.HasKey(e => new { e.OwnerNo, e.ItemKey }).HasName("PkTblPalette");

      entity.ToTable("TblPalette", "PaGamePrivate", tb => tb.HasComment("팔레트"));

      entity.Property(e => e.OwnerNo).HasComment("소유자번호");
      entity.Property(e => e.ItemKey).HasComment("아이템키");
      entity.Property(e => e.Count).HasComment("수량");
    });

    modelBuilder.Entity<TblParty>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblParty");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblPartyMatching>(entity => {
      entity.HasKey(e => e.MatchId).HasName("PKTblPartyMatching");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPartyMatchingMember>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PKTblPartyMatchingMember")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblPcWorking>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("PkTblPcWorking");

      entity.ToTable("TblPcWorking", "PaGamePrivate", tb => tb.HasComment("PC의 작업 정보"));

      entity.Property(e => e.CharacterNo)
            .ValueGeneratedNever()
            .HasComment("캐릭터번호");
      entity.Property(e => e.CompletingTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("작업완료시간(작업종류가 변경될 때마다 설정됨)");
      entity.Property(e => e.DelivererNo).HasComment("운송자 번호(이동중일때만 설정)");
      entity.Property(e => e.DeliveryFrom).HasComment("출발지 지역번호");
      entity.Property(e => e.DeliveryRoute).HasComment("노선번호");
      entity.Property(e => e.DeliveryTo).HasComment("도착지 지역번호");
      entity.Property(e => e.DirectionX).HasComment("_directionX(방향)");
      entity.Property(e => e.DirectionY).HasComment("_directionY(방향)");
      entity.Property(e => e.DirectionZ)
            .HasDefaultValueSql("((-1))")
            .HasComment("_directionZ(방향)");
      entity.Property(e => e.HouseholdNo).HasComment("수리하는 곳의 집 번호, 이외는 NULL");
      entity.Property(e => e.InstallationKey).HasComment("설치물번호의 아이템키, 이외는 NULL");
      entity.Property(e => e.InstallationNo).HasComment("수리할때 이용하는 설치물 번호, 이외는 NULL");
      entity.Property(e => e.ItemNo).HasComment("수리되는 아이템번호, 이외는 NULL");
      entity.Property(e => e.MaxWp).HasComment("(회복작업시)회복할 최대 대화여력");
      entity.Property(e => e.PcWorkingType).HasComment("작업종류(PcWorkingType와 연결됨)");
      entity.Property(e => e.ServerNo).HasComment("서버번호-작업중일때만 의미있음");
      entity.Property(e => e.StartTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("작업시작시간(작업종류가 변경될 때마다 설정됨)");
    });

    modelBuilder.Entity<TblPearlCashProductList>(entity => {
      entity.HasKey(e => new { e.ServiceType, e.CashProductNo })
            .HasName("PkTblPearlCashProductList")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblPearlInventoryDeletedItemRestoreLog>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblPearlItemList>(entity => {
      entity.HasKey(e => new { e.ServiceType, e.ItemKey })
            .HasName("PkTblPearlItemList")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblPearlUsedAmount>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblPearlUsedAmount")
            .IsClustered(false);

      entity.ToTable("TblPearlUsedAmount", "PaGamePrivate", tb => tb.HasComment("펄 획득, 사용량 누적내역"));

      entity.Property(e => e.UserNo)
            .ValueGeneratedNever()
            .HasComment("유저번호");
      entity.Property(e => e.DailyResetTime).HasComment("일단위 펄 사용량 리셋 시간");
      entity.Property(e => e.MonthlyResetTime).HasComment("월단위 펄 사용량 리셋 시간");
      entity.Property(e => e.PearlObtainedDaily).HasComment("일간 펄 획득량");
      entity.Property(e => e.PearlObtainedMonthly).HasComment("월간 펄 획득량");
      entity.Property(e => e.PearlObtainedTotal).HasComment("총 누적 펄 획득량");
      entity.Property(e => e.PearlObtainedWeekly).HasComment("주간 펄 획득량");
      entity.Property(e => e.PearlUsedDaily).HasComment("일간 펄 사용량");
      entity.Property(e => e.PearlUsedMonthly).HasComment("월간 펄 사용량");
      entity.Property(e => e.PearlUsedTotal).HasComment("총 누적 펄 사용량");
      entity.Property(e => e.PearlUsedWeekly).HasComment("주간 펄 사용량");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.WeeklyResetTime).HasComment("주단위 펄 사용량 리셋 시간");
    });

    modelBuilder.Entity<TblPearlUsedChallengeResetCount>(entity => {
      entity.HasKey(e => new { e.UserNo, e.MainChallengeKey })
            .HasName("PkTblPearlUsedChallenge")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ResetCount).HasDefaultValueSql("((0))");
    });

    modelBuilder.Entity<TblPearlUsedLastMonthAmount>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblPearlUsedLastMonthAmount")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.LastRegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPenaltyEscape>(entity => { entity.HasKey(e => new { e.InstanceFieldKey, e.UserNo }).HasName("PKTblPenaltyEscape"); });

    modelBuilder.Entity<TblPendingReward>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ItemKey, e.Type }).HasName("PK__TblPendi__DB64CADA2C527A24");

      entity.Property(e => e.UpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPendingRewardLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblPersonalBattleRanking>(entity => {
      entity.HasKey(e => new { e.UserNo, e.Season }).HasName("PkTblPersonalBattleRanking");

      entity.ToTable("TblPersonalBattleRanking", "PaGamePrivate", tb => tb.HasComment("개인 결전 랭크 정보"));

      entity.Property(e => e.UserNo).HasComment("길드 넘버");
      entity.Property(e => e.Season).HasComment("시즌");
      entity.Property(e => e.Lose).HasComment("패배");
      entity.Property(e => e.PersonalRating).HasComment("길드 점수");
      entity.Property(e => e.Win).HasComment("승리");
    });

    modelBuilder.Entity<TblPersonalDuelRanking>(entity => { entity.HasKey(e => new { e.UserNo, e.Season }).HasName("PkTblPersonalDuelRanking"); });

    modelBuilder.Entity<TblPersonalMonsterInformation>(entity => {
      entity.HasKey(e => new { e.UserNo, e.CharacterKey })
            .HasName("PkTblPersonalMonsterInformation")
            .IsClustered(false);

      entity.Property(e => e.LevelupTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.SpawnTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPersonalMonsterUserInfo>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PKTblPersonalMonsterUserInfo")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPet>(entity => {
      entity.HasKey(e => e.PetNo)
            .HasName("PkTblPet")
            .IsClustered(false);

      entity.ToTable("TblPet", "PaGamePrivate", tb => tb.HasComment("펫"));

      entity.Property(e => e.PetNo).HasComment("_petNo");
      entity.Property(e => e.ActionIndex).HasComment("펫의 외형");
      entity.Property(e => e.CharacterKey).HasComment("_characterKey");
      entity.Property(e => e.Experience).HasComment("펫의 경험치");
      entity.Property(e => e.Hungry).HasComment("펫의 배고픔");
      entity.Property(e => e.IsSealed)
            .HasDefaultValueSql("((1))")
            .HasComment("펫이 맡겨져있는지");
      entity.Property(e => e.LearnedEquipSkillFlag).HasComment("_learnedEquipSkillFlag");
      entity.Property(e => e.LearnedFlag).HasComment("_learnedFlag");
      entity.Property(e => e.Level)
            .HasDefaultValueSql("((1))")
            .HasComment("펫의 레벨");
      entity.Property(e => e.Lovely).HasComment("펫의 애정도");
      entity.Property(e => e.OwnerUserNo).HasComment("소유 사용자번호");
      entity.Property(e => e.PetLootingType)
            .HasDefaultValueSql("((1))")
            .HasComment("_petLootingType");
      entity.Property(e => e.PetState)
            .HasDefaultValueSql("((1))")
            .HasComment("맡겨진 상태 값");
      entity.Property(e => e.PetType).HasComment("_petType");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
      entity.Property(e => e.UpgradeStackCount).HasComment("_upgradeStackCount");
    });

    modelBuilder.Entity<TblPlantRepository>(entity => {
      entity.HasKey(e => new { e.UserNo, e.Type, e.SubType, e.WaypointKey }).HasName("PkTblPlantRepository");

      entity.ToTable("TblPlantRepository", "PaGamePrivate", tb => tb.HasComment("탐험 & 탐험과 연계되는 컨텐츠 저장소"));

      entity.Property(e => e.UserNo).HasComment("사용자번호");
      entity.Property(e => e.Type).HasComment("_type 별로 의미가 다르다");
      entity.Property(e => e.SubType).HasComment("_subType");
      entity.Property(e => e.WaypointKey).HasComment("대상 노드의 WaypointKey");
      entity.Property(e => e.DateTime).HasComment("업그레이드가 완료될 시각");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
      entity.Property(e => e.Value).HasComment("_value");
    });

    modelBuilder.Entity<TblPlayerTitle>(entity => {
      entity.HasKey(e => new { e.UserNo, e.Key }).HasName("PkTblPlayerTitle");

      entity.ToTable("TblPlayerTitle", "PaGamePrivate", tb => tb.HasComment("칭호 시스템"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.Key).HasComment("칭호 키");
      entity.Property(e => e.Count).HasComment("칭호 카운트");
      entity.Property(e => e.ExpirationDate).HasComment("칭호 종료시간");
      entity.Property(e => e.IsAcquired).HasComment("칭호 획득 여부");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblPostBoxTemplate>(entity => {
      entity.HasKey(e => e.TemplateNo)
            .HasName("PkTblPostBoxTemplate")
            .IsClustered(false);

      entity.Property(e => e.TemplateNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblPriorityGuildPr>(entity => {
      entity.HasKey(e => e.GuildNo).HasName("PkTblPriorityGuildPR");

      entity.Property(e => e.GuildNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblPrizeLottery>(entity => {
      entity.ToTable("TblPrizeLottery", "PaGamePrivate", tb => tb.HasComment("경품 추첨"));

      entity.Property(e => e.CharacterKey).HasComment("NPC키");
      entity.Property(e => e.EntryUserNo).HasComment("추첨유저번호");
    });

    modelBuilder.Entity<TblProgressChallenge>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ChallengeKey })
            .HasName("PkTblProgressChallenge")
            .IsClustered(false);

      entity.ToTable("TblProgressChallenge", "PaGamePrivate", tb => tb.HasComment("진행중-도전과제 및 pc방 정액제"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.ChallengeKey).HasComment("도전과제 키-DataSheet_Challenge$Challenge_Table");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblProgressExpedition>(entity => {
      entity.ToTable("TblProgressExpedition", "PaGamePrivate", tb => tb.HasComment("토벌테이블"));

      entity.Property(e => e.CharacterNo).HasComment("캐릭터 번호");
      entity.Property(e => e.GroupKey).HasComment("토벌 그룹");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("토벌 등록 시간");
      entity.Property(e => e.SlotIndex).HasComment("토벌 지역");
      entity.Property(e => e.UnitNo).HasComment("유닛 번호");
      entity.Property(e => e.UserNo).HasComment("유저 번호");
    });

    modelBuilder.Entity<TblProgressingGuildDuel>(entity => {
      entity.HasKey(e => e.DuelNo).HasName("PkTblProgressingGuildDuel");

      entity.ToTable("TblProgressingGuildDuel", "PaGamePrivate", tb => tb.HasComment("길드 결전 정보"));

      entity.Property(e => e.DuelNo).HasComment("길드 결전 번호");
      entity.Property(e => e.AcceptGuildKill).HasComment("수락한 길드가 죽인 횟수");
      entity.Property(e => e.AcceptGuildNo).HasComment("결전 수락한 길드 번호");
      entity.Property(e => e.Deadline)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("마감 시간");
      entity.Property(e => e.DeclareGuildKill).HasComment("선포한 길드가 죽인 횟수");
      entity.Property(e => e.DeclareGuildNo).HasComment("결전 선포한 길드 번호");
      entity.Property(e => e.Prize).HasComment("상금");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.TargetKill).HasComment("목표 킬수");
    });

    modelBuilder.Entity<TblProgressingNewQuest>(entity => {
      entity.HasKey(e => new { e.UserCharacterNo, e.IsUserBaseQuest, e.QuestGroupNo, e.QuestNo })
            .HasName("PkTblProgressingNewQuest")
            .IsClustered(false);

      entity.ToTable("TblProgressingNewQuest", "PaGamePrivate", tb => tb.HasComment("퀘스트 진행 목록"));

      entity.Property(e => e.UserCharacterNo).HasComment("유저,캐릭터번호");
      entity.Property(e => e.IsUserBaseQuest).HasComment("1이면 유저 0이면 캐릭터 기반");
      entity.Property(e => e.QuestGroupNo).HasComment("_questGroupNo");
      entity.Property(e => e.QuestNo).HasComment("퀘스트번호");
      entity.Property(e => e.Count1).HasComment("_count1");
      entity.Property(e => e.Count2).HasComment("_count2");
      entity.Property(e => e.Count3).HasComment("_count3");
      entity.Property(e => e.Count4).HasComment("_count4");
      entity.Property(e => e.Count5).HasComment("_count5");
      entity.Property(e => e.OrderTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_orderTime");
    });

    modelBuilder.Entity<TblProposeList>(entity => {
      entity.HasKey(e => new { e.UserNo, e.NpcKey }).HasName("PkTblProposeList");

      entity.ToTable("TblProposeList", "PaGamePrivate", tb => tb.HasComment("고백 리스트 테이블"));

      entity.Property(e => e.UserNo).HasComment("고백한 유저번호");
      entity.Property(e => e.NpcKey).HasComment("npc 번호");
    });

    modelBuilder.Entity<TblPs4cashInfoLog>(entity => {
      entity.Property(e => e.LogNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPurchasedClassType>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ClassType }).HasName("PKTblPurchasedClassType");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPurchasedSkin>(entity => {
      entity.HasKey(e => new { e.UserNo, e.SkinKey }).HasName("PKTblPurchasedSkin");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblQuizEventUserInfo>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblQuizEventUserInfo");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblRandomPartyMatching>(entity => {
      entity.HasKey(e => new { e.InstanceFieldKey, e.RegisterDate, e.UserNo }).HasName("PkTblRandomPartyMatching");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblRecordGuildVolunteerScore>(entity => {
      entity.ToTable("TblRecordGuildVolunteerScore", "PaGamePrivate", tb => tb.HasComment("길드 용병 리스트"));

      entity.Property(e => e.CharacterName).HasComment("캐릭터 넘버");
      entity.Property(e => e.CharacterNo).HasComment("캐릭터 넘버");
      entity.Property(e => e.DeathCount).HasComment("사망 횟수");
      entity.Property(e => e.IsVillageSiege).HasComment("거점전 인지");
      entity.Property(e => e.KillCount).HasComment("죽인 횟수");
      entity.Property(e => e.MissionComplete).HasComment("용병 성공 했는지");
      entity.Property(e => e.OriginalGuilNo).HasComment("원래 길드 넘버");
      entity.Property(e => e.OriginalGuildName).HasComment("원래 길드 이름");
      entity.Property(e => e.RegionKey).HasComment("거점 리전 키");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.SiegeScoreNo).HasComment("거점/점령전 요일");
      entity.Property(e => e.UserNickname).HasComment("유저 가문명");
      entity.Property(e => e.UserNo).HasComment("유저 넘버");
      entity.Property(e => e.VolunteerGuilNo).HasComment("용병 길드 넘버");
      entity.Property(e => e.VolunteerguildName).HasComment("용병 길드 이름");
    });

    modelBuilder.Entity<TblRegionGroup>(entity => {
      entity.HasKey(e => e.RegionGroupKey)
            .HasName("PkTblRegionGroup")
            .IsClustered(false);

      entity.ToTable("TblRegionGroup", "PaGamePrivate", tb => tb.HasComment("영역별 정보"));

      entity.Property(e => e.RegionGroupKey)
            .ValueGeneratedNever()
            .HasComment("_regionGroupKey");
      entity.Property(e => e.CorpProductivity).HasComment("농산물 생산력");
      entity.Property(e => e.FishingProductivity).HasComment("낚시 생산력");
      entity.Property(e => e.LastUpdateDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("마지막 수정일시");
      entity.Property(e => e.Loyalty).HasComment("충성도");
    });

    modelBuilder.Entity<TblRentInstanceField>(entity => {
      entity.HasKey(e => new { e.InstanceFieldKey, e.ServerNo, e.UniqueIndex })
            .HasName("PkTblRentInstanceField")
            .IsClustered(false);

      entity.Property(e => e.InstanceFieldKey).HasDefaultValueSql("((-1))");
      entity.Property(e => e.ExpirationDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.HostUserNickName).HasDefaultValueSql("('')");
      entity.Property(e => e.HostUserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.InstanceFieldMapKey).HasDefaultValueSql("((-1))");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblRentInstanceFieldPass>(entity => {
      entity.HasKey(e => new { e.InstanceFieldKey, e.ServerNo, e.UniqueIndex, e.UserNo })
            .HasName("PkTblRentInstanceFieldPass")
            .IsClustered(false);

      entity.Property(e => e.InstanceFieldKey).HasDefaultValueSql("((-1))");
      entity.Property(e => e.UserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.HostUserNo).HasDefaultValueSql("((-1))");
      entity.Property(e => e.UserNickname).HasDefaultValueSql("('')");
    });

    modelBuilder.Entity<TblRequestGuildInviteList>(entity => {
      entity.HasKey(e => new { e.RegisterDate, e.HostGuildNo, e.ReceiveUserNo }).HasName("PkTblRequestGuildInviteList");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblReservationArsha>(entity => {
      entity.HasKey(e => new { e.ReservationDay, e.ServerNo }).HasName("PkTblReservationArsha");

      entity.ToTable("TblReservationArsha", "PaGamePrivate", tb => tb.HasComment("아르샤의 창 예약"));

      entity.Property(e => e.ReservationDay)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("예약일");
      entity.Property(e => e.ServerNo).HasComment("예약 채널 번호");
      entity.Property(e => e.GuildName).HasComment("예약 길드 이름");
      entity.Property(e => e.GuildNo).HasComment("예약 길드 번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("예약 등록시간");
    });

    modelBuilder.Entity<TblRestoreItemRepository>(entity => {
      entity.HasKey(e => e.ItemNo)
            .HasName("PkTblRestoreItemRepository")
            .IsClustered(false);

      entity.Property(e => e.ItemNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblRestoreItemUserInfo>(entity => { entity.HasKey(e => new { e.UserNo, e.RestoreType }).HasName("PkTblRestoreItemUserInfo"); });

    modelBuilder.Entity<TblRestoreServantList>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblReturnStone>(entity => {
      entity.HasKey(e => new { e.CharacterNo, e.TeleportType })
            .HasName("PkTblReturnStone")
            .IsClustered(false);

      entity.Property(e => e.UsableDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblScreenShot>(entity => {
      entity.HasKey(e => e.ScreenNo)
            .HasName("PkTblScreenShot")
            .IsClustered(false);

      entity.Property(e => e.Regdate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblScreenShotBlind>(entity => { entity.Property(e => e.BlindDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblScreenShotComment>(entity => {
      entity.HasKey(e => e.ScreenCommentNo).HasName("PkTblScreenShotComment");

      entity.Property(e => e.CharacterName).HasDefaultValueSql("('')");
      entity.Property(e => e.CharacterNo).HasDefaultValueSql("((0))");
      entity.Property(e => e.CommentRegdate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.CommentUpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblScreenShotCommentReport>(entity => {
      entity.Property(e => e.BlindType)
            .HasDefaultValueSql("('')")
            .IsFixedLength();
      entity.Property(e => e.ReportDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblScreenShotLikeLog>(entity => { entity.Property(e => e.LikeDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblSeasonChangeLog>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblSeasonCloseChallenge>(entity => { entity.Property(e => e.Type).HasDefaultValueSql("((2))"); });

    modelBuilder.Entity<TblSeasonCloseChallengeInfo>(entity => {
      entity.HasKey(e => new { e.ChallengeKey, e.CloseType })
            .HasName("PkTblTblSeasonCloseChallengeInfo")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblSeasonCloseItemInfo>(entity => {
      entity.HasKey(e => new { e.ItemKey, e.CloseType })
            .HasName("PkTblTblSeasonCloseItemInfo")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblSeasonCloseQuest>(entity => { entity.Property(e => e.Type).HasDefaultValueSql("((2))"); });

    modelBuilder.Entity<TblSeasonCloseQuestInfo>(entity => {
      entity.HasKey(e => new { e.QuestGroupNo, e.QuestNo, e.CloseType })
            .HasName("PkTblTblSeasonCloseQuestInfo")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblSeasonReward>(entity => {
      entity.HasKey(e => new { e.UserNo, e.SelectedItemKey })
            .HasName("PkTblTblSeasonReward")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblServantMating>(entity => {
      entity.HasKey(e => e.MatingNo).HasName("PkTblServantMating");

      entity.ToTable("TblServantMating", "PaGamePrivate", tb => tb.HasComment("말 교배 정보"));

      entity.Property(e => e.MatingNo).HasComment("교배 고유 번호");
      entity.Property(e => e.ChildCharacterKey).HasComment("망아지 캐릭터 키");
      entity.Property(e => e.EndDate).HasComment("교배 종료 시간");
      entity.Property(e => e.FemaleServantNo).HasComment("암컷 말 고유 번호");
      entity.Property(e => e.IsMaleStallion)
            .HasDefaultValueSql("((0))")
            .HasComment("수컷 말 종마 구분");
      entity.Property(e => e.MaleServantNo).HasComment("수컷 말 고유 번호");
      entity.Property(e => e.StartDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("교배 시작 시간");
    });

    modelBuilder.Entity<TblServantRepository>(entity => {
      entity.HasKey(e => e.ServantNo).HasName("PkTblServantRepository");

      entity.ToTable("TblServantRepository", "PaGamePrivate", tb => tb.HasComment("Servant 정보"));

      entity.Property(e => e.ServantNo).HasComment("고유 번호");
      entity.Property(e => e.AwakenStack).HasComment("준마 각성 스택");
      entity.Property(e => e.CharacterKey).HasComment("캐릭터 키");
      entity.Property(e => e.ClearCountByDead).HasComment("죽은 횟수 초기화 아이템 사용 횟수");
      entity.Property(e => e.ClearCountByMating).HasComment("교배 횟수 추가 아이템 사용 횟수");
      entity.Property(e => e.CurrentFieldIndex).HasComment("_currentFieldIndex");
      entity.Property(e => e.CurrentFieldNo).HasComment("_currentFieldNo");
      entity.Property(e => e.CurrentPositionX).HasComment("_currentPositionX");
      entity.Property(e => e.CurrentPositionY).HasComment("_currentPositionY");
      entity.Property(e => e.CurrentPositionZ).HasComment("_currentPositionZ");
      entity.Property(e => e.DeleteDate).HasComment("삭제 일시");
      entity.Property(e => e.Direction)
            .HasDefaultValueSql("((0))")
            .HasComment("_direction");
      entity.Property(e => e.DyeingList).HasComment("염색");
      entity.Property(e => e.EndSkillExpTrainingTime).HasComment("스킬 훈련 종료시간");
      entity.Property(e => e.Experience).HasComment("경험치");
      entity.Property(e => e.ExpiredTime).HasComment("경험치");
      entity.Property(e => e.Food).HasDefaultValueSql("((0))");
      entity.Property(e => e.FormIndex).HasComment("외형 인덱스");
      entity.Property(e => e.Hp)
            .HasDefaultValueSql("((1))")
            .HasComment("체력");
      entity.Property(e => e.IsImprint).HasComment("각인(유/무)");
      entity.Property(e => e.IsSeized).HasComment("압류(유/무)");
      entity.Property(e => e.LastServerNo).HasComment("소환된 서버 번호");
      entity.Property(e => e.Level)
            .HasDefaultValueSql("((1))")
            .HasComment("레벨");
      entity.Property(e => e.MatingCount).HasComment("교배 횟수");
      entity.Property(e => e.MatingNo).HasComment("교배 고유 번호");
      entity.Property(e => e.Mp).HasComment("스태미너");
      entity.Property(e => e.Name).HasComment("이름");
      entity.Property(e => e.OwnerCharacterNo).HasComment("소유자 유저 고유 번호");
      entity.Property(e => e.OwnerNo).HasComment("소유자 고유 번호");
      entity.Property(e => e.OwnerServantNo).HasComment("연결된 마차 번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 일시");
      entity.Property(e => e.RentOwnerNo).HasDefaultValueSql("((0))");
      entity.Property(e => e.SealRegion).HasComment("_sealRegion");
      entity.Property(e => e.ServantBasicCacheSeqNo).HasComment("캐싱 시퀀스번호");
      entity.Property(e => e.SkillFailedCount).HasComment("스킬 변경 실패 횟수");
      entity.Property(e => e.StatParam1).HasDefaultValueSql("((0))");
      entity.Property(e => e.StatParam2).HasDefaultValueSql("((0))");
      entity.Property(e => e.StatParam3).HasDefaultValueSql("((0))");
      entity.Property(e => e.StateType).HasComment("말 상태");
      entity.Property(e => e.SympatheticCoolTime).HasComment("교감쿨타임(밀리초)");
      entity.Property(e => e.Type).HasComment("캐릭터 타입(지상, 수상)");
      entity.Property(e => e.UnsealDelayTime).HasComment("서번트 소환 가능 시간");
      entity.Property(e => e.VariedAcceleration).HasComment("성장 가변 가속도");
      entity.Property(e => e.VariedBrake).HasComment("성장 가변 브레이크");
      entity.Property(e => e.VariedCannonAccuracy).HasComment("성장 가변 대포 정확도");
      entity.Property(e => e.VariedCannonCoolTime).HasComment("성장 가변 대포 쿨타임");
      entity.Property(e => e.VariedCannonMaxAngle).HasComment("성장 가변 대포 각도");
      entity.Property(e => e.VariedCannonMaxLength).HasComment("성장 가변 대포 사거리");
      entity.Property(e => e.VariedCornering).HasComment("성장 가변 코너링");
      entity.Property(e => e.VariedMaxHp).HasComment("_variedMaxHp");
      entity.Property(e => e.VariedMaxMp).HasComment("_variedMaxMp");
      entity.Property(e => e.VariedMoveSpeed).HasComment("성장 가변 속도");
      entity.Property(e => e.WhereType).HasComment("소유자 타입");
    });

    modelBuilder.Entity<TblServantStallionSkillInfo>(entity => { entity.HasKey(e => new { e.Tier, e.SkillNo }).HasName("PkTblTblServantStallionSkillInfo"); });

    modelBuilder.Entity<TblServantTierInfo>(entity => {
      entity.HasKey(e => e.CharacterKey).HasName("PkTblServantTierInfo");

      entity.ToTable("TblServantTierInfo", "PaGamePrivate", tb => tb.HasComment("tier 정보"));

      entity.Property(e => e.CharacterKey)
            .ValueGeneratedNever()
            .HasComment("탑승물 characterKey");
      entity.Property(e => e.SexType).HasComment("탑승물 성별 (0: 수컷, 1: 암컷)");
      entity.Property(e => e.Tier).HasComment("탑승물 tier");
    });

    modelBuilder.Entity<TblShaFreeClassType>(entity => { entity.HasKey(e => e.ClassType).HasName("PKTblShaFreeClassType"); });

    modelBuilder.Entity<TblShadowArenaAbusingUser>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PKTblShadowArenaAbusingUser");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShadowArenaAttendance>(entity => {
      entity.HasKey(e => new { e.UserNo, e.Key, e.Day })
            .HasName("PKTblShadowArenaAttendance")
            .IsClustered(false);

      entity.Property(e => e.ReceiveDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShadowArenaAttendanceOption>(entity => {
      entity.HasKey(e => e.Key).HasName("PKTblShadowArenaAttendanceOption");

      entity.Property(e => e.Key).ValueGeneratedNever();
      entity.Property(e => e.BeginDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.EndDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShadowArenaBriefUserInformation>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblShadowArenaBriefUserInformation");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.AllCharacterBoostEndTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.CurrentAccountRewardLevel).HasDefaultValueSql("((1))");
      entity.Property(e => e.ExpBoostEndTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.IsTutorialComplete).HasDefaultValueSql("((1))");
      entity.Property(e => e.MoneyBoostEndTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.SelectedProfileIconKey).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblShadowArenaCharacter>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ClassType })
            .HasName("PkTblShadowArenaCharacter")
            .IsClustered(false);

      entity.Property(e => e.Level).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblShadowArenaClanApplicant>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblShadowArenaClanApplicant");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShadowArenaClanAssembleFlag>(entity => {
      entity.HasKey(e => e.GuildNo).HasName("PKTblShadowArenaClanAssembleFlag");

      entity.Property(e => e.GuildNo).ValueGeneratedNever();
      entity.Property(e => e.InstanceFieldKey).HasDefaultValueSql("((-1))");
      entity.Property(e => e.SummonTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShadowArenaClanChat>(entity => {
      entity.HasKey(e => e.ChatIdx)
            .HasName("PKTblShadowArenaClanChat")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShadowArenaDodgePanelty>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PKTblShadowArenaDodgePanelty");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.NextResetTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShadowArenaFriendChat>(entity => {
      entity.HasKey(e => e.ChatIdx)
            .HasName("PKTblShadowArenaFriendChat")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShadowArenaLastBattleResultInfo>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PKTblShadowArenaLastBattleResultInfo");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblShadowArenaPurchasedProfileIcon>(entity => {
      entity.HasKey(e => new { e.UserNo, e.IconKey }).HasName("PKTblShadowArenaPurchasedProfileIcon");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShadowArenaRestrictMode>(entity => {
      entity.HasKey(e => e.InstanceFieldKey).HasName("PKTblShadowArenaRestrictMode");

      entity.Property(e => e.InstanceFieldKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblShadowArenaShopPreset>(entity => {
      entity.HasKey(e => new { e.UserNo, e.InstanceContentsType, e.InstanceContentsMode, e.ClassType, e.PresetIndex })
            .HasName("PKTblShadowArenaShopPreset")
            .IsClustered(false);

      entity.Property(e => e.InstanceContentsType).HasDefaultValueSql("((1))");
      entity.Property(e => e.InstanceContentsMode).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblShadowArenaSkillAwakenList>(entity => { entity.HasKey(e => new { e.UserNo, e.ClassType, e.SkillNo }).HasName("PKTblShaSkillAwakenList"); });

    modelBuilder.Entity<TblShadowArenaSkillAwakenSelect>(entity => { entity.HasKey(e => new { e.UserNo, e.SkillNo }).HasName("PKTblShaSkillAwakenSelect"); });

    modelBuilder.Entity<TblShadowArenaSkillStone>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PKTblShadowArenaSkillStone");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblShadowArenaSkinDyingInfo>(entity => { entity.HasKey(e => new { e.UserNo, e.SkinKey }).HasName("PKTblShadowArenaSkinDyingInfo"); });

    modelBuilder.Entity<TblShadowArenaUserTitle>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PKTblShadowArenaUserTitle");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblSiege>(entity => {
      entity.HasKey(e => e.RegionKey).HasName("PkTblSiege");

      entity.ToTable("TblSiege", "PaGamePrivate", tb => tb.HasComment("공성&마을 정보"));

      entity.Property(e => e.RegionKey)
            .ValueGeneratedNever()
            .HasComment("_regionKey");
      entity.Property(e => e.Dislike).HasComment("싫어요수 (약탈게임)");
      entity.Property(e => e.GuildNo).HasComment("주인이 없으면 0");
      entity.Property(e => e.Like).HasComment("좋아요수 (약탈게임)");
      entity.Property(e => e.OccupyingDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("점령일시(주인이 없다면 해방일시)");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("최초 등록시간");
      entity.Property(e => e.TaxRateForSiege).HasComment("성주가 설정한 세율");
      entity.Property(e => e.TaxRemainedAmountForFortress).HasComment("영주가 인출할 수 있는 세금잔량");
      entity.Property(e => e.TaxRemainedAmountForSiege).HasComment("성주가 인출할 수 있는 세금잔량");
      entity.Property(e => e.UpdateDateOfTaxRemainedAmount)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_taxRemainedAmount이 변경된 시간");
    });

    modelBuilder.Entity<TblSiegeColor>(entity => { entity.HasKey(e => e.ColorIndex).HasName("PkTblSiegeColor"); });

    modelBuilder.Entity<TblSiegeHistory>(entity => {
      entity.HasKey(e => new { e.SiegeHistoryDate, e.RegionKey }).HasName("PkTblSiegeHistory");

      entity.ToTable("TblSiegeHistory", "PaGamePrivate", tb => tb.HasComment("공성&마을 정보"));

      entity.Property(e => e.SiegeHistoryDate).HasComment("공성 날짜 키");
      entity.Property(e => e.RegionKey).HasComment("_regionKey");
      entity.Property(e => e.GuildName).HasComment("점령 길드명");
      entity.Property(e => e.GuildNo).HasComment("주인이 없으면 0");
      entity.Property(e => e.IsVillageSiege).HasComment("공성 종류");
      entity.Property(e => e.OccupyingDate).HasComment("점령일시(주인이 없다면 해방일시)");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("최초 등록시간");
      entity.Property(e => e.UpdateDate).HasComment("갱신된 시간");
    });

    modelBuilder.Entity<TblSiegeScore>(entity => {
      entity.HasKey(e => new { e.SiegeScoreNo, e.GuildNo, e.UserNo, e.RegionKey })
            .HasName("PkTblSiegeScore")
            .IsClustered(false);

      entity.ToTable("TblSiegeScore", "PaGamePrivate", tb => tb.HasComment("길드공성전적"));

      entity.Property(e => e.SiegeScoreNo).HasComment("공성 회차");
      entity.Property(e => e.GuildNo).HasComment("참여 길드 번호");
      entity.Property(e => e.UserNo).HasComment("참여 유저 번호");
      entity.Property(e => e.RegionKey).HasComment("해당 공성의 지역키");
      entity.Property(e => e.CharacterName).HasComment("캐릭터명");
      entity.Property(e => e.CharacterNo).HasComment("캐릭터 번호");
      entity.Property(e => e.GuildName).HasComment("참여 길드 이름");
      entity.Property(e => e.IsVillageSiege).HasComment("해당 공성의 종류");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("공성 시작 시간");
      entity.Property(e => e.ScoreType0).HasComment("사망 횟수");
      entity.Property(e => e.ScoreType1).HasComment("지휘소 파괴 횟수");
      entity.Property(e => e.ScoreType10).HasComment("배치물 파괴 횟수");
      entity.Property(e => e.ScoreType11).HasComment("공성병기로 사람을 죽인 횟수");
      entity.Property(e => e.ScoreType2).HasComment("성채 파괴 횟수");
      entity.Property(e => e.ScoreType3).HasComment("군주 (연합 길드장) 죽인 횟수");
      entity.Property(e => e.ScoreType4).HasComment("대장 처치 횟수");
      entity.Property(e => e.ScoreType5).HasComment("성문 파괴 횟수");
      entity.Property(e => e.ScoreType6).HasComment("부대장 처치 횟수");
      entity.Property(e => e.ScoreType7).HasComment("길드처치 횟수");
      entity.Property(e => e.ScoreType8).HasComment("도움 횟수");
      entity.Property(e => e.ScoreType9).HasComment("탑승물 처치 횟수");
      entity.Property(e => e.TerritoryKey).HasComment("해당 공성의 영지키");
      entity.Property(e => e.UpdateDate).HasComment("공성 전적 업데이트 시간");
      entity.Property(e => e.UserNickname).HasComment("가문명");
    });

    modelBuilder.Entity<TblSiegeSecondRoundScore>(entity => {
      entity.HasKey(e => new { e.SiegeScoreNo, e.GuildNo, e.RegionKey, e.TerritoryKey }).HasName("PkTblSiegeSecondRoundScore");

      entity.Property(e => e.UpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblSiegeTaxTime>(entity => {
      entity.ToTable("TblSiegeTaxTime", "PaGamePrivate", tb => tb.HasComment("세금 납입 시간 기록용"));

      entity.Property(e => e.LastPayTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("지급 시간");
    });

    modelBuilder.Entity<TblSiegeVote>(entity => {
      entity.HasKey(e => new { e.UserNo, e.TerritoryKey })
            .HasName("PkTblSiegeVote")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblSimpleGuildInviteList>(entity => {
      entity.HasKey(e => new { e.HostGuildNo, e.ReciveUserNo }).HasName("PkTblSimpleGuildInviteList");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblSkill>(entity => {
      entity.HasKey(e => new { e.CharacterNo, e.IsPlayer, e.SkillNo }).HasName("PkTblSkill");

      entity.ToTable("TblSkill", "PaGamePrivate", tb => tb.HasComment("스킬 정보"));

      entity.Property(e => e.CharacterNo).HasComment("캐릭터번호");
      entity.Property(e => e.IsPlayer).HasComment("_isPlayer");
      entity.Property(e => e.SkillNo).HasComment("스킬번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
      entity.Property(e => e.SkillLearningType).HasComment("스킬 배우는 방법 타입");
      entity.Property(e => e.SkillLevel).HasComment("_skillLevel");
      entity.Property(e => e.SkillPointType).HasComment("스킬 포인트타입(전투,생산)");
    });

    modelBuilder.Entity<TblSkillAwakeningVersion2>(entity => {
      entity.HasKey(e => new { e.CharacterNo, e.SkillNo }).HasName("PkTblSkillAwakeningVersion2");

      entity.ToTable("TblSkillAwakeningVersion2", "PaGamePrivate", tb => tb.HasComment("스킬 각성 정보 ( 리뉴얼 )"));

      entity.Property(e => e.CharacterNo).HasComment("캐릭터번호");
      entity.Property(e => e.SkillNo).HasComment("스킬번호");
      entity.Property(e => e.AwakeningBitFlag).HasComment("_awakeningBitFlag");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
    });

    modelBuilder.Entity<TblSkillPreset>(entity => {
      entity.HasKey(e => new { e.CharacterNo, e.SlotNo })
            .HasName("PkTblSkillPreset")
            .IsClustered(false);

      entity.Property(e => e.CommandLockList).HasDefaultValueSql("('')");
      entity.Property(e => e.CoolTimeList).HasDefaultValueSql("('')");
      entity.Property(e => e.QuickSlotList).HasDefaultValueSql("('')");
      entity.Property(e => e.RingMenuList).HasDefaultValueSql("('')");
      entity.Property(e => e.SkillList).HasDefaultValueSql("('')");
      entity.Property(e => e.SpiritLockList).HasDefaultValueSql("('')");
    });

    modelBuilder.Entity<TblSkillPresetLastUpdateTime>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PKTblSkillPresetLastUpdateTime");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblSkillPresetSlot>(entity => { entity.HasKey(e => new { e.UserNo, e.CharacterNo }).HasName("PKTblSkillPresetSlot"); });

    modelBuilder.Entity<TblStatementTemp>(entity => { entity.Property(e => e.Idx).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblStockMarketBuy>(entity => {
      entity.HasKey(e => e.MarketId)
            .HasName("PkTblStockMarketBuy")
            .IsClustered(false);

      entity.Property(e => e.MarketId).HasComment("거래순번");
      entity.Property(e => e.Count).HasComment("구매수량");
      entity.Property(e => e.ItemKey).HasComment("아이템 종류");
      entity.Property(e => e.Price).HasComment("구매가격");
      entity.Property(e => e.RegionKey).HasComment("지역번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.UserNo).HasComment("구매자");
    });

    modelBuilder.Entity<TblStockMarketSell>(entity => {
      entity.HasKey(e => e.MarketId)
            .HasName("PkTblStockMarketSell")
            .IsClustered(false);

      entity.Property(e => e.MarketId).HasComment("거래순번");
      entity.Property(e => e.Count).HasComment("판매수량");
      entity.Property(e => e.ItemKey).HasComment("아이템 종류");
      entity.Property(e => e.ItemNo).HasComment("아이템 고유번호");
      entity.Property(e => e.Price).HasComment("판매가격");
      entity.Property(e => e.RegionKey).HasComment("지역번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.UserNo).HasComment("판매자");
    });

    modelBuilder.Entity<TblSupplyCount>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblSupplyCount");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblSupportPoint>(entity => {
      entity.HasKey(e => new { e.UserNo, e.TerritoryKey }).HasName("PkTblSupportPoint");

      entity.ToTable("TblSupportPoint", "PaGamePrivate", tb => tb.HasComment("탐험 포인트(지역별 지지도)"));

      entity.Property(e => e.UserNo).HasComment("유저 고유번호");
      entity.Property(e => e.TerritoryKey).HasComment("지역번호");
      entity.Property(e => e.AquiredPoint).HasComment("총 획득 포인트");
      entity.Property(e => e.Experience).HasComment("경험치");
      entity.Property(e => e.RemainedPoint).HasComment("남은 포인트");
    });

    modelBuilder.Entity<TblSyncGuildInformation>(entity => { entity.Property(e => e.RegionKey).HasDefaultValueSql("((0))"); });

    modelBuilder.Entity<TblSyncGuildInformationSnap>(entity => { entity.Property(e => e.RegionKey).HasDefaultValueSql("((0))"); });

    modelBuilder.Entity<TblSyncGuildInformationTran>(entity => { entity.Property(e => e.RegionKey).HasDefaultValueSql("((0))"); });

    modelBuilder.Entity<TblSyncWebUserInformation>(entity => {
      entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
      entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblSyncWebUserInformationTran>(entity => {
      entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
      entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblTax>(entity => {
      entity.HasKey(e => new { e.RegionKey, e.TaxType }).HasName("PkTblTax");

      entity.ToTable("TblTax", "PaGamePrivate", tb => tb.HasComment("세금정보"));

      entity.Property(e => e.RegionKey).HasComment("_regionKey");
      entity.Property(e => e.TaxType).HasComment("_taxType");
      entity.Property(e => e.AffiliatedAmount).HasComment("주민세(소속지역주민들의 세금합)");
      entity.Property(e => e.ProducedAmount).HasComment("지방세(해당지역의 세금합)");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("점령일시");
      entity.Property(e => e.TaxRate).HasComment("현재 세율");
    });

    modelBuilder.Entity<TblTeleportableUser>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblTeleportableUser");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblTeleportationPoint>(entity => { entity.HasKey(e => new { e.UserNo, e.RegionKey }).HasName("PkTblTeleportationPoint"); });

    modelBuilder.Entity<TblTerritoryTradeAuthority>(entity => {
      entity.HasKey(e => new { e.UserNo, e.TerritoryKey }).HasName("PkTblTerritoryTradeAuthority");

      entity.ToTable("TblTerritoryTradeAuthority", "PaGamePrivate", tb => tb.HasComment("영지 무역(황실무역) 권한 테이블"));

      entity.Property(e => e.UserNo).HasComment("유져 번호");
      entity.Property(e => e.TerritoryKey).HasComment("영지 번호");
    });

    modelBuilder.Entity<TblTerritoryTradeItem>(entity => {
      entity.HasKey(e => e.TerritoryKey).HasName("PkTblTerritoryTradeItem");

      entity.ToTable("TblTerritoryTradeItem", "PaGamePrivate", tb => tb.HasComment("영지 무역, 납품 아이템 테이블"));

      entity.Property(e => e.TerritoryKey)
            .ValueGeneratedNever()
            .HasComment("영지 번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("영지 아이템 등록 시간");
      entity.Property(e => e.SupplyItemMainGroupKey).HasComment("영지 납품 gc::ItemMainGroupKey ");
      entity.Property(e => e.TradeItemMainGroupKey).HasComment("영지 무역 gc::ItemMainGroupKey ");
    });

    modelBuilder.Entity<TblThumbsUpCountInformation>(entity => { entity.HasKey(e => new { e.ChatRoomNo, e.UserNo }).HasName("PkTblThumbsUpCountInformation"); });

    modelBuilder.Entity<TblThumbsUpInformation>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblThumbsUpInformation")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.LastVoteTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblTimeAttackRanking>(entity => {
      entity.HasKey(e => new { e.Type, e.OwnerNo, e.MonsterNo })
            .HasName("PkTblTimeAttackRanking")
            .IsClustered(false);

      entity.ToTable("TblTimeAttackRanking", "PaGamePrivate", tb => tb.HasComment("타임어택 TOP 랭킹"));

      entity.Property(e => e.Type).HasComment("타입");
      entity.Property(e => e.OwnerNo).HasComment("타임어택 소유주");
      entity.Property(e => e.MonsterNo).HasComment("몬스터");
      entity.Property(e => e.CompleteTime).HasComment("완료 시간");
    });

    modelBuilder.Entity<TblTradeCompany>(entity => {
      entity.HasKey(e => e.OwnerUserNo)
            .HasName("PkTblTradeCompany")
            .IsClustered(false);

      entity.Property(e => e.OwnerUserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblTradeCompanyLog>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblTradeCompanyObtainItem>(entity => { entity.HasKey(e => new { e.OwnerUserNo, e.ObtainItemNo }).HasName("PkTblTradeCompanyObtainItem"); });

    modelBuilder.Entity<TblTradeGroupList>(entity => { entity.HasKey(e => new { e.OwnerUserNo, e.TradeGroupIndex }).HasName("PkTblTradeGroupList"); });

    modelBuilder.Entity<TblTroller>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ContentsType })
            .HasName("PkTblTroller")
            .IsClustered(false);

      entity.Property(e => e.UserNo).HasComment("게임내 고유 유저번호");
      entity.Property(e => e.ContentsType).HasComment("컨텐츠 타입");
      entity.Property(e => e.BannedTime).HasComment("밴 시간");
      entity.Property(e => e.ReportStack).HasComment("신고 당한 횟수");
    });

    modelBuilder.Entity<TblTutorial>(entity => {
      entity.HasKey(e => new { e.UserNo, e.Type })
            .HasName("PkTblTutorial")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblTutorialCharacterInfo>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblTutorialCharacterInfo");

      entity.Property(e => e.UserNo).HasDefaultValueSql("((-1))");
    });

    modelBuilder.Entity<TblUserEnchantStackInfo>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblUserEnchantStackSlotInfo")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblUserEnchantStackSlot>(entity => { entity.HasKey(e => new { e.UserNo, e.SlotNo }).HasName("PkTblUserEnchantStackSlot"); });

    modelBuilder.Entity<TblUserGameOptionType>(entity => {
      entity.HasKey(e => new { e.UserNo, e.GameOptionType }).HasName("PkTblUserGameOptionType");

      entity.Property(e => e.GameOptionValue).HasDefaultValueSql("('')");
    });

    modelBuilder.Entity<TblUserItemLoan>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ItemKey, e.EnchantLevel }).HasName("PkTblUserItemLoan");

      entity.ToTable("TblUserItemLoan", "PaGamePrivate", tb => tb.HasComment("유저의 아이템 반납 정보"));

      entity.Property(e => e.UserNo).HasComment("게임내 고유 유저번호");
      entity.Property(e => e.ItemKey).HasComment("아이템 키");
      entity.Property(e => e.EnchantLevel).HasComment("인챈트 레벨");
      entity.Property(e => e.Count).HasComment("개수");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록 시간");
    });

    modelBuilder.Entity<TblUserItemLoanLog>(entity => {
      entity.HasKey(e => new { e.RegisterDate, e.UserNo, e.ItemNo, e.ItemKey }).HasName("PKTblUserItemLoanLog");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblUserLanguage>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PKTblUserLanguage");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblUserNpcCustomizing>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("pkTblUserNpcCustomizing");

      entity.Property(e => e.CharacterNo).ValueGeneratedNever();
      entity.Property(e => e.Expression).HasDefaultValueSql("(0x0064)");
    });

    modelBuilder.Entity<TblUserProfileInfo>(entity => {
      entity.HasKey(e => new { e.DateInitTerm, e.UserNo })
            .HasName("PkTblUserProfileInfo")
            .IsClustered(false);

      entity.ToTable("TblUserProfileInfo", "PaGamePrivate", tb => tb.HasComment("유저 프로파일"));

      entity.Property(e => e.DateInitTerm).HasComment("프로파일 날짜 초기화 간격");
      entity.Property(e => e.UserNo).HasComment("게임내 고유 유저번호");
      entity.Property(e => e.IsRewardGain1).HasComment("몬스터 킬 수로 아이템 획득");
      entity.Property(e => e.IsRewardGain2).HasComment("낚시 성공으로 아이템 획득");
      entity.Property(e => e.IsRewardGain3).HasComment("아이템 획득으로 아이템 획득");
      entity.Property(e => e.IsRewardGain4).HasComment("제작 성공으로 아이템 획득");
      entity.Property(e => e.NextInitDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("초기화 될 시간");
      entity.Property(e => e.UpdateDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("업데이트 시간");
      entity.Property(e => e.Value1).HasComment("몬스터 킬 수");
      entity.Property(e => e.Value2).HasComment("낚시 성공 횟수");
      entity.Property(e => e.Value3).HasComment("아이템 획득 횟수");
      entity.Property(e => e.Value4).HasComment("제작 성공 횟수");
    });

    modelBuilder.Entity<TblUserSeasonState>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblTblUserSeasonState")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblUserSocialActionConfig>(entity => {
      entity.HasKey(e => new { e.UserNo, e.SocialActionKey, e.Type }).HasName("PkTblUserSocialActionConfig");

      entity.ToTable("TblUserSocialActionConfig", "PaGamePrivate", tb => tb.HasComment("유저를 위한 소셜액션 키워드 변경정보"));

      entity.Property(e => e.UserNo).HasComment("게임내 고유 유저번호");
      entity.Property(e => e.SocialActionKey).HasComment("소셜액션 키");
      entity.Property(e => e.Type).HasComment("타입(0:명령어,1:구문분석용)");
      entity.Property(e => e.Data)
            .HasDefaultValueSql("('')")
            .HasComment("저장된 데이터");
    });

    modelBuilder.Entity<TblUserUsePearlForCashProduct>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblUserUsePearlForCashProductt")
            .IsClustered(false);

      entity.Property(e => e.UserNo)
            .ValueGeneratedNever()
            .HasComment("게임내 고유 유저번호");
      entity.Property(e => e.StampCount).HasComment("현재 스탬프 카운트");
    });

    modelBuilder.Entity<TblUsingHiredNpc>(entity => {
      entity.HasKey(e => e.ActorKey).HasName("PkTblUsingHiredNpc");

      entity.ToTable("TblUsingHiredNpc", "PaGamePrivate", tb => tb.HasComment("고용되어 사용중인 Npc"));

      entity.Property(e => e.ActorKey)
            .ValueGeneratedNever()
            .HasComment("액터키");
      entity.Property(e => e.CharacterKey).HasComment("캐릭터키");
      entity.Property(e => e.CharacterNo).HasComment("소유 캐릭터번호");
      entity.Property(e => e.ExpiredTime).HasComment("만료일");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
    });

    modelBuilder.Entity<TblVendingMachine>(entity => { entity.HasKey(e => new { e.InstallationNo, e.VendingIndex }).HasName("PkTblVendingMachine"); });

    modelBuilder.Entity<TblVendorTempVirtualItemList>(entity => {
      entity.ToTable("TblVendorTempVirtualItemList", "PaGamePrivate", tb => tb.HasComment("집이 기간 만료 후 남아있는 자판기 및 위탁판매용 아이템 임시 저장소"));

      entity.Property(e => e.Count).HasComment("수량");
      entity.Property(e => e.EnchantLevel).HasComment("강화레벨");
      entity.Property(e => e.IsStackable).HasComment("스택여부");
      entity.Property(e => e.ItemKey).HasComment("아이템키");
      entity.Property(e => e.TownRegionKey).HasComment("지역키");
      entity.Property(e => e.UserNo).HasComment("유저번호");
    });

    modelBuilder.Entity<TblVote>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblVote");

      entity.ToTable("TblVote", "PaGamePrivate", tb => tb.HasComment("투표 테이블"));

      entity.Property(e => e.UserNo)
            .ValueGeneratedNever()
            .HasComment("투표한 자신");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("등록일");
      entity.Property(e => e.ToCharacterNo).HasComment("후보자 캐릭터번호");
    });

    modelBuilder.Entity<TblWantedList>(entity => {
      entity.HasKey(e => e.CharacterNo).HasName("PkTblWantedList");

      entity.Property(e => e.CharacterNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblWarehouseSlotCount>(entity => {
      entity.HasKey(e => new { e.UserNo, e.RegionKey }).HasName("PkTblWarehouseSlotCount");

      entity.ToTable("TblWarehouseSlotCount", "PaGamePrivate", tb => tb.HasComment("창고 확장 슬롯 수 저장"));

      entity.Property(e => e.UserNo).HasComment("유저번호");
      entity.Property(e => e.RegionKey).HasComment("지역키");
      entity.Property(e => e.SlotCount).HasComment("슬롯 추가 갯수(아이템 사용)");
    });

    modelBuilder.Entity<TblWarningItemList>(entity => {
      entity.HasKey(e => new { e.ItemKey, e.EnchantLevel }).HasName("PkTblWarningItemList");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWarningItemMailList>(entity => {
      entity.Property(e => e.MailRequestNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWeatherDynamicFactor>(entity => {
      entity.ToTable("TblWeatherDynamicFactor", "PaGamePrivate", tb => tb.HasComment("날씨 동적 요소"));

      entity.Property(e => e.AirPress).HasComment("기압");
      entity.Property(e => e.CloudRate).HasComment("구름비율(운량)");
      entity.Property(e => e.Direction).HasComment("방향");
      entity.Property(e => e.LastUpdateDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("마지막 수정일시");
      entity.Property(e => e.PositionX).HasComment("_positionX");
      entity.Property(e => e.PositionY).HasComment("_positionY");
      entity.Property(e => e.PositionZ).HasComment("_positionZ");
      entity.Property(e => e.RadiusMax).HasComment("최대반경");
      entity.Property(e => e.RadiusMin).HasComment("최소반경");
      entity.Property(e => e.RainAmount).HasComment("강수량");
      entity.Property(e => e.Speed).HasComment("속도");
    });

    modelBuilder.Entity<TblWeatherFactor>(entity => {
      entity.HasKey(e => new { e.SlotNo, e.SectorX, e.SectorZ }).HasName("PkTblWeatherFactor");

      entity.ToTable("TblWeatherFactor", "PaGamePrivate", tb => tb.HasComment("날씨 요소"));

      entity.Property(e => e.SlotNo).HasComment("슬롯번호");
      entity.Property(e => e.SectorX).HasComment("_sectorX");
      entity.Property(e => e.SectorZ).HasComment("_sectorZ");
      entity.Property(e => e.Celsius).HasComment("섭씨");
      entity.Property(e => e.Grass).HasComment("잔디");
      entity.Property(e => e.Humidity).HasComment("습기");
      entity.Property(e => e.LastUpdateDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("마지막 수정일시");
      entity.Property(e => e.Oil).HasComment("기름");
      entity.Property(e => e.Water).HasComment("물");
    });

    modelBuilder.Entity<TblWebBenefit>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblWebContentsOption>(entity => { entity.HasKey(e => e.Type).HasName("PkTblWebContentsOption"); });

    modelBuilder.Entity<TblWindDirection>(entity => { entity.Property(e => e.LastUpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblWorker>(entity => {
      entity.HasKey(e => e.WorkerNo)
            .HasName("PkTblWorker")
            .IsClustered(false);

      entity.ToTable("TblWorker", "PaGamePrivate", tb => tb.HasComment("일꾼"));

      entity.Property(e => e.WorkerNo).HasComment("_workerNo");
      entity.Property(e => e.ActionPoint)
            .HasDefaultValueSql("((0))")
            .HasComment("작업 가능 횟수(NULL무제한, 0 행동력소모)");
      entity.Property(e => e.ActionPointMax)
            .HasDefaultValueSql("((0))")
            .HasComment("작업 가능 최대횟수(NULL무제한, 0 행동력소모)");
      entity.Property(e => e.CharacterKey).HasComment("_characterKey");
      entity.Property(e => e.DeleteDate).HasComment("삭제여부");
      entity.Property(e => e.Experience).HasComment("현재 경험치");
      entity.Property(e => e.HomePlantKey).HasComment("마을(살고 있는 곳)의 PlantKey");
      entity.Property(e => e.IsAuctionInsert).HasComment("거래소 등록 여부");
      entity.Property(e => e.Level).HasComment("일꾼의 레벨");
      entity.Property(e => e.Luck).HasComment("일꾼의 추가 행운");
      entity.Property(e => e.MoveSpeed).HasComment("일꾼의 추가 이동속도");
      entity.Property(e => e.OwnerUserNo).HasComment("소유 사용자번호");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
      entity.Property(e => e.SkillKey0).HasComment("일꾼의 스킬0");
      entity.Property(e => e.SkillKey1).HasComment("일꾼의 스킬1");
      entity.Property(e => e.SkillKey2).HasComment("일꾼의 스킬2");
      entity.Property(e => e.SkillKey3).HasComment("일꾼의 스킬3");
      entity.Property(e => e.SkillKey4).HasComment("일꾼의 스킬4");
      entity.Property(e => e.SkillKey5).HasComment("일꾼의 스킬5");
      entity.Property(e => e.SkillKey6).HasComment("일꾼의 스킬6");
      entity.Property(e => e.UpgradePoint).HasComment("승급가능 횟수");
      entity.Property(e => e.WorkEfficience).HasComment("일꾼의 추가 효율");
    });

    modelBuilder.Entity<TblWorkerWorking>(entity => {
      entity.HasKey(e => e.WorkerNo).HasName("PkTblWorkerWorking");

      entity.ToTable("TblWorkerWorking", "PaGamePrivate", tb => tb.HasComment("일꾼 작업"));

      entity.Property(e => e.WorkerNo)
            .ValueGeneratedNever()
            .HasComment("_workerNo");
      entity.Property(e => e.EnchantLevel)
            .HasDefaultValueSql("((255))")
            .HasComment("개량할 아이템종류의 enchantLevel(_workingType에 따라서 가변적임)");
      entity.Property(e => e.Endurance).HasComment("개량할 아이템의 내구도");
      entity.Property(e => e.ExchangeKey).HasComment("할일(전출의 경우 키 지정없음)");
      entity.Property(e => e.InstallationNo).HasComment("집에서 제작하는 경우 사용할 (설치된)주설비의 번호");
      entity.Property(e => e.LeftCount).HasComment("남은 작업회수");
      entity.Property(e => e.LuckProductivityLevel).HasComment("운 생산 효율 레벨");
      entity.Property(e => e.MaxEndurance).HasComment("개량할 아이템의 최대 내구도");
      entity.Property(e => e.ProductivityLevel).HasComment("생산 효율 레벨");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("작업시작시간");
      entity.Property(e => e.ServerNo).HasComment("서버번호");
      entity.Property(e => e.StateChangeTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("일상태 변경시간");
      entity.Property(e => e.ToPlantDynamicKey).HasComment("목적지가 동적 플랜트일경우 추가키");
      entity.Property(e => e.ToPlantKey).HasComment("목적지(=작업할 물건이 있는 곳)");
      entity.Property(e => e.ToVariable).HasComment("목적지 정보(_workingType에 따라서 가변적임)");
      entity.Property(e => e.WorkingState)
            .HasDefaultValueSql("((-1))")
            .HasComment("일의 상태");
      entity.Property(e => e.WorkingType).HasComment("OdbcNpcWorkingType 와 연결됨.");
      entity.Property(e => e.WorkingVariable).HasComment("작업내역 정보(_workingType에 따라서 가변적임)");
      entity.Property(e => e.WorkingVariable2).HasComment("작업내역 정보2(_workingType에 따라서 가변적임)");
    });

    modelBuilder.Entity<TblWorldBoss>(entity => {
      entity.HasKey(e => e.CharacterKey).HasName("PkTblWorldBoss");

      entity.Property(e => e.CharacterKey).ValueGeneratedNever();
      entity.Property(e => e.UpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWorldMarketCurrentPrice>(entity => {
      entity.HasKey(e => new { e.MainKey, e.SubKey })
            .HasName("PkTblWorldMarketCurrentPrice")
            .IsClustered(false);

      entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWorldMarketPayloadGameDb>(entity => {
      entity.HasKey(e => e.Payload)
            .HasName("PkTblWorldMarketPayroad")
            .IsClustered(false);

      entity.Property(e => e.Payload).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWorldMarketPayloadGameDbOld>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("(getdate())"); });

    modelBuilder.Entity<TblWorldMarketTicket>(entity => {
      entity.HasKey(e => new { e.UserNo, e.Type })
            .HasName("PkTblWorldMarketTicket")
            .IsClustered(false);

      entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWorldQuestLimit>(entity => { entity.HasKey(e => new { e.QuestGroupNo, e.QuestNo }).HasName("PkTblWorldQuestLimit"); });

    modelBuilder.Entity<TblXboxCashInfo>(entity => {
      entity.HasKey(e => new { e.AccountNo, e.LegacyProductId })
            .HasName("PkTblXBoxCashInfo")
            .IsClustered(false);

      entity.ToTable("TblXBoxCashInfo", "PaGamePrivate", tb => tb.HasComment("캐쉬정보"));

      entity.Property(e => e.AccountNo).HasComment("계정 번호");
      entity.Property(e => e.LegacyProductId).HasComment("상품 넘버");
      entity.Property(e => e.ConsumeCount).HasComment("사용한 상품 개수 (누적 수량, remarks 참고)");
      entity.Property(e => e.ProductCount).HasComment("xbox 에서 구매한 상품 개수 (누적 수량, remarks 참고)");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("생성일");
    });

    modelBuilder.Entity<TblXboxCashInfoLog>(entity => {
      entity.Property(e => e.LogNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    OnModelCreatingPartial(modelBuilder);
  }

  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}