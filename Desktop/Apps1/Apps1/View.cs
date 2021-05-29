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

namespace Apps1
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string nameTable = "";
            string strSQL;
            switch (cmbData.SelectedIndex)
            {
                case 0: nameTable = "master"; break;
                case 1: nameTable = "client"; break;
            }

            strSQL = "SELECT * FROM " + nameTable;

            string connectionStr = "Server=localhost; Port=5432; Database=store; User Id=postgres; Password=123";
            try
            {
                if(cmbData.SelectedItem == null)
                {
                    MessageBox.Show("Выберите пользователя");
                }
                
                NpgsqlConnection Connection = new NpgsqlConnection(connectionStr);
                Connection.Open();

                NpgsqlCommand command = new NpgsqlCommand(strSQL, Connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                dgvData.DataSource = table.DefaultView;
                dgvData.Columns[0].Visible = false;
                dgvData.Columns[2].HeaderText = "Пароль";
                dgvData.Columns[3].HeaderText = "Фамилия";
                dgvData.Columns[4].HeaderText = "Имя";
                dgvData.Columns[5].HeaderText = "Отчество";
                dgvData.Columns[6].HeaderText = "Телефон";
                dgvData.Columns[7].HeaderText = "Дата регистрации";
                dgvData.Columns[8].HeaderText = "Дата рождения";

                if (cmbData.SelectedIndex == 0)
                {
                    dgvData.Columns[9].Visible = false; //Описание вида деятельности
                    dgvData.Columns[10].HeaderText = "Никнейм";
                }

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadButtonProduct_Click(object sender, EventArgs e)
        {
            string strSQL2;
            strSQL2 = "SELECT * FROM product1";
            string info;
            string connectionStr = "Server=localhost; Port=5432; Database=store; User Id=postgres; Password=123";
            try
            {
                NpgsqlConnection Connection = new NpgsqlConnection(connectionStr);
                Connection.Open();

                NpgsqlCommand command = new NpgsqlCommand(strSQL2, Connection);
               
                NpgsqlDataReader reader1 = command.ExecuteReader();
                while (reader1.Read())
                {
                    info = "Наименование: " + reader1["Name"] + " " + "Описание: " +
                        Convert.ToString(reader1["Description"]) + " " + "Цена: " +
                        Convert.ToString(reader1["Price"]) + "₽";
                    this.listBox1.Items.Add(info);
                }

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}