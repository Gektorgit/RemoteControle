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
using RemoteControleClient.Repository;
using RemoteControleClient.DataBase;

namespace RemoteControleClient
{
    /// <summary>
    /// Interaction logic for ServerDialog.xaml
    /// </summary>
    public partial class ServerDialog : Window
    {
        public ServerDialog()
        {
            InitializeComponent();

        }
        bool err = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                ConfigurationRepository cr = new ConfigurationRepository();
                Configuration conf = new Configuration();

                if (tB1.Text != String.Empty && tB2.Text != String.Empty && tB3.Text != String.Empty)
                {
                    try
                    {
                        int Name = cr.GetAll().Where(p => p.Name == tB1.Text).Select(p => p.id).First();
                        MessageBox.Show("Such item exists in database try another name");
                        err = false;
                    }
                    catch (Exception)
                    {
                        conf.Name = tB1.Text;
                        err = true;
                    }
                    try
                    {
                        int IPAddres = cr.GetAll().Where(p => p.IPAdress == tB2.Text).Select(p => p.id).First();
                        MessageBox.Show("Such item exists in database try another IPAdress");
                    }
                    catch (Exception)
                    {
                        if (err)
                        {
                            conf.IPAdress = tB2.Text;
                            conf.port = Convert.ToInt32(tB3.Text);
                            conf.Details = tB4.Text;
                            cr.Create(conf);
                            Win1.DialogResult = true;
                            Win1.Close();
                        }
                        
                    }
                    

                }
                else
                {
                    MessageBox.Show("Not all fields is fullfield");
                }
        }
    }
}
