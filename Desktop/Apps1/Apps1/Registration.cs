using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            txbUserSurname.Text = "Введите фамилию";
            txbUserSurname.ForeColor = Color.Gray;

            txbUserName.Text = "Введите имя";
            txbUserName.ForeColor = Color.Gray;

            txbLogin.Text = "Введите логин";
            txbLogin.ForeColor = Color.Gray;

            txbPass.Text = "Введите пароль";
            txbPass.ForeColor = Color.Gray;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (txbUserSurname.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (txbPass.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (txbLogin.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (isUserExist())
                return;
            
            DB db = new DB();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO admin (login, password, surname, name) VALUES ('" + txbLogin.Text + "','" + txbPass.Text + "','" + txbUserSurname.Text + "','"+txbUserName.Text+"')", db.getConnection());

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
                this.Hide();
                Authorization aut = new Authorization();
                aut.Show();
            }
            else
                MessageBox.Show("Аккаунт не был создан. Попробуйте снова");

            db.closeConnection();
        }

        private void txbUserSurname_Enter(object sender, EventArgs e)
        {
            if (txbUserSurname.Text == "Введите фамилию")
            {
                txbUserSurname.Text = "";
                txbUserSurname.ForeColor = Color.Black;
            }
        }
        private void txbUserSurname_Leave(object sender, EventArgs e)
        {
            if (txbUserSurname.Text == "")
            {
                txbUserSurname.Text = "Введите фамилию";
                txbUserSurname.ForeColor = Color.Gray;
            }   
        }

        private void txbUserName_Enter(object sender, EventArgs e)
        {
            if (txbUserName.Text == "Введите имя")
            {
                txbUserName.Text = "";
                txbUserName.ForeColor = Color.Black;
            }
        }
        private void txbUserName_Leave(object sender, EventArgs e)
        {
            if (txbUserName.Text == "")
            {
                txbUserName.Text = "Введите имя";
                txbUserName.ForeColor = Color.Gray;
            }
        }
        
        private void txbLogin_Enter(object sender, EventArgs e)
        {
            if (txbLogin.Text == "Введите логин")
            {
                txbLogin.Text = "";
                txbLogin.ForeColor = Color.Black;
            }
        }
        private void txbLogin_Leave(object sender, EventArgs e)
        {
            if (txbLogin.Text == "")
            {
                txbLogin.Text = "Введите логин";
                txbLogin.ForeColor = Color.Gray;
            }
        }

        private void txbPass_Enter(object sender, EventArgs e)
        {
            if (txbPass.Text == "Введите пароль")
            {
                txbPass.Text = "";
                txbPass.ForeColor = Color.Black;
            }
        }
        private void txbPass_Leave(object sender, EventArgs e)
        {
            if (txbPass.Text == "")
            {
                txbPass.Text = "Введите пароль";
                txbPass.ForeColor = Color.Gray;
            }
        }

        public Boolean isUserExist()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM admin WHERE login = '" + txbLogin.Text + "'", db.getConnection());
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return true;
            }
            else
                return false;
        }
    }
}