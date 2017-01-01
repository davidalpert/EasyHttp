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
    public class WebRequestWrapper : IWebRequest
    {
        private WebRequest _innerRequest;

        public WebRequestWrapper(WebRequest innerRequest)
        {
            _innerRequest = innerRequest;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public RequestCachePolicy CachePolicy { get { return _innerRequest.CachePolicy; } set { _innerRequest.CachePolicy = value; } }
        public string Method { get { return _innerRequest.Method; } set { _innerRequest.Method = value; } }
        public Uri RequestUri { get { return _innerRequest.RequestUri; }  }
        public string ConnectionGroupName { get { return _innerRequest.ConnectionGroupName; } set { _innerRequest.ConnectionGroupName = value; } }
        public WebHeaderCollection Headers { get { return _innerRequest.Headers; } set { _innerRequest.Headers = value; } }
        public long ContentLength { get { return _innerRequest.ContentLength; } set { _innerRequest.ContentLength = value; } }
        public string ContentType { get { return _innerRequest.ContentType; } set { _innerRequest.ContentType = value; } }
        public ICredentials Credentials { get { return _innerRequest.Credentials; } set { _innerRequest.Credentials = value; } }
        public bool UseDefaultCredentials { get { return _innerRequest.UseDefaultCredentials; } set { _innerRequest.UseDefaultCredentials = value; } }
        public IWebProxy Proxy { get { return _innerRequest.Proxy; } set { _innerRequest.Proxy = value; } }
        public bool PreAuthenticate { get { return _innerRequest.PreAuthenticate; } set { _innerRequest.PreAuthenticate = value; } }
        public int Timeout { get { return _innerRequest.Timeout; } set { _innerRequest.Timeout = value; } }
        public AuthenticationLevel AuthenticationLevel { get { return _innerRequest.AuthenticationLevel; } set { _innerRequest.AuthenticationLevel = value; } }
        public TokenImpersonationLevel ImpersonationLevel { get { return _innerRequest.ImpersonationLevel; } set { _innerRequest.ImpersonationLevel = value; } }

        public Stream GetRequestStream()
        {
            throw new NotImplementedException();
        }

        public IWebResponse GetResponse()
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IWebResponse EndGetResponse(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public Stream EndGetRequestStream(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> GetRequestStreamAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IWebResponse> GetResponseAsync()
        {
            throw new NotImplementedException();
        }

        public void Abort()
        {
            throw new NotImplementedException();
        }

        public object GetLifetimeService()
        {
            throw new NotImplementedException();
        }

        public object InitializeLifetimeService()
        {
            throw new NotImplementedException();
        }

        public ObjRef CreateObjRef(Type requestedType)
        {
            throw new NotImplementedException();
        }
    }
}