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
    public partial class LoginForm : Form
    {
        private MySqlConnection connection;
        private DBconnect db;
        private EmployeeForm EmpOrders;
        private ManagerForm managerView;
        private int userId;
        private string userLname;

        public LoginForm()
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
            //connect();
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

        private void cleanFields()
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect();
            string Value="";
            int count = 0;
            userId = int.Parse(txtUser.Text.ToString());
            string query = "select * from Employees where EmployeeID='"+txtUser.Text+"' and password='"+txtPassword.Text+"'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    Value = dataReader["position"].ToString();
                    userLname = dataReader["lastName"].ToString();
                    count++;
                }
                dataReader.Close();
                cleanFields();
                if (count > 0)
                {
                    if (Value.Equals("0", StringComparison.Ordinal))
                    {
                        EmpOrders = new EmployeeForm(connection, this, userId, userLname);
                        EmpOrders.Show();
                        this.Hide();


                    }
                    else
                    {
                        if (Value.Equals("1", StringComparison.Ordinal))
                        {
                            managerView = new ManagerForm(connection, this, userId, userLname);
                            managerView.Show();
                            this.Hide();
                        }

                    }


                }
                else
                {
                    MessageBox.Show("User or Password is not correct");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
