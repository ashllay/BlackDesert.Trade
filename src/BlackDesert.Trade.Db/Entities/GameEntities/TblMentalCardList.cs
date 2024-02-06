using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   카드 목록 테이블
/// </summary>
[PrimaryKey("UserNo", "CardKey")]
[Table("TblMentalCardList", Schema = "PaGamePrivate")]
public class TblMentalCardList
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   소유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   카드키
  /// </summary>
  [Key]
  [Column("_cardKey")]
  public int CardKey { get; set; }

  [Column("_level")]
  public int Level { get; set; }
}