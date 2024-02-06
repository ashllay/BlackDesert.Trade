namespace BlackDesert.Trade.Domain.Models;

public class CommonDBResult<T> : CommonResult
{
  public List<T> list { get; set; }
}