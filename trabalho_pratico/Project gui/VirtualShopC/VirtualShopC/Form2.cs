using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualShopC
{
    public partial class Form2 : Form
    {
        string connStr = @"Data Source=localhost;Initial Catalog=project_dummy;Integrated Security=True;";

        public Form2()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!EmailBox.Text.Contains("@") && EmailBox.Text.Length < 5)
            {
                MessageBox.Show("Email does not have the correct format or is too short.");
            }
            else if (PasswordBox.Text.Length <7)
            {
                MessageBox.Show("Password is too short!");
            }
            else if (PasswordBox.Text != ConfirmPasswordBox.Text)
            {
                MessageBox.Show("Passwords do not match!");
            }
            else
            {
                using (SqlConnection sqlConn = new SqlConnection(connStr)) { 
                    sqlConn.Open();
                    SqlCommand sqlComm = new SqlCommand("Create_Acc", sqlConn);
                    sqlComm.Parameters.AddWithValue("@Email", EmailBox.Text);
                    sqlComm.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    sqlComm.Parameters.AddWithValue("@Password", PasswordBox.Text);
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.ExecuteNonQuery();

                    this.Close();
                }
            }

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
