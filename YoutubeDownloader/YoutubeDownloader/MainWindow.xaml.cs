using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Util.Initialize();
            ContentView.Navigate(new Uri("SearchView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == Mouse.LeftButton)
            {
                this.DragMove();
            }
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void max_btn_Click(object sender, RoutedEventArgs e)
        {
            PackIcon pack = new PackIcon();
            if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                pack.Kind = PackIconKind.WindowRestore;
                max_btn.Content = pack;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                pack.Kind = PackIconKind.WindowMaximize;
                max_btn.Content = pack;
            }
            
        }

        private void min_btn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void SettingBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentView.Navigate(new Uri("ConfiguracionView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentView.Navigate(new Uri("SearchView.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Util.Setting.Save("settings.json");
        }
    }
}
