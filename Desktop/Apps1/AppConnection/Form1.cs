using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AppConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string connectionStr = "Server=localhost; Port=5432; Database=store1; User Id=postgres; Password=123";
            try
            {
                NpgsqlConnection Connection = new NpgsqlConnection(connectionStr);
                Connection.Open();
                string strSQL = "SELECT * FROM category";

                NpgsqlCommand command = new NpgsqlCommand(strSQL, Connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table.DefaultView;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            String connectionString = "server=localhost; port=5432; uid=postgres; password=123;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select datname from pg_database", npgSqlConnection);
            try
            {
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        comboBox1.Items.Add(dr[i]);
                        comboBox1.SelectedItem = comboBox1.Items[0];
                    }
                }
                label1.Text = "Выберите БД из списка и нажмите кнопку 'Подключение'";
            }
            catch (NpgsqlException ex)
            {
                label4.Text = (ex.ToString());
            }
            npgSqlConnection.Close();
        }

        private void connectButon_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string Store = comboBox1.Text;
            String connectionString = $"server=localhost;port=5432;uid=postgres;password=123;database="+Store+";";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            label4.Text = $"Открыто подключение с базой данных " + npgSqlConnection.Database;
            //npgSqlConnection.Close();
        }
    }
}