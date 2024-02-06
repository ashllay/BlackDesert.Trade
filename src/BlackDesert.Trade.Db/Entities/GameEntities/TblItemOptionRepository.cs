using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblItemOptionRepository", Schema = "PaGamePrivate")]
public class TblItemOptionRepository
{
  [Key]
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_optionType0")]
  public int OptionType0 { get; set; }

  [Column("_optionType1")]
  public int OptionType1 { get; set; }

  [Column("_optionType2")]
  public int OptionType2 { get; set; }

  [Column("_optionType3")]
  public int OptionType3 { get; set; }

  [Column("_optionType4")]
  public int OptionType4 { get; set; }

  [Column("_optionParam0")]
  public int OptionParam0 { get; set; }

  [Column("_optionParam1")]
  public int OptionParam1 { get; set; }

  [Column("_optionParam2")]
  public int OptionParam2 { get; set; }

  [Column("_optionParam3")]
  public int OptionParam3 { get; set; }

  [Column("_optionParam4")]
  public int OptionParam4 { get; set; }

  [Column("_itemOptionChangeCount")]
  public long ItemOptionChangeCount { get; set; }

  [Column("_parentItemNo")]
  public long? ParentItemNo { get; set; }

  [Column("_limitOption0")]
  public bool LimitOption0 { get; set; }

  [Column("_limitOption1")]
  public bool LimitOption1 { get; set; }

  [Column("_limitOption2")]
  public bool LimitOption2 { get; set; }

  [Column("_limitOption3")]
  public bool LimitOption3 { get; set; }

  [Column("_limitOption4")]
  public bool LimitOption4 { get; set; }

  [Column("_lastUpdateTime", TypeName = "datetime")]
  public DateTime LastUpdateTime { get; set; }
}