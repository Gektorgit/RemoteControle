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
using RemoteControleClient.ServiceReference1;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RemoteControleClient
{
    /// <summary>
    /// Interaction logic for sendMesWnd.xaml
    /// </summary>
    public partial class sendMesWnd : Window
    {
        public string data { get; set; }
        public List<string> ldata { get; set; }
        public bool ch { get; set; }
        RemoteServiceClient proxy = new RemoteServiceClient();
        public sendMesWnd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ch == false)
            {
                proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri(data));
                proxy.DisplayMessage(mesBox.Text);
            }
            else
            {
                foreach (var item in ldata)
                {
                    proxy = new RemoteServiceClient();
                    proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri(item));
                    proxy.DisplayMessage(mesBox.Text);
                }
            }
            this.Close();
        }
    }
}
