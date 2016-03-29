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
    /// Logica di interazione per UserArea.xaml
    /// </summary>
    public partial class UserArea : Window
    {
        public UserArea(string name)
        {
            InitializeComponent();
            labeluser.Content = name;
            ListTable();
            ListTablePrenotation();
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
                SqlDataAdapter sda = new SqlDataAdapter("Select Name,Reserved from Tables where Reserved='No'", con);

                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                dataGrid.ItemsSource = dt.DefaultView;
                sda.Update(dt);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void ListTablePrenotation()
        {
            SqlConnection con;
            ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
            string connectionString = conSetting.ConnectionString;
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select TableName,Date,Hour from Prenotation where Username='"+labeluser.Content+"'", con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                dataGridprenotation.ItemsSource = dt.DefaultView;
                sda.Update(dt);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            insertDB();
            updateDB();
            MessageBox.Show("Prenotation Inserted.", "Restaurant", MessageBoxButton.OK, MessageBoxImage.Information);

           
        }
        private void insertDB()
        {
            try
            {
                SqlConnection con;
            SqlCommand cmd;
            ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
            string connectionString = conSetting.ConnectionString;
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("INSERT INTO Prenotation(TableName,Date,Hour,Username) VALUES ('" + prenotationtable.Text + "','" + prenotationdate.Text + "','" + prenotationhour.Text + "','" + labeluser.Content + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void updateDB()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd1;
                ConnectionStringSettings conSetting = ConfigurationManager.ConnectionStrings["Conn"];
                string connectionString = conSetting.ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                 cmd1 = new SqlCommand("UPDATE Tables SET Reserved='Yes' WHERE Name='" + prenotationtable.Text + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ListTable();
        }

        private void button_Clicklist(object sender, RoutedEventArgs e)
        {
            ListTablePrenotation();
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
