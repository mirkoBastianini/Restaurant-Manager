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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantAdmin
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonadmin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
                string connectionString = conSetting.ConnectionString;
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Admin Where Username='" + useradmin.Text + "' and Password='" + passwordadmin.Password + " '", connectionString);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nessun utente trovato!");

                }
                else if (dt.Rows.Count >= 2)
                {
                    MessageBox.Show("Utente duplicato!");
                }
                else
                {
                    this.Hide();
                    AdminArea admin = new AdminArea(useradmin.Text);
                    admin.Show();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonuser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
                string connectionString = conSetting.ConnectionString;
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Users Where Username='" + useruser.Text + "' and Password='" + passworduser.Password + " '", connectionString);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nessun utente trovato!");

                }
                else if (dt.Rows.Count >= 2)
                {
                    MessageBox.Show("Utente duplicato!");
                }
                else
                {
                    this.Hide();
                    UserArea user = new UserArea(useruser.Text);
                    user.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonuser_Click1(object sender, RoutedEventArgs e)
        {
            
            Registration reg = new Registration();
            reg.Show();
        }

        private void Button_Click444(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3333(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RestaurantAdmin v1.0\nCreated By Mirko Bastianini.", "Restaurant", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
