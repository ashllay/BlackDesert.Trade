namespace BlackDesert.Trade.Domain.Models.Api;

public class ViewRequestUserAuthModel
{
  public ViewRequestUserAuthModel() {
    userNo = 0L;
    certifiedKey = string.Empty;
    type = 0;
  }

  public long userNo { set; get; }

  public string certifiedKey { set; get; }

  public int type { set; get; }
}