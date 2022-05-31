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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();

            this.txbPass.AutoSize = false;
            this.txbPass.Size = new Size(this.txbPass.Size.Width, 45);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String loginUser = txbLogin.Text;
            String passUser = txbPass.Text;
            

            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM admin WHERE login = '"+ txbLogin.Text +"' AND password = '"+ txbPass.Text +"'", db.getConnection());
            //command.Parameters.Add("@uL", NpgsqlTypes.NpgsqlDbType.Varchar).Value = loginUser;
            //command.Parameters.Add("@uP", NpgsqlTypes.NpgsqlDbType.Varchar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
                MessageBox.Show("Пользователь не найден!");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }
    }
}