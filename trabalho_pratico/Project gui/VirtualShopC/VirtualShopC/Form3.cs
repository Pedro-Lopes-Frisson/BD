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
    public partial class Form3 : Form
    {

        string connStr = @"Data Source=My-LEGION;Initial Catalog=project_dummy;Integrated Security=True;";
        string _user="";
        public Form3(string user)
        {
            setUser(user);
            InitializeComponent();
        }
        public void setUser(string user)
        {
            _user = user;
        }
        public string getUser()
        {
            return _user;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();
                string objects = "";
                string command = "select Name, Upgraded, Rank from";
                int commandNo = 0;
                if (WeaponCheck.Checked)
                {
                    objects = objects + "weapon,";
                    commandNo++;
                }
                if (ShieldCheck.Checked)
                {
                    objects = objects + "shield,";
                    commandNo++;

                }
                if (ArmorCheck.Checked)
                {
                    objects = objects + "armor,";
                    commandNo++;

                }
                if (MeleeCheck.Checked)
                {
                    objects = objects + "melee,";
                    commandNo++;

                }
                if (RangedCheck.Checked)
                {
                    objects = objects + "ranged,";
                    commandNo++;

                }
                if (PhysicalCheck.Checked)
                {
                    objects = objects + "physical,";
                    commandNo++;

                }
                if (MagicalCheck.Checked)
                {
                    objects = objects + "magical,";
                    commandNo++;

                }
                if (commandNo == 0)
                {
                    objects = "item";
                }
                else
                {
                    objects.Remove(objects.Length - 1);
                }
                command += objects;
                SqlCommand query = new SqlCommand(command, sqlConn);
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                

            
        }

       
    }

        private void RegisterItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(_user);
            form4.ShowDialog();
        }
    }
}
