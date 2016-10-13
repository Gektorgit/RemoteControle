using RemoteControleClient.DataBase;
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
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {

        public Authorization()
        {
            InitializeComponent();
        }

        private void Reg_button_Click(object sender, RoutedEventArgs e)
        {
            UsersRepository usrep = new UsersRepository();
            Users us = new Users();

            if (textFirstName.Text != String.Empty && textLastName.Text != String.Empty &&
                textUserName.Text != String.Empty && textPassword.Text != String.Empty &&
                textHelp.Text != String.Empty && textEmail.Text != String.Empty)
            {
                us.Firstname = textFirstName.Text;
                us.Lastname = textLastName.Text;
                us.Username = textUserName.Text;
                us.Password = textPassword.Text;
                us.Help = textHelp.Text;
                us.E_Mail = textEmail.Text;
                usrep.Create(us);
                MessageBox.Show("New Client create");
            }
            else
                MessageBox.Show("Not all fields is fullfield");
        }

        private void textUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UsersRepository usrep = new UsersRepository();
            try
            {
                string usName = usrep.GetAll().Where(p => p.Username == textUserName.Text).Select(p => p.Username).First();
                MessageBox.Show("This username already exists");
            }
            catch
            {

            }
        }

        private void AdminPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            UsersRepository usrep = new UsersRepository();
            try
            {
                string password = usrep.GetAll().Where(p => p.Password == AdminPass.Password && p.Username == "Admin").Select(p => p.Password).First();
                labAdminPass.Visibility = Visibility.Hidden;
                AdminPass.Visibility = Visibility.Hidden;

                labfirstName.Visibility = Visibility.Visible;
                lablastname.Visibility = Visibility.Visible;
                labusername.Visibility = Visibility.Visible;
                labpassword.Visibility = Visibility.Visible;
                labhelp.Visibility = Visibility.Visible;
                labEmail.Visibility = Visibility.Visible;

                textFirstName.Visibility = Visibility.Visible;
                textLastName.Visibility = Visibility.Visible;
                textUserName.Visibility = Visibility.Visible;
                textPassword.Visibility = Visibility.Visible;
                textHelp.Visibility = Visibility.Visible;
                textEmail.Visibility = Visibility.Visible;
                Reg_button.Visibility = Visibility.Visible;
            }
            catch
            {

            }
        }

        private void MyTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            labAdminPass.Visibility = Visibility.Visible;
            AdminPass.Visibility = Visibility.Visible;
            AdminPass.Password = String.Empty;

            labfirstName.Visibility = Visibility.Hidden;
            lablastname.Visibility = Visibility.Hidden;
            labusername.Visibility = Visibility.Hidden;
            labpassword.Visibility = Visibility.Hidden;
            labhelp.Visibility = Visibility.Hidden;
            labEmail.Visibility = Visibility.Hidden;

            textFirstName.Visibility = Visibility.Hidden;
            textLastName.Visibility = Visibility.Hidden;
            textUserName.Visibility = Visibility.Hidden;
            textPassword.Visibility = Visibility.Hidden;
            textHelp.Visibility = Visibility.Hidden;
            textEmail.Visibility = Visibility.Hidden;
            Reg_button.Visibility = Visibility.Hidden;
        }

        private void Ok_button_Click(object sender, RoutedEventArgs e)
        {
            UsersRepository usrep = new UsersRepository();
            if (tbUserName.Text != String.Empty && tbPassword.Text != String.Empty)
            {
                try
                {
                    var exist = usrep.GetAll().Where(p => p.Username == tbUserName.Text && p.Password == tbPassword.Text).ToList();
                    if (exist.Count() > 0)
                    {
                        MainWindow mWindow = new MainWindow();
                        this.Visibility = Visibility.Hidden;
                        mWindow.mWindow = this;
                        mWindow.Show();
                    }
                    else
                        MessageBox.Show("Такой пользователь не зарегистрирован");
                }
                catch
                {

                }
            }
        }

        private void tbUserName_GotFocus(object sender, RoutedEventArgs e) // Изменил
        {
            tbUserName.Text = String.Empty;
        }

        private void tbPassword_GotFocus(object sender, RoutedEventArgs e) // Изменил
        {
            tbPassword.Text = String.Empty;
        }
    }
}
