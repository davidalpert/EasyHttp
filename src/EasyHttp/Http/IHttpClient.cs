using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using EasyHttp.Http.Abstractions;
using EasyHttp.Infrastructure;

namespace EasyHttp.Http
{
    public interface IHttpClient
    {
        bool LoggingEnabled { get; set; }
        bool ThrowExceptionOnHttpError { get; set; }
        bool StreamResponse { get; set; }
        bool ShouldRemoveAtSign { get; set; }
        IHttpResponse Response { get; }
        IHttpRequest Request { get; }
        IHttpResponse GetAsFile(string uri, string filename);
        IHttpResponse Get(string uri, object query = null);
        IHttpResponse Options(string uri);
        IHttpResponse Post(string uri, object data, string contentType, object query = null);
        IHttpResponse Patch(string uri, object data, string contentType, object query = null);
        IHttpResponse Post(string uri, IDictionary<string, object> formData, IList<FileData> files, object query = null);
        IHttpResponse Put(string uri, object data, string contentType, object query = null);
        IHttpResponse Delete(string uri, object query = null);
        IHttpResponse Head(string uri, object query = null);
        IHttpResponse PutFile(string uri, string filename, string contentType);
        void AddClientCertificates(X509CertificateCollection certificates);
    }
}