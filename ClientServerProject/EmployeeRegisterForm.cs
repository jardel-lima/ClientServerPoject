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
    public partial class EmployeeRegisterForm : Form
    {
        private MySqlConnection connection=null;
        private DataSet ds;
        private MySqlDataAdapter mcmd;
        int empID;
        int empIdDelete;
        private int rowIndex = 0;



        public EmployeeRegisterForm(MySqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //function to show all employees
        private void LoadData()
        {
            string query = "SELECT EmployeeID AS 'ID', firstName AS 'First Name', lastName AS 'Last Name', active as 'Active' FROM Employees order by active asc";

            if (connection != null)
            {
                //Create Command
                try {
                    Cursor.Current = Cursors.WaitCursor;
                    mcmd = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    new MySqlCommandBuilder(mcmd);

                    mcmd.Fill(ds, "Person details");

                    dgEmployees.DataSource = ds.Tables[0];
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

        //function of the add button 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String firstName;
            String lastName;
            String password;
            String confPassword;
            
                firstName = txtFirstName.Text.ToString().Trim();
                lastName = txtLastName.Text.ToString().Trim();
                password = txtPassword.Text.ToString().Trim();
                confPassword = txtConfPassword.Text.ToString().Trim();

                if (firstName.Length > 0 && lastName.Length > 0 && password.Length > 0 && confPassword.Length > 0)
                {
                    if (password.Equals(confPassword, StringComparison.Ordinal))
                    {
                        insertEmployee(firstName, lastName, password);
                    }
                    else
                    {
                        MessageBox.Show("The password does not match!!!", "Message");
                    }
                }
                else
                {
                    MessageBox.Show("One of the fields is empty!!!", "Message");
                }  
        }

        //insert a new employee in the Database
        private void insertEmployee(string firstName, string lastName, string password)
        {
            string instruction = "INSERT INTO Employees(firstName,lastName,position,password) VALUES ('" + firstName + "','" + lastName + "',0,'" + password + "')";

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
                    MessageBox.Show("Employee registered!!!", "Message");

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

        //function to edit a employee fields and update the database
        private void updateEmployee(int empID, string firstName, string lastName, string password, string active)
        {
            string instruction = "UPDATE Employees SET firstName='" + firstName + "',lastName='" + lastName + "',password='" + password + "',active='" + active + "' WHERE EmployeeID=" + empID;

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
                    MessageBox.Show("Employee updated!!!", "Message");

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
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtConfPassword.Text = "";
        }
        
        //function to get the clicked row in the Employee DataGridView
        private void dgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string active; //Var to get the field "active" in the table Employee which says if the employee still working or not
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgEmployees.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells["First Name"].Value.ToString();
                txtLastName.Text = row.Cells["Last Name"].Value.ToString();
                
                active = row.Cells["Active"].Value.ToString();
                //enable the GroupBox which contains the check boxes
                gbActive.Enabled = true;

                //Checking the checkBox
                if (active == "y")
                {
                    rbActive.Checked = true;
                }
                else
                {
                    rbInactive.Checked = true;
                }
                //get the Employee ID
                empID = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                

            }
        }

        //Function to the button Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            String firstName;
            String lastName;
            String password;
            String confPassword;
            String active;

            firstName = txtFirstName.Text.ToString().Trim();
            lastName = txtLastName.Text.ToString().Trim();
            password = txtPassword.Text.ToString().Trim();
            confPassword = txtConfPassword.Text.ToString().Trim();

            //get the value of check box and set to the string "active"
            if (rbActive.Checked == true)
            {
                active = "y";
            }
            else
            {
                if (isAdmin(empID)) {
                    MessageBox.Show("This employee is the only Manager, It canot be unactived !!!", "Message");
                    active = "y";
                }
                else
                    active = "n";
            }



            //check if one of the fields is not empty
            if (firstName.Length > 0 && lastName.Length > 0 && password.Length > 0 && confPassword.Length > 0)
            {
                //checks if the password matchs
                if (password.Equals(confPassword, StringComparison.Ordinal))
                {
                    updateEmployee(empID, firstName, lastName, password, active);
                }
                else
                {
                    MessageBox.Show("The password does not match!!!", "Message");
                }
            }
            else
            {
                MessageBox.Show("One of the fields is empty!!!", "Message");
            }
            gbActive.Enabled = false;
        }

        public bool isAdmin(int id)
        {
            bool admin = false;
            int position = 1;
            string query = "SELECT position FROM Employees where  EmployeeID = "+id;

            if (connection != null)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        position = int.Parse(dataReader[0].ToString());
                    }
                    dataReader.Close();
                    if (position == 1)
                        admin = true;
                    else
                        admin = false;
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

            return admin;
        }

    }
}
