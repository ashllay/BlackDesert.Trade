using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   백과사전(어류도감)
/// </summary>
[PrimaryKey("UserNo", "Key")]
[Table("TblEncyclopedia", Schema = "PaGamePrivate")]
public class TblEncyclopedium
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   어종키 (DataSheet_Encyclopedia$Encyclopedia_Table)
  /// </summary>
  [Key]
  [Column("_key")]
  public int Key { get; set; }

  /// <summary>
  ///   잡은 수량
  /// </summary>
  [Column("_count")]
  public int Count { get; set; }

  /// <summary>
  ///   최대크기
  /// </summary>
  [Column("_value")]
  public int Value { get; set; }
}