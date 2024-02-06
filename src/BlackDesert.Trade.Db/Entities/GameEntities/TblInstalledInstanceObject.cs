using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   하우징 설치 InstanceObject 테이블
/// </summary>
[Table("TblInstalledInstanceObject", Schema = "PaGamePrivate")]
public class TblInstalledInstanceObject
{
  /// <summary>
  ///   설치된 설치물의 고유번호
  /// </summary>
  [Key]
  [Column("_instanceObjectNo")]
  public long InstanceObjectNo { get; set; }

  /// <summary>
  ///   설치된 설치물의 종류
  /// </summary>
  [Column("_objectType")]
  public byte ObjectType { get; set; }

  /// <summary>
  ///   설치된 설치물의 캐릭터키
  /// </summary>
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  /// <summary>
  ///   소속 길드번호
  /// </summary>
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   캐릭을 소유한 사용자번호(정상적인 캐릭터라면 TUserNoDefault 이면 안됨)
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   소유자 사용자캐릭터번호
  /// </summary>
  [Column("_userCharacterNo")]
  public long UserCharacterNo { get; set; }

  [Column("_householdNo")]
  public long HouseholdNo { get; set; }

  /// <summary>
  ///   _fieldNo
  /// </summary>
  [Column("_fieldNo")]
  public short FieldNo { get; set; }

  /// <summary>
  ///   _fieldIndex
  /// </summary>
  [Column("_fieldIndex")]
  public short FieldIndex { get; set; }

  /// <summary>
  ///   _posX
  /// </summary>
  [Column("_posX")]
  public double PosX { get; set; }

  /// <summary>
  ///   _posY
  /// </summary>
  [Column("_posY")]
  public double PosY { get; set; }

  /// <summary>
  ///   _posZ
  /// </summary>
  [Column("_posZ")]
  public double PosZ { get; set; }

  /// <summary>
  ///   _dirX
  /// </summary>
  [Column("_dirX")]
  public double DirX { get; set; }

  /// <summary>
  ///   _dirY
  /// </summary>
  [Column("_dirY")]
  public double DirY { get; set; }

  /// <summary>
  ///   _dirZ
  /// </summary>
  [Column("_dirZ")]
  public double DirZ { get; set; }
}