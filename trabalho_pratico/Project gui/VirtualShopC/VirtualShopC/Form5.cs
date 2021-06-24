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
    public partial class Form5 : Form
    {
        private string _user = "";
        string connStr = @"Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101; Initial Catalog = p1g4; uid = p1g4; password =Espanc@_R4b4s69";

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


        public Form5(string user)
        {
            InitializeComponent();
            setUser(user);
            MessageBox.Show(user);
        }
        public void setUser(string user)
        {
            _user = user;
        }



        private void RangedCheck_CheckedChanged(object sender, EventArgs e)
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
        private void WeaponCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WeaponCheck.Checked)
            {
                weaponQ = "ranged,";
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
                if (commandNo == 0) { itemQ = "item"; }

                command += weaponQ + armorQ + shieldQ + meleeQ + rangedQ + physicalQ + magicalQ + itemQ;
                command = command.TrimEnd(',');
                SqlCommand query = new SqlCommand(command, sqlConn);
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
