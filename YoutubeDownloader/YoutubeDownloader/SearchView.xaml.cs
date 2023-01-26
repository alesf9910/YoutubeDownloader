using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

namespace YoutubeDownloader
{
    /// <summary>
    /// Lógica de interacción para SearchView.xaml
    /// </summary>
    public partial class SearchView : Page
    {
        public SearchView()
        {
            InitializeComponent();
        }

        private async void Search()
        {
            searchList.Children.Clear();
            SearchResource.ListRequest k = Util.Service.Search.List("snippet");
            k.Q = seacrhText.Text;
            try
            {
                SearchListResponse sr = await k.ExecuteAsync();
                foreach (var i in sr.Items)
                {
                    searchList.Children.Add(new VideoDetailView(i.Snippet));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            Search();
        }

        private void seacrhText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Search();
            }
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            
        }
    }
}
