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
using System.Windows.Shapes;

namespace RemoteControleHost
{
    /// <summary>
    /// Interaction logic for Message_window.xaml
    /// </summary>
    public partial class Message_window : Window
    {
        public Message_window()
        {
            InitializeComponent();
            WrnTxtBx.Width = this.Width;
        }
    }
}
