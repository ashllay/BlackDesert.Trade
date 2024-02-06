using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   확장 슬롯 정보
/// </summary>
[PrimaryKey("Type", "OwnerNo", "VariousNo")]
[Table("TblExtendSlotRepository", Schema = "PaGamePrivate")]
public class TblExtendSlotRepository
{
  /// <summary>
  ///   슬롯 타입
  /// </summary>
  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   유저 혹은 캐릭터 고유 번호
  /// </summary>
  [Key]
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  /// <summary>
  ///   지역번호 등 값
  /// </summary>
  [Key]
  [Column("_variousNo")]
  public long VariousNo { get; set; }

  /// <summary>
  ///   확장 슬롯 개수
  /// </summary>
  [Column("_slot")]
  public int Slot { get; set; }

  /// <summary>
  ///   등록 일시
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}