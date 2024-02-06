using System.Diagnostics;
using System.Text.Encodings.Web;
using BlackDesert.Trade.Business.Manager;
using BlackDesert.Trade.Business.Manager.Abstract;
using BlackDesert.Trade.Business.Manager.Info;
using BlackDesert.Trade.Business.Manager.Logger;
using BlackDesert.Trade.Business.Manager.Server;
using BlackDesert.Trade.Business.Manager.Timers;
using BlackDesert.Trade.Business.Services;
using BlackDesert.Trade.Business.Services.Common;
using BlackDesert.Trade.Domain.AspNetCore;
using BlackDesert.Trade.Domain.AspNetCore.Middlewares;
using BlackDesert.Trade.Domain.Common;
using BlackDesert.Trade.Domain.DB.Context;
using BlackDesert.Trade.Domain.Extensions;

AppDomain.CurrentDomain.UnhandledException += (sender,
                                               eventArgs) => {
  Log.Fatal((Exception)eventArgs.ExceptionObject, "Application Unhandled Exception");
};
var swMain = Stopwatch.StartNew();
AppDomain.CurrentDomain.ProcessExit += (sender,
                                        eventArgs) => {
  Log.CloseAndFlush();
  Log.Information("Application Process Exit {RunningElapsedMilliseconds}ms", swMain.ElapsedMilliseconds);
};
LogUtil.ConfigureSerilog();

var sw = Stopwatch.StartNew();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
       .AddJsonOptions(x => {
         x.JsonSerializerOptions.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
       });

if (builder.Environment.IsDevelopment() || !ConstantContainer.IsLive) {
  builder.Services.AddEndpointsApiExplorer();
  builder.Services.AddSwaggerGen();
}

builder.Services.AddMemoryCache();


builder.Services.AddDbContext<TradeDbContext>();
builder.Services.AddDbContext<GameDbContext>();
builder.Services.AddDbContext<WorldDbContext>();
builder.Services.AddDbContext<LogDbContext>();


builder.Services.AddScoped<TradeBiddingService>();
builder.Services.AddScoped<TradeProcessService>();
builder.Services.AddScoped<TradePayloadService>();
builder.Services.AddScoped<TradeTransactionService>();
builder.Services.AddScoped<TradeViewService>();
builder.Services.AddScoped<TradeWalletService>();




builder.Services.AddSingleton(TradeAlarmService.This);


builder.Services.AddSingleton(XmlModule.This);
builder.Services.AddSingleton(ServerInfoManager.This);
builder.Services.AddSingleton(OptionManager.This);
builder.Services.AddSingleton(VariedPriceInfoManager.This);
builder.Services.AddSingleton(ItemInfoManager.This);
builder.Services.AddSingleton(TickCountManager.This);
builder.Services.AddSingleton(VariedTradeCountManager.This);
builder.Services.AddSingleton(BiddingInfoManager.This);
builder.Services.AddSingleton(StockInfoManger.This);
builder.Services.AddSingleton(CategoryInfoManager.This);
builder.Services.AddSingleton(FamilySkillManager.This);
builder.Services.AddSingleton(HistoryTruncateManager.This);
builder.Services.AddSingleton(TimerManager.This);
builder.Services.AddSingleton(DbConnectionCheckTimer.This);

builder.Services.AddScoped<TradeWalletService>();



var app = builder.Build();

app.Services.SetServiceCollection(); //set service collection to AppServiceAccessor globally






if (app.Environment.IsDevelopment() || !ConstantContainer.IsLive) {
  app.UseSwagger();
  app.UseSwaggerUI();
}


app.UseHttpsRedirection();


if (ConstantContainer.CheckAndLogPerformance) 
  app.UseMiddleware<EndpointPerformanceLoggerMiddleware>();
app.UseMiddleware<MetaDataMiddleware>();
app.UseMiddleware<HttpErrorLoggerMiddleware>();
app.UseMiddleware<ApiExceptionHandlerMiddleware>();

app.MapControllers();


Log.Information("Trade Market Initialize Start");
try
{
  ServerControlManager.This.Init();
}
catch (Exception ex)
{
  Log.Fatal(ex, "Trade Market Initialize Fail");
  throw;
}
Log.Information("Trade Market Server Init Complete {ElapsedSeconds}seconds", sw.ElapsedMilliseconds / 1000.0);
app.Run();
