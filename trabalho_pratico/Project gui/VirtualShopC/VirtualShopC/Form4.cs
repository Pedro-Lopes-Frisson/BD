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
    public partial class Form4 : Form
    {
        private string _user = "";
        string connStr = @"Data Source=localhost;Initial Catalog=project_dummy;Integrated Security=True;";
        string[] baseattr = { "Price", "Weapon_ID", "AttackSpeed", "HandNum", "BaseItem_ID", "Name", "isUnique", "Upgraded",  };
        string currentlyChecked = "";
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
        private void CosmeticType_Click(object sender, EventArgs e)
        {
            checkGroup(ItemType, CosmeticCheck);
        }

        private void ConsumableType_Click(object sender, EventArgs e)
        {
            checkGroup(ItemType, ConsumableCheck);

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
            if (MeleeCheck.Checked)
            {
                BaseAttributes.Visible = true;
                MeleeAttributes.Visible = true;

                Consumable.Visible = false;
                Cosmetic.Visible = false;
                ArmorAttributes.Visible = false;
                ShieldAttributes.Visible = false;
                PhysicalAttributes.Visible = false;
                MagicalAttributes.Visible = false;
                Cosmetic.Visible = false;
                Consumable.Visible = false;

                currentlyChecked = "MeleeCheck";

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    string command = "SELECT * FROM melee WHERE BaseItem_ID IS NULL";
                    SqlCommand query = new SqlCommand(command, sqlConn);
                    query.CommandType = CommandType.Text;
                    SqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                    }
                }

            }
            else if (ArmorCheck.Checked)
            {
                BaseAttributes.Visible = true;
                ArmorAttributes.Visible = true;

                Consumable.Visible = false;
                Cosmetic.Visible = false;
                ShieldAttributes.Visible = false;
                MeleeAttributes.Visible = false;
                PhysicalAttributes.Visible = false;
                MagicalAttributes.Visible = false;
                Cosmetic.Visible = false;
                Consumable.Visible = false;

                currentlyChecked = "ArmorCheck";
            }
            else if (ShieldCheck.Checked)
            {
                BaseAttributes.Visible = true;
                ShieldAttributes.Visible = true;

                Consumable.Visible = false;
                Cosmetic.Visible = false;
                ArmorAttributes.Visible = false;
                MeleeAttributes.Visible = false;
                PhysicalAttributes.Visible = false;
                MagicalAttributes.Visible = false;
                Cosmetic.Visible = false;
                Consumable.Visible = false;

                currentlyChecked = "ShieldCheck";

            }
            else if (PhysicalCheck.Checked)
            {
                BaseAttributes.Visible = true;
                PhysicalAttributes.Visible = true;

                Consumable.Visible = false;
                Cosmetic.Visible = false;
                ArmorAttributes.Visible = false;
                ShieldAttributes.Visible = false;
                MeleeAttributes.Visible = false;
                MagicalAttributes.Visible = false;
                Cosmetic.Visible = false;
                Consumable.Visible = false;

                currentlyChecked = "PhysicalCheck";

            }
            else if (MagicalCheck.Checked)
            {
                BaseAttributes.Visible = true;
                MagicalAttributes.Visible = true;

                Consumable.Visible = false;
                Cosmetic.Visible = false;
                ArmorAttributes.Visible = false;
                ShieldAttributes.Visible = false;
                PhysicalAttributes.Visible = false;
                MeleeAttributes.Visible = false;
                Cosmetic.Visible = false;
                Consumable.Visible = false;

                currentlyChecked = "MagicalCheck";

            }
            else if (CosmeticCheck.Checked)
            {
                Cosmetic.Visible = true;

                MeleeAttributes.Visible = false;
                BaseAttributes.Visible = false;
                Consumable.Visible = false;
                ArmorAttributes.Visible = false;
                ShieldAttributes.Visible = false;
                PhysicalAttributes.Visible = false;
                MagicalAttributes.Visible = false;
                Consumable.Visible = false;

                currentlyChecked = "CosmeticCheck";

            }
            else if (ConsumableCheck.Checked)
            {
                Consumable.Visible = true;

                MeleeAttributes.Visible = false;
                BaseAttributes.Visible = false;
                Cosmetic.Visible = false;
                ArmorAttributes.Visible = false;
                ShieldAttributes.Visible = false;
                PhysicalAttributes.Visible = false;
                MagicalAttributes.Visible = false;
                Cosmetic.Visible = false;

                currentlyChecked = "ConsumableCheck";

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

        private void ResgisterItem_Click(object sender, EventArgs e)
        {
            switch (currentlyChecked)
            {
                case "MeleeCheck":
                    using (SqlConnection sqlConn = new SqlConnection(connStr))
                    {
                        sqlConn.Open();
                        SqlCommand sqlComm = new SqlCommand("Melee_Insert", sqlConn);
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.Parameters.AddWithValue("@Username", "dummy");
                        sqlComm.Parameters.AddWithValue("@Password", "dummypassword");
                        
                        sqlComm.ExecuteNonQuery();

                    }
                    break;
                case "ArmorCheck":

                    break;
                case "ShieldCheck":

                    break;
                case "PhysicalCheck":

                    break;
                case "MagicalCheck":

                    break;
                case "ConsumableCheck":

                    break;
                case "CosmeticCheck":

                    break;
                default:
                    MessageBox.Show("Please select an item to register");
                    break;
            }
        }
    }
}
