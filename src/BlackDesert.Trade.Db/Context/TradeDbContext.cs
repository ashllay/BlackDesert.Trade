using BlackDesert.Trade.Db.Entities.TradeEntities;

namespace BlackDesert.Trade.Domain.DB.Context;

public partial class TradeDbContext : DbContext
{
  public TradeDbContext() { }

  public TradeDbContext(DbContextOptions<TradeDbContext> options)
    : base(options) { }

  public virtual DbSet<TargetItemTrade> TargetItemTrades { get; set; }

  public virtual DbSet<TblAppPushEnableFlag> TblAppPushEnableFlags { get; set; }

  public virtual DbSet<TblAutoBuyBannedMainCategory> TblAutoBuyBannedMainCategories { get; set; }

  public virtual DbSet<TblAutoBuyBannedSubCategory> TblAutoBuyBannedSubCategories { get; set; }

  public virtual DbSet<TblAutoBuyBlockedItem> TblAutoBuyBlockedItems { get; set; }

  public virtual DbSet<TblAutoBuyBoughtItemsLog> TblAutoBuyBoughtItemsLogs { get; set; }

  public virtual DbSet<TblAutoBuyLog> TblAutoBuyLogs { get; set; }

  public virtual DbSet<TblAutoBuyOption> TblAutoBuyOptions { get; set; }

  public virtual DbSet<TblBlockItem> TblBlockItems { get; set; }

  public virtual DbSet<TblBlockUser> TblBlockUsers { get; set; }

  public virtual DbSet<TblContentMst> TblContentMsts { get; set; }

  public virtual DbSet<TblDisabledAutoBuyUser> TblDisabledAutoBuyUsers { get; set; }

  public virtual DbSet<TblMinusLoanIndex> TblMinusLoanIndices { get; set; }

  public virtual DbSet<TblMinusLoanInfo> TblMinusLoanInfos { get; set; }

  public virtual DbSet<TblMinusLoanResultInfo> TblMinusLoanResultInfos { get; set; }

  public virtual DbSet<TblShutDownDetail> TblShutDownDetails { get; set; }

  public virtual DbSet<TblUserAutoBuyOption> TblUserAutoBuyOptions { get; set; }

  public virtual DbSet<TblWaitItem> TblWaitItems { get; set; }

  public virtual DbSet<TblWebLogEnableFlag> TblWebLogEnableFlags { get; set; }

  public virtual DbSet<TblWorldMarket> TblWorldMarkets { get; set; }

  public virtual DbSet<TblWorldMarketBiddingBuy> TblWorldMarketBiddingBuys { get; set; }

  public virtual DbSet<TblWorldMarketBiddingSell> TblWorldMarketBiddingSells { get; set; }

  public virtual DbSet<TblWorldMarketKeyWord> TblWorldMarketKeyWords { get; set; }

  public virtual DbSet<TblWorldMarketNoticeItem> TblWorldMarketNoticeItems { get; set; }

  public virtual DbSet<TblWorldMarketOption> TblWorldMarketOptions { get; set; }

  public virtual DbSet<TblWorldMarketPayload> TblWorldMarketPayloads { get; set; }

  public virtual DbSet<TblWorldMarketPayloadOld> TblWorldMarketPayloadOlds { get; set; }

  public virtual DbSet<TblWorldMarketPayloadRestoration> TblWorldMarketPayloadRestorations { get; set; }

  public virtual DbSet<TblWorldMarketPersonalTrade> TblWorldMarketPersonalTrades { get; set; }

  public virtual DbSet<TblWorldMarketPriceInfo> TblWorldMarketPriceInfos { get; set; }

  public virtual DbSet<TblWorldMarketRingBuff> TblWorldMarketRingBuffs { get; set; }

  public virtual DbSet<TblWorldMarketTickCount> TblWorldMarketTickCounts { get; set; }

  public virtual DbSet<TblWorldMarketWaitBiddingSell> TblWorldMarketWaitBiddingSells { get; set; }

  public virtual DbSet<TblWorldMarketWaitBiddingSellNotice> TblWorldMarketWaitBiddingSellNotices { get; set; }

  public virtual DbSet<TblWorldMarketWallet> TblWorldMarketWallets { get; set; }

  public virtual DbSet<TblWorldMarketWalletInfo> TblWorldMarketWalletInfos { get; set; }

  public virtual DbSet<TblWorldMarketWalletParam> TblWorldMarketWalletParams { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    optionsBuilder.UseSqlServer(DbConnectionContainer.This.ConnectionStrings.Trade);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    modelBuilder.Entity<TargetItemTrade>(entity => {
      entity.HasKey(e => e.ItemKey).HasName("PKTargetItemTrade");

      entity.Property(e => e.ItemKey).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblAutoBuyBannedMainCategory>(entity => { entity.HasKey(e => e.Id).HasName("PK__TblAutoB__DED88B1C5E3B7F58"); });

    modelBuilder.Entity<TblAutoBuyBannedSubCategory>(entity => { entity.HasKey(e => e.Id).HasName("PK__TblAutoB__DED88B1C22453F78"); });

    modelBuilder.Entity<TblAutoBuyBlockedItem>(entity => {
      entity.HasKey(e => e.Id).HasName("PK__TblAutoB__DED88B1C0718619E");

      entity.Property(e => e.Id).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblAutoBuyBoughtItemsLog>(entity => {
      entity.HasKey(e => e.Id).HasName("PK__TblAutoB__DED88B1CEBB37BFB");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("(getdate())");
    });

    modelBuilder.Entity<TblAutoBuyLog>(entity => {
      entity.HasKey(e => e.Id).HasName("PK__TblAutoB__DED88B1C1C56E7DB");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("(getdate())");
    });

    modelBuilder.Entity<TblAutoBuyOption>(entity => {
      entity.HasKey(e => e.IsAutoBuyOpen).HasName("PK__TblAutoB__F3949C008136AFD9");

      entity.Property(e => e.ItemWaitDay).HasDefaultValueSql("((7))");
      entity.Property(e => e.MaxPriceLimit).HasDefaultValueSql("((1000000000000.))");
      entity.Property(e => e.PremiumPercent).HasDefaultValueSql("((25))");
      entity.Property(e => e.RingSilverBuff).HasDefaultValueSql("((5))");
      entity.Property(e => e.SilverPercent).HasDefaultValueSql("((20))");
    });

    modelBuilder.Entity<TblBlockItem>(entity => {
      entity.HasKey(e => new { e.KeyType, e.MainKey, e.SubKey })
            .HasName("PkTblBlockItem")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblBlockUser>(entity => {
      entity.HasKey(e => new { e.NationCode, e.ServerNo, e.UserNo })
            .HasName("PkTblBlockUser")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblContentMst>(entity => {
      entity.HasKey(e => e.GroupContentNo)
            .HasName("PkTblContentMst")
            .IsClustered(false);

      entity.Property(e => e.GroupContentNo).ValueGeneratedNever();
      entity.Property(e => e.IsDisplay).HasDefaultValueSql("((1))");
      entity.Property(e => e.RegDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDateTime]())");
    });

    modelBuilder.Entity<TblDisabledAutoBuyUser>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PK__TblAutoB__D84CDD5FB6EF62DB");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("(getdate())");
    });

    modelBuilder.Entity<TblMinusLoanIndex>(entity => {
      entity.Property(e => e.Idx).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.Result).HasDefaultValueSql("((0))");
    });

    modelBuilder.Entity<TblMinusLoanInfo>(entity => {
      entity.HasKey(e => new { e.Idx, e.UserId }).HasName("PK_TblMinusLoanInfo_idx_userId");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblMinusLoanResultInfo>(entity => {
      entity.HasKey(e => new { e.Idx, e.UserId }).HasName("PK_TblMinusLoanResultInfo_idx_userId");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblShutDownDetail>(entity => {
      entity.HasKey(e => new { e.GroupContentno, e.CultureCode })
            .HasName("PkTblShutDownDetail")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblUserAutoBuyOption>(entity => {
      entity.HasKey(e => e.UserNo).HasName("PK__TblUserA__DED88B1CE2648A7A");

      entity.Property(e => e.UserNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblWaitItem>(entity => {
      entity.HasKey(e => new { e.KeyType, e.MainKey, e.SubKey })
            .HasName("PkTblWaitItem")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWebLogEnableFlag>(entity => {
      entity.Property(e => e.WriteErrorLog).HasDefaultValueSql("((1))");
      entity.Property(e => e.WriteFatalLog).HasDefaultValueSql("((1))");
      entity.Property(e => e.WriteWarringLog).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblWorldMarket>(entity => {
      entity.HasKey(e => new { e.MainKey, e.SubKey, e.KeyType }).HasName("PkTblWorldMarket");

      entity.Property(e => e.LastTradeTime).HasDefaultValueSql("('1970-01-01 00:00:00')");
    });

    modelBuilder.Entity<TblWorldMarketBiddingBuy>(entity => {
      entity.HasKey(e => new { e.MainKey, e.SubKey, e.KeyType, e.UserNo }).HasName("PkTblWorldMarketBiddingBuy");

      entity.Property(e => e.BuyNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWorldMarketBiddingSell>(entity => {
      entity.HasKey(e => new { e.MainKey, e.SubKey, e.UserNo, e.IsSealed, e.KeyType }).HasName("PkTblWorldMarketBiddingSell");

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.SellNo).ValueGeneratedOnAdd();
    });

    modelBuilder.Entity<TblWorldMarketKeyWord>(entity => {
      entity.HasKey(e => e.KeyWordNo)
            .HasName("PkTblWorldMarketKeyWord")
            .IsClustered(false);

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWorldMarketOption>(entity => {
      entity.Property(e => e.IsMarketOpen).HasDefaultValueSql("((1))");
      entity.Property(e => e.IsRingBuff).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblWorldMarketPayload>(entity => {
      entity.HasKey(e => e.Payload)
            .HasName("PkTblWorldMarketPayload")
            .IsClustered(false);

      entity.HasIndex(e => e.RegisterDate, "IxWorldMarketPayload_registerDate").IsClustered();

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWorldMarketPayloadOld>(entity => {
      entity.HasKey(e => e.Payload)
            .HasName("PkTblWorldMarketPayload_OLD")
            .IsClustered(false);

      entity.HasIndex(e => e.RegisterDate, "IxWorldMarketPayload_registerDate_OLD").IsClustered();

      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWorldMarketPayloadRestoration>(entity => {
      entity.HasKey(e => e.Payload)
            .HasName("PkTblWorldMarketPayloadRestoration")
            .IsClustered(false);

      entity.Property(e => e.Payload).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblWorldMarketPersonalTrade>(entity => {
      entity.HasKey(e => e.MarketNo)
            .HasName("PkTblWorldMarketPersonalTrade")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblWorldMarketRingBuff>(entity => {
      entity.HasKey(e => new { e.NationCode, e.ServerNo, e.UserNo })
            .HasName("PkTblWorldMarketRingBuff")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblWorldMarketTickCount>(entity => {
      entity.HasKey(e => e.MainGroupNo)
            .HasName("PkTblWorldMarketTickCount")
            .IsClustered(false);

      entity.Property(e => e.MainGroupNo).ValueGeneratedNever();
      entity.Property(e => e.LastUpdateTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.UpdateTickCount).HasDefaultValueSql("((1))");
    });

    modelBuilder.Entity<TblWorldMarketWaitBiddingSell>(entity => {
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.WaitNo).ValueGeneratedOnAdd();
    });

    modelBuilder.Entity<TblWorldMarketWaitBiddingSellNotice>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblWorldMarketWallet>(entity => {
      entity.HasKey(e => new { e.UserNo, e.ServerNo, e.NationCode, e.KeyType, e.MainKey, e.SubKey, e.IsSealed }).HasName("PkTblWorldMarketWallet");
    });

    modelBuilder.Entity<TblWorldMarketWalletInfo>(entity => {
      entity.HasKey(e => new { e.NationCode, e.ServerNo, e.UserNo })
            .HasName("PkTblWorldMarketWalletInfo")
            .IsClustered(false);

      entity.Property(e => e.AddWeightBuffExpiration).HasDefaultValueSql("('1970-01-01 00:00:00')");
      entity.Property(e => e.BlackUserCheckTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.PackageExpiration).HasDefaultValueSql("('1970-01-01 00:00:00')");
      entity.Property(e => e.PearlItemLimitedresetTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
      entity.Property(e => e.ResetTime).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWorldMarketWalletParam>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    OnModelCreatingPartial(modelBuilder);
  }

  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}