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
    public partial class EmployeeOrders : Form
    {
        private MySqlConnection connection = null;
        private Order orderForm;
        public EmployeeOrders(MySqlConnection con)
        {
            connection = con;
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
            orderForm = new Order(connection);
            orderForm.ShowDialog();
        }
    }
}
