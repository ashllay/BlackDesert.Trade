using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   유저 캐시
/// </summary>
[Table("TblUserCache", Schema = "PaGamePrivate")]
public class TblUserCache
{
  /// <summary>
  ///   유저
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   캐시 데이터(pack)
  /// </summary>
  [Column("_pack")]
  public byte[]? Pack { get; set; }
}