using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   유저 캐릭을 위한 key 설정 정보
/// </summary>
[Table("TblCustomizedKey", Schema = "PaGamePrivate")]
public class TblCustomizedKey
{
  /// <summary>
  ///   캐릭터번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   키보드 ActionInputType 설정 데이터
  /// </summary>
  [Column("_keyActionInputSerializedData")]
  [StringLength(400)]
  [Unicode(false)]
  public string KeyActionInputSerializedData { get; set; } = null!;

  /// <summary>
  ///   키보드 UiInputType 설정 데이터
  /// </summary>
  [Column("_keyUiInputSerializedData")]
  [StringLength(240)]
  [Unicode(false)]
  public string KeyUiInputSerializedData { get; set; } = null!;

  /// <summary>
  ///   패드 ActionInputType 설정 데이터
  /// </summary>
  [Column("_padActionInputSerializedData")]
  [StringLength(500)]
  [Unicode(false)]
  public string PadActionInputSerializedData { get; set; } = null!;

  /// <summary>
  ///   패드 UiInputType 설정 데이터
  /// </summary>
  [Column("_padUiInputSerializedData")]
  [StringLength(300)]
  [Unicode(false)]
  public string PadUiInputSerializedData { get; set; } = null!;

  /// <summary>
  ///   패드 기능키 1
  /// </summary>
  [Column("_padFunctionInput1")]
  public byte? PadFunctionInput1 { get; set; }

  /// <summary>
  ///   패드 기능키 2
  /// </summary>
  [Column("_padFunctionInput2")]
  public byte? PadFunctionInput2 { get; set; }
}