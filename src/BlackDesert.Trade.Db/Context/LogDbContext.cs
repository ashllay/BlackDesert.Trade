using BlackDesert.Trade.Db.Entities.LogEntities;

namespace BlackDesert.Trade.Domain.DB.Context;

public partial class LogDbContext : DbContext
{
  public LogDbContext() { }

  public LogDbContext(DbContextOptions<LogDbContext> options)
    : base(options) { }

  public virtual DbSet<DimLogOperationLogReason> DimLogOperationLogReasons { get; set; }

  public virtual DbSet<TblAuctionLog> TblAuctionLogs { get; set; }

  public virtual DbSet<TblCashProductLog> TblCashProductLogs { get; set; }

  public virtual DbSet<TblCashProductLogExInmem> TblCashProductLogExInmems { get; set; }

  public virtual DbSet<TblCashProductLogExNew> TblCashProductLogExNews { get; set; }

  public virtual DbSet<TblChatLog> TblChatLogs { get; set; }

  public virtual DbSet<TblChatLogInmem> TblChatLogInmems { get; set; }

  public virtual DbSet<TblGmCommandLog> TblGmCommandLogs { get; set; }

  public virtual DbSet<TblGmCommandLogInmem> TblGmCommandLogInmems { get; set; }

  public virtual DbSet<TblGuildSiegeLogInmem> TblGuildSiegeLogInmems { get; set; }

  public virtual DbSet<TblItemLog> TblItemLogs { get; set; }

  public virtual DbSet<TblItemLogInmem> TblItemLogInmems { get; set; }

  public virtual DbSet<TblLogReasonGroup> TblLogReasonGroups { get; set; }

  public virtual DbSet<TblLogReasonGroupName> TblLogReasonGroupNames { get; set; }

  public virtual DbSet<TblMiscLog> TblMiscLogs { get; set; }

  public virtual DbSet<TblMiscLogInmem> TblMiscLogInmems { get; set; }

  public virtual DbSet<TblPointResourceLog> TblPointResourceLogs { get; set; }

  public virtual DbSet<TblPointResourceLogInmem> TblPointResourceLogInmems { get; set; }

  public virtual DbSet<TblServantLog> TblServantLogs { get; set; }

  public virtual DbSet<TblServantLogInmem> TblServantLogInmems { get; set; }

  public virtual DbSet<TblServiceLog> TblServiceLogs { get; set; }

  public virtual DbSet<TblTrPerformance> TblTrPerformances { get; set; }

  public virtual DbSet<TblUserLog> TblUserLogs { get; set; }

  public virtual DbSet<TblUserLogInmem> TblUserLogInmems { get; set; }

  public virtual DbSet<TblWebAdminToolLogV3> TblWebAdminToolLogV3s { get; set; }

  public virtual DbSet<TblWebBoardGameLog> TblWebBoardGameLogs { get; set; }

  public virtual DbSet<TblWorldMarketLog> TblWorldMarketLogs { get; set; }

  public virtual DbSet<TblWorldMarketLogInmem> TblWorldMarketLogInmems { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    optionsBuilder.UseSqlServer(DbConnectionContainer.This.ConnectionStrings.Log);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    modelBuilder.Entity<DimLogOperationLogReason>(entity => {
      entity.HasKey(e => e.LogReasonNo).HasName("PK__Dim_Log___29F30E5F82B1B6FD");

      entity.Property(e => e.LogReasonNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblAuctionLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblCashProductLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblCashProductLogExInmem>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())"); });

    modelBuilder.Entity<TblCashProductLogExNew>(entity => {
      entity.Property(e => e.LogNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblChatLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblChatLogInmem>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblGmCommandLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblGmCommandLogInmem>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblGuildSiegeLogInmem>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblItemLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblItemLogInmem>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblLogReasonGroup>(entity => {
      entity.HasKey(e => new { e.LogReasonGroupNo, e.LogReasonNo })
            .HasName("PkTblLogReasonGroup")
            .IsClustered(false);
    });

    modelBuilder.Entity<TblLogReasonGroupName>(entity => {
      entity.HasKey(e => e.LogReasonGroupNo)
            .HasName("PkTblLogReasonGroupName")
            .IsClustered(false);

      entity.Property(e => e.LogReasonGroupNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblMiscLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblMiscLogInmem>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblPointResourceLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblPointResourceLogInmem>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblServantLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblServantLogInmem>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblServiceLog>(entity => {
      entity.HasKey(e => e.LogNo)
            .HasName("PkTblWorker")
            .IsClustered(false);

      entity.ToTable("TblServiceLog", "PaGamePrivate", tb => tb.HasComment("Service 로그"));

      entity.Property(e => e.LogNo).HasComment("로그 고유번호");
      entity.Property(e => e.GameAgeGradeType).HasComment("15세 이용가");
      entity.Property(e => e.IsGuestAccount).HasComment("guest 계정 여부");
      entity.Property(e => e.IsPcRoom).HasComment("참이면 PC방");
      entity.Property(e => e.IsPcRoomPremium).HasComment("참이면 PC방 혜택");
      entity.Property(e => e.IsPvP).HasComment("참이면 PVP");
      entity.Property(e => e.IsUserGm).HasComment("참이면 운영자");
      entity.Property(e => e.OperationLogType).HasComment("로그 타입");
      entity.Property(e => e.PlayMinuteOfUser).HasComment("유저 플레이 시간");
      entity.Property(e => e.RegisterDate)
            .HasDefaultValueSql("(getdate())")
            .HasComment("등록 시간");
      entity.Property(e => e.ServerNo).HasComment("서버 번호");
      entity.Property(e => e.ServiceParam1).HasComment("param1");
      entity.Property(e => e.ServiceParam2).HasComment("param2");
      entity.Property(e => e.ServiceParam3).HasComment("param3");
      entity.Property(e => e.ServiceString).HasComment("운영 로그 내용");
      entity.Property(e => e.SymNoReason).HasComment("로그 이유");
      entity.Property(e => e.UserId).HasComment("유저 ID");
      entity.Property(e => e.UserIp).HasComment("유저 IP");
      entity.Property(e => e.UserNo).HasComment("유저 고유 번호");
    });

    modelBuilder.Entity<TblTrPerformance>(entity => { entity.Property(e => e.RegisterDate).HasDefaultValueSql("(getdate())"); });

    modelBuilder.Entity<TblUserLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblUserLogInmem>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblWebAdminToolLogV3>(entity => {
      entity.Property(e => e.LogNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterDate).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    modelBuilder.Entity<TblWebBoardGameLog>(entity => { entity.Property(e => e.LogNo).ValueGeneratedOnAdd(); });

    modelBuilder.Entity<TblWorldMarketLog>(entity => {
      entity.HasKey(e => e.LogNo).HasName("PK__TblWorld__820A04EA0B75A0FA");

      entity.Property(e => e.LogNo).ValueGeneratedNever();
    });

    modelBuilder.Entity<TblWorldMarketLogInmem>(entity => {
      entity.Property(e => e.LogNo).ValueGeneratedOnAdd();
      entity.Property(e => e.RegisterUtc).HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
    });

    OnModelCreatingPartial(modelBuilder);
  }

  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}