﻿/*
Cliente Server Final Project - Winter 2015

Jardel Lima - 300219631
Marcelle Amorim - 300227420
Weslley Kelson - 300227439
Rhafael Pinheiro - 300227431
 
Database account: f2014_user24
 */
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
        private BillForm billform;
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

        //New Order 
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            orderForm = new OrderForm(connection, this, userId, userLname);
            orderForm.ShowDialog();
        }

        private void EmployeeOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
            }
            mainForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        //Load the employee's orders and the unpaid orders   
        public void LoadData()
        {
            string query = "SELECT orderId AS 'ID', `date` AS 'Date', price AS 'Price' FROM `Order` WHERE Employees_EmployeeID=" + userId;
            string query2 = "SELECT ot.tableNumber AS 'Table Number',ot.orderId AS 'Order Number',o.price AS 'Price',o.Employees_EmployeeID AS 'Employee ID' FROM `OrderTable` as ot inner join `Order` as o on o.orderId=ot.orderId";

            if (connection != null)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    //Create Command
                    mcmd = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    new MySqlCommandBuilder(mcmd);

                    mcmd.Fill(ds, "Person details");
                    dataGVOrders.DataSource = ds.Tables[0];
                    getTotal();

                    
                    //Create Command
                    mcmd = new MySqlDataAdapter(query2, connection);
                    ds = new DataSet();
                    new MySqlCommandBuilder(mcmd);

                    mcmd.Fill(ds, "Person details");
                    dgNotPaid.DataSource = ds.Tables[0];
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }


            }
            else
            {
                MessageBox.Show("Try to connect");
            }
            
        }
        //show the total of orders
        private void getTotal()
        {
            int rowCount;
            double total = 0.0;
            //get the values from the Datagirdview's cells
            rowCount = dataGVOrders.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                total += double.Parse(dataGVOrders.Rows[i].Cells[2].Value.ToString());
            }
            txtTotal.Text = string.Format("TOTAL: {0:c}",total);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            billform = new BillForm(connection,this, userId, userLname);
            billform.ShowDialog();
        }
    }
}
