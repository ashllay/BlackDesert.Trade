using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   흑정령외형변경
/// </summary>
[Keyless]
[Table("TblBlackSpiritForm", Schema = "PaGamePrivate")]
public class TblBlackSpiritForm
{
  /// <summary>
  ///   소유 캐릭터
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   흑정령외형 인덱스
  /// </summary>
  [Column("_blackSpiritFormIndex")]
  public int BlackSpiritFormIndex { get; set; }
}