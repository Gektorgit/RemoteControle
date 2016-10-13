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
    /// Interaction logic for ProcListWindow.xaml
    /// </summary>
    public partial class ProcListWindow : Window
    {
        public class SIn
        {
            public string Name { get; set; }

            public SIn(string n)
            {
                Name = n;


            }
        }
        public string data2 { get; set; }
        RemoteServiceClient proxy = new RemoteServiceClient();
        public ProcListWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri(data2));
                SIn strc = new SIn(prclw.SelectedItem.ToString());
                proxy.KillProc(strc.Name);

                prclw.Items.Clear();
                string pr = proxy.CloseProcess();
                string[] pr2 = pr.Split('#');

                //proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress( new Uri( "net.tcp://192.168.0.100:8733/RemoteControleHost/RemoteService/"));

                foreach (var item in pr2)
                {
                    prclw.Items.Add(item);
                }

            }
            catch(Exception ex)
            {

            }

        }
    }
}
