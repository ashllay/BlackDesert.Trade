namespace BlackDesert.Trade.Domain.AspNetCore.Middlewares;

public class HttpErrorLoggerMiddleware
{
  private readonly RequestDelegate _next;

  public HttpErrorLoggerMiddleware(RequestDelegate next) {
    _next = next;
  }

  public async Task Invoke(HttpContext context) {
    await _next(context);
    var responseHttpStatusCode = context.Response.StatusCode;
    var isSuccess = responseHttpStatusCode >= 200 && responseHttpStatusCode <= 299;
    if (!isSuccess) {
      var query = context.Request.QueryString.ToString();
      if (query.Contains("GameProcess", StringComparison.InvariantCultureIgnoreCase) ||
          query.Contains("GameTradeMarket", StringComparison.InvariantCultureIgnoreCase) ||
          query.Contains("TradeMarket", StringComparison.InvariantCultureIgnoreCase)) {
        var fullRequestPath = context.Request.Path.ToString() + query;
        var requestBodySize = context.Request.ContentLength;
        Log.Warning("HttpErrorLoggerMiddleware HttpStatusCode: {responseHttpStatusCode}, RequestPath: {fullRequestPath}, RequestBodySize: {requestBodySize}",
                    responseHttpStatusCode,
                    fullRequestPath,
                    requestBodySize);
      }
    }
  }
}