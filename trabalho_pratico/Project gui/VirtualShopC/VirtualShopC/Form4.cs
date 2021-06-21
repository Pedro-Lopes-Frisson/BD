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
        string[] baseattr = { "Price", "Weapon_ID", "AttackSpeed", "HandNum", "BaseItem_ID", "Name", "isUnique", "Upgraded",  };
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
                    LoadItemProperties(checkbox, MeleeAttributes);
                }
            }
        }

        public void LoadItemProperties(CheckBox checkBox, GroupBox group)
        {
            if(checkBox == MeleeCheck)
            {
                melee.Melee c = new melee.Melee();
                int space = 20;
                foreach (var prop in c.GetType().GetProperties())
                {
                    if(prop.Name != "Weapon_ID" && prop.Name != "Stash_ID" && prop.Name != "Name") {
                        if (prop.Name == "isUnique")
                        {
                            Label label2 = new Label();
                            label2.Text = "Unique Item";
                            label2.Location = new Point(20, space);
                            CheckBox check1 = new CheckBox();
                            CheckBox check2 = new CheckBox();
                            check1.Text = "Yes";
                            check2.Text = "No";
                            check1.Name = "UniqueYes";
                            check2.Name = "UniqueNo";
                            check1.Location = new Point(150, space);
                            check2.Location = new Point(270, space);
                            group.Controls.Add(label2);
                            group.Controls.Add(check1);
                            group.Controls.Add(check2);
                            space += 25;
                            continue;
                        }
                        if (prop.Name == "Rank")
                        {
                            Label label3 = new Label();
                            label3.Text = "Item Rank";
                            label3.Location = new Point(20, space);
                            space += 25;
                            group.Controls.Add(label3);
                            continue;
                        }
                        if (prop.Name == "TabNumber")
                        {
                            Label label3 = new Label();
                            label3.Text = "Stash Tab Number";
                            label3.Location = new Point(20, space);
                            space += 25;
                            group.Controls.Add(label3);
                            continue;
                        }
                        Label label1 = new Label();
                        label1.Text = prop.Name;
                        label1.Location = new Point(20, space);
                        space += 25;
                        group.Controls.Add(label1);
                    }
                }

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
