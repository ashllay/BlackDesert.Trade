using BlackDesert.Trade.Db.Entities.WorldEntities;

namespace BlackDesert.Trade.Domain.DB.Context;

public partial class WorldDbContext : DbContext
{
  public WorldDbContext() { }

  public WorldDbContext(DbContextOptions<WorldDbContext> options)
    : base(options) { }

  public virtual DbSet<TblAccessibleServerInformation> TblAccessibleServerInformations { get; set; }

  public virtual DbSet<TblAdminCommandType> TblAdminCommandTypes { get; set; }

  public virtual DbSet<TblBlockChatByUserHistory> TblBlockChatByUserHistories { get; set; }

  public virtual DbSet<TblBlockHistory> TblBlockHistories { get; set; }

  public virtual DbSet<TblBlockType> TblBlockTypes { get; set; }

  public virtual DbSet<TblBlockedIp> TblBlockedIps { get; set; }

  public virtual DbSet<TblBlockedUser> TblBlockedUsers { get; set; }

  public virtual DbSet<TblBlockedUserForPublisher> TblBlockedUserForPublishers { get; set; }

  public virtual DbSet<TblBriefCharacterInformation> TblBriefCharacterInformations { get; set; }

  public virtual DbSet<TblChannelChatBlockInfo> TblChannelChatBlockInfos { get; set; }

  public virtual DbSet<TblCharacterName> TblCharacterNames { get; set; }

  public virtual DbSet<TblCommandInfo> TblCommandInfos { get; set; }

  public virtual DbSet<TblCommonTime> TblCommonTimes { get; set; }

  public virtual DbSet<TblContentsOptionsLog> TblContentsOptionsLogs { get; set; }

  public virtual DbSet<TblContentsOptionsNewList> TblContentsOptionsNewLists { get; set; }

  public virtual DbSet<TblContentsOptionsOldList> TblContentsOptionsOldLists { get; set; }

  public virtual DbSet<TblCurrentInformation> TblCurrentInformations { get; set; }

  public virtual DbSet<TblFoolsDayEvent> TblFoolsDayEvents { get; set; }

  public virtual DbSet<TblGuildName> TblGuildNames { get; set; }

  public virtual DbSet<TblHijack> TblHijacks { get; set; }

  public virtual DbSet<TblIpblockHistory> TblIpblockHistories { get; set; }

  public virtual DbSet<TblLoveDonateEvent> TblLoveDonateEvents { get; set; }

  public virtual DbSet<TblMacAddressLock> TblMacAddressLocks { get; set; }

  public virtual DbSet<TblMacAddressLog> TblMacAddressLogs { get; set; }

  public virtual DbSet<TblNameChange> TblNameChanges { get; set; }

  public virtual DbSet<TblNameChangeFailLogInWorld> TblNameChangeFailLogInWorlds { get; set; }

  public virtual DbSet<TblNameExchange> TblNameExchanges { get; set; }

  public virtual DbSet<TblOperationMention> TblOperationMentions { get; set; }

  public virtual DbSet<TblOperationTicket> TblOperationTickets { get; set; }

  public virtual DbSet<TblOperationTicketV3> TblOperationTicketV3s { get; set; }

  public virtual DbSet<TblPcroomGateWayList> TblPcroomGateWayLists { get; set; }

  public virtual DbSet<TblPcroomLoginList> TblPcroomLoginLists { get; set; }

  public virtual DbSet<TblPcroomRequestList> TblPcroomRequestLists { get; set; }

  public virtual DbSet<TblProhibitedWord> TblProhibitedWords { get; set; }

  public virtual DbSet<TblPs4accessTokenList> TblPs4accessTokenLists { get; set; }

  public virtual DbSet<TblPs4cashConsumeLog> TblPs4cashConsumeLogs { get; set; }

  public virtual DbSet<TblPs4cashInfoWorld> TblPs4cashInfoWorlds { get; set; }

  public virtual DbSet<TblPs4cashProductAndItemMapping> TblPs4cashProductAndItemMappings { get; set; }

  public virtual DbSet<TblPs4cashProductRefundInfo> TblPs4cashProductRefundInfos { get; set; }

  public virtual DbSet<TblPs4devAccessUserList> TblPs4devAccessUserLists { get; set; }

  public virtual DbSet<TblPs4entitlementHistory> TblPs4entitlementHistories { get; set; }

  public virtual DbSet<TblPs4refundHistory> TblPs4refundHistories { get; set; }

  public virtual DbSet<TblRecommandUserNickName> TblRecommandUserNickNames { get; set; }

  public virtual DbSet<TblReplaceSubItemGroup> TblReplaceSubItemGroups { get; set; }

  public virtual DbSet<TblReportedNegativeUser> TblReportedNegativeUsers { get; set; }

  public virtual DbSet<TblRoleGroup> TblRoleGroups { get; set; }

  public virtual DbSet<TblRoleGroupMember> TblRoleGroupMembers { get; set; }

  public virtual DbSet<TblRoleGroupMemberLoginIpOasis> TblRoleGroupMemberLoginIpOases { get; set; }

  public virtual DbSet<TblRoleGroupMemberOasis> TblRoleGroupMemberOases { get; set; }

  public virtual DbSet<TblRoleGroupName> TblRoleGroupNames { get; set; }

  public virtual DbSet<TblRoleGroupNameOasis> TblRoleGroupNameOases { get; set; }

  public virtual DbSet<TblRoleGroupOasis> TblRoleGroupOases { get; set; }

  public virtual DbSet<TblRoleList> TblRoleLists { get; set; }

  public virtual DbSet<TblRoleListOasis> TblRoleListOases { get; set; }

  public virtual DbSet<TblServerChannelChatInformation> TblServerChannelChatInformations { get; set; }

  public virtual DbSet<TblServerDataCrc> TblServerDataCrcs { get; set; }

  public virtual DbSet<TblServerExpPreset> TblServerExpPresets { get; set; }

  public virtual DbSet<TblServerFamilyInformation> TblServerFamilyInformations { get; set; }

  public virtual DbSet<TblServerGroup> TblServerGroups { get; set; }

  public virtual DbSet<TblServerInformation> TblServerInformations { get; set; }

  public virtual DbSet<TblServerInformationPreset> TblServerInformationPresets { get; set; }

  public virtual DbSet<TblServerInstanceFieldInformation> TblServerInstanceFieldInformations { get; set; }

  public virtual DbSet<TblShaRegistedUserYesterday> TblShaRegistedUserYesterdays { get; set; }

  public virtual DbSet<TblStatementTemp> TblStatementTemps { get; set; }

  public virtual DbSet<TblTeenageUserInformation> TblTeenageUserInformations { get; set; }

  public virtual DbSet<TblTradeAuthKey> TblTradeAuthKeys { get; set; }

  public virtual DbSet<TblTradeAuthKeyHistory> TblTradeAuthKeyHistories { get; set; }

  public virtual DbSet<TblTransferAccountBuffUserList> TblTransferAccountBuffUserLists { get; set; }

  public virtual DbSet<TblTranslationReport> TblTranslationReports { get; set; }

  public virtual DbSet<TblTranslationReportRecommendHistory> TblTranslationReportRecommendHistories { get; set; }

  public virtual DbSet<TblUniqueName> TblUniqueNames { get; set; }

  public virtual DbSet<TblUniqueNameBackup> TblUniqueNameBackups { get; set; }

  public virtual DbSet<TblUserCache> TblUserCaches { get; set; }

  public virtual DbSet<TblUserChattingMacro> TblUserChattingMacros { get; set; }

  public virtual DbSet<TblUserEtcInformation> TblUserEtcInformations { get; set; }

  public virtual DbSet<TblUserGameOption> TblUserGameOptions { get; set; }

  public virtual DbSet<TblUserInformation> TblUserInformations { get; set; }

  public virtual DbSet<TblUserNickNameModStr> TblUserNickNameModStrs { get; set; }

  public virtual DbSet<TblUserUiinfomation> TblUserUiinfomations { get; set; }

  public virtual DbSet<TblValidServerInformation> TblValidServerInformations { get; set; }

  public virtual DbSet<TblXboxCashInfoWorld> TblXboxCashInfoWorlds { get; set; }

  public virtual DbSet<TblXboxCashProductAndItemMapping> TblXboxCashProductAndItemMappings { get; set; }

  public virtual DbSet<TblXboxCashProductRefundInfo> TblXboxCashProductRefundInfos { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    optionsBuilder.UseSqlServer(DbConnectionContainer.This.ConnectionStrings.World);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    modelBuilder.Entity<TblAccessibleServerInformation>(entity => {
      entity.ToTable("TblAccessibleServerInformation", "PaGamePrivate", tb => tb.HasComment("유저별 접속가능한 게임서버(채널번호)"));

      entity.Property(e => e.IsWorking).HasComment("작업중 이라서 이곳으로 접속 가능");
      entity.Property(e => e.MoveableSpecialChannelTime).HasComment("이 시간이 지나야 특수 채널 이동을 할 수 있다");
      entity.Property(e => e.MoveableTime).HasComment("이 시간이 지나야 채널 이동을 할 수 있다");
      entity.Property(e => e.ServerGroupNo).HasDefaultValueSql("((0))");
      entity.Property(e => e.ServerNo).HasComment("서버 번호(채널)");
      entity.Property(e => e.UserNo).HasComment("유저 번호");
      entity.Property(e => e.WorldNo).HasComment("월드 번호");
    });

    modelBuilder.Entity<TblAdminCommandType>(entity => {
      entity.HasKey(e => e.CommandTypeNo)
            .HasName("PkTblAdminCommandType")
            .IsClustered(false);

      entity.Property(e => e.CommandTypeNo).ValueGeneratedNever();
      entity.Property(e => e.ParamCount).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblBlockChatByUserHistory>(entity => {
      entity.HasKey(e => e.BlockNo)
            .HasName("PkTblBlockChatByUserHistory")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblBlockHistory>(entity => { entity.HasKey(e => e.HistoryNo).HasName("PK__TblBlock__491844CEE05FE8BF"); });

    modelBuilder.Entity<TblBlockType>(entity => {
      entity.HasKey(e => e.BlockCode)
            .HasName("PkTblBlockType")
            .IsClustered(false);

      entity.Property(e => e.BlockCode).ValueGeneratedNever();
      entity.Property(e => e.Index).ValueGeneratedOnAdd();
      entity.Property(e => e.IsUse).HasDefaultValueSql("((1))");
      entity.Property(e => e.Memo).HasDefaultValueSql("(N'')");
    });

    modelBuilder.Entity<TblBlockedIp>(entity => {
      entity.HasKey(e => e.BlockNo)
            .HasName("PkTblBlockedIP")
            .IsClustered(false);

      entity.ToTable("TblBlockedIP", "PaGamePrivate", tb => tb.HasComment("IP 블록 테이블"));

      entity.Property(e => e.BlockNo).HasComment("블록 고유 번호");
      entity.Property(e => e.BigintEndIp).HasComment("IP 대역 시작점 BIGINT형");
      entity.Property(e => e.BigintStartIp).HasComment("IP 대역 시작점 BIGINT형");
      entity.Property(e => e.BlockCode).HasComment("블록 사유 코드");
      entity.Property(e => e.EndIp).HasComment("IP 대역 시작점 NVARCHAR형");
      entity.Property(e => e.OperationMemo).HasComment("블록 운영자 메모");
      entity.Property(e => e.RegisterDate).HasComment("등록 시간");
      entity.Property(e => e.StartIp).HasComment("IP 대역 시작점 NVARCHAR형");
    });

    modelBuilder.Entity<TblBlockedUser>(entity => {
      entity.HasKey(e => e.BlockNo)
            .HasName("PkTblBlockedUser")
            .IsClustered(false);

      entity.ToTable("TblBlockedUser", "PaGamePrivate", tb => tb.HasComment("운영 관련 그룹의 역할 테이블"));

      entity.Property(e => e.BlockNo).HasComment("블록 고유 번호");
      entity.Property(e => e.BlockCode).HasComment("블록 사유 코드");
      entity.Property(e => e.EndDate).HasComment("블록 종료 시간");
      entity.Property(e => e.OperationMemo).HasComment("블록 운영자 메모");
      entity.Property(e => e.RegisterDate).HasComment("블록 등록 시간");
      entity.Property(e => e.UserNo).HasComment("블록 유저 번호");
    });

    modelBuilder.Entity<TblBlockedUserForPublisher>(entity => {
      entity.HasKey(e => new { e.UserNo, e.BlockType })
            .HasName("PkTblBlockedUserForPublisher")
            .IsClustered(false);

      entity.ToTable("TblBlockedUserForPublisher", "PaGamePrivate", tb => tb.HasComment("북미 블록 유저 테이블"));

      entity.Property(e => e.UserNo).HasComment("유저 넘버");
      entity.Property(e => e.BlockType).HasComment("블록 타입");
      entity.Property(e => e.BlockCode).HasComment("블록 코드");
      entity.Property(e => e.BlockDuration).HasComment("블록 종료 시간");
      entity.Property(e => e.BlockNo)
            .ValueGeneratedOnAdd()
            .HasComment("블록 고유 번호");
      entity.Property(e => e.CharacterName).HasComment("유저 이름");
      entity.Property(e => e.OperationMemo).HasComment("블록 사유");
      entity.Property(e => e.RegisterDate).HasComment("블록 등록 시간");
      entity.Property(e => e.ServerNo).HasComment("북미 서버 넘버");
    });

    modelBuilder.Entity<TblBriefCharacterInformation>(entity => {
      entity.HasKey(e => new { e.CharacterNo, e.UserNo, e.WorldNo })
            .HasName("PkTblBriefCharacterInformation")
            .IsClustered(false);

      entity.ToTable("TblBriefCharacterInformation", "PaGamePrivate", tb => tb.HasComment("캐릭터 요약정보"));

      entity.Property(e => e.CharacterNo).HasComment("캐릭터 번호");
      entity.Property(e => e.UserNo).HasComment("유저 번호");
      entity.Property(e => e.WorldNo).HasComment("월드 번호");
      entity.Property(e => e.AffiliatedTerritoryKey).HasComment("소속영지");
      entity.Property(e => e.CharacterName).HasComment("캐릭터 명");
      entity.Property(e => e.ClassType).HasComment("클래스");
      entity.Property(e => e.CreateDate).HasComment("생성일");
      entity.Property(e => e.DeletedDate).HasComment("삭제일");
      entity.Property(e => e.IsMain).HasComment("메인 캐릭터여부");
      entity.Property(e => e.IsValid)
            .HasDefaultValueSql("((1))")
            .HasComment("참인 경우에만 선택할 수 있는 캐릭터");
      entity.Property(e => e.LastLoginTime).HasComment("최종 로그인");
      entity.Property(e => e.LastLogoutTime).HasComment("최종 로그아웃");
      entity.Property(e => e.Level).HasComment("레벨");
      entity.Property(e => e.TotalPlayTime).HasComment("총 플레이시간(분)");
    });

    modelBuilder.Entity<TblChannelChatBlockInfo>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblChannelChatBlockInfo");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.AvailableBlockCount).HasDefaultValueSql("((5))");
      entity.Property(e => e.BlockedCount).HasDefaultValueSql("((0))");
      entity.Property(e => e.ChannelJoinBlockEndTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ChattingBlockEndTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblCommandInfo>(entity => {
      entity.HasKey(e => e.CommandNo)
            .HasName("PkTblCommandInfo")
            .IsClustered(false);

      entity.Property(e => e.EndDate).HasDefaultValueSql("(dateadd(day,(7),[PaGamePublic].[ufnGetCustomDatetime]()))");
      entity.Property(e => e.Interval).HasDefaultValueSql("((0))");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ReserveDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ServerNo).HasDefaultValueSql("((-1))");
    });

    modelBuilder.Entity<TblCommonTime>(entity => {
      entity.HasKey(e => e.WorldNo).HasName("PkTblCommonTime");

      entity.ToTable("TblCommonTime", "PaGamePrivate", tb => tb.HasComment("시간 테이블"));

      entity.Property(e => e.WorldNo).ValueGeneratedNever();
      entity.Property(e => e.CumulatedTick).HasComment("서버 누적 시간(서버가 켜진 상태에서만 누적됨)");
      entity.Property(e => e.LastUpdateTime).HasComment("서버의 마지막 업데이트 시간");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("_registerDate");
      entity.Property(e => e.ServerOpenTime).HasComment("서버가 켜진 시간");
    });

    modelBuilder.Entity<TblContentsOptionsLog>(entity => { entity.HasKey(e => new { e.ProcessTime, e.ContentsOptionKey }).HasName("PkTblContentsOptionsLog"); });

    modelBuilder.Entity<TblContentsOptionsNewList>(entity => {
      entity.HasKey(e => e.ContentsOptionKey).HasName("PkTblContentsOptionsNewList");

      entity.Property(e => e.ContentsOptionKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblContentsOptionsOldList>(entity => {
      entity.HasKey(e => e.ContentsOptionKey).HasName("PkTblContentsOptionsOldList");

      entity.Property(e => e.ContentsOptionKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblCurrentInformation>(entity => {
      entity.HasKey(e => new { e.WorldNo, e.ServerNo, e.UpdatedDate }).HasName("PkTblCurrentInformation");

      entity.ToTable("TblCurrentInformation", "PaGamePrivate", tb => tb.HasComment("현재정보"));

      entity.Property(e => e.WorldNo).HasComment("월드번호");
      entity.Property(e => e.ServerNo).HasComment("서버번호");
      entity.Property(e => e.UpdatedDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("수정시간");
      entity.Property(e => e.BusySessionCount).HasComment("사용중인 세션수");
      entity.Property(e => e.LoginningUserCount).HasComment("ID PW는 맞는데 아직 필드 진입하지 않은 수");
      entity.Property(e => e.PlayingUserCount).HasComment("플레이중인 이용자 수");
      entity.Property(e => e.TotalSessionCount).HasComment("총세션수");
    });

    modelBuilder.Entity<TblFoolsDayEvent>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblHijack>(entity => {
      entity.HasKey(e => new { e.AdminUserNo, e.HijackUserNo }).HasName("PK__TblHijac__1D09636FBF41C6BA");

      entity.Property(e => e.AdminUserNo).HasComment("_adminUserNo");
      entity.Property(e => e.HijackUserNo).HasComment("_hijackUserNo");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblIpblockHistory>(entity => {
      entity.HasKey(e => e.BlockNo)
            .HasName("PkTblIPBlockHistory")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblLoveDonateEvent>(entity => { entity.Property(e => e.EventNo).HasDefaultValueSql("((1))"); });

    modelBuilder.Entity<TblMacAddressLock>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PK__TblMacAd__D84CDD5F18135269");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblMacAddressLog>(entity => {
      entity.HasKey(e => e.RecordId).HasName("PK__TblMacAd__2508F51DED736BF9");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("(getdate())");
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

    modelBuilder.Entity<TblNameExchange>(entity => {
      entity.HasKey(e => e.OwnerNo)
            .HasName("PkTblNameExchange")
            .IsClustered(false);

      entity.Property(e => e.OwnerNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblOperationMention>(entity => {
      entity.HasKey(e => e.MentionNo)
            .HasName("PkTblOperationMention")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblOperationTicket>(entity => {
      entity.HasKey(e => e.TicketNo)
            .HasName("PkTblOperationTicket")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblOperationTicketV3>(entity => {
      entity.HasKey(e => e.TicketNo)
            .HasName("PkTblOperationTicket_v3")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPcroomGateWayList>(entity => {
      entity.HasKey(e => e.GatewayServerNo).HasName("PkTblPCRoomGateWayList");

      entity.Property(e => e.LastUpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPcroomLoginList>(entity => {
      entity.Property(e => e.GussUpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.IngameUpdateDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPcroomRequestList>(entity => {
      entity.Property(e => e.DoState).HasDefaultValueSql("((0))");
      entity.Property(e => e.RegistDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblProhibitedWord>(entity => {
      entity.HasKey(e => e.ProhibitedWord)
            .HasName("PkTblProhibitedWord")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPs4accessTokenList>(entity => {
      entity.HasKey(e => e.UserId)
            .HasName("PkTblPS4AccessTokenList")
            .IsClustered(false);

      entity.Property(e => e.AccessToken).HasDefaultValueSql("('')");
      entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPs4cashConsumeLog>(entity => {
      entity.Property(e => e.LogNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPs4cashInfoWorld>(entity => {
      entity.HasKey(e => new { e.UserId, e.EntitlementId })
            .HasName("PkTblPS4CashInfoWorld")
            .IsClustered(false);

      entity.Property(e => e.ActiveDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPs4cashProductAndItemMapping>(entity => {
      entity.HasKey(e => e.EntitlementId)
            .HasName("PkTblPS4CashProductAndItemMapping")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPs4cashProductRefundInfo>(entity => {
      entity.HasKey(e => e.RefundNo)
            .HasName("PkTblPS4CashProductRefundInfo")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPs4devAccessUserList>(entity => {
      entity.HasKey(e => e.TokenKey)
            .HasName("PkTblPS4AccessUserList")
            .IsClustered(false);

      entity.Property(e => e.AccessIp).HasDefaultValueSql("(' ')");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblPs4entitlementHistory>(entity => {
      entity.Property(e => e.Index).ValueGeneratedOnAdd();
      entity.Property(e => e.RegDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UseCount).HasDefaultValueSql("((0))");
      entity.Property(e => e.UseLimit).HasDefaultValueSql("((0))");
    });

    modelBuilder.Entity<TblPs4refundHistory>(entity => {
      entity.Property(e => e.Index).ValueGeneratedOnAdd();
      entity.Property(e => e.RegDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UseCount).HasDefaultValueSql("((0))");
      entity.Property(e => e.UseLimit).HasDefaultValueSql("((0))");
    });

    modelBuilder.Entity<TblRecommandUserNickName>(entity => {
      entity.HasKey(e => e.RecommandNickNameIndex).HasName("PkTblRecommandUserNickName");

      entity.ToTable("TblRecommandUserNickName", "PaGamePrivate", tb => tb.HasComment("가문 생성시 추천 닉네임"));

      entity.Property(e => e.RecommandNickNameIndex).HasComment("추천 닉네임 인덱스");
      entity.Property(e => e.RecommandNickName)
            .HasDefaultValueSql("('')")
            .HasComment("추천 닉네임 스트링");
      entity.Property(e => e.RecommandNickNameId).HasComment("추천 닉네임 뒤에 붙을 고유 ID");
    });

    modelBuilder.Entity<TblReplaceSubItemGroup>(entity => {
      entity.HasKey(e => e.ItemSubGroupKey)
            .HasName("PkTblReplaceSubItemGroup")
            .IsClustered(false);

      entity.ToTable("TblReplaceSubItemGroup", "PaGamePrivate", tb => tb.HasComment("변경할 드랍그룹(일본용)"));

      entity.Property(e => e.ItemSubGroupKey)
            .ValueGeneratedNever()
            .HasComment("아이템드랍엑셀의 서브그룹키(ItemSubGroup_Table)");
      entity.Property(e => e.ItemList).HasComment("아이템목록");
    });

    modelBuilder.Entity<TblReportedNegativeUser>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblRoleGroup>(entity => {
      entity.HasKey(e => new { e.RoleGroupNo, e.RoleNo })
            .HasName("PkTblRoleGroup")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblRoleGroupMember>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblRoleGroupMember")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.IpAddress).HasDefaultValueSql("(' ')");
      entity.Property(e => e.MacAddress).HasDefaultValueSql("(' ')");
    });

    modelBuilder.Entity<TblRoleGroupMemberLoginIpOasis>(entity => {
      entity.HasKey(e => new { e.WhereType, e.WhereNo, e.IpAddress })
            .HasName("PkTblRoleGroupMemberLoginIpOasis")
            .IsClustered(false);

      entity.Property(e => e.IpAddress).HasDefaultValueSql("(' ')");
    });

    modelBuilder.Entity<TblRoleGroupMemberOasis>(entity => {
      entity.HasKey(e => new { e.WhereType, e.WhereNo })
            .HasName("PkTblRoleGroupMemberOasis")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblRoleGroupName>(entity => {
      entity.HasKey(e => e.RoleGroupNo)
            .HasName("PkTblRoleGroupName")
            .IsClustered(false);

      entity.Property(e => e.RoleGroupGrade).HasDefaultValueSql("((100))");
    });

    modelBuilder.Entity<TblRoleGroupNameOasis>(entity => {
      entity.HasKey(e => e.RoleGroupNo)
            .HasName("PkTblRoleGroupNameOasis")
            .IsClustered(false);

      entity.Property(e => e.RoleGroupGrade).HasDefaultValueSql("((100))");
    });

    modelBuilder.Entity<TblRoleGroupOasis>(entity => {
      entity.HasKey(e => new { e.RoleGroupNo, e.RoleNo })
            .HasName("PkTblRoleGroupOasis")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblRoleList>(entity => {
      entity.HasKey(e => e.RoleNo)
            .HasName("PkTblRoleList")
            .IsClustered(false);

      entity.Property(e => e.RoleNo).ValueGeneratedOnAdd();
    });

    modelBuilder.Entity<TblRoleListOasis>(entity => {
      entity.HasKey(e => e.RoleNo)
            .HasName("PkTblRoleListOasis")
            .IsClustered(false);

      entity.Property(e => e.RoleNo).ValueGeneratedOnAdd();
    });

    modelBuilder.Entity<TblServerChannelChatInformation>(entity => {
      entity.HasKey(e => e.RoomNo).HasName("PkTblServerChannelChatInformation");

      entity.Property(e => e.RoomNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblServerDataCrc>(entity => {
      entity.HasKey(e => new { e.ServerVersion, e.ServerDataCrc }).HasName("PkTblServerDataCRC");

      entity.Property(e => e.ServerDataCrc).HasDefaultValueSql("((-1))");
      entity.Property(e => e.RegistDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblServerExpPreset>(entity => {
      entity.HasKey(e => new { e.SavePresetName, e.ServerNo })
            .HasName("PkTblServerExpPreset")
            .IsClustered(false);

      entity.Property(e => e.BattleExpTooltipText).HasDefaultValueSql("('')");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblServerFamilyInformation>(entity => { entity.Property(e => e.IsValid).HasDefaultValueSql("((1))"); });

    modelBuilder.Entity<TblServerGroup>(entity => { entity.Property(e => e.ServerGroup).IsFixedLength(); });

    modelBuilder.Entity<TblServerInformation>(entity => {
      entity.HasKey(e => e.ServerNo)
            .HasName("PkTblServerInformation")
            .IsClustered(false);

      entity.Property(e => e.ServerNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblServerInformationPreset>(entity => {
      entity.HasKey(e => e.PresetName).HasName("PkTblServerInformationPreset");

      entity.Property(e => e.FieldDsn).HasDefaultValueSql("('field1.dsn')");
      entity.Property(e => e.IsInstanceFieldMainServer).HasDefaultValueSql("('')");
      entity.Property(e => e.LogDsn).HasDefaultValueSql("('log1.dsn')");
      entity.Property(e => e.MacAddress).HasDefaultValueSql("('')");
      entity.Property(e => e.MainIp).HasDefaultValueSql("('')");
      entity.Property(e => e.PublicIp).HasDefaultValueSql("('')");
      entity.Property(e => e.RegistDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ServerName).HasDefaultValueSql("(N'None')");
      entity.Property(e => e.ServerType).HasDefaultValueSql("((1))");
      entity.Property(e => e.StartSiegeTerritory).HasDefaultValueSql("((-2))");
      entity.Property(e => e.WorldNo).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblStatementTemp>(entity => { entity.Property(e => e.Idx).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblTeenageUserInformation>(entity => {
      entity.HasKey(e => e.UserId)
            .HasName("PkTblTeenageUserInformation")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblTradeAuthKey>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblTradeAuthKey_userNo")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblTradeAuthKeyHistory>(entity => {
      entity.Property(e => e.HistoryNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblTransferAccountBuffUserList>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblTransferAccountBuffUserList")
            .IsClustered(false);

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblTranslationReport>(entity => {
      entity.HasKey(e => e.ReportNo)
            .HasName("PkTblTranslationReport")
            .IsClustered(false);

      entity.ToTable("TblTranslationReport", "PaGamePrivate", tb => tb.HasComment("번역신고"));

      entity.Property(e => e.ReportNo).HasComment("신고글의 고유 번호");
      entity.Property(e => e.RecommendCount).HasComment("추천수");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("신고일");
      entity.Property(e => e.ServiceResourceType).HasComment("언어 타입");
      entity.Property(e => e.StaticType).HasComment("번역키");
      entity.Property(e => e.TextNo).HasComment("번역키");
      entity.Property(e => e.TranslationKey1).HasComment("번역키");
      entity.Property(e => e.TranslationKey2).HasComment("번역키");
      entity.Property(e => e.TranslationKey3).HasComment("번역키");
      entity.Property(e => e.TranslationText).HasComment("바꾸고자 하는 번역 내용");
      entity.Property(e => e.UserNo).HasComment("유저 번호");
    });

    modelBuilder.Entity<TblTranslationReportRecommendHistory>(entity => {
      entity.HasKey(e => new { e.ReportNo, e.UserNo })
            .HasName("PkTblTranslationReportRecommendHistory")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblUniqueName>(entity => {
      entity.HasKey(e => new { e.Type, e.Name })
            .HasName("PkTblUniqueName")
            .IsClustered(false);

      entity.ToTable("TblUniqueName", "PaGamePrivate", tb => tb.HasComment("유일한 이름"));

      entity.Property(e => e.Type).HasComment("0 캐릭터명,1 길드명, 2 가문명(enum NameType)");
      entity.Property(e => e.Name).HasComment("이름");
      entity.Property(e => e.DeletedDate).HasComment("삭제일");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("생성일");
      entity.Property(e => e.VariousNo).HasComment("해당번호");
      entity.Property(e => e.WorldNo).HasComment("월드번호");
    });

    modelBuilder.Entity<TblUserCache>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblUserCache");

      entity.ToTable("TblUserCache", "PaGamePrivate", tb => tb.HasComment("유저 캐시"));

      entity.Property(e => e.UserNo)
            .ValueGeneratedNever()
            .HasComment("유저");
      entity.Property(e => e.Pack).HasComment("캐시 데이터(pack)");
    });

    modelBuilder.Entity<TblUserChattingMacro>(entity => {
      entity.HasKey(e => new { e.UserNo, e.MacroNo }).HasName("PkTblUserChattingMacro");

      entity.ToTable("TblUserChattingMacro", "PaGamePrivate", tb => tb.HasComment("유저를 위한 채팅 매크로 정보"));

      entity.Property(e => e.UserNo).HasComment("게임내 고유 유저번호");
      entity.Property(e => e.MacroNo).HasComment("매크로 번호");
      entity.Property(e => e.ChatMessage)
            .HasDefaultValueSql("('')")
            .HasComment("채팅 메시지");
      entity.Property(e => e.ChatType).HasComment("채팅 타입");
    });

    modelBuilder.Entity<TblUserEtcInformation>(entity => {
      entity.HasKey(e => e.UserNo)
            .HasName("PkTblUserEtcInformation")
            .IsClustered(false);

      entity.ToTable("TblUserEtcInformation", "PaGamePrivate", tb => tb.HasComment("유저부가정보"));

      entity.Property(e => e.UserNo)
            .ValueGeneratedNever()
            .HasComment("_userNo");
      entity.Property(e => e.ConsoleCrossPlayOption).HasDefaultValueSql("((1))");
      entity.Property(e => e.CpuBrandString).HasComment("_cpuBrandString");
      entity.Property(e => e.GraphicOption).HasComment("_graphicOption");
      entity.Property(e => e.GraphicsAdapterBrandString).HasComment("_graphicsAdapterBrandString");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("생성일");
      entity.Property(e => e.ResoulutionHeight).HasComment("_resoulutionHeight");
      entity.Property(e => e.ResoulutionWidth).HasComment("_resoulutionWidth");
      entity.Property(e => e.TextureQuality).HasComment("_textureQuality");
      entity.Property(e => e.TotalSystemMemory).HasComment("_totalSystemMemory");
    });

    modelBuilder.Entity<TblUserGameOption>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblUserGameOption");

      entity.ToTable("TblUserGameOption", "PaGamePrivate", tb => tb.HasComment("유저를 위한 게임 옵션 정보"));

      entity.Property(e => e.UserNo)
            .ValueGeneratedNever()
            .HasComment("게임내 고유 유저번호");
      entity.Property(e => e.GameOptionSerializedData)
            .HasDefaultValueSql("('')")
            .HasComment("게임 옵션 데이터");
    });

    modelBuilder.Entity<TblUserInformation>(entity => {
      entity.HasKey(e => e.UserNo).IsClustered(false);

      entity.ToTable("TblUserInformation", "PaGamePrivate", tb => tb.HasComment("유저정보"));

      entity.Property(e => e.UserNo).HasComment("_userNo");
      entity.Property(e => e.AccountExpirationDate).HasComment("계정 만료 시간");
      entity.Property(e => e.AtField)
            .HasDefaultValueSql("(left(newid(),(13)))")
            .IsFixedLength();
      entity.Property(e => e.AuthenticExpiration)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("인증유통기한");
      entity.Property(e => e.AuthenticKey).HasComment("인증Key");
      entity.Property(e => e.FailPasswordCount).HasComment("비밀번호 틀린 횟수");
      entity.Property(e => e.IsAccessBlanceChannel)
            .HasDefaultValueSql("((1))")
            .HasComment("밸런스 채널에 접속 가능한가");
      entity.Property(e => e.IsAdmissionToSpeedServer)
            .HasDefaultValueSql("((2))")
            .HasComment("스피드서버 접속 가능 여부");
      entity.Property(e => e.IsAdultWorldUser).HasComment("성인 채널에 접속 한 계정인지");
      entity.Property(e => e.IsGuestAccount).HasComment("게스트 패스");
      entity.Property(e => e.IsIgnoreCheckCustomizeOnly).HasComment("사전생성 기간에도 접속 유무");
      entity.Property(e => e.IsPcRoom).HasComment("피씨방 여부");
      entity.Property(e => e.IsPremiumChannelPermission).HasComment("프리미엄 채널 입장 가능여부");
      entity.Property(e => e.IsValid)
            .HasDefaultValueSql("((1))")
            .HasComment("참인 경우에만 선택할 수 있는 사용자임");
      entity.Property(e => e.LastIp)
            .HasDefaultValueSql("(' ')")
            .HasComment("최근접속IP");
      entity.Property(e => e.LastLoginTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("최근로그인시간");
      entity.Property(e => e.LastLogoutTime)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("최근로그아웃시간");
      entity.Property(e => e.LastServerNo)
            .HasDefaultValueSql("((-1))")
            .HasComment("접속중인 월드번호.=>접속중이 아니면 음수임");
      entity.Property(e => e.MembershipType).HasComment("유저 채널링 정보");
      entity.Property(e => e.Password).HasComment("2차 비밀 번호");
      entity.Property(e => e.PaymentPassword).HasComment("결제 비밀 번호");
      entity.Property(e => e.PreAuthenticKey).HasComment("재접 인증Key");
      entity.Property(e => e.PublisherCryptToken).HasComment("퍼블리셔 토큰 정보");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("생성일");
      entity.Property(e => e.ShutDownTime).HasComment("셧다운 시간");
      entity.Property(e => e.SpeedServerExpiration)
            .HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
            .HasComment("스피드서버 접속 가능 기간");
      entity.Property(e => e.SurveyHwandSw).HasComment("하드웨어와 드라이버 정보");
      entity.Property(e => e.TokenExpireDate).HasDefaultValueSql("(getdate())");
      entity.Property(e => e.TotalPlayTime).HasComment("총 play시간(단위:분)");
      entity.Property(e => e.UserId).HasComment("_userId");
      entity.Property(e => e.UserNickname).HasComment("_userNickname");
    });

    modelBuilder.Entity<TblUserNickNameModStr>(entity => { entity.Property(e => e.Str).IsFixedLength(); });

    modelBuilder.Entity<TblUserUiinfomation>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PkTblUserUIInfomation");

      entity.ToTable("TblUserUIInfomation", "PaGamePrivate", tb => tb.HasComment("탈것 장착 메시 보이기on/off"));

      entity.Property(e => e.UserNo)
            .ValueGeneratedNever()
            .HasComment("게임내 고유 유저번호");
      entity.Property(e => e.AvatarEquipSlotFlag).HasComment("아바타 장착");
      entity.Property(e => e.CamelVehicleEquipFlag).HasComment("낙타 탈것 장비");
      entity.Property(e => e.HorseVehicleEquipFlag).HasComment("말 탈것 장비");
      entity.Property(e => e.IsBattleHelmShow).HasComment("안면 보호대");
      entity.Property(e => e.IsCloakShow)
            .HasDefaultValueSql("((1))")
            .HasComment("망토 보이기 on/off");
    });

    modelBuilder.Entity<TblValidServerInformation>(entity => {
      entity.HasKey(e => e.ServerNo).HasName("PkTblValidServerInformation");

      entity.Property(e => e.ServerNo).ValueGeneratedNever();
      entity.Property(e => e.FieldDsn).HasDefaultValueSql("('field1.dsn')");
      entity.Property(e => e.IsInstanceFieldMainServer).HasDefaultValueSql("('')");
      entity.Property(e => e.LogDsn).HasDefaultValueSql("('log1.dsn')");
      entity.Property(e => e.MacAddress).HasDefaultValueSql("('')");
      entity.Property(e => e.MainIp).HasDefaultValueSql("('')");
      entity.Property(e => e.PublicIp).HasDefaultValueSql("('')");
      entity.Property(e => e.RegistDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ServerName).HasDefaultValueSql("(N'None')");
      entity.Property(e => e.ServerType).HasDefaultValueSql("((1))");
      entity.Property(e => e.StartSiegeTerritory).HasDefaultValueSql("((-2))");
      entity.Property(e => e.WorldNo).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblXboxCashInfoWorld>(entity => {
      entity.HasKey(e => new { e.AccountNo, e.LegacyProductId })
            .HasName("PkTblXboxCashInfoWorld")
            .IsClustered(false);

      entity.Property(e => e.PurchaseCountry).HasDefaultValueSql("('')");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblXboxCashProductAndItemMapping>(entity => {
      entity.HasKey(e => e.LegacyProductId)
            .HasName("PkTblXboxCashProductAndItemMapping")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblXboxCashProductRefundInfo>(entity => {
      entity.HasKey(e => e.RefundNo)
            .HasName("PkTblXboxCashProuctRefundInfo")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    OnModelCreatingPartial(modelBuilder);
  }

  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}