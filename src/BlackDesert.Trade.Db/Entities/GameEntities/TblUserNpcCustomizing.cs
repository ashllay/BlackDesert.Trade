using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblUserNpcCustomizing", Schema = "PaGamePrivate")]
public class TblUserNpcCustomizing
{
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_headMesh")]
  public byte HeadMesh { get; set; }

  [Column("_hairMesh")]
  public byte HairMesh { get; set; }

  [Column("_extra0")]
  public byte Extra0 { get; set; }

  [Column("_extra1")]
  public byte Extra1 { get; set; }

  [Column("_extra2")]
  public byte Extra2 { get; set; }

  [Column("_extra3")]
  public byte Extra3 { get; set; }

  [Column("_bone")]
  [MaxLength(660)]
  public byte[]? Bone { get; set; }

  [Column("_decoration")]
  [MaxLength(130)]
  public byte[]? Decoration { get; set; }

  [Column("_decorationRGB")]
  [MaxLength(12)]
  public byte[]? DecorationRgb { get; set; }

  [Column("_expression")]
  [MaxLength(2)]
  public byte[] Expression { get; set; } = null!;

  [Column("_seqNo")]
  public int SeqNo { get; set; }
}