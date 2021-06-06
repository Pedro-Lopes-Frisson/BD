using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace VirtualShopC
{
    public partial class Form1 : Form
    {
        string connStr = @"Data Source=My-LEGION;Initial Catalog=project_dummy;Integrated Security=True;";
        string user;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();
                SqlCommand sqlComm = new SqlCommand("Verify_Login", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.AddWithValue("@Username", UsernameBox.Text);
                sqlComm.Parameters.AddWithValue("@Password", PasswordBox.Text);
                SqlParameter success = new SqlParameter("@Verified", DbType.Binary);
                success.Direction = System.Data.ParameterDirection.Output;
                sqlComm.Parameters.Add(success);
                sqlComm.ExecuteNonQuery();
                if(sqlComm.Parameters["@Verified"].Value.ToString() == "1")
                {
                    MessageBox.Show("Login Successful!");
                    user = UsernameBox.Text;
                    Clear();
                    this.Hide();
                    Form form3 = new Form3(user);
                    form3.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!\nPlease try again!");
                    Clear();
                }
            }
        }

        private void Clear()
        {
            PasswordBox.Text = UsernameBox.Text = "";
        }
            
            private static readonly Encoding Encoding1252 = Encoding.GetEncoding(1252);

            public static byte[] SHA1HashValue(string s)
            {
                byte[] bytes = Encoding1252.GetBytes(s);

                var sha1 = SHA512.Create();
                byte[] hashBytes = sha1.ComputeHash(bytes);

                return hashBytes;
            }


    }
}
