using System.Net;
using BlackDesert.Trade.Domain.Common;
using BlackDesert.Trade.Domain.Enum;
using BlackDesert.Trade.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlackDesert.Trade.Api.Game.Controllers;

[ApiController]
public class HomeController : Controller
{
  [Route("/error")]
  public ActionResult Error() {
    return StatusCode((int)HttpStatusCode.InternalServerError,
                      new CommonResult() {
                        resultCode = 1,
                        resultMsg = MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue(),
                      });
  }

  [Route("/")]
  public ActionResult Index() {
    return Ok("Black Desert Central Market");
  }
}