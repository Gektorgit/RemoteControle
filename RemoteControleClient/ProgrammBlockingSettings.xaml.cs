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
    /// Interaction logic for ProgrammBlockingSettings.xaml
    /// </summary>
    public partial class ProgrammBlockingSettings : Window
    {
        public class SIn
        {
            public string Name { get; set; }
            
           
            public SIn(string n)
            {
                Name = n;
               
             

            }
        }

        public ProgrammBlockingSettings()
        {
            InitializeComponent();
        }
        public void GetProg(string d)
        {
            listView1.Items.Clear();
            BannedProgrammsRepository bpr = new BannedProgrammsRepository();
            var pr = bpr.GetAll().Where(p=>p.DaysOfWeek.Day==d);
            if (pr.Count()!= 0)
            {
                foreach (var p in pr)
                {

                    //SIn servData = new SIn(p.ProgName);


                    listView1.Items.Add(p.ProgName);
                }

            }
            else
            {
                MessageBox.Show("Nothing happened");
            }
        }
        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
            try {
                BannedProgrammsRepository bpr = new BannedProgrammsRepository();
                BannedProgramms bp = new BannedProgramms();
                DaysOfWeekRepository dowr = new DaysOfWeekRepository();
                AddProgToDBandLV add = new AddProgToDBandLV();
                add.ShowDialog();
                if (add.DialogResult == true)
                {
                    bp.Day_id = dowr.GetAll().Where(p => p.Day == add.comboBox.SelectedValue.ToString()).Select(p => p.id).First();
                    bp.ProgName = add.textBox1.Text;
                    bpr.Create(bp);
                    GetProg(comboBox1.SelectedValue.ToString());
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        private void button_Remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BannedProgrammsRepository bpr = new BannedProgrammsRepository();
                BannedProgramms bp = bpr.GetAll().Where(p => p.DaysOfWeek.Day == comboBox1.SelectedValue.ToString() && p.ProgName == listView1.SelectedItem.ToString()).First();
                DaysOfWeekRepository dowr = new DaysOfWeekRepository();
                
              
                bpr.Delete(bp);
               
                GetProg(comboBox1.SelectedValue.ToString());
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            DaysOfWeekRepository dowr = new DaysOfWeekRepository();
            comboBox1.ItemsSource = dowr.GetAll().Select(p=>p.Day);
          
            
            
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetProg(comboBox1.SelectedValue.ToString());
        }
    }
}
