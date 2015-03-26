
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
    public partial class ManagerForm : Form
    {
        private MySqlConnection connection=null;
        private EmployeeRegisterForm FormEmp;
        private MySqlDataAdapter mcmd;
        private DataSet ds;
        private int userId;
        private string userLname;
        private MenuRegisterForm food;
        private LoginForm mainForm;

        public ManagerForm(MySqlConnection con, LoginForm loginForm, int id, string lname )
        {
            userId = id;
            userLname = lname;
            connection = con;
            mainForm = loginForm;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(int.Parse(txtId.Text.ToString().Trim()));
            SearchOrderByEmp(int.Parse(txtId.Text.ToString().Trim()));
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
                    getTotal();
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
            FormEmp = new EmployeeRegisterForm(connection);
            FormEmp.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            food = new MenuRegisterForm(connection);
            food.ShowDialog();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
            SearchAllOrder();
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            string date1, date2;
            date1 = dateFrom.Value.ToString("yyyy-MM-dd");
            date2 = dateTo.Value.ToString("yyyy-MM-dd");
            if (dateFrom.Value > dateTo.Value)
                MessageBox.Show("The initial date is greater than the final");
            else
                SearchByDate(date1,date2);
        }

        private void SearchByDate( string date1, string date2)
        {
            string query = "SELECT orderId 'Order ID', `date` AS 'Date', price AS 'Price', Employees_EmployeeID as 'Employee ID' FROM `Order` where `date` between '" + date1 + "' and '" + date2 + "'";
            

            if (connection != null)
            {
                try
                {
                    //Create Command
                    mcmd = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    new MySqlCommandBuilder(mcmd);

                    mcmd.Fill(ds, "Person details");


                    dgOrders.DataSource = ds.Tables[0];
                    getTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Try to connect");
            }
        }

        private void SearchOrderByEmp(int ID)
        {
            string query = "SELECT orderId 'Order ID', `date` AS 'Date', price AS 'Price' FROM `Order` where Employees_EmployeeID="+ID;


            if (connection != null)
            {
                try
                {
                    //Create Command
                    mcmd = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    new MySqlCommandBuilder(mcmd);

                    mcmd.Fill(ds, "Person details");


                    dgOrders.DataSource = ds.Tables[0];
                    getTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Try to connect");
            }
        }

        private void SearchAllOrder()
        {
            string query = "SELECT orderId 'Order ID', `date` AS 'Date', price AS 'Price', Employees_EmployeeID as 'Employee ID' FROM `Order`";


            if (connection != null)
            {
                try
                {
                    //Create Command
                    mcmd = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    new MySqlCommandBuilder(mcmd);

                    mcmd.Fill(ds, "Person details");


                    dgOrders.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Try to connect");
            }
        }

        private void dgEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgEmployees.Rows[e.RowIndex];
                    SearchOrderByEmp(int.Parse(row.Cells["ID"].Value.ToString()));
                }
           
        }

        private void getTotal()
        {
            int rowCount;
            double total = 0.0;
            rowCount = dgOrders.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                total += double.Parse(dgOrders.Rows[i].Cells[2].Value.ToString());
            }
            txtTotal.Text = string.Format("TOTAL: {0:c}",total);
        }


    }
    }



   

