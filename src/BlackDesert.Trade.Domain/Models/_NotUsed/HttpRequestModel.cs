// using System.Collections.Specialized;
// using System.Security.Cryptography.X509Certificates;
//
// namespace BlackDesert.Trade.Domain.Models;
//
// public class HttpRequestModel
// {
//   public HttpRequestModel() {
//     _requestUrl = string.Empty;
//     _requestParam = string.Empty;
//     _requestMethod = string.Empty;
//     _requesetContentType = string.Empty;
//     _encodingType = "default";
//     _useTlsProtocol = false;
//     _useCertificate = false;
//     _accept = string.Empty;
//     _reqHeaders = null;
//     _wCertification = null;
//   }
//
//   public HttpRequestModel(
//     string _reqUrl,
//     string _reqParam,
//     string _reqMethod,
//     string _reqContentType) {
//     _requestUrl = _reqUrl;
//     _requestParam = _reqParam;
//     _requestMethod = _reqMethod;
//     _requesetContentType = _reqContentType;
//     _encodingType = "default";
//     _useTlsProtocol = false;
//     _useCertificate = false;
//     _accept = string.Empty;
//     _reqHeaders = null;
//     _wCertification = null;
//   }
//
//   public HttpRequestModel(
//     string _reqUrl,
//     string _reqParam,
//     string _reqMethod,
//     string _reqContentType,
//     bool _isUseAccessToken) {
//     _requestUrl = _reqUrl;
//     _requestParam = _reqParam;
//     _requestMethod = _reqMethod;
//     _requesetContentType = _reqContentType;
//     _encodingType = "default";
//     _useTlsProtocol = false;
//     _useCertificate = false;
//     _accept = string.Empty;
//     _reqHeaders = null;
//     _wCertification = null;
//   }
//
//   public HttpRequestModel(
//     string _reqUrl,
//     string _reqParam,
//     string _reqMethod,
//     string _reqContentType,
//     bool _useTlsProtocol,
//     string _encodingType) {
//     _requestUrl = _reqUrl;
//     _requestParam = _reqParam;
//     _requestMethod = _reqMethod;
//     _requesetContentType = _reqContentType;
//     this._encodingType = _encodingType;
//     this._useTlsProtocol = _useTlsProtocol;
//     _useCertificate = false;
//     _accept = string.Empty;
//     _reqHeaders = null;
//     _wCertification = null;
//   }
//
//   public string _requestUrl { get; set; }
//
//   public string _requestParam { get; set; }
//
//   public string _requestMethod { get; set; }
//
//   public string _requesetContentType { get; set; }
//
//   public string _encodingType { get; set; }
//
//   public bool _useTlsProtocol { get; set; }
//
//   public bool _useCertificate { get; set; }
//
//   public string _accept { get; set; }
//
//   public bool _useExpect100Continue { get; set; }
//
//   public NameValueCollection _reqHeaders { get; set; }
//
//   public X509Certificate2 _wCertification { get; set; }
// }