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
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.ServiceModel;
using NDde;
using NDde.Client;
using SHDocVw;
using IWshRuntimeLibrary;
using System.Diagnostics;


namespace RemoteControleHost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceHost sh;
         ThreadStart ts;
            Thread thr;
         ThreadStart ts2;
            Thread thr2;
            ThreadStart ts3;
            Thread thr3;
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                CreateShortCut(System.Windows.Forms.Application.ExecutablePath, System.Windows.Forms.Application.ExecutablePath.Substring(0, System.Windows.Forms.Application.ExecutablePath.LastIndexOf('\\')), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\ExeName.lnk");
            }
            catch
            {

            }
        }
        private void CreateShortCut(string FilePath, string WorkDir, string SaveTo)
        {
            var WshShell = new WshShellClass();
            IWshRuntimeLibrary.IWshShortcut MyShortcut;
            MyShortcut = (IWshRuntimeLibrary.IWshShortcut)WshShell.CreateShortcut(SaveTo);
            //путь к exe
            MyShortcut.TargetPath = FilePath;
            MyShortcut.Description = "Запуск";
            //рабочая диреткория
            MyShortcut.WorkingDirectory = WorkDir;
            MyShortcut.Save();
            //MessageBox.Show("Path:  " + MyShortcut.TargetPath + "\nDir:  " + MyShortcut.WorkingDirectory + "Where to save:   " + SaveTo);
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
               
                
                sh = new ServiceHost(typeof(RemoteService));

                sh.Description.Endpoints[0].Address = new EndpointAddress(new Uri("net.tcp://" + textBox1.Text + ":" + textBox2.Text + "/RemoteControleHost/RemoteService/"));
               
                sh.Description.Endpoints[0].ListenUri = new Uri("net.tcp://" + textBox1.Text + ":" + textBox2.Text + "/RemoteControleHost/RemoteService/");
                //MessageBox.Show(sh.Description.Endpoints[0].ListenUri.ToString());
              
                sh.Open();
                button1.IsEnabled = false;
                button2.IsEnabled = true;
                label2.Content = "Online";
                label2.Foreground = new SolidColorBrush(Colors.LimeGreen);
            }
            catch 
            {
               

            }
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            sh.Close();
            button1.IsEnabled = true;
            button2.IsEnabled = false;
            label2.Content = "Offline";
            label2.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            if (sh != null)
                sh.Close();
        }
        ImgWind wind;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
            button2.IsEnabled = false;
            try
            {
                StreamReader file2 = new StreamReader(new FileStream(@"D:\acs.txt", FileMode.Open, FileAccess.Read));

                string check = file2.ReadLine();
                MessageBox.Show(check);
                int bl = Convert.ToInt32(check);
                if (bl == 1)
                {
                    wind = new ImgWind();
                    wind.Topmost = true;
                    wind.Show();
                    wind.Focus();
                }
                file2.Close();
            }
            catch
            {
            }

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    textBox1.Text = ip.ToString();
                }
            }

            ts = new ThreadStart(ThreadMethod);
             thr = new Thread(ts);
             ts2 = new ThreadStart(ThreadMethod2);
             thr2 = new Thread(ts2);
             ts3 = new ThreadStart(ThreadMethod3);
             thr3 = new Thread(ts3);
            thr.Start();
            thr2.Start();
            thr3.Start();
        }

        static void ThreadMethod()
        {
            System.Threading.Timer t;
            t = new System.Threading.Timer(Timer_t);
            t.Change(0, 1000);
        }
        static void ThreadMethod2()
        {
            System.Threading.Timer t2;
            t2 = new System.Threading.Timer(Timer_t2);
            t2.Change(0, 3000);

        }
        static void ThreadMethod3()
        {
           System.Threading.Timer t3;
            t3 = new System.Threading.Timer(Timer_t3);
            t3.Change(0, 1000);
        }
        static void Timer_t3(object sender)
        {
            StreamReader file2 = new StreamReader(new FileStream(@"D:\prclist.txt", FileMode.Open, FileAccess.Read));

            string check = file2.ReadLine();
            string []check2 = check.Split('#');
            Process[] local_procs = Process.GetProcesses();
            Process target_proc;
            foreach (string name in check2)
            {
                try
                {
                    target_proc = local_procs.First(p => p.ProcessName == name);
                    target_proc.Kill();
                }
                catch (Exception)
                {
                    continue;
                }

            }
        }
      static void Timer_t(object sender)
        {
            
             string strc = String.Empty;
          
          try
          {
              System.Diagnostics.Process[] local_procs2 = System.Diagnostics.Process.GetProcesses();
              System.Diagnostics.Process target_proc2 = local_procs2.First(p => p.ProcessName == "chrome");
              target_proc2.Kill();
          }
          catch
          {


          }
              try
          {
              System.Diagnostics.Process[] local_procs3 = System.Diagnostics.Process.GetProcesses();
              System.Diagnostics.Process target_proc3 = local_procs3.First(p => p.ProcessName == "opera");
              target_proc3.Kill();
          }
                      catch
          {


          }
                  try
          {
              System.Diagnostics.Process[] local_procs4 = System.Diagnostics.Process.GetProcesses();
              System.Diagnostics.Process target_proc4 = local_procs4.First(p => p.ProcessName == "safari");
              target_proc4.Kill();
          }
          catch
          {


          }
          try
          {
              string s = GetURL((IntPtr)0, "firefox", out strc);
              
              string[] strcs = s.Split('/');
              
              if (strcs[2].Equals("vk.ru") || strcs[2].Equals("vk.com") || strcs[2].Equals("www.youtube.com") || strcs[2].Equals("twitter.com")
                  || strcs[2].Equals("uk-ua.facebook.com") || strcs[2].Equals("www.facebook.com") || strcs[2].Equals("ru - ru.facebook.com")
                  || strcs[2].Equals("ok.ru") || strcs[2].Equals("odnoklassniki.ru") || strcs[2].Equals("instagram.com"))
              {
                  System.Diagnostics.Process[] local_procs = System.Diagnostics.Process.GetProcesses();
                  try
                  {
                      System.Diagnostics.Process target_proc = local_procs.First(p => p.ProcessName == "firefox");

                      target_proc.Kill();
                      MessageBox.Show("Был открыт запрещенный сайт!!! Оставайтесь на месте, полиция уже едет!!! ");
                  }
                  catch 
                  {


                  }
              }
          }
          catch
          {



          }
   

        }

       static void Timer_t2(object sender)
        {

            try
            {
                foreach (InternetExplorer ie in new ShellWindows())
                {
                    var fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(ie.FullName);
                    if (fileNameWithoutExtension != null)
                    {
                        var filename = fileNameWithoutExtension.ToLower();
                        if (filename.Equals("iexplore"))
                        {
                            string[] strcs2 = ie.LocationURL.Split('/');

                            if (strcs2[2].Equals("vk.ru") || strcs2[2].Equals("vk.com") || strcs2[2].Equals("www.youtube.com") || strcs2[2].Equals("twitter.com")
                    || strcs2[2].Equals("uk-ua.facebook.com") || strcs2[2].Equals("www.facebook.com") || strcs2[2].Equals("ru - ru.facebook.com")
                    || strcs2[2].Equals("ok.ru") || strcs2[2].Equals("odnoklassniki.ru") || strcs2[2].Equals("instagram.com"))
                            {
                                System.Diagnostics.Process[] local_procs8 = System.Diagnostics.Process.GetProcesses();
                                try
                                {
                                    System.Diagnostics.Process target_proc8 = local_procs8.First(p => p.ProcessName == "iexplore");

                                    target_proc8.Kill();
                                    MessageBox.Show("Был открыт запрещенный сайт!!! Оставайтесь на месте, полиция уже едет!!! ");
                                }
                                catch
                                {


                                }
                            }
                        }
                    }

                }




            }


            catch
            {


            }

        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr parentHandle,
        IntPtr childAfter, string className, IntPtr windowTitle);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd,
            int msg, int wParam, StringBuilder ClassName);

        private static string GetURL(IntPtr intPtr, string programName, out string url)
        {
            string temp = null;
            if (programName.Equals("chrome"))
            {
                var hAddressBox = FindWindowEx(intPtr, IntPtr.Zero, "Chrome_OmniboxView", IntPtr.Zero);
                var sb = new StringBuilder(256);
                SendMessage(hAddressBox, 0x000D, 256, sb);
                temp = sb.ToString();

            }
            if (programName.Equals("iexplore"))
            {
                foreach (InternetExplorer ie in new ShellWindows())
                {
                    var fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(ie.FullName);
                    if (fileNameWithoutExtension != null)
                    {
                        var filename = fileNameWithoutExtension.ToLower();
                        if (filename.Equals("iexplore"))
                        {
                            temp += ie.LocationURL + " ";
                        }
                    }
                }
            }
            if (programName.Equals("firefox"))
            {
                DdeClient dde = new DdeClient("Firefox", "WWW_GetWindowInfo");
                dde.Connect();

                string url1 = dde.Request("URL", int.MaxValue);
                dde.Disconnect();
                temp = url1.Replace("\"", "").Replace("\0", "");
            }

            url = temp;
            return temp;
        }
    }
}
