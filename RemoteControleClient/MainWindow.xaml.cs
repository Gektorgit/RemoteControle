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
using RemoteControleClient.Repository;
using RemoteControleClient.DataBase;



namespace RemoteControleClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Authorization mWindow { get; set; }
        public class SIn
        {
            public string Name { get; set; }
            public string IP { get; set; }
            public int Port { get; set; }
            public string Det { get; set; }
            public SIn(string n, string ip, int p, string det)
            {
                Name = n;
                IP = ip;
                Port = p;
                Det = det;

            }
        }

        

        RemoteServiceClient proxy = new RemoteServiceClient();
        public MainWindow()
        {
            InitializeComponent();
            
            GetConf();

        }

        void GetConf()
        {
            try 
            { 
            ConfigurationRepository cr = new ConfigurationRepository();
            var quer = cr.GetAll();
            foreach (var p in quer)
            {
                SIn servData = new SIn(p.Name, p.IPAdress, p.port, p.Details);
                listView1.Items.Add(servData);
            }
            }
            catch
            {

                MessageBox.Show("Somthing is wrong");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               // proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri("net.tcp://10.4.32.109:1121/RemoteControleHost/RemoteService/"));
                if (MU.IsChecked == true)
                {

                    foreach (var item in listView1.Items)
                    {
                        SIn strcs = (SIn)item;
                        proxy = new RemoteServiceClient();
                        proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri("net.tcp://" + strcs.IP + ":" + strcs.Port + "/RemoteControleHost/RemoteService/"));
                        proxy.Block();
                    }
                    
                }
                else
                {
                    proxy.Block();
                }
            }
            catch
            {
                
                
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MU.IsChecked == true)
                {

                    foreach (var item in listView1.Items)
                    {
                        SIn strcs = (SIn)item;
                        proxy = new RemoteServiceClient();
                        proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri("net.tcp://" + strcs.IP + ":" + strcs.Port + "/RemoteControleHost/RemoteService/"));
                        proxy.UnBlock();
                    }

                }
                else
                {
                    proxy.UnBlock();
                }
            }
            catch
            {

                
            }
        }
        sendMesWnd smw;
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            List<string> ll = new List<string>();
            if (MU.IsChecked == true)
            {
                smw = new sendMesWnd();
                foreach (var item in listView1.Items)
                {
                    SIn strcs = (SIn)item;
                   ll.Add("net.tcp://" + strcs.IP + ":" + strcs.Port + "/RemoteControleHost/RemoteService/");
                }


                smw.ch = true;
                smw.ldata = ll;
                smw.Show();
            }
            else
            {
                smw = new sendMesWnd();
                smw.data = proxy.Endpoint.Address.Uri.AbsoluteUri;
                smw.ch = false;
                smw.Show();

            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (MU.IsChecked == true)
                {

                    foreach (var item in listView1.Items)
                    {
                        SIn strcs = (SIn)item;
                        proxy = new RemoteServiceClient();
                        proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri("net.tcp://" + strcs.IP + ":" + strcs.Port + "/RemoteControleHost/RemoteService/"));
                        proxy.ShutDown();
                    }

                }
                else
                {
                    proxy.ShutDown();
                }
            }
            catch
            {

                MessageBox.Show("Somthing is wrong");
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (MU.IsChecked == true)
                {

                    foreach (var item in listView1.Items)
                    {
                        SIn strcs = (SIn)item;
                        proxy = new RemoteServiceClient();
                        proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri("net.tcp://" + strcs.IP + ":" + strcs.Port + "/RemoteControleHost/RemoteService/"));
                        proxy.Reboot();
                    }
                }
                else
                {
                    proxy.Reboot();
                }
            }
            catch
            {

                MessageBox.Show("Somthing is wrong");
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
            string pr = proxy.CloseProcess();
            string[] pr2 = pr.Split('#');

            ProcListWindow w = new ProcListWindow();
            w.data2 = proxy.Endpoint.Address.Uri.AbsoluteUri;
         
            foreach (var item in pr2)
            {
                w.prclw.Items.Add(item);
            }
            w.Show();
            }
            catch
            {

                MessageBox.Show("Somthing is wrong");
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                byte[] bt = proxy.GetScreen();



                System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
                foreach (byte b1 in bt) memoryStream1.WriteByte(b1);
                System.Drawing.Image image1 = System.Drawing.Image.FromStream(memoryStream1);
                image1.Save(@"D:\pict.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                ScreenShotWnd swnd = new ScreenShotWnd();
                swnd.img.Source = new BitmapImage(new Uri(@"D:\pict.bmp"));
                swnd.Show();
            }
            catch
            {
                
            }
        }
        bool flag = true;
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            ServerDialog wnd1= new ServerDialog();
            wnd1.ShowDialog();

                if (wnd1.DialogResult == true)
                {
                   

                    SIn servData = new SIn(wnd1.tB1.Text, wnd1.tB2.Text, Convert.ToInt32(wnd1.tB3.Text), wnd1.tB4.Text);


                    listView1.Items.Add(servData);

                    flag = false;
                }
            flag = true;
            }
            catch
            {

                MessageBox.Show("Somthing is wrong");
            }

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            ConfigurationRepository cr = new ConfigurationRepository();
            
           
            try
            {
                SIn strc = (SIn)listView1.SelectedItem;
                Configuration obj = cr.GetAll().Where(p => p.Name == strc.Name).First();
                cr.Delete(obj);
                listView1.Items.Clear();

                GetConf();
            }
            catch
            {
                MessageBox.Show("Please choose item to delete NOOB!!! :-)(^_^)");
                
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MU.IsChecked == true)
                {
                    BannedProgrammsRepository bpr = new BannedProgrammsRepository();
                    string dayName = DateTime.Now.DayOfWeek.ToString();
                    string[] prc = new string[20];
                    foreach (var item in listView1.Items)
                    {
                        SIn strcs = (SIn)item;
                        proxy = new RemoteServiceClient();
                        proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri("net.tcp://" + strcs.IP + ":" + strcs.Port + "/RemoteControleHost/RemoteService/"));



                        try
                        {
                            var ProgramBlock = bpr.GetAll().Where(p => p.DaysOfWeek.Day == dayName).Select(p => p.ProgName).ToList();
                            for (int i = 0; i < ProgramBlock.Count; i++)
                            {
                                prc[i] = ProgramBlock[i];
                            }

                            proxy.KillProcesses(prc);
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {


                    string dayName = DateTime.Now.DayOfWeek.ToString();
                    BannedProgrammsRepository bpr = new BannedProgrammsRepository();
                    string[] prc = new string[20];
                    try
                    {
                        var ProgramBlock = bpr.GetAll().Where(p => p.DaysOfWeek.Day == dayName).Select(p => p.ProgName).ToList();
                        for (int i = 0; i < ProgramBlock.Count; i++)
                        {
                            prc[i] = ProgramBlock[i];
                        }

                        proxy.KillProcesses(prc);
                    }
                    catch
                    {
                    }
                }
            }
            catch { }
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProgrammBlockingSettings pbs = new ProgrammBlockingSettings();

                pbs.Show();

            }
            catch
            {

                MessageBox.Show("Somthing is wrong");
            }
        }

        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SIn strc = (SIn)listView1.SelectedItem;
            proxy = new RemoteServiceClient();
            proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(new Uri("net.tcp://"+strc.IP+":"+strc.Port+"/RemoteControleHost/RemoteService/"));
            MessageBox.Show(proxy.Endpoint.Address.Uri.AbsoluteUri);
           
         
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mWindow.Close();
        }

        private void MU_Checked(object sender, RoutedEventArgs e)
        {
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
        }

        private void MU_Unchecked(object sender, RoutedEventArgs e)
        {
            button8.Visibility = Visibility.Visible;
            button9.Visibility = Visibility.Visible;
        }
    }
}
