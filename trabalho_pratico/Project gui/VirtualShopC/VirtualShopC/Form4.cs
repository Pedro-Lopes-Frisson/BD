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
    public partial class Form4 : Form
    {
        private string _user = "";
        public Form4(string user)
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
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        
        private void checkGroup(GroupBox GroupBox1, CheckBox CheckBox1)
        {
            foreach (Control c in GroupBox1.Controls)
            {
                CheckBox checkbox = c as CheckBox;
                if (checkbox != null && checkbox.Checked && checkbox != CheckBox1)
                {
                    checkbox.Checked = false;
                }
            }
        }

        private void MeleeType_Click(object sender, EventArgs e)
        {
            checkGroup(ItemType, MeleeCheck);
        }

        private void ArmorType_Click(object sender, EventArgs e)
        {
            checkGroup(ItemType, ArmorCheck);

        }

        private void ShieldType_Click(object sender, EventArgs e)
        {
            checkGroup(ItemType, ShieldCheck);

        }

        private void PhysicalType_click(object sender, EventArgs e)
        {
            checkGroup(ItemType, PhysicalCheck);

        }

        private void MagicalType_Click(object sender, EventArgs e)
        {
            checkGroup(ItemType, MagicalCheck);

        }
        private void ListAttributes_Click(object sender, EventArgs e)
        {
            foreach (Control c in ItemType.Controls)
            {
                CheckBox checkbox = c as CheckBox;
                if (checkbox != null && checkbox.Checked)
                {
                    LoadItemProperties(checkbox, ItemAttributes);
                }
            }
        }

        public void LoadItemProperties(CheckBox checkBox, GroupBox group)
        {
            if(checkBox == MeleeCheck)
            {
                Label baseItem = new Label();
                baseItem.Text = "Base Item?";
                baseItem.Location = new Point(20, 20);

                Label name = new Label();
                name.Text = "Item Name";
                name.Location = new Point(20, 40);

                Label handNum = new Label();
                handNum.Text = "Nº of Hands";
                baseItem.Location = new Point(20, 20);

                Label meleeType = new Label();
                meleeType.Text = "Melee Type";
                baseItem.Location = new Point(20, 20);

                Label attackSpd = new Label();
                attackSpd.Text = "Attack Speed";
                baseItem.Location = new Point(20, 20);

                Label dmg = new Label();
                dmg.Text = "Damage";
                baseItem.Location = new Point(20, 20);

                Label dmgType = new Label();
                dmgType.Text = "Damage Type";
                baseItem.Location = new Point(20, 20);

                Label critical = new Label();
                critical.Text = "Critical Chance";
                baseItem.Location = new Point(20, 20);

                Label criticalMult = new Label();
                criticalMult.Text = "Critical Multiplier";
                baseItem.Location = new Point(20, 20);

                Label rank = new Label();
                rank.Text = "Item Rank";
                baseItem.Location = new Point(20, 20);

                Label upgraded = new Label();
                upgraded.Text = "Upgraded";
                baseItem.Location = new Point(20, 20);

                Label unique = new Label();
                unique.Text = "Unique Item?";
                baseItem.Location = new Point(20, 20);

                Label specialAttr = new Label();
                specialAttr.Text = "Special Attributes";
                baseItem.Location = new Point(20, 20);

                group.Controls.Add(baseItem);
                group.Controls.Add(name);
                //group.Controls.Add(handNum);
                //group.Controls.Add(meleeType);
                //group.Controls.Add(attackSpd);
                //group.Controls.Add(dmg);
                //group.Controls.Add(dmgType);
                //group.Controls.Add(critical);
                //group.Controls.Add(criticalMult);
                //group.Controls.Add(rank);
                //group.Controls.Add(upgraded);
                //group.Controls.Add(unique);
                //group.Controls.Add(specialAttr);

            }
        }

        
    }
}
