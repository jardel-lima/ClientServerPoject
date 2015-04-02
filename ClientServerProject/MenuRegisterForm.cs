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
    public partial class MenuRegisterForm : Form
    {
        private MySqlConnection connection = null;
        private MySqlDataAdapter mcmd;
        private DataSet ds;
        int menuID;
        int IdDelete;
        private int rowIndex = 0;
        public MenuRegisterForm(MySqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //function to get the row clicked
        private void dgMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string available;
            if (e.RowIndex >= 0)
            {

                gbAva.Enabled = true;
                DataGridViewRow row = this.dgMenu.Rows[e.RowIndex];
                txtDishe.Text = row.Cells["Dishes"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtDesc.Text = row.Cells["description"].Value.ToString();

                //get the value of "avalilable" field 
                available = row.Cells["available"].Value.ToString();
                //check if the dishe is available
                if (available == "y")
                {
                    rdAva.Checked = true;

                }
                else
                {
                    rdUnava.Checked = true;
                }

                menuID = Convert.ToInt16(row.Cells["ID"].Value.ToString());


            }
        }

        //show the Menu
        private void LoadData()
        {
            string query = "SELECT menuId AS 'ID', dishes AS 'Dishes', price AS 'Price' , description, available  FROM Menu";

            if (connection != null)
            {
                //Create Command
                try {
                    Cursor.Current = Cursors.WaitCursor;
                    mcmd = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    new MySqlCommandBuilder(mcmd);

                    mcmd.Fill(ds, "Person details");

                    dgMenu.DataSource = ds.Tables[0];
                }
                catch (MySqlException ex) {
                    MessageBox.Show("Erro: " + ex.Message, "Message");
                }
                finally {
                    Cursor.Current = Cursors.Default;
                }
               

            }
            else
            {
                MessageBox.Show("Try to connect");
            }
        }

        //function to the add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String dishe;
            Double price;
            String desc;

            try
            {
                
                dishe = txtDishe.Text.ToString().Trim();
                price = double.Parse(txtPrice.Text.ToString().Trim());
                desc = txtDesc.Text.ToString().Trim();

                if (dishe.Length > 0 && desc.Length > 0)
                {
                    insertFood(dishe, price, desc);
                }
                else
                {
                    MessageBox.Show("One of the fields is empty!!!");
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("One of the fields is empty or its content type is wrong");
            }

            

            
        }

        //Insert a new dishe in the Menu
        private void insertFood(string dishe, double price, string desc)
        {
            string instruction = "INSERT INTO Menu(dishes,price,description) VALUES ('" + dishe + "','" + price + "','" + desc + "')";

            if (connection != null)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = instruction;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    clearTextBox();
                    MessageBox.Show("Dishe registered!!!", "Message");

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

        private void clearTextBox()
        {
            txtDishe.Text = "";
            txtPrice.Text = "";
            txtDesc.Text = "";
            
        }

        private void Food_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //function to edit a item in the menu
        private void updateMenu(int menuID, string dishe, double price, string desc, string available)
        {
            string instruction = "UPDATE Menu SET dishes='" + dishe + "',price=" + price + ",description='" + desc + "',available='" + available + "' WHERE menuId=" + menuID;

            if (connection != null)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = instruction;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    clearTextBox();
                    MessageBox.Show("Menu updated!!!", "Message");

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

        //button edit menu
        private void btnEdit_Click(object sender, EventArgs e)
        {
            String dishe;
            Double price;
            String desc;
            String available;

            dishe = txtDishe.Text.ToString().Trim();
            price = double.Parse(txtPrice.Text.ToString().Trim());
            desc = txtDesc.Text.ToString().Trim();
            if (rdAva.Checked == true)
            {
                available = "y";
            }
            else
            {
                available = "n";
            }

            updateMenu(menuID,dishe, price, desc, available);

            gbAva.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //function to set a dishe as unvailable
        private void delete()
        {
            string query = "UPDATE Menu SET available = 'n' WHERE menuId=" + IdDelete;

            if (connection != null)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    clearTextBox();
                    MessageBox.Show("Dishe deleted!!!", "Message");

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

        //function to make a dishe unavailabe when the user click on the DataGridView using right click
        private void dgMenus_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgMenu.Rows[e.RowIndex];
            if (e.Button == MouseButtons.Right)
            {
                this.dgMenu.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgMenu.CurrentCell = this.dgMenu.Rows[e.RowIndex].Cells[0];
                //get the ID to make the dishe Inavailable
                IdDelete = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                this.contextMenuStrip1.Show(this.dgMenu, e.Location);

                contextMenuStrip1.Show(Cursor.Position);


            }
        }

        
   
       

        private void contextMenuStrip1_MouseClick_1(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Comfirm delete?", "Confirm", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                delete();
            }
        }
    }
}
