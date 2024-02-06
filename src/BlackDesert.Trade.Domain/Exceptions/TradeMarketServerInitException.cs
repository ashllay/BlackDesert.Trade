using System.Globalization;

namespace BlackDesert.Trade.Domain.Exceptions;

public class TradeMarketServerInitException : Exception
{
  public TradeMarketServerInitException(string name, int errorCode, string message) : base($"[{name.ToUpper(ConstantContainer.DefaultCulture)}] [{errorCode}] {message}") {
    
  }

  
  public TradeMarketServerInitException(string name,int errorCode, string message, Exception innerException) : base($"[{name.ToUpper(ConstantContainer.DefaultCulture)}] [{errorCode}] {message}", innerException) {
    
  }
}