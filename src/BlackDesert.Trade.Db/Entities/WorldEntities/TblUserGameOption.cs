using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   유저를 위한 게임 옵션 정보
/// </summary>
[Table("TblUserGameOption", Schema = "PaGamePrivate")]
public class TblUserGameOption
{
  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   게임 옵션 데이터
  /// </summary>
  [Column("_gameOptionSerializedData")]
  [StringLength(200)]
  [Unicode(false)]
  public string GameOptionSerializedData { get; set; } = null!;
}