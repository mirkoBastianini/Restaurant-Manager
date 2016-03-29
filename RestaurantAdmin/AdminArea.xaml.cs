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
    /// Logica di interazione per AdminArea.xaml
    /// </summary>
    public partial class AdminArea : Window
    {
        public AdminArea(string name)
        {
            InitializeComponent();
            labeladmin.Content = name;
            ListTable();
            ListUser();
            ListPrenotation();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListTable()
        {
            SqlConnection con;
            ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
            string connectionString = conSetting.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                //                SqlDataAdapter sda = new SqlDataAdapter("Select Tables.Name,Tables.Reserved,Prenotation.Date,Prenotation.Hour from Tables INNER JOIN Prenotation on Tables.Name=Prenotation.TableName where Tables.Reserved='No'", con);
                SqlDataAdapter sda = new SqlDataAdapter("Select Name,Reserved from Tables", con);

                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                dataGrid.ItemsSource = dt.DefaultView;
                sda.Update(dt);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void ListUser()
        {
            SqlConnection con;
            ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
            string connectionString = conSetting.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
               SqlDataAdapter sda = new SqlDataAdapter("Select * from Users", con);

                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                dataGrid_Copy.ItemsSource = dt.DefaultView;
                sda.Update(dt);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void ListPrenotation()
        {
            SqlConnection con;
            ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
            string connectionString = conSetting.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Tables.Name,Tables.Reserved,Prenotation.Date,Prenotation.Hour from Tables INNER JOIN Prenotation on Tables.Name=Prenotation.TableName", con);
               
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                dataGrid_Copy1.ItemsSource = dt.DefaultView;
                sda.Update(dt);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ListTable();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            ListUser();
        }

        private void button_Click11(object sender, RoutedEventArgs e)
        {
            ListPrenotation();
        }

        private void button_Click12(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
                string connectionString = conSetting.ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("INSERT INTO Tables(Table,Reserved) VALUES ('" + tablenameinsert.Text + "','" + comboBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Table inserted.", "Restaurant", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }

        private void button_Click123(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
                string connectionString = conSetting.ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("Delete from Users where Email='"+ deleteUser.Text+"'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("User deleted.", "Restaurant", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void button_Click1233(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
                string connectionString = conSetting.ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("Delete from Tables where Name='" + deleteTable.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Table deleted.", "Restaurant", MessageBoxButton.OK, MessageBoxImage.Information);

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
