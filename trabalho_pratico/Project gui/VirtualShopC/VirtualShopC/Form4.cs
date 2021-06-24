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
    public partial class Form4 : Form
    {
        private string _user = "";
        private int currentItem;
        string connStr = @"Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101; Initial Catalog = p1g4; uid = p1g4; password =Espanc@_R4b4s69";
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
                    LoadItemProperties();
                }
            }
        }

        public void LoadItemProperties()
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
                    BaseItems.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.melee WHERE BaseItem_ID IS NULL";
                    SqlCommand query = new SqlCommand(command, sqlConn);
                    query.CommandType = CommandType.Text;
                    SqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        Melee w = new Melee();
                        w.Name = reader["Name"].ToString();
                        w.Rank = reader["Rank"].ToString();
                        w.Upgraded = reader["Upgraded"].ToString();
                        w.Weapon_ID = reader["Weapon_ID"].ToString();
                        BaseItems.Items.Add(w);
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

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    BaseItems.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.armor WHERE BaseItem_ID IS NULL";
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
                        BaseItems.Items.Add(w);
                    }
                }
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

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    BaseItems.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.shield WHERE BaseItem_ID IS NULL";
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
                        BaseItems.Items.Add(w);
                    }
                }

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

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    BaseItems.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.physical WHERE BaseItem_ID IS NULL";
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

                        BaseItems.Items.Add(w);
                    }
                }

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

                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    BaseItems.Items.Clear();
                    string command = "SELECT * FROM VirtualShopc.magical WHERE BaseItem_ID IS NULL";
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
                        BaseItems.Items.Add(w);
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

                currentlyChecked = "CosmeticCheck";

                BaseItems.Items.Clear();

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

                BaseItems.Items.Clear();

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
                        SqlCommand sqlComm = new SqlCommand("VirtualShopc.meleeInsert", sqlConn);
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        Melee m = new Melee();
                        currentItem = BaseItems.SelectedIndex;
                        m = (Melee)BaseItems.Items[currentItem];


                        sqlComm.Parameters.AddWithValue("@AttackSpeed1", MeleeAtkSpdText.Value.ToString());
                        int handnum = 0;
                        if (OneHandRadio.Checked)
                        {
                            handnum = 1; 
                        }else if(TwoHandRadio.Checked)
                        {
                            handnum = 2;
                        }
                        sqlComm.Parameters.AddWithValue("@HandNum", handnum);
                        sqlComm.Parameters.AddWithValue("@MeleeType", MeleeTypeInput.Text);
                        sqlComm.Parameters.AddWithValue("@Price1", PriceText.Value.ToString());
                        sqlComm.Parameters.AddWithValue("@Name", NameText.Text);
                        int unique = 0;
                        if (UniqueNo.Checked)
                        {
                            unique = 0;
                        }
                        else if(UniqueYes.Checked)
                        {
                            unique = 1;
                        }
                        sqlComm.Parameters.AddWithValue("@isUnique", unique);
                        String upgraded = ItemUpgraded.Text;
                        MessageBox.Show(upgraded);
                        sqlComm.Parameters.AddWithValue("@Upgraded", Int32.Parse(upgraded));
                        int itemRank = 0;
                        if (CommonRank.Checked)
                        {
                            itemRank = 0;
                        } else if (UncommonRank.Checked)
                        {
                            itemRank = 1;
                        } else if (RareRank.Checked)
                        {
                            itemRank = 2;
                        } else if (LegendaryRank.Checked)
                        {
                            itemRank = 3;
                        }

                        sqlComm.Parameters.AddWithValue("@Rank", itemRank);
                        sqlComm.Parameters.AddWithValue("@TabNumber", 1);
                        sqlComm.Parameters.AddWithValue("@Stash_ID", 900);
                        sqlComm.Parameters.AddWithValue("@SpecialAttributes", MeleeSpecialAttributes.Text);
                        sqlComm.Parameters.AddWithValue("@Damage1",MeleeDmgText.Value.ToString());
                        string dmgType = "";
                        if (SlashDmg.Checked)
                        {
                            dmgType = "Slash";
                        }else if (PenetrationDmg.Checked)
                        {
                            dmgType = "Penetration";
                        }else if (FireDmg.Checked)
                        {
                            dmgType = "Fire";
                        }else if (EarthDmg.Checked)
                        {
                            dmgType = "Earth";
                        }else if (IceDmg.Checked)
                        {
                            dmgType = "Ice";
                        }else if (ConcussionDmg.Checked)
                        {
                            dmgType = "Concussion";
                        }else if (PoisonDmg.Checked)
                        {
                            dmgType = "Poison";
                        }else if (BleedDmg.Checked)
                        {
                            dmgType = "Bleed";
                        }
                        sqlComm.Parameters.AddWithValue("@DamageType", dmgType);
                        sqlComm.Parameters.AddWithValue("@CriticalChance1", MeleeCritChanceText.Value.ToString());
                        sqlComm.Parameters.AddWithValue("@CriticalMutiplier1", MeleeCritMultChance.Value.ToString());
                        sqlComm.Parameters.AddWithValue("@BaseItem_ID",Convert.ToInt32(m.Weapon_ID));

                        sqlComm.ExecuteNonQuery();

                    }
                    break;
                case "ArmorCheck":
                    using (SqlConnection sqlConn = new SqlConnection(connStr))
                    {
                        sqlConn.Open();
                        SqlCommand sqlComm = new SqlCommand("VirtualShopc.armorInsert", sqlConn);
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        Armor m = new Armor();
                        currentItem = BaseItems.SelectedIndex;
                        m = (Armor)BaseItems.Items[currentItem];
                        sqlComm.Parameters.AddWithValue("@Defense", "");
                        sqlComm.Parameters.AddWithValue("@HealthBonus", "");
                        sqlComm.Parameters.AddWithValue("@Price", "");
                        sqlComm.Parameters.AddWithValue("@Name", "");
                        sqlComm.Parameters.AddWithValue("@isUnique", "");
                        sqlComm.Parameters.AddWithValue("@Upgraded", "");
                        sqlComm.Parameters.AddWithValue("@Rank", "");
                        sqlComm.Parameters.AddWithValue("@TabNumber", "");
                        sqlComm.Parameters.AddWithValue("@Stash_ID", "");
                        sqlComm.Parameters.AddWithValue("@SpecialAttributes", "");
                        sqlComm.Parameters.AddWithValue("@BaseItemID", "");

                        sqlComm.ExecuteNonQuery();

                    }
                    break;
                case "ShieldCheck":
                    using (SqlConnection sqlConn = new SqlConnection(connStr))
                    {
                        sqlConn.Open();
                        SqlCommand sqlComm = new SqlCommand("VirtualShopc.shieldInsert", sqlConn);
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        Shield m = new Shield();
                        currentItem = BaseItems.SelectedIndex;
                        m = (Shield)BaseItems.Items[currentItem];
                        sqlComm.Parameters.AddWithValue("@Defense", "");
                        sqlComm.Parameters.AddWithValue("@SpecialAbility", "");
                        sqlComm.Parameters.AddWithValue("@Price", "");
                        sqlComm.Parameters.AddWithValue("@Name", "");
                        sqlComm.Parameters.AddWithValue("@isUnique", "");
                        sqlComm.Parameters.AddWithValue("@Upgraded", "");
                        sqlComm.Parameters.AddWithValue("@Rank", "");
                        sqlComm.Parameters.AddWithValue("@TabNumber", "");
                        sqlComm.Parameters.AddWithValue("@Stash_ID", "");
                        sqlComm.Parameters.AddWithValue("@SpecialAttributes", "");
                        sqlComm.Parameters.AddWithValue("@BaseItemID", "");

                        sqlComm.ExecuteNonQuery();

                    }
                    break;
                case "PhysicalCheck":
                    using (SqlConnection sqlConn = new SqlConnection(connStr))
                    {
                        sqlConn.Open();
                        SqlCommand sqlComm = new SqlCommand("VirtualShopc.physicalInsert", sqlConn);
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        Physical m = new Physical();
                        currentItem = BaseItems.SelectedIndex;
                        m = (Physical)BaseItems.Items[currentItem];
                        sqlComm.Parameters.AddWithValue("@FireRate", "");
                        sqlComm.Parameters.AddWithValue("@PiercingRate", "");
                        sqlComm.Parameters.AddWithValue("@Accuraccy", "");
                        sqlComm.Parameters.AddWithValue("@Range", "");
                        sqlComm.Parameters.AddWithValue("@Price", "");
                        sqlComm.Parameters.AddWithValue("@Name", "");
                        sqlComm.Parameters.AddWithValue("@isUnique", "");
                        sqlComm.Parameters.AddWithValue("@Upgraded", "");
                        sqlComm.Parameters.AddWithValue("@Rank", "");
                        sqlComm.Parameters.AddWithValue("@TabNumber", "");
                        sqlComm.Parameters.AddWithValue("@Stash_ID", "");
                        sqlComm.Parameters.AddWithValue("@SpecialAttributes", "");
                        sqlComm.Parameters.AddWithValue("@Damage", "");
                        sqlComm.Parameters.AddWithValue("@DamageType", "");
                        sqlComm.Parameters.AddWithValue("@CriticalChance", "");
                        sqlComm.Parameters.AddWithValue("@CriticalMultiplier", "");
                        sqlComm.Parameters.AddWithValue("@BaseItemID", "");

                        sqlComm.ExecuteNonQuery();

                    }
                    break;
                case "MagicalCheck":
                    using (SqlConnection sqlConn = new SqlConnection(connStr))
                    {
                        sqlConn.Open();
                        SqlCommand sqlComm = new SqlCommand("VirtualShopc.magicalInsert", sqlConn);
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        Magical m = new Magical();
                        currentItem = BaseItems.SelectedIndex;
                        m = (Magical)BaseItems.Items[currentItem];
                        sqlComm.Parameters.AddWithValue("@CoolDown", "");
                        sqlComm.Parameters.AddWithValue("@RadiusOfEffectiveness", "");
                        sqlComm.Parameters.AddWithValue("@Accuracy", "");
                        sqlComm.Parameters.AddWithValue("@Range", "");
                        sqlComm.Parameters.AddWithValue("@Price", "");
                        sqlComm.Parameters.AddWithValue("@Name", "");
                        sqlComm.Parameters.AddWithValue("@isUnique", "");
                        sqlComm.Parameters.AddWithValue("@Upgraded", "");
                        sqlComm.Parameters.AddWithValue("@Rank", "");
                        sqlComm.Parameters.AddWithValue("@TabNumber", "");
                        sqlComm.Parameters.AddWithValue("@Stash_ID", "");
                        sqlComm.Parameters.AddWithValue("@SpecialAttributes", "");
                        sqlComm.Parameters.AddWithValue("@Damage", "");
                        sqlComm.Parameters.AddWithValue("@DamageType", "");
                        sqlComm.Parameters.AddWithValue("@CriticalChance", "");
                        sqlComm.Parameters.AddWithValue("@CriticalMultiplier", "");
                        sqlComm.Parameters.AddWithValue("@BaseItemID", "");

                        sqlComm.ExecuteNonQuery();

                    }
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

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
