using System;
using System.Net;

namespace YoutubeDownloader.Data
{
    [Serializable]
    public class Proxy
    {
        public ProxyStatus Status { get; set; } = ProxyStatus.NoProxy;
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public WebProxy GetWebProxy()
        {
            WebProxy proxy = new WebProxy(Host, Port);
            if(!string.IsNullOrEmpty(User) || !string.IsNullOrEmpty(Password))
            {
                proxy.Credentials = new NetworkCredential()
                {
                    UserName = User,
                    Password = Password
                };
            }
            return proxy;
        }
    }

    [Serializable]
    public enum ProxyStatus
    {
        NoProxy,
        Manual
    }
}