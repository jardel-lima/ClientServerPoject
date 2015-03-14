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
    public partial class EmployeeOrders : Form
    {
        private MySqlConnection connection;
        private String y;

        public EmployeeOrders(MySqlConnection con, String x)
        {
            connection = con;
            InitializeComponent();
            y = x;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeOrders_Load(object sender, EventArgs e)
        {
            if (connection != null)
            {
                Text = "Connected" + y;
            }
        }
    }
}
