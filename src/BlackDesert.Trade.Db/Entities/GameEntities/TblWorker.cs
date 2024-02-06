using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   일꾼
/// </summary>
[Table("TblWorker", Schema = "PaGamePrivate")]
public class TblWorker
{
  /// <summary>
  ///   _registerDate
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   소유 사용자번호
  /// </summary>
  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  /// <summary>
  ///   _workerNo
  /// </summary>
  [Key]
  [Column("_workerNo")]
  public long WorkerNo { get; set; }

  /// <summary>
  ///   _characterKey
  /// </summary>
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  /// <summary>
  ///   마을(살고 있는 곳)의 PlantKey
  /// </summary>
  [Column("_homePlantKey")]
  public int HomePlantKey { get; set; }

  /// <summary>
  ///   작업 가능 횟수(NULL무제한, 0 행동력소모)
  /// </summary>
  [Column("_actionPoint")]
  public int? ActionPoint { get; set; }

  /// <summary>
  ///   작업 가능 최대횟수(NULL무제한, 0 행동력소모)
  /// </summary>
  [Column("_actionPointMax")]
  public int? ActionPointMax { get; set; }

  /// <summary>
  ///   일꾼의 레벨
  /// </summary>
  [Column("_level")]
  public int Level { get; set; }

  /// <summary>
  ///   현재 경험치
  /// </summary>
  [Column("_experience")]
  public long Experience { get; set; }

  /// <summary>
  ///   일꾼의 추가 이동속도
  /// </summary>
  [Column("_moveSpeed")]
  public int MoveSpeed { get; set; }

  /// <summary>
  ///   일꾼의 추가 효율
  /// </summary>
  [Column("_workEfficience")]
  public int WorkEfficience { get; set; }

  /// <summary>
  ///   일꾼의 추가 행운
  /// </summary>
  [Column("_luck")]
  public int Luck { get; set; }

  /// <summary>
  ///   일꾼의 스킬0
  /// </summary>
  [Column("_skillKey0")]
  public int SkillKey0 { get; set; }

  /// <summary>
  ///   일꾼의 스킬1
  /// </summary>
  [Column("_skillKey1")]
  public int SkillKey1 { get; set; }

  /// <summary>
  ///   일꾼의 스킬2
  /// </summary>
  [Column("_skillKey2")]
  public int SkillKey2 { get; set; }

  /// <summary>
  ///   일꾼의 스킬3
  /// </summary>
  [Column("_skillKey3")]
  public int SkillKey3 { get; set; }

  /// <summary>
  ///   일꾼의 스킬4
  /// </summary>
  [Column("_skillKey4")]
  public int SkillKey4 { get; set; }

  /// <summary>
  ///   일꾼의 스킬5
  /// </summary>
  [Column("_skillKey5")]
  public int SkillKey5 { get; set; }

  /// <summary>
  ///   일꾼의 스킬6
  /// </summary>
  [Column("_skillKey6")]
  public int SkillKey6 { get; set; }

  /// <summary>
  ///   승급가능 횟수
  /// </summary>
  [Column("_upgradePoint")]
  public byte UpgradePoint { get; set; }

  /// <summary>
  ///   거래소 등록 여부
  /// </summary>
  [Column("_isAuctionInsert")]
  public bool IsAuctionInsert { get; set; }

  /// <summary>
  ///   삭제여부
  /// </summary>
  [Column("_deleteDate", TypeName = "datetime")]
  public DateTime? DeleteDate { get; set; }
}