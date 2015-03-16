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
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private DBconnect db;
        private EmployeeOrders EmpOrders;
        private Manager managerView;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DBconnect();
            db.host = "ec2-54-152-4-112.compute-1.amazonaws.com";
            db.uid = "f2014_user24";
            db.password = "f2014_user24";
            db.database = "f2014_user24";
            connect();
        }

        private void connect()
        {
            connection = new MySqlConnection(db.ToString());

            try
            {
                connection.Open();
                Text = "Connected";
            }
            catch (MySqlException ex)
            {
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Text = "Cannot connect to server.  Contact administrator";
                        break;

                    case 1045:
                        Text = "Invalid username/password, please try again";
                        break;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string query="select * from employes"

            //EmpOrders = new EmployeeOrders(connection, " oi");
            //EmpOrders.Show();
            //this.Hide();
            //this.Close();

            managerView = new Manager();
            managerView.Show();
            this.Hide();

        }
    }
}
