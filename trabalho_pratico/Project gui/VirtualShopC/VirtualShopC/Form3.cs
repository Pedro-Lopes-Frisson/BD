using VirtualShopC.Objetos;

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

        string connStr = @"Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101; Initial Catalog = p1g4; uid = p1g4; password =Espanc@_R4b4s69";
        string _user = "";
        int selectedIndex = 0;

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
            this.GetMoney();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();
                string command = "select [Name], [Upgraded], [Rank] from ";
                string command2 = "select [";
                int commandNo = 0;
                foreach (Control c in FiltersType.Controls)
                {
                    CheckBox checkbox = c as CheckBox;
                    if (checkbox.Checked)
                    {
                        commandNo++;
                    }
                }
                LoadItemProperties();

            }


        }

        private void RegisterItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(_user);
            form4.ShowDialog();
        }

        private void WeaponCheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ArmorCheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ShieldCheck_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MeleeCheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }


        private void PhysicalCheck_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MagicalCheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ConsumableCheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void CosmeticCheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void YourStash_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(_user);
            form5.ShowDialog();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void MagicalSpecialAttributes_TextChanged(object sender, EventArgs e)
        {

        }

        private void MagicalRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void MagicalAccuracy_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiltersType_Enter(object sender, EventArgs e)
        {

        }

        private void BuyItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                decimal price = 0;
                sqlConn.Open();
                SqlCommand sqlComm = new SqlCommand("VirtualShopc.CompratItemProc", sqlConn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                if (MeleeCheck.Checked || PhysicalCheck.Checked || MagicalCheck.Checked || ArmorCheck.Checked || ShieldCheck.Checked || WeaponCheck.Checked || RangedCheck.Checked)
                {
                    price = Convert.ToDecimal(PriceText.Text);
                }else if(CosmeticCheck.Checked )
                {
                    price = Convert.ToDecimal(CosmeticPrice.Text);
                }else if ( ConsumableCheck.Checked)
                {
                    price = Convert.ToDecimal(ConsumablePrice.Text);
                }
                sqlComm.Parameters.AddWithValue("@AccName", this._user);
                sqlComm.Parameters.AddWithValue("@Price", price);
                SqlParameter success = new SqlParameter("@Result", DbType.Binary);
                success.Direction = System.Data.ParameterDirection.Output;
                sqlComm.Parameters.Add(success);
                sqlComm.ExecuteNonQuery();
                if(sqlComm.Parameters["@Result"].Value.ToString() == "1")
                {
                    MessageBox.Show("Item bought with success!");
                    this.GetMoney();
                }
                else
                {
                    MessageBox.Show("Could not buy item\nCheck if you have enough money to proceed with the transaction...");
                }
            }
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

        private void WeaponCheck_Click(object sender, EventArgs e)
        {
            checkGroup(FiltersType, WeaponCheck);
        }

        private void ArmorCheck_Click(object sender, EventArgs e)
        {
            checkGroup(FiltersType, ArmorCheck);

        }

        private void ShieldCheck_Click(object sender, EventArgs e)
        {
            checkGroup(FiltersType, ShieldCheck);

        }

        private void MeleeCheck_Click(object sender, EventArgs e)
        {
            checkGroup(FiltersType, MeleeCheck);

        }

        private void RangedCheck_Click(object sender, EventArgs e)
        {
            checkGroup(FiltersType, RangedCheck);

        }

        private void MagicalCheck_Click(object sender, EventArgs e)
        {
            checkGroup(FiltersType, MagicalCheck);

        }

        private void PhysicalCheck_Click(object sender, EventArgs e)
        {
            checkGroup(FiltersType, PhysicalCheck);

        }

        private void CosmeticCheck_Click(object sender, EventArgs e)
        {
            checkGroup(FiltersType, CosmeticCheck);

        }

        private void ConsumableCheck_Click(object sender, EventArgs e)
        {
            checkGroup(FiltersType, ConsumableCheck);

        }
        public void LoadItemProperties()
        {
            if (MeleeCheck.Checked)
            {
                Requirements.Visible = true;
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

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    ItemShower.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.melee WHERE BaseItem_ID IS NOT NULL";
                    SqlCommand query = new SqlCommand(command, sqlConn);
                    query.CommandType = CommandType.Text;
                    SqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        Melee w = new Melee();
                        w.Name = reader["Name"].ToString();
                        w.Rank = reader["Rank"].ToString();
                        w.Upgraded =  reader["Upgraded"].ToString();
                        w.Weapon_ID = reader["Weapon_ID"].ToString();
                        //w.Stash_ID = reader["Stash_ID"].ToString();
                        w.Price = reader["Price"].ToString();
                        w.isUnique = reader["isUnique"].ToString();
                        w.AttackSpeed = reader["AttackSpeed"].ToString();
                        w.Damage = reader["Damage"].ToString();
                        w.DamageType = reader["DamageType"].ToString();
                        w.CriticalChance = reader["CriticalChance"].ToString();
                        w.CriticalMutiplier = reader["CriticalMutiplier"].ToString();
                        w.MeleeType  = reader["MeleeType"].ToString();
                        w.SpecialAttributes = reader["SpecialAttributes"].ToString();
                        w.HandNum = reader["HandNum"].ToString();
                        ItemShower.Items.Add(w);
                    }
                    
                }

            }
            else if (ArmorCheck.Checked)
            {
                Requirements.Visible = true;
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

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    ItemShower.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.armor WHERE BaseItem_ID IS NOT NULL";
                    SqlCommand query = new SqlCommand(command, sqlConn);
                    query.CommandType = CommandType.Text;
                    SqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        Armor w = new Armor();
                        w.Name = reader["Name"].ToString();
                        w.Rank = reader["Rank"].ToString();
                        w.Upgraded = reader["Upgraded"].ToString();
                        w.ID = reader["ID"].ToString();
                        //w.Stash_ID = reader["Stash_ID"].ToString();
                        w.Price = reader["Price"].ToString();
                        w.isUnique = reader["isUnique"].ToString();
                        w.Defense = reader["Defense"].ToString();
                        w.HealthBonus = reader["HealthBonus"].ToString();
                        w.SpecialAttributes = reader["SpecialAttributes"].ToString();
                        ItemShower.Items.Add(w);
                    }

                }

            }
            else if (ShieldCheck.Checked)
            {
                Requirements.Visible = true;
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

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    ItemShower.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.shield WHERE BaseItem_ID IS NOT NULL";
                    SqlCommand query = new SqlCommand(command, sqlConn);
                    query.CommandType = CommandType.Text;
                    SqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        Shield w = new Shield();
                        w.Name = reader["Name"].ToString();
                        w.Rank = reader["Rank"].ToString();
                        w.Upgraded = reader["Upgraded"].ToString();
                        w.ID = reader["ID"].ToString();
                        //w.Stash_ID = reader["Stash_ID"].ToString();
                        w.Price = reader["Price"].ToString();
                        w.isUnique = reader["isUnique"].ToString();
                        w.Defense = reader["Defense"].ToString();
                        w.SpecialAbility = reader["HealthBonus"].ToString();
                        ItemShower.Items.Add(w);
                    }

                }

            }
            else if (PhysicalCheck.Checked)
            {
                Requirements.Visible = true;
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

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    ItemShower.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.physical WHERE BaseItem_ID IS NOT NULL";
                    SqlCommand query = new SqlCommand(command, sqlConn);
                    query.CommandType = CommandType.Text;
                    SqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        Physical w = new Physical();
                        w.Name = reader["Name"].ToString();
                        w.Rank = reader["Rank"].ToString();
                        w.Upgraded = reader["Upgraded"].ToString();
                        w.item_ID = reader["item_ID"].ToString();
                        //w.Stash_ID = reader["Stash_ID"].ToString();
                        w.Price = reader["Price"].ToString();
                        w.isUnique = reader["isUnique"].ToString();
                        w.PiercingRate = reader["PiercingRate"].ToString();
                        w.Damage = reader["Damage"].ToString();
                        w.DamageType = reader["DamageType"].ToString();
                        w.CriticalChance = reader["CriticalChance"].ToString();
                        w.CriticalMutiplier = reader["CriticalMutiplier"].ToString();
                        w.Range = reader["Range"].ToString();
                        w.SpecialAttributes = reader["SpecialAttributes"].ToString();
                        w.FireRate = reader["FireRate"].ToString();
                        w.Accuraccy = reader["Accuraccy"].ToString();
                        ItemShower.Items.Add(w);
                    }

                }

            }
            else if (MagicalCheck.Checked)
            {
                Requirements.Visible = true;
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

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    ItemShower.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.magical WHERE BaseItem_ID IS NOT NULL";
                    SqlCommand query = new SqlCommand(command, sqlConn);
                    query.CommandType = CommandType.Text;
                    SqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        Magical w = new Magical();
                        w.Name = reader["Name"].ToString();
                        w.Rank = reader["Rank"].ToString();
                        w.Upgraded = reader["Upgraded"].ToString();
                        w.item_ID = reader["item_ID"].ToString();
                        //w.Stash_ID = reader["Stash_ID"].ToString();
                        w.Price = reader["Price"].ToString();
                        w.isUnique = reader["isUnique"].ToString();
                        w.RadiusOfEffectiveness = reader["RadiusOfEffectiveness"].ToString();
                        w.Damage = reader["Damage"].ToString();
                        w.DamageType = reader["DamageType"].ToString();
                        w.CriticalChance = reader["CriticalChance"].ToString();
                        w.CriticalMutiplier = reader["CriticalMutiplier"].ToString();
                        w.Range = reader["Range"].ToString();
                        w.SpecialAttributes = reader["SpecialAttributes"].ToString();
                        w.CoolDown = reader["CoolDown"].ToString();
                        w.Accuraccy = reader["Accuraccy"].ToString();
                        ItemShower.Items.Add(w);
                    }

                }

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

            }

        }

        public void GetMoney()
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            { 
                sqlConn.Open();
                String command = String.Format("select [GameCurrency], [RealCurrency] from VirtualShopc.[user] where AccName='{0}'", this._user);
                SqlCommand query = new SqlCommand(command, sqlConn);
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Gold.Text = reader["GameCurrency"].ToString();
                    Money.Text = reader["RealCurrency"].ToString();
                }
            }   
        }
        

        public void FillItemProperties()
        {
            if (MeleeCheck.Checked)
            {
                Melee m = new Melee();
                m = (Melee)ItemShower.Items[this.selectedIndex];
                NameText.Text = m.Name;
                PriceText.Text = m.Price;
                ItemUpgraded.Text = m.Upgraded;
                ItemRank.Text = m.Rank;
                ItemUnique.Text = m.isUnique;
                MeleeAtkSpdText.Text = m.AttackSpeed;
                MeleeCritChanceText.Text = m.CriticalChance;
                MeleeCritMultChance.Text = m.CriticalMutiplier;
                MeleeDmgText.Text = m.Damage;
                MeleeDmgType.Text = m.DamageType;
                MeleeHandNum.Text = m.HandNum;
                MeleeTypeInput.Text = m.MeleeType;
                MeleeSpecialAttributes.Text = m.SpecialAttributes;
            }
            else if (WeaponCheck.Checked)
            {

            }else if (RangedCheck.Checked)
            {

            }else if (PhysicalCheck.Checked)
            {

            }else if (MagicalCheck.Checked)
            {

            }else if (ArmorCheck.Checked)
            {

            }else if (ShieldCheck.Checked)
            {

            }



        }

        private void ItemShower_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedIndex = ItemShower.SelectedIndex;
            this.FillItemProperties();
        }
    }
}

