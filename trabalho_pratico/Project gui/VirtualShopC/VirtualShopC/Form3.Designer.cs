namespace VirtualShopC
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.project_dummyDataSet = new VirtualShopC.project_dummyDataSet();
            this.armorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armorTableAdapter = new VirtualShopC.project_dummyDataSetTableAdapters.armorTableAdapter();
            this.physicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.physicalTableAdapter = new VirtualShopC.project_dummyDataSetTableAdapters.physicalTableAdapter();
            this.Search = new System.Windows.Forms.Button();
            this.FiltersType = new System.Windows.Forms.GroupBox();
            this.MagicalCheck = new System.Windows.Forms.CheckBox();
            this.PhysicalCheck = new System.Windows.Forms.CheckBox();
            this.RangedCheck = new System.Windows.Forms.CheckBox();
            this.MeleeCheck = new System.Windows.Forms.CheckBox();
            this.ShieldCheck = new System.Windows.Forms.CheckBox();
            this.ArmorCheck = new System.Windows.Forms.CheckBox();
            this.WeaponCheck = new System.Windows.Forms.CheckBox();
            this.ItemShower = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MyStore = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.project_dummyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalBindingSource)).BeginInit();
            this.FiltersType.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // project_dummyDataSet
            // 
            this.project_dummyDataSet.DataSetName = "project_dummyDataSet";
            this.project_dummyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // armorBindingSource
            // 
            this.armorBindingSource.DataMember = "armor";
            this.armorBindingSource.DataSource = this.project_dummyDataSet;
            // 
            // armorTableAdapter
            // 
            this.armorTableAdapter.ClearBeforeFill = true;
            // 
            // physicalBindingSource
            // 
            this.physicalBindingSource.DataMember = "physical";
            this.physicalBindingSource.DataSource = this.project_dummyDataSet;
            // 
            // physicalTableAdapter
            // 
            this.physicalTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.Search.AccessibleName = "Search";
            this.Search.Location = new System.Drawing.Point(531, 390);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(98, 36);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // FiltersType
            // 
            this.FiltersType.AccessibleName = "FiltersType";
            this.FiltersType.Controls.Add(this.MagicalCheck);
            this.FiltersType.Controls.Add(this.PhysicalCheck);
            this.FiltersType.Controls.Add(this.RangedCheck);
            this.FiltersType.Controls.Add(this.MeleeCheck);
            this.FiltersType.Controls.Add(this.ShieldCheck);
            this.FiltersType.Controls.Add(this.ArmorCheck);
            this.FiltersType.Controls.Add(this.WeaponCheck);
            this.FiltersType.Location = new System.Drawing.Point(436, 24);
            this.FiltersType.Name = "FiltersType";
            this.FiltersType.Size = new System.Drawing.Size(336, 186);
            this.FiltersType.TabIndex = 2;
            this.FiltersType.TabStop = false;
            this.FiltersType.Text = "Filter by Type";
            // 
            // MagicalCheck
            // 
            this.MagicalCheck.AccessibleName = "MagicalCheck";
            this.MagicalCheck.AutoSize = true;
            this.MagicalCheck.Location = new System.Drawing.Point(193, 150);
            this.MagicalCheck.Margin = new System.Windows.Forms.Padding(5);
            this.MagicalCheck.Name = "MagicalCheck";
            this.MagicalCheck.Size = new System.Drawing.Size(142, 21);
            this.MagicalCheck.TabIndex = 6;
            this.MagicalCheck.Text = "Magical (Ranged)";
            this.MagicalCheck.UseVisualStyleBackColor = true;
            this.MagicalCheck.CheckedChanged += new System.EventHandler(this.MagicalCheck_CheckedChanged);
            // 
            // PhysicalCheck
            // 
            this.PhysicalCheck.AccessibleName = "PhysicalCheck";
            this.PhysicalCheck.AutoSize = true;
            this.PhysicalCheck.Location = new System.Drawing.Point(9, 150);
            this.PhysicalCheck.Margin = new System.Windows.Forms.Padding(5);
            this.PhysicalCheck.Name = "PhysicalCheck";
            this.PhysicalCheck.Size = new System.Drawing.Size(146, 21);
            this.PhysicalCheck.TabIndex = 5;
            this.PhysicalCheck.Text = "Physical (Ranged)";
            this.PhysicalCheck.UseVisualStyleBackColor = true;
            this.PhysicalCheck.CheckedChanged += new System.EventHandler(this.PhysicalCheck_CheckedChanged);
            // 
            // RangedCheck
            // 
            this.RangedCheck.AccessibleName = "RangedCheck";
            this.RangedCheck.AutoSize = true;
            this.RangedCheck.Location = new System.Drawing.Point(121, 86);
            this.RangedCheck.Margin = new System.Windows.Forms.Padding(5);
            this.RangedCheck.Name = "RangedCheck";
            this.RangedCheck.Size = new System.Drawing.Size(80, 21);
            this.RangedCheck.TabIndex = 4;
            this.RangedCheck.Text = "Ranged";
            this.RangedCheck.UseVisualStyleBackColor = true;
            this.RangedCheck.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // MeleeCheck
            // 
            this.MeleeCheck.AccessibleName = "MeleeCheck";
            this.MeleeCheck.AutoSize = true;
            this.MeleeCheck.Location = new System.Drawing.Point(9, 86);
            this.MeleeCheck.Margin = new System.Windows.Forms.Padding(5);
            this.MeleeCheck.Name = "MeleeCheck";
            this.MeleeCheck.Size = new System.Drawing.Size(68, 21);
            this.MeleeCheck.TabIndex = 3;
            this.MeleeCheck.Text = "Melee";
            this.MeleeCheck.UseVisualStyleBackColor = true;
            this.MeleeCheck.CheckedChanged += new System.EventHandler(this.MeleeCheck_CheckedChanged);
            // 
            // ShieldCheck
            // 
            this.ShieldCheck.AccessibleName = "ShieldCheck";
            this.ShieldCheck.AutoSize = true;
            this.ShieldCheck.Location = new System.Drawing.Point(236, 24);
            this.ShieldCheck.Margin = new System.Windows.Forms.Padding(6);
            this.ShieldCheck.Name = "ShieldCheck";
            this.ShieldCheck.Size = new System.Drawing.Size(69, 21);
            this.ShieldCheck.TabIndex = 2;
            this.ShieldCheck.Text = "Shield";
            this.ShieldCheck.UseVisualStyleBackColor = true;
            this.ShieldCheck.CheckedChanged += new System.EventHandler(this.ShieldCheck_CheckedChanged);
            // 
            // ArmorCheck
            // 
            this.ArmorCheck.AccessibleName = "ArmorCheck";
            this.ArmorCheck.AutoSize = true;
            this.ArmorCheck.Location = new System.Drawing.Point(121, 24);
            this.ArmorCheck.Margin = new System.Windows.Forms.Padding(6);
            this.ArmorCheck.Name = "ArmorCheck";
            this.ArmorCheck.Size = new System.Drawing.Size(68, 21);
            this.ArmorCheck.TabIndex = 1;
            this.ArmorCheck.Text = "Armor";
            this.ArmorCheck.UseVisualStyleBackColor = true;
            this.ArmorCheck.CheckedChanged += new System.EventHandler(this.ArmorCheck_CheckedChanged);
            // 
            // WeaponCheck
            // 
            this.WeaponCheck.AccessibleName = "WeaponCheck";
            this.WeaponCheck.AutoSize = true;
            this.WeaponCheck.Location = new System.Drawing.Point(9, 24);
            this.WeaponCheck.Margin = new System.Windows.Forms.Padding(6);
            this.WeaponCheck.Name = "WeaponCheck";
            this.WeaponCheck.Size = new System.Drawing.Size(83, 21);
            this.WeaponCheck.TabIndex = 0;
            this.WeaponCheck.Text = "Weapon";
            this.WeaponCheck.UseVisualStyleBackColor = true;
            this.WeaponCheck.CheckedChanged += new System.EventHandler(this.WeaponCheck_CheckedChanged);
            // 
            // ItemShower
            // 
            this.ItemShower.AccessibleName = "ItemShower";
            this.ItemShower.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemShower.HideSelection = false;
            this.ItemShower.Location = new System.Drawing.Point(0, 30);
            this.ItemShower.Name = "ItemShower";
            this.ItemShower.Size = new System.Drawing.Size(370, 408);
            this.ItemShower.TabIndex = 3;
            this.ItemShower.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyStore});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MyStore
            // 
            this.MyStore.AccessibleName = "MyStore";
            this.MyStore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterItem});
            this.MyStore.Name = "MyStore";
            this.MyStore.Size = new System.Drawing.Size(78, 26);
            this.MyStore.Text = "MyStore";
            // 
            // RegisterItem
            // 
            this.RegisterItem.AccessibleName = "RegisterItem";
            this.RegisterItem.Name = "RegisterItem";
            this.RegisterItem.Size = new System.Drawing.Size(180, 26);
            this.RegisterItem.Text = "Register Item";
            this.RegisterItem.Click += new System.EventHandler(this.RegisterItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 438);
            this.Controls.Add(this.ItemShower);
            this.Controls.Add(this.FiltersType);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_dummyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalBindingSource)).EndInit();
            this.FiltersType.ResumeLayout(false);
            this.FiltersType.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private project_dummyDataSet project_dummyDataSet;
        private System.Windows.Forms.BindingSource armorBindingSource;
        private project_dummyDataSetTableAdapters.armorTableAdapter armorTableAdapter;
        private System.Windows.Forms.BindingSource physicalBindingSource;
        private project_dummyDataSetTableAdapters.physicalTableAdapter physicalTableAdapter;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.GroupBox FiltersType;
        private System.Windows.Forms.CheckBox MagicalCheck;
        private System.Windows.Forms.CheckBox PhysicalCheck;
        private System.Windows.Forms.CheckBox RangedCheck;
        private System.Windows.Forms.CheckBox MeleeCheck;
        private System.Windows.Forms.CheckBox ShieldCheck;
        private System.Windows.Forms.CheckBox ArmorCheck;
        private System.Windows.Forms.CheckBox WeaponCheck;
        private System.Windows.Forms.ListView ItemShower;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MyStore;
        private System.Windows.Forms.ToolStripMenuItem RegisterItem;
    }
}