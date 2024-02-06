namespace BlackDesert.Trade.Domain.Models.Api;

public class ViewUser
{
  public ViewUser() {
    nationCode = 0;
    worldNo = 0;
    userNo = 0L;
  }

  public int nationCode { set; get; }

  public int worldNo { set; get; }

  public long userNo { set; get; }

  public string userNickname { get; set; }
}