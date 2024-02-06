using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblUserUsePearlForCashProduct", Schema = "PaGamePrivate")]
public class TblUserUsePearlForCashProduct
{
  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   현재 스탬프 카운트
  /// </summary>
  [Column("_stampCount")]
  public int StampCount { get; set; }
}