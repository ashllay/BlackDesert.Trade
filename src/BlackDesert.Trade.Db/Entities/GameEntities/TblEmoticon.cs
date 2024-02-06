using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   이모티콘
/// </summary>
[PrimaryKey("OwnerUserNo", "EmoticonPackageKey")]
[Table("TblEmoticon", Schema = "PaGamePrivate")]
public class TblEmoticon
{
  /// <summary>
  ///   소유자번호
  /// </summary>
  [Key]
  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  /// <summary>
  ///   이모티콘패키지 키
  /// </summary>
  [Key]
  [Column("_emoticonPackageKey")]
  public long EmoticonPackageKey { get; set; }

  /// <summary>
  ///   이모티콘 상품 타입
  /// </summary>
  [Column("_emoticonType")]
  public byte EmoticonType { get; set; }

  /// <summary>
  ///   기간제 이모티콘 유통기한
  /// </summary>
  [Column("_packageExpirationDate", TypeName = "datetime")]
  public DateTime PackageExpirationDate { get; set; }
}