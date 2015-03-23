
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
        private MySqlDataAdapter mcmd;
        private DataSet ds;
        private int userId;
        private string userLname;
        private Food food;

        public Manager(MySqlConnection con, int id, string lname )
        {
            userId = id;
            userLname = lname;
            connection = con;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(int.Parse(txtId.Text.ToString().Trim()));
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            string query = "SELECT EmployeeID AS 'ID', firstName AS 'First Name', lastName AS 'Last Name' FROM Employees";

            if (connection != null)
            {
                try
                {
                     //Create Command
                    mcmd = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    new MySqlCommandBuilder(mcmd);

                    mcmd.Fill(ds, "Person details");
                    

                    dgEmployees.DataSource = ds.Tables[0];
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                }
                

            }
            else
            {
                MessageBox.Show("Try to connect");
            }
        }

        private void Search(int id)
        {
            string query = "SELECT EmployeeID AS 'ID', firstName AS 'First Name', lastName AS 'Last Name' FROM Employees WHERE EmployeeID=" + id;

            if (connection != null)
            {
                //Create Command
                mcmd = new MySqlDataAdapter(query, connection);
                ds = new DataSet();
                new MySqlCommandBuilder(mcmd);

                mcmd.Fill(ds, "Person details");

                dgEmployees.DataSource = ds.Tables[0];

            }
            else
            {
                MessageBox.Show("Try to connect");
            }
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

       
    }
}
