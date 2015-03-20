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
    public partial class Order : Form
    {
        private MySqlConnection connection;
        private DataSet ds;
        private MySqlDataAdapter mcmd;
        int empID;

        public Order(MySqlConnection conn)
        {
            connection = conn;
            InitializeComponent();
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
        }
    }

    
}
