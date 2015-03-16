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
    public partial class FormEmployee : Form
    {
        private MySqlConnection connection=null;
        private DataSet ds;
        private MySqlDataAdapter mcmd;
        int empID;


        public FormEmployee(MySqlConnection con)
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

        private void LoadData()
        {
            string query = "SELECT EmployeeID AS 'ID', firstName AS 'First Name', lastName AS 'Last Name' FROM Employees";

            if (connection != null)
            {
                //Create Command
                mcmd = new MySqlDataAdapter(query, connection);
                ds = new DataSet();
                new MySqlCommandBuilder(mcmd);

                mcmd.Fill(ds, "Person details");

                dgEmployees.DataSource = ds.Tables[0];
               
            }
            else
            {
                MessageBox.Show("Try to connect");
            }
        }

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
                if (password.Equals(confPassword,StringComparison.Ordinal))
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

        private void insertEmployee(string firstName, string lastName, string password)
        {
            string instruction = "INSERT INTO Employees(firstName,lastName,position,password) VALUES ('" + firstName + "','" + lastName + "',0,'" + password + "')";

            if (connection != null)
            {
                try
                {
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
            }
            else
            {
                MessageBox.Show("You are not connected!!!", "Message");
            }
        }

        private void updateEmployee(int empID, string firstName, string lastName, string password)
        {
            string instruction = "UPDATE Employees SET firstName='" + firstName + "',lastName='" + lastName + "',password='" + password + "' WHERE EmployeeID=" + empID;

            if (connection != null)
            {
                try
                {
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

        private void dgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgEmployees.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells["First Name"].Value.ToString();
                txtLastName.Text = row.Cells["Last Name"].Value.ToString();
                empID = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                    updateEmployee(empID, firstName, lastName, password);
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
    }
}
