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
    public partial class Search : Form
    {
        string strSQL, strOp;
        public string connectionStr = "Server=localhost; Port=5432; Database=store; User Id=postgres; Password=123";
        public Search()
        {
            InitializeComponent();
            
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
                connection.Close();
                cmbCategory.Items.AddRange(list.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_Load(object sender, EventArgs e){ }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (chBCategory.Checked == false & chBPrice.Checked == false)
            {
                MessageBox.Show("Выберите критерий поиска!");
                return;
            }

            var cat = (Category)cmbCategory.SelectedItem;
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("О нет, вы не выбрали категорию!");
                return;
            }    

            var id = cat.id;
            var name = cat.categoryname;
            
            if (chBCategory.Checked == false || chBPrice.Checked == false)
                strOp = "OR";
            else strOp = "AND";
           
            if (chBPrice.Checked == true)
                strSQL = "SELECT name, description, price FROM product WHERE Price >= '" + textBox1.Text + "'";
            if (chBCategory.Checked == true)
                strSQL = "SELECT name, description, price FROM product WHERE id_category = '" + cat.id + "'";
      
            if (chBPrice.Checked == true & chBCategory.Checked == true)
                strSQL = "SELECT name, description, price FROM product WHERE ID_Category = '" + cat.id + "'" + strOp + " Price >='" + textBox1.Text + "'";
            
            try
            {
                NpgsqlConnection Connection = new NpgsqlConnection(connectionStr);
                Connection.Open();

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
    }
}