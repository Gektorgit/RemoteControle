using RemoteControleClient.Repository;
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

namespace RemoteControleClient
{
    /// <summary>
    /// Interaction logic for AddProgToDBandLV.xaml
    /// </summary>
    public partial class AddProgToDBandLV : Window
    {
        public AddProgToDBandLV()
        {
            InitializeComponent();
            DaysOfWeekRepository dowr = new DaysOfWeekRepository();
            comboBox.ItemsSource = dowr.GetAll().Select(p => p.Day);
        }

        private void button_OK_Click(object sender, RoutedEventArgs e)
        {
           this.DialogResult = true;
            this.Close();
        }
    }
}
