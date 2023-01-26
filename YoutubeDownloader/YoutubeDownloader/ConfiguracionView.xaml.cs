using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using YoutubeDownloader.Data;

namespace YoutubeDownloader
{
    /// <summary>
    /// Lógica de interacción para ConfiguracionView.xaml
    /// </summary>
    public partial class ConfiguracionView : Page
    {
        public ConfiguracionView()
        {
            InitializeComponent();
            AddressText.Text = Util.Setting.Proxy.Host;
            PortText.Text = Util.Setting.Proxy.Port.ToString();
            UserText.Text = Util.Setting.Proxy.User;
            PassText.Password = Util.Setting.Proxy.Password;
            if(Util.Setting.Proxy.Status == ProxyStatus.Manual)
            {
                ProxyState.SelectedIndex = 1;
            }
            else
            {
                ProxyState.SelectedIndex = 0;
            }
        }

        private void ProxyBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Util.Setting.Proxy.Host = AddressText.Text;
            Util.Setting.Proxy.Port = int.Parse(PortText.Text);
            Util.Setting.Proxy.User = UserText.Text;
            Util.Setting.Proxy.Password = PassText.Password;
            string sel = (string)ProxyState.SelectedItem;
            if (sel == "Manual")
            {
                Util.Setting.Proxy.Status = ProxyStatus.Manual;
            }
            else if (sel == "Sin Proxy")
            {
                Util.Setting.Proxy.Status = ProxyStatus.NoProxy;
            }
            Util.ReconfigureProxy();
        }

        private void ProxyState_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string sel = (string)ProxyState.SelectedItem;
            if (sel == "Manual")
            {
                contentDataProxy.IsEnabled = true;
            }
            else if (sel == "Sin Proxy")
            {
                contentDataProxy.IsEnabled = false;
            }
        }
    }
}
