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
    public partial class EditForm : Form
    {
        int id = -1;
        public string connectionStr = "Server=localhost; Port=5432; Database=store; User Id=postgres; Password=123";
        protected EditForm()
        {
            InitializeComponent();
            
            string strSQLCategory = "select * from category";
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(strSQLCategory, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbCategory.DisplayMember = "categoryname";
                cmbCategory.ValueMember = "id";
                cmbCategory.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public EditForm(int id) 
            : this()
        {
            this.id = id;
            string strSQLName = "SELECT * FROM product1 WHERE id = "+id+"";
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(strSQLName, connectionStr);
                DataTable t = new DataTable();
                dataAdapter.Fill(t);

                txbName.DataBindings.Add(new Binding("Text", t, "name"));
                txbDescription.DataBindings.Add(new Binding("Text", t, "description"));
                txbPrice.DataBindings.Add(new Binding("Text", t, "price"));
                cmbCategory.SelectedValue = t.Rows[0]["id_category"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
             
               NpgsqlConnection connection = new NpgsqlConnection(connectionStr);
               connection.Open();

               string strSQL = "UPDATE product1 SET name = '"+txbName.Text+"', description = '"+txbDescription.Text+ "', price = " + Convert.ToDecimal(txbPrice.Text) + ", id_category = " + cmbCategory.SelectedValue + " WHERE id = " + id+"";

               NpgsqlDataAdapter da = new NpgsqlDataAdapter(strSQL, connectionStr);

               da.UpdateCommand = new NpgsqlCommand(strSQL, connection);
               if (da.UpdateCommand.ExecuteNonQuery() == 1)
                   MessageBox.Show("Запись успешно изменена!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancellingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
/*
           txbName.ResetText();
           txbDescription.ResetText();
           //txbPrice.Clear();
           txbPrice.ResetText();
           cmbCategory.ResetText();*/