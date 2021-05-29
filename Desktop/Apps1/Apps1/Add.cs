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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();

            string connectionStr = "Server=localhost; Port=5432; Database=store; User Id=postgres; Password=123";
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionStr);
                connection.Open();
                string strSQL = "SELECT id, categoryname FROM category";
                
                NpgsqlCommand command = new NpgsqlCommand(strSQL, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                var list = new List<Category>();
                while (reader.Read())
                {
                    list.Add(new Category() { id = Convert.ToInt32(reader["id"]), categoryname = Convert.ToString(reader["categoryname"]) });
                }
                reader.Close();
                cmbCategory.Items.AddRange(list.ToArray());

                string strSQL1 = "SELECT id, nickname FROM master";
                NpgsqlCommand command1 = new NpgsqlCommand(strSQL1, connection);
                NpgsqlDataReader reader1 = command1.ExecuteReader();
                var list1 = new List<Master>();
                while (reader1.Read())
                {
                    list1.Add(new Master() { Id = Convert.ToInt32(reader1["id"]), Nickname = Convert.ToString(reader1["nickname"]) });
                }
                connection.Close();
                cmbMaster.Items.AddRange(list1.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string connectionStr = "Server=localhost; Port=5432; Database=store; User Id=postgres; Password=123";
            try
            {
                var master = (Master)cmbMaster.SelectedItem;
                var idm = master.Id;
                var nickname = master.Nickname;

                var cat = (Category)cmbCategory.SelectedItem;
                var idc = cat.id;
                var name = cat.categoryname;

                NpgsqlConnection connection = new NpgsqlConnection(connectionStr);
                connection.Open();
              
                string strSQL = "INSERT INTO product1 (name, description, id_master, id_category, price) VALUES ('" + textBox1.Text +
                    "','" + textBox2.Text + "','" + master.Id + "','" + 
                    cat.id + "'," + Convert.ToDecimal(textBox3.Text) + ")";

                NpgsqlCommand command = new NpgsqlCommand(strSQL, connection);

                if (command.ExecuteNonQuery() == 1) 
                    MessageBox.Show("Запись успешно добавлена!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Loaddgv();
        }

        private void Add_Load(object sender, EventArgs e) { }
        private void Loaddgv()
        {
            
            string connectionStr = "Server=localhost; Port=5432; Database=store; User Id=postgres; Password=123";
            try
            {
                NpgsqlConnection Connection = new NpgsqlConnection(connectionStr);
                Connection.Open();
                string strSQL = "SELECT * FROM product1";
                NpgsqlCommand command = new NpgsqlCommand(strSQL, Connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                dgvData.DataSource = table.DefaultView;
                dgvData.Columns[0].Visible = false;
                dgvData.Columns[1].HeaderText = "Наименование";
                dgvData.Columns[2].HeaderText = "Описание";

                dgvData.Columns[3].HeaderText = "ID Мастерa"; //???
                dgvData.Columns[3].Visible = false;
                dgvData.Columns[4].HeaderText = "ID Категории"; //???
                dgvData.Columns[4].Visible = false;

                dgvData.Columns[5].HeaderText = "Цена";

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}