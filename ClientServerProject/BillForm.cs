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
    public partial class BillForm : Form
    {
        private MySqlConnection connection;
        public BillForm(MySqlConnection con, int id, string lname)
        {
            InitializeComponent();
            connection = con;
            userLabel.Text = "User: " + lname;
            idLabel.Text = "ID: " + id;

        }

        private void BillForm_Load(object sender, EventArgs e)
        {

        }
    }
}
