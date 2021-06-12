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

        public void LoadItemProperties(CheckBox checkBox)
        {

        }
    }
}
