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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void MeleeCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.checkGroup(ItemType, MeleeCheck);
            

        }

        private void ArmorCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.checkGroup(ItemType, ArmorCheck);

        }

        private void ShieldCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.checkGroup(ItemType, ShieldCheck);

        }

        private void PhysicalCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.checkGroup(ItemType, PhysicalCheck);

        }

        private void MagicalCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.checkGroup(ItemType, MagicalCheck);

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
    }
}
