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
        private MySqlConnection connection;
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
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = instruction;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee registered!!!","Message");

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Message");
            }
        }
    }
}
