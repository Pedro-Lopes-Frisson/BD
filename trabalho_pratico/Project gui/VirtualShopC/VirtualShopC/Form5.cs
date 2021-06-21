using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
        public void setUser(string user)
        {
            _user = user;
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

    }
}
