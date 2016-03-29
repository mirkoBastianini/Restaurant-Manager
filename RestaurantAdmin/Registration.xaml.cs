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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantAdmin
{
    /// <summary>
    /// Logica di interazione per Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
  

        public Registration()
        {
            InitializeComponent();
        }

        private void buttonadmin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
                string connectionString = conSetting.ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("INSERT INTO Users(Username,Password,Email,Telephone,Address) VALUES ('" + usernameRegister.Text + "','" + passwordregister.Password + "','" + emailRegister.Text + "','" + telephoneregister.Text + "','" + addressregister.Text+ "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
            
            
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
