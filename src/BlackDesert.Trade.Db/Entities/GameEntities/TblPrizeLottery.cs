using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   경품 추첨
/// </summary>
[Keyless]
[Table("TblPrizeLottery", Schema = "PaGamePrivate")]
public class TblPrizeLottery
{
  /// <summary>
  ///   NPC키
  /// </summary>
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  /// <summary>
  ///   추첨유저번호
  /// </summary>
  [Column("_entryUserNo")]
  public long EntryUserNo { get; set; }
}