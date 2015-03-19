using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerProject
{
    public partial class Manager : Form
    {
        private MySqlConnection connection=null;
        private FormEmployee FormEmp;
        private Food food;

        public Manager(MySqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormEmp = new FormEmployee(connection);
            FormEmp.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            food = new Food(connection);
            food.ShowDialog();
        }

       
    }
}
