using Google.Apis.YouTube.v3.Data;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YoutubeDownloader.Data;

namespace YoutubeDownloader
{
    /// <summary>
    /// Lógica de interacción para VideoDetailView.xaml
    /// </summary>
    public partial class VideoDetailView : Card
    {
        public VideoDetailView(SearchResultSnippet snippet)
        {
            this.DataContext = snippet;
            InitializeComponent();
            BitmapImage image = new BitmapImage();
            SearchResult sr;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(snippet.Thumbnails.High.Url);
            if (Util.Setting.Proxy.Status == ProxyStatus.Manual)
            {
                req.Proxy = Util.Setting.Proxy.GetWebProxy();
            }
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            image.BeginInit();
            image.StreamSource = res.GetResponseStream();
            image.EndInit();
            videoImg.Source = image;            
        }
    }
}
