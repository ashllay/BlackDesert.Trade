using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   탈것 장착 메시 보이기on/off
/// </summary>
[Table("TblUserUIInfomation", Schema = "PaGamePrivate")]
public class TblUserUiinfomation
{
  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   말 탈것 장비
  /// </summary>
  [Column("_horseVehicleEquipFlag")]
  public int HorseVehicleEquipFlag { get; set; }

  /// <summary>
  ///   낙타 탈것 장비
  /// </summary>
  [Column("_camelVehicleEquipFlag")]
  public int CamelVehicleEquipFlag { get; set; }

  /// <summary>
  ///   아바타 장착
  /// </summary>
  [Column("_avatarEquipSlotFlag")]
  public int AvatarEquipSlotFlag { get; set; }

  /// <summary>
  ///   안면 보호대
  /// </summary>
  [Column("_isBattleHelmShow")]
  public bool IsBattleHelmShow { get; set; }

  /// <summary>
  ///   망토 보이기 on/off
  /// </summary>
  [Required]
  [Column("_isCloakShow")]
  public bool? IsCloakShow { get; set; }
}