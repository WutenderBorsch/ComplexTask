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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) { }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            View view = new View();
            view.Show();
        }

       /*private void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }*/

        private void SearchAndEditButton_Click(object sender, EventArgs e)
        {
            SearchAndEdit edit = new SearchAndEdit();
            edit.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }
    }
}