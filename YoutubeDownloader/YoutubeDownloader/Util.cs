using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System.Net;
using System.Net.Http;
using System.Windows;
using YoutubeDownloader.Data;

namespace YoutubeDownloader
{
    internal class Util
    {
        public static Setting Setting;

        public static YouTubeService Service;

        public static void Initialize()
        {
            Setting = Setting.Load("settings.json");

            Service = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyDvdPiYnFMcbTGixqajbdt5ty6QkH-HkBA",
            });
            ReconfigureProxy();
        }

        public static void ReconfigureProxy()
        {
            if (Setting.Proxy.Status == ProxyStatus.Manual)
            {
                Service.HttpClient.MessageHandler.InnerHandler = new HttpClientHandler()
                {
                    Proxy = Setting.Proxy.GetWebProxy()
                };
            }
        }
    }
}
