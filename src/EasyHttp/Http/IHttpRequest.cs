using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using EasyHttp.Http.Abstractions;
using EasyHttp.Infrastructure;

namespace EasyHttp.Http
{
    public interface IHttpRequest
    {
        bool DisableAutomaticCompression { get; set; }
        string Accept { get; set; }
        string AcceptCharSet { get; set; }
        string AcceptEncoding { get; set; }
        string AcceptLanguage { get; set; }
        bool KeepAlive { get; set; }
        X509CertificateCollection ClientCertificates { get; set; }
        string ContentLength { get; }
        string ContentType { get; set; }
        string ContentEncoding { get; set; }
        CookieCollection Cookies { get; set; }
        DateTime Date { get; set; }
        bool Expect { get; set; }
        string From { get; set; }
        string Host { get; set; }
        string IfMatch { get; set; }
        DateTime IfModifiedSince { get; set; }
        string IfRange { get; set; }
        int MaxForwards { get; set; }
        string Referer { get; set; }
        int Range { get; set; }
        string UserAgent { get; set; }
        IDictionary<string, object> RawHeaders { get; }
        HttpMethod Method { get; set; }
        object Data { get; set; }
        string Uri { get; set; }
        string PutFilename { get; set; }
        IDictionary<string, object> MultiPartFormData { get; set; }
        IList<FileData> MultiPartFileData { get; set; }
        int Timeout { get; set; }
        Boolean ParametersAsSegments { get; set; }
        bool ForceBasicAuth { get; set; }
        bool PersistCookies { get; set; }
        bool AllowAutoRedirect { get; set; }
        void SetBasicAuthentication(string username, string password);
        void AddExtraHeader(string header, object value);
        IHttpWebRequest PrepareRequest();
        void SetCacheControlToNoCache();
        void SetCacheControlWithMaxAge(TimeSpan maxAge);
        void SetCacheControlWithMaxAgeAndMaxStale(TimeSpan maxAge, TimeSpan maxStale);
        void SetCacheControlWithMaxAgeAndMinFresh(TimeSpan maxAge, TimeSpan minFresh);
    }
}