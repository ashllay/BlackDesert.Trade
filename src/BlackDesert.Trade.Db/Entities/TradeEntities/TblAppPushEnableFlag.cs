using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Keyless]
[Table("TblAppPushEnableFlag", Schema = "PaGamePrivate")]
public class TblAppPushEnableFlag
{
  [Column("_enablePushSend")]
  public bool EnablePushSend { get; set; }
}