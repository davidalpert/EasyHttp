using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using EasyHttp.Infrastructure;

namespace EasyHttp.Http.Abstractions
{
    public class HttpRequestWrapper : IHttpRequest
    {
        private readonly HttpRequest _innerRequest;

        public HttpRequestWrapper(HttpRequest innerRequest)
        {
            _innerRequest = innerRequest;
        }

        public bool DisableAutomaticCompression { get { return _innerRequest.DisableAutomaticCompression; } set { _innerRequest.DisableAutomaticCompression = value; } }
        public string Accept { get { return _innerRequest.Accept; } set { _innerRequest.Accept = value; } }
        public string AcceptCharSet { get { return _innerRequest.AcceptCharSet; } set { _innerRequest.AcceptCharSet = value; } }
        public string AcceptEncoding { get { return _innerRequest.AcceptEncoding; } set { _innerRequest.AcceptEncoding = value; } }
        public string AcceptLanguage { get { return _innerRequest.AcceptLanguage; } set { _innerRequest.AcceptLanguage = value; } }
        public bool KeepAlive { get { return _innerRequest.KeepAlive; } set { _innerRequest.KeepAlive = value; } }
        public X509CertificateCollection ClientCertificates { get { return _innerRequest.ClientCertificates; } set { _innerRequest.ClientCertificates = value; } }
        public string ContentLength { get { return _innerRequest.ContentLength; } }
        public string ContentType { get { return _innerRequest.ContentType; } set { _innerRequest.ContentType = value; } }
        public string ContentEncoding { get { return _innerRequest.ContentEncoding; } set { _innerRequest.ContentEncoding = value; } }
        public CookieCollection Cookies { get { return _innerRequest.Cookies; } set { _innerRequest.Cookies = value; } }
        public DateTime Date { get { return _innerRequest.Date; } set { _innerRequest.Date = value; } }
        public bool Expect { get { return _innerRequest.Expect; } set { _innerRequest.Expect = value; } }
        public string From { get { return _innerRequest.From; } set { _innerRequest.From = value; } }
        public string Host { get { return _innerRequest.Host; } set { _innerRequest.Host = value; } }
        public string IfMatch { get { return _innerRequest.IfMatch; } set { _innerRequest.IfMatch = value; } }
        public DateTime IfModifiedSince { get { return _innerRequest.IfModifiedSince; } set { _innerRequest.IfModifiedSince = value; } }
        public string IfRange { get { return _innerRequest.IfRange; } set { _innerRequest.IfRange = value; } }
        public int MaxForwards { get { return _innerRequest.MaxForwards; } set { _innerRequest.MaxForwards = value; } }
        public string Referer { get { return _innerRequest.Referer; } set { _innerRequest.Referer = value; } }
        public int Range { get { return _innerRequest.Range; } set { _innerRequest.Range = value; } }
        public string UserAgent { get { return _innerRequest.UserAgent; } set { _innerRequest.UserAgent = value; } }
        public IDictionary<string, object> RawHeaders { get { return _innerRequest.RawHeaders; } }
        public HttpMethod Method { get { return _innerRequest.Method; } set { _innerRequest.Method = value; } }
        public object Data { get { return _innerRequest.Data; } set { _innerRequest.Data = value; } }
        public string Uri { get { return _innerRequest.Uri; } set { _innerRequest.Uri = value; } }
        public string PutFilename { get { return _innerRequest.PutFilename; } set { _innerRequest.PutFilename = value; } }
        public IDictionary<string, object> MultiPartFormData { get { return _innerRequest.MultiPartFormData; } set { _innerRequest.MultiPartFormData = value; } }
        public IList<FileData> MultiPartFileData { get { return _innerRequest.MultiPartFileData; } set { _innerRequest.MultiPartFileData = value; } }
        public int Timeout { get { return _innerRequest.Timeout; } set { _innerRequest.Timeout = value; } }
        public bool ParametersAsSegments { get { return _innerRequest.ParametersAsSegments; } set { _innerRequest.ParametersAsSegments = value; } }
        public bool ForceBasicAuth { get { return _innerRequest.ForceBasicAuth; } set { _innerRequest.ForceBasicAuth = value; } }
        public bool PersistCookies { get { return _innerRequest.PersistCookies; } set { _innerRequest.PersistCookies = value; } }
        public bool AllowAutoRedirect { get { return _innerRequest.AllowAutoRedirect; } set { _innerRequest.AllowAutoRedirect = value; } }

        public void SetBasicAuthentication(string username, string password)
        {
            _innerRequest.SetBasicAuthentication(username, password);
        }

        public void AddExtraHeader(string header, object value)
        {
            _innerRequest.AddExtraHeader(header, value);
        }

        public IHttpWebRequest PrepareRequest()
        {
            return _innerRequest.PrepareRequest();
        }

        public void SetCacheControlToNoCache()
        {
            _innerRequest.SetCacheControlToNoCache();
        }

        public void SetCacheControlWithMaxAge(TimeSpan maxAge)
        {
            _innerRequest.SetCacheControlWithMaxAge(maxAge);
        }

        public void SetCacheControlWithMaxAgeAndMaxStale(TimeSpan maxAge, TimeSpan maxStale)
        {
            _innerRequest.SetCacheControlWithMaxAgeAndMaxStale(maxAge, maxStale);
        }

        public void SetCacheControlWithMaxAgeAndMinFresh(TimeSpan maxAge, TimeSpan minFresh)
        {
            _innerRequest.SetCacheControlWithMaxAgeAndMinFresh(maxAge, minFresh);
        }
    }
}