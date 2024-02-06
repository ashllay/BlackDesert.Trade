using BlackDesert.Trade.Domain.Exceptions;
using BlackDesert.Trade.Domain.Models;

namespace BlackDesert.Trade.Domain.AspNetCore.Middlewares;

public class ApiExceptionHandlerMiddleware
{
  private readonly ILogger<ApiExceptionHandlerMiddleware> _logger;
  private readonly RequestDelegate _next;

  public ApiExceptionHandlerMiddleware(
    RequestDelegate next) {
    _next = next;
  }

  public async Task InvokeAsync(HttpContext context) {
    try {
      await _next(context);
    }
    catch (TradeMarketUnauthorized ex) {
      Log.Error(ex, "TradeMarketUnauthorized");
      context.Response.WriteAsJsonAsync(CommonResult.Unauthorized(-1111));
    }
    catch (TradeMarketException ex) {
      Log.Error(ex, "TradeMarketException");
      context.Response.WriteAsJsonAsync(CommonResult.Exception(-1222));
    }
    catch (Exception ex) {
      Log.Error(ex, "Exception");
      context.Response.WriteAsJsonAsync(CommonResult.Exception(-1444));
    }
  }
}