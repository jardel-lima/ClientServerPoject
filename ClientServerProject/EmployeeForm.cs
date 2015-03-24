﻿using MySql.Data.MySqlClient;
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
                
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            orderForm = new OrderForm(connection, userId, userLname);
            orderForm.ShowDialog();
        }

        private void EmployeeOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}