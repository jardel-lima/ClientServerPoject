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
    public partial class EmployeeForm : Form
    {
        private MySqlConnection connection = null;
        private OrderForm orderForm;
        
        private DataSet ds;
        private MySqlDataAdapter mcmd;
        private int userId;
        private string userLname;
        private LoginForm mainForm;
        public EmployeeForm(MySqlConnection con, LoginForm form, int id, string lname)
        {
            connection = con;
            mainForm = form;
            userId = id;
            userLname = lname;
            InitializeComponent();
            
        }

        
        private void EmployeeOrders_Load(object sender, EventArgs e)
        {
            if (connection != null)
            {
                LoadData();
                userLastName.Text = "Employee: " + userLname;
                IdUser.Text = "ID: " + userId;
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            orderForm = new OrderForm(connection, this, userId, userLname);
            orderForm.ShowDialog();
        }

        private void EmployeeOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            string query = "SELECT orderId AS 'ID', `date` AS 'Date', price AS 'Price' FROM `Order` WHERE Employees_EmployeeID=" + userId;

            if (connection != null)
            {
                try
                {
                    //Create Command
                    mcmd = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    new MySqlCommandBuilder(mcmd);

                    mcmd.Fill(ds, "Person details");


                    dataGVOrders.DataSource = ds.Tables[0];
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

        private void getTotal()
        {
            int rowCount;
            double total = 0.0;
            rowCount = dataGVOrders.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                total += double.Parse(dataGVOrders.Rows[i].Cells[2].Value.ToString());
            }
            txtTotal.Text = string.Format("TOTAL: {0:c}",total);
        }
    }
}
