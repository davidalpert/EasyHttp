using System;
using System.IO;
using System.Net;
using EasyHttp.Http.Abstractions;

namespace EasyHttp.Http
{
    public interface IHttpResponse
    {
        string CharacterSet { get; }
        string ContentType { get; }
        HttpStatusCode StatusCode { get; }
        string StatusDescription { get; }
        CookieCollection Cookies { get; }
        int Age { get; }
        HttpMethod[] Allow { get; }
        CacheControl CacheControl { get; }
        string ContentEncoding { get; }
        string ContentLanguage { get; }
        long ContentLength { get; }
        string ContentLocation { get; }
        string ContentDisposition { get; }
        DateTime Date { get; }
        string ETag { get; }
        DateTime Expires { get; }
        DateTime LastModified { get; }
        string Location { get; }
        CacheControl Pragma { get; }
        string Server { get; }
        WebHeaderCollection RawHeaders { get; }
        Stream ResponseStream { get; }
        dynamic DynamicBody { get; }
        string RawText { get; }
        T StaticBody<T>(string overrideContentType = null);
        void GetResponse(IHttpWebRequest request, string filename, bool streamResponse);
    }
}