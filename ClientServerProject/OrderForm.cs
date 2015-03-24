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
    public partial class OrderForm : Form
    {
        private MySqlConnection connection;
        private DataSet ds;
        private MySqlDataAdapter mcmd;
        private LoginForm mainForm;
        private int userId;
        private string userLname;
        private const double GST = 5.0 / 100.0;
        private double subTotal = 0.0;
        private double taxes = 0.0;
        private double total = 0.0;

        public OrderForm(MySqlConnection conn, int id, string lname)
        {
            userId = id;
            userLname = lname;
            connection = conn;
            InitializeComponent();
            txtEmployee.Text = "Employee: " + lname;
            txtId.Text = "Id: " + id;
        }

        private void loadMenu()
        {
            string query = "SELECT menuId , dishes, description , price FROM Menu";
            dataGVMenu.ColumnCount = 4;
            dataGVMenu.Columns[0].Name = "ID";
            dataGVMenu.Columns[1].Name = "Dish";
            dataGVMenu.Columns[2].Name = "Descriotion";
            dataGVMenu.Columns[3].Name = "price";
            dataGVMenu.Columns[0].Width = 30;
            dataGVMenu.Columns[1].Width = 150;
            dataGVMenu.Columns[2].Width = 200;
            dataGVMenu.Columns[3].Width = 50;
            
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Qty";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 11;
            cmb.Items.Add("0");
            cmb.Items.Add("1");
            cmb.Items.Add("2");
            cmb.Items.Add("3");
            cmb.Items.Add("4");
            cmb.Items.Add("5");
            cmb.Items.Add("6");
            cmb.Items.Add("7");
            cmb.Items.Add("8");
            cmb.Items.Add("9");
            cmb.Items.Add("10");
            dataGVMenu.Columns.Add(cmb);
            dataGVMenu.Columns[4].Width = 40;

            dataGVMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (connection != null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dataGVMenu.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString());
                        
                    }
                    dataReader.Close();
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

        private void Order_Load(object sender, EventArgs e)
        {
            loadMenu();
            initiateOrderGrid();
        }

        private void addItems(){

            int rows = dataGVMenu.RowCount;

            for (int i = 0; i < rows; i++)
            {
                int qty;
                try {
                   qty = int.Parse(dataGVMenu.Rows[i].Cells[4].Value.ToString());
                   dataGVMenu.Rows[i].Cells[4].Value = "0";
                }
                catch (Exception ex)
                {
                    qty = 0;
                }
               

                if (qty > 0)
                {
                    int id = int.Parse(dataGVMenu.Rows[i].Cells[0].Value.ToString());
                    string dish = dataGVMenu.Rows[i].Cells[1].Value.ToString();
                    double price = double.Parse(dataGVMenu.Rows[i].Cells[3].Value.ToString());
                    addOrUpdateItem(id, dish, qty, price);
                }
            }
        }

        private void initiateOrderGrid(){
            dataGVOrder.ColumnCount = 4;
            dataGVOrder.Columns[0].Name = "ID";
            dataGVOrder.Columns[1].Name = "Dish";
            dataGVOrder.Columns[2].Name = "Qty";
            dataGVOrder.Columns[3].Name = "price";
            dataGVOrder.Columns[0].Width = 30;
            dataGVOrder.Columns[1].Width = 150;
            dataGVOrder.Columns[2].Width = 30;
            dataGVOrder.Columns[3].Width = 50;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addItems();
            calculateTotal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGVOrder.SelectedRows)
            {
                dataGVOrder.Rows.Remove(row);
            }
            calculateTotal();
        }

        private void addOrUpdateItem(int dishId, string dishName, int dishQty, double dishPrice)
        {
            bool added = false;
            foreach (DataGridViewRow row in dataGVOrder.Rows)
            {   
                int id = int.Parse(row.Cells[0].Value.ToString());
                if (id == dishId)
                {
                    row.Cells[2].Value = dishQty;
                    row.Cells[3].Value = string.Format("{0:0.00}", dishPrice * dishQty);
                    added = true;
                    break;
                }
            }

            if (!added)
            {
                dataGVOrder.Rows.Add(dishId, dishName, dishQty, string.Format("{0:0.00}", dishPrice * dishQty));
            }
        }

        private void calculateTotal()
        {
            int rowCount = dataGVOrder.RowCount;
            subTotal = 0.0;
            taxes = 0.0;
            total = 0.0;

            for (int i = 0; i < rowCount; i++)
            {
                subTotal += double.Parse(dataGVOrder.Rows[i].Cells[3].Value.ToString());
            }

            taxes = subTotal * GST;
            total = subTotal + taxes;

            txtSubTotal.Text = String.Format("Sub Total: {0:c}", subTotal);
            txtTaxes.Text = String.Format("Taxes (GST 5%): {0:c}", taxes);
            txtTotal.Text = String.Format("TOTAL: {0:c}", total);

            if (rowCount > 0)
            {
                btnConfirm.Enabled = true;
            }
            else
            {
                btnConfirm.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Comfirm payment of "+string.Format("{0:c}",total), "Confirm", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                confirmPurchase();
            }
        }

        private void confirmPurchase()
        {
            insertOrder();
        }

        private void insertOrder()
        {
            DateTime today = DateTime.Today;
            string date = today.ToString("yyyy-MM-dd");
            string instruction = " INSERT INTO `Order`(`date`, `price`, `Employees_EmployeeID`) VALUES( '" + date + "', " + total + ", " + userId + ")";
            long orderId;

            if (connection != null)
            {
                try
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = instruction;
                    cmd.ExecuteNonQuery();
                    orderId = cmd.LastInsertedId;
                    inserteOrderDetails(orderId);

                    MessageBox.Show("Thank you for your purchase", "Thank you", MessageBoxButtons.OK);
                    this.Close();

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

        private void inserteOrderDetails(long orderId){
            int rowCount = dataGVOrder.RowCount;

            for (int i = 0; i < rowCount; i++)
            {
                int menuId = int.Parse(dataGVOrder.Rows[i].Cells[0].Value.ToString());
                int qty = int.Parse(dataGVOrder.Rows[i].Cells[2].Value.ToString());

                string instruction = " INSERT INTO `orderDetails`(`Order_orderId`, `Menu_menuId`, `quantity`) VALUES( " + orderId + ", " + menuId + ", " + qty + ")";

                if (connection != null)
                {
                    try
                    {
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = instruction;
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
        }
       
    }

    
}
