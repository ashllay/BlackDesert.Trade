using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblMailWaitingQueue", Schema = "PaOperationPublic")]
public class TblMailWaitingQueue
{
  [Column("_waitingNo")]
  public long WaitingNo { get; set; }

  [Column("_mailRequestNo")]
  public long? MailRequestNo { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }
}