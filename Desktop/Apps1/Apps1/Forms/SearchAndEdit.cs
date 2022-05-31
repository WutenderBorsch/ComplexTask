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
    public partial class SearchAndEdit : Form
    {
        public string strSQL;
        public string connectionStr = "Server=localhost; Port=5432; Database=store; User Id=postgres; Password=123";

        public SearchAndEdit()
        {
            InitializeComponent();
            
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionStr);
                connection.Open();
                string strSQLCat = "SELECT id, categoryname FROM category";
                NpgsqlCommand command = new NpgsqlCommand(strSQLCat, connection);
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

            /*foreach (DataGridViewColumn column in dgvProduct.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.Width = dgvProduct.Width + 100;*/
        }
        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var cat = (Category)cmbCategory.SelectedItem;
            
            if (chbCategory.Checked == true & cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }
            if (chbPrice.Checked == true & txbPrice.Text == String.Empty)
            {
                MessageBox.Show("Введите цену!");
                return;
            }
            if (chbName.Checked == true & txbName.Text == String.Empty)
            {
                MessageBox.Show("Введите наименование товара!");
                return;
            }

            if (chbPrice.Checked == true)
                strSQL = "SELECT id, name, description, price FROM product1 WHERE Price >= '" + txbPrice.Text + "'";
            if (chbCategory.Checked == true)
                strSQL = "SELECT id, name, description, price FROM product1 WHERE id_category = '" + cat.id + "'";
            if (chbName.Checked == true)
                strSQL = "SELECT id, name, description, price FROM product1 WHERE name LIKE '" + txbName.Text + "'";

            if (chbPrice.Checked == true & chbCategory.Checked == true)
                strSQL = "SELECT id, name, description, price FROM product1 WHERE ID_Category = '" + cat.id + "'" + "AND" + " Price >='" + txbPrice.Text + "'";
            if (chbPrice.Checked == true & chbName.Checked == true)
                strSQL = "SELECT id, name, description, price FROM product1 WHERE Price >='" + txbPrice.Text + "' AND name LIKE '" + txbName.Text + "'";
            if (chbCategory.Checked == true & chbName.Checked == true)
                strSQL = "SELECT id, name, description, price FROM product1 WHERE ID_Category = '" + cat.id + "'" + " AND name LIKE '" + txbName.Text + "'";
            if (chbPrice.Checked == true & chbCategory.Checked == true & chbName.Checked == true)
                strSQL = "SELECT id, name, description, price FROM product1 WHERE ID_Category = '" + cat.id + "'" + "AND Price >='" + txbPrice.Text + "' AND name LIKE '" + txbName.Text + "'";

            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(strSQL, connectionStr);
                DataTable table = new DataTable();
                
                dgvProduct.DataSource = table.DefaultView;
                countlabel.Text = da.Fill(table).ToString();
                da.Update(table);

                dgvProduct.Columns[0].Visible = false;
                dgvProduct.Columns[1].HeaderText = "Наименование";
                dgvProduct.Columns[2].HeaderText = "Описание";
                dgvProduct.Columns[3].HeaderText = "Цена";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm (int.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString()));
            editForm.ShowDialog();

            SearchButton_Click(sender, e);
        }

        private void SearchAndEdit_Load(object sender, EventArgs e) { }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.Rows[e.RowIndex].Selected = true;
        }
    }
}