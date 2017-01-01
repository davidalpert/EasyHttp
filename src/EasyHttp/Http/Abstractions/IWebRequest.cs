using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Threading.Tasks;

namespace EasyHttp.Http.Abstractions
{
    public interface IWebRequest : ISerializable
    {
        RequestCachePolicy CachePolicy { get; set; }
        string Method { get; set; }
        Uri RequestUri { get; }
        string ConnectionGroupName { get; set; }
        WebHeaderCollection Headers { get; set; }
        long ContentLength { get; set; }
        string ContentType { get; set; }
        ICredentials Credentials { get; set; }
        bool UseDefaultCredentials { get; set; }
        IWebProxy Proxy { get; set; }
        bool PreAuthenticate { get; set; }
        int Timeout { get; set; }
        AuthenticationLevel AuthenticationLevel { get; set; }
        TokenImpersonationLevel ImpersonationLevel { get; set; }
        Stream GetRequestStream();
        IWebResponse GetResponse();
        IAsyncResult BeginGetResponse(AsyncCallback callback, object state);
        IWebResponse EndGetResponse(IAsyncResult asyncResult);
        IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state);
        Stream EndGetRequestStream(IAsyncResult asyncResult);
        Task<Stream> GetRequestStreamAsync();
        Task<IWebResponse> GetResponseAsync();
        void Abort();
        object GetLifetimeService();
        object InitializeLifetimeService();
        ObjRef CreateObjRef(Type requestedType);
    }
}