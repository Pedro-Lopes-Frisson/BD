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

        string connStr = @"Data Source=localhost;Initial Catalog=project_dummy;Integrated Security=True;";
        string _user="";
        string weaponQ = "";
        string meleeQ = "";
        string rangedQ = "";
        string physicalQ = "";
        string magicalQ = "";
        string armorQ = "";
        string shieldQ = "";
        string itemQ = "";
        string consumableQ = "";
        string cosmeticQ = "";

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
            if (RangedCheck.Checked)
            {
                rangedQ = "ranged,";
            }
            else
            {
                rangedQ = "";
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();
                string command = "select [Name], [Upgraded], [Rank] from ";
                int commandNo = 0;
                foreach (Control c in FiltersType.Controls)
                {
                    CheckBox checkbox = c as CheckBox;
                    if (checkbox.Checked)
                    {
                        commandNo++;
                    }
                }
                if (commandNo == 0) { itemQ = "item";}

                command += weaponQ + armorQ + shieldQ  + meleeQ + rangedQ + physicalQ + magicalQ +itemQ;
                command = command.TrimEnd(',');
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

        private void WeaponCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WeaponCheck.Checked)
            {
                weaponQ = "weapon,";
            }
            else
            {
                weaponQ = "";
            }
        }

        private void ArmorCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ArmorCheck.Checked)
            {
                armorQ = "armor,";
            }
            else
            {
                armorQ = "";
            }
        }

        private void ShieldCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShieldCheck.Checked)
            {
                shieldQ = "shield,";
            }
            else
            {
                shieldQ = "";
            }
        }

        private void MeleeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MeleeCheck.Checked)
            {
                meleeQ = "melee,";
            }
            else
            {
                meleeQ = "";
            }
        }


        private void PhysicalCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PhysicalCheck.Checked)
            {
                physicalQ = "physical,";
            }
            else
            {
                physicalQ = "";
            }
        }

        private void MagicalCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MagicalCheck.Checked)
            {
                magicalQ = "magical,";
            }
            else
            {
                magicalQ = "";
            }
        }

        private void ConsumableCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ConsumableCheck.Checked)
            {
                consumableQ = "consumable,";
            }
            else
            {
                consumableQ = "";
            }
        }

        private void CosmeticCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (CosmeticCheck.Checked)
            {
                cosmeticQ = "cosmetic,";
            }
            else
            {
                cosmeticQ = "";
            }
        }

        private void YourStash_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(_user);
            form5.ShowDialog();
        }
    }
}
