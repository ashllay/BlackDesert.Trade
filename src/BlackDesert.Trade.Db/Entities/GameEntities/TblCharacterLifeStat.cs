using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCharacterLifeStat", Schema = "PaGamePrivate")]
public class TblCharacterLifeStat
{
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_mainType")]
  public byte MainType { get; set; }

  [Column("_subType")]
  public byte SubType { get; set; }

  [Column("_stat")]
  public int Stat { get; set; }
}