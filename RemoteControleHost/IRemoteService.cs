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


namespace RemoteControleHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRemoteService" in both code and config file together.
    [ServiceContract]
    public interface IRemoteService
    {
        [OperationContract]
         void Block();
        [OperationContract]
        byte[] GetScreen();
        [OperationContract]
        void UnBlock();
        [OperationContract]
        void ShutDown();
        [OperationContract]
        void Reboot();
        [OperationContract]
        string CloseProcess();
        [OperationContract]
        void KillProc(string prc);
        [OperationContract]
        void DisplayMessage(string msg);

        [OperationContract]
        void KillProcesses(string[] prc);
    }
}
