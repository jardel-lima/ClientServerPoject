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
        private DataSet ds;
        private MySqlDataAdapter mcmd;
        private const double GST = 5.0 / 100.0;
        private double subTotal = 0.0;
        private double taxes = 0.0;
        private double total = 0.0;
        private int tableNumber;
        public BillForm(MySqlConnection con, int id, string lname)
        {
            connection = con;
            
            InitializeComponent();
            userLabel.Text = "User: " + lname;
            idLabel.Text = "ID: " + id;

        }

        

        private void LoadData()
        {
            

            try
            {
                tableNumber = int.Parse(txtTable.Text.ToString().Trim());

                if (connection != null)
                {
                    string query = "SELECT ot.tableNumber as 'Table',ordt.Order_orderID as 'Order ID', me.dishes as 'Dishe',me.price as 'Price'," +
                                    "ordt.quantity as 'Quantity', ord.Employees_EmployeeID as 'Employee ID' FROM `OrderTable` as ot " +
                                    "inner join `Order` as ord on ot.orderId=ord.OrderId " +
                                    "inner join `orderDetails` as ordt on ord.orderId=ordt.Order_orderId " +
                                    "inner join `Menu` as me on me.menuId=ordt.Menu_menuId " +
                                    "WHERE ot.tableNumber=" + tableNumber;
                    
                        //Create Command
                        mcmd = new MySqlDataAdapter(query, connection);
                        
                        ds = new DataSet();
                        new MySqlCommandBuilder(mcmd);

                        mcmd.Fill(ds, "Person details");
                    
                        dgOrderTable.DataSource = ds.Tables[0];
                        getTotal();
                    }
                
                else
                {
                    MessageBox.Show("Try to connect");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getTotal()
        {
            int rowCount;
            
            double price = 0.0;
            int quantity = 0;
           
            rowCount = dgOrderTable.RowCount;
            
            for (int i = 0; i < rowCount; i++)
            {
                price = double.Parse(dgOrderTable.Rows[i].Cells[3].Value.ToString());
               
               quantity = int.Parse(dgOrderTable.Rows[i].Cells[4].Value.ToString());
                subTotal += price * quantity;
            }

            taxes = subTotal * GST;
            total = subTotal + taxes;

            txtSubTotal.Text = String.Format("Sub Total: {0:c}", subTotal);
            txtTaxes.Text = String.Format("Taxes (GST 5%): {0:c}", taxes);
            txtTotal.Text = String.Format("TOTAL: {0:c}", total);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void delete()
        {
            
            string query = "delete from OrderTable where tableNumber=" + tableNumber;

            if (connection != null)
            {
                try
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    
                    
               

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Message");
                }
            }
            else
            {
                MessageBox.Show("You are not connected!!!", "Message");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try{

                double payment = double.Parse(txtPay.Text.ToString().Trim());
                if (payment > total)
                {
                    double charge = payment - total;
                    MessageBox.Show("Charge :" + charge);
                    delete();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Payment is less than required");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
