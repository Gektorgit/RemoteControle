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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Diagnostics;

namespace RemoteControleHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RemoteService" in both code and config file together.
    public class RemoteService : IRemoteService
    {
        ImgWind wind;
        static List<string> listPrc = new List<string>();
        ThreadStart ts;
        Thread thr;
        static Timer t;
        public void Block()
        {
            wind = new ImgWind();
            wind.Topmost = true;
            StreamWriter file = new StreamWriter(new FileStream(@"D:\acs.txt", FileMode.Create, FileAccess.Write));

            file.Write("1");
            file.Close();
            
            wind.Show();
            wind.Focus();

        }


        public byte[] GetScreen()
        {

            BufferedGraphicsContext _currentContext;
            BufferedGraphics _myBuffer;
            System.Drawing.Rectangle _maximizedWindowRect =
              new System.Drawing.Rectangle(0, 0,
                  System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize.Width,
                  System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize.Height);

            Bitmap bmp;
            Graphics g;
            System.Drawing.Size ScreenSize = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            Bitmap image = new Bitmap(ScreenSize.Width, ScreenSize.Height);
            bmp = image;
            g = Graphics.FromImage(bmp);
            _currentContext = BufferedGraphicsManager.Current;
            _myBuffer = _currentContext.Allocate(g, _maximizedWindowRect);
            g.CopyFromScreen(System.Drawing.Point.Empty, System.Drawing.Point.Empty, ScreenSize);
            _myBuffer.Graphics.CopyFromScreen(System.Drawing.Point.Empty, System.Drawing.Point.Empty, ScreenSize);

            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            bmp.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] b = memoryStream.ToArray();
            return b;
        }

        public void UnBlock()
        {
            try
            {

                StreamWriter file = new StreamWriter(new FileStream(@"D:\acs.txt", FileMode.Create, FileAccess.Write));
               
                file.Write("0");
                file.Close();
                
            }
            catch
            {
              
            }
            try
            {
                wind.Close();
            }
            catch
            {


            }
        }
        public void ShutDown()
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        public void Reboot()
        {
            System.Diagnostics.Process.Start("shutdown", "/r /t 0");
        }

        public string CloseProcess()
        {
            string s_p = String.Empty;
            System.Diagnostics.Process[] p_arr = System.Diagnostics.Process.GetProcesses();
            foreach (var p in p_arr)
            {
                s_p += "#" + p.ProcessName;

            }
            return s_p;
        }
        public void KillProc(string prc)
        {
            System.Diagnostics.Process[] local_procs = System.Diagnostics.Process.GetProcesses();
            try
            {
                System.Diagnostics.Process target_proc = local_procs.First(p => p.ProcessName == prc);
                target_proc.Kill();
            }
            catch 
            {


            }
        }
        public void DisplayMessage(string msg)
        {
            timer1 = new System.Windows.Threading.DispatcherTimer();
            timer1.Tick += new EventHandler(dispatcherTimer_Tick);
            timer1.Interval = new TimeSpan(0, 0, 1);
            msge = msg;
            timer1.Start();

        }
        Message_window mW;
        int counter;
        DispatcherTimer timer1;

        string msge;
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            if (counter == 0)
            {
                mW = new Message_window();
                mW.Topmost = true;
                mW.WrnTxtBx.Text = msge;
                mW.Show();
            }
            counter++;

            if (counter == 15)
            {

                timer1.Stop();
                mW.Close();
                counter = 0;
            }

        }
        string temp;
        public void KillProcesses(string[] prc)
        {
            temp = String.Empty;

            foreach (var i in prc)
            {
                listPrc.Add(i);
                if (i != null)
                {
                    temp += i + "#";
                }   
            }

            try
            {

                StreamWriter file = new StreamWriter(new FileStream(@"D:\prclist.txt", FileMode.Create, FileAccess.Write));

                file.Write(temp);
                file.Close();

            }
            catch
            {

            }
            ts = new ThreadStart(ThreadMethod);
            thr = new Thread(ts);
            thr.Start();

        }

        static void ThreadMethod()
        {

            t = new Timer(timer_Tick);
            t.Change(0, 2000);
        }

        static void timer_Tick(object sender)
        {
            Process[] local_procs = Process.GetProcesses();
            Process target_proc;
            foreach (string name in listPrc)
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
    }
}
