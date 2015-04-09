/*
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
    public partial class BillForm : Form
    {
        private MySqlConnection connection;//Connection variable
        private DataSet ds;
        private MySqlDataAdapter mcmd;
        private const double GST = 5.0 / 100.0;//GST variable
        private double subTotal = 0.0;//Saves table's subtotal
        private double taxes = 0.0;//Saves table's taxes
        private double total = 0.0;//Saves table's total
        private int tableNumber;//Saves table's number
        private EmployeeForm parentForm;

        public BillForm(MySqlConnection con, EmployeeForm empForm, int id, string lname)
        {
            connection = con;
            parentForm = empForm;
            InitializeComponent();
            userLabel.Text = "User: " + lname;
            idLabel.Text = "ID: " + id;

        }

        
        /*Load all orders made by  a specific table*/
        private void LoadData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
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
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        /*Calculates the total of all table's orders*/
        private void getTotal()
        {
            int rowCount;
            subTotal = 0.0;
            double price = 0.0;
            int quantity = 0;
            
           
            rowCount = dgOrderTable.RowCount;
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < rowCount; i++)
            {
                price = double.Parse(dgOrderTable.Rows[i].Cells[3].Value.ToString());
               
               quantity = int.Parse(dgOrderTable.Rows[i].Cells[4].Value.ToString());
                subTotal += price * quantity;
            }
            Cursor.Current = Cursors.Default;
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
        /*After the all table's orders are paid delete the relation between orders and table*/
        private void delete()
        {
            
            string query = "delete from OrderTable where tableNumber=" + tableNumber;

            if (connection != null)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    
                    
               

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Message");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("You are not connected!!!", "Message");
            }
        }
        /*Process table's orders payment*/
        private void btnPay_Click(object sender, EventArgs e)
        {
            try{

                double payment = double.Parse(txtPay.Text.ToString().Trim());
                if (payment > total)
                {
                    double charge = payment - total;
                    MessageBox.Show(string.Format("Charge : {0:c}" , charge));
                    delete();
                    parentForm.LoadData();
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
