using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   캐싱관련 변경회수
/// </summary>
[PrimaryKey("Key", "CacheType")]
[Table("TblCacheSeq", Schema = "PaGamePrivate")]
public class TblCacheSeq
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   _cacheType 에 따라서 의미가 다름
  /// </summary>
  [Key]
  [Column("_key")]
  public long Key { get; set; }

  /// <summary>
  ///   OdbcCacheType 참고
  /// </summary>
  [Key]
  [Column("_cacheType")]
  public short CacheType { get; set; }

  /// <summary>
  ///   CacheSeq 참고
  /// </summary>
  [Column("_seqNo")]
  public int SeqNo { get; set; }
}