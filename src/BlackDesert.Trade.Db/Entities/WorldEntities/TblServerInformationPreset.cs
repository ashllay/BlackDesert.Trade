using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblServerInformationPreset", Schema = "PaOperationPrivate")]
public class TblServerInformationPreset
{
  [Column("_registDate", TypeName = "datetime")]
  public DateTime RegistDate { get; set; }

  [Key]
  [Column("_presetName")]
  [StringLength(30)]
  public string PresetName { get; set; } = null!;

  [Column("_serverName")]
  [StringLength(30)]
  public string ServerName { get; set; } = null!;

  [Column("_serverType")]
  public short ServerType { get; set; }

  [Column("_isSpareMachine")]
  public bool IsSpareMachine { get; set; }

  [Column("_mainIP")]
  [StringLength(15)]
  [Unicode(false)]
  public string MainIp { get; set; } = null!;

  [Column("_publicIP")]
  [StringLength(100)]
  [Unicode(false)]
  public string PublicIp { get; set; } = null!;

  [Column("_macAddress")]
  [StringLength(32)]
  [Unicode(false)]
  public string MacAddress { get; set; } = null!;

  [Column("_worldNo")]
  public short WorldNo { get; set; }

  [Column("_fieldDsn")]
  [StringLength(100)]
  public string FieldDsn { get; set; } = null!;

  [Column("_logDsn")]
  [StringLength(100)]
  public string LogDsn { get; set; } = null!;

  [Column("_startSiegeTerritory")]
  public short StartSiegeTerritory { get; set; }

  [Column("_doImperialDelivery")]
  public bool DoImperialDelivery { get; set; }

  [Column("_doImperialProductDelivery")]
  public bool DoImperialProductDelivery { get; set; }

  [Column("_dontPvPTendencyDecrease")]
  public bool DontPvPtendencyDecrease { get; set; }

  [Column("_doHorseRaceMatch")]
  public bool DoHorseRaceMatch { get; set; }

  [Column("_serverGroupNo")]
  public short ServerGroupNo { get; set; }

  [Column("_fixedCharge")]
  public bool FixedCharge { get; set; }

  [Column("_isLimitedLocalWar")]
  public bool IsLimitedLocalWar { get; set; }

  [Column("_isSpeedChannel")]
  public bool IsSpeedChannel { get; set; }

  [Column("_doCompetitionArsha")]
  public bool DoCompetitionArsha { get; set; }

  [Column("_isBalanceChannel")]
  public bool IsBalanceChannel { get; set; }

  [Column("_isSavageDefence")]
  public short IsSavageDefence { get; set; }

  [Column("_isPcroomChannel")]
  public bool IsPcroomChannel { get; set; }

  [Column("_isSteamChannel")]
  public bool IsSteamChannel { get; set; }

  [Column("_isPremiumChannel")]
  public bool IsPremiumChannel { get; set; }

  [Column("_isGuildBattleChannel")]
  public short IsGuildBattleChannel { get; set; }

  [Column("_isCantPvPChannel")]
  public bool IsCantPvPchannel { get; set; }

  [Column("_isFixedBossSpawn")]
  public bool IsFixedBossSpawn { get; set; }

  [Column("_startNationSiege")]
  public bool StartNationSiege { get; set; }

  [Column("_isInstanceFieldMainServer")]
  [StringLength(30)]
  [Unicode(false)]
  public string IsInstanceFieldMainServer { get; set; } = null!;

  [Column("_servicePlatformType")]
  public byte ServicePlatformType { get; set; }

  [Column("_isSeasonChannel")]
  public bool IsSeasonChannel { get; set; }

  [Column("_isSeasonNewbieChannel")]
  public bool IsSeasonNewbieChannel { get; set; }

  [Column("_isHadumChannel")]
  public bool IsHadumChannel { get; set; }

  [Column("_isEventChannel")]
  public bool IsEventChannel { get; set; }

  [Column("_isSequentialCheck")]
  public bool IsSequentialCheck { get; set; }
}