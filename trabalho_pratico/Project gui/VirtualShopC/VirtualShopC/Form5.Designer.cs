namespace VirtualShopC
{
    partial class Form5
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
            this.ItemList = new System.Windows.Forms.ListBox();
            this.Title = new System.Windows.Forms.Label();
            this.FiltersType = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.ConsumableCheck = new System.Windows.Forms.CheckBox();
            this.CosmeticCheck = new System.Windows.Forms.CheckBox();
            this.MagicalCheck = new System.Windows.Forms.CheckBox();
            this.PhysicalCheck = new System.Windows.Forms.CheckBox();
            this.RangedCheck = new System.Windows.Forms.CheckBox();
            this.MeleeCheck = new System.Windows.Forms.CheckBox();
            this.ShieldCheck = new System.Windows.Forms.CheckBox();
            this.ArmorCheck = new System.Windows.Forms.CheckBox();
            this.WeaponCheck = new System.Windows.Forms.CheckBox();
            this.FiltersType.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 16;
            this.ItemList.Location = new System.Drawing.Point(0, 297);
            this.ItemList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(1073, 452);
            this.ItemList.TabIndex = 20;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 0, 11, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(140, 29);
            this.Title.TabIndex = 18;
            this.Title.Text = "Your Stash";
            // 
            // FiltersType
            // 
            this.FiltersType.AccessibleName = "FiltersType";
            this.FiltersType.Controls.Add(this.Search);
            this.FiltersType.Controls.Add(this.ConsumableCheck);
            this.FiltersType.Controls.Add(this.CosmeticCheck);
            this.FiltersType.Controls.Add(this.MagicalCheck);
            this.FiltersType.Controls.Add(this.PhysicalCheck);
            this.FiltersType.Controls.Add(this.RangedCheck);
            this.FiltersType.Controls.Add(this.MeleeCheck);
            this.FiltersType.Controls.Add(this.ShieldCheck);
            this.FiltersType.Controls.Add(this.ArmorCheck);
            this.FiltersType.Controls.Add(this.WeaponCheck);
            this.FiltersType.Location = new System.Drawing.Point(0, 32);
            this.FiltersType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltersType.Name = "FiltersType";
            this.FiltersType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltersType.Size = new System.Drawing.Size(1073, 252);
            this.FiltersType.TabIndex = 21;
            this.FiltersType.TabStop = false;
            this.FiltersType.Text = "Filter by Type";
            // 
            // Search
            // 
            this.Search.AccessibleName = "Search";
            this.Search.Location = new System.Drawing.Point(480, 210);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(99, 36);
            this.Search.TabIndex = 9;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ConsumableCheck
            // 
            this.ConsumableCheck.AccessibleName = "PhysicalCheck";
            this.ConsumableCheck.AutoSize = true;
            this.ConsumableCheck.Location = new System.Drawing.Point(915, 150);
            this.ConsumableCheck.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ConsumableCheck.Name = "ConsumableCheck";
            this.ConsumableCheck.Size = new System.Drawing.Size(108, 21);
            this.ConsumableCheck.TabIndex = 8;
            this.ConsumableCheck.Text = "Consumable";
            this.ConsumableCheck.UseVisualStyleBackColor = true;
            // 
            // CosmeticCheck
            // 
            this.CosmeticCheck.AccessibleName = "PhysicalCheck";
            this.CosmeticCheck.AutoSize = true;
            this.CosmeticCheck.Location = new System.Drawing.Point(499, 150);
            this.CosmeticCheck.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CosmeticCheck.Name = "CosmeticCheck";
            this.CosmeticCheck.Size = new System.Drawing.Size(87, 21);
            this.CosmeticCheck.TabIndex = 7;
            this.CosmeticCheck.Text = "Cosmetic";
            this.CosmeticCheck.UseVisualStyleBackColor = true;
            // 
            // MagicalCheck
            // 
            this.MagicalCheck.AccessibleName = "MagicalCheck";
            this.MagicalCheck.AutoSize = true;
            this.MagicalCheck.Location = new System.Drawing.Point(915, 86);
            this.MagicalCheck.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MagicalCheck.Name = "MagicalCheck";
            this.MagicalCheck.Size = new System.Drawing.Size(142, 21);
            this.MagicalCheck.TabIndex = 6;
            this.MagicalCheck.Text = "Magical (Ranged)";
            this.MagicalCheck.UseVisualStyleBackColor = true;
            // 
            // PhysicalCheck
            // 
            this.PhysicalCheck.AccessibleName = "PhysicalCheck";
            this.PhysicalCheck.AutoSize = true;
            this.PhysicalCheck.Location = new System.Drawing.Point(9, 150);
            this.PhysicalCheck.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PhysicalCheck.Name = "PhysicalCheck";
            this.PhysicalCheck.Size = new System.Drawing.Size(146, 21);
            this.PhysicalCheck.TabIndex = 5;
            this.PhysicalCheck.Text = "Physical (Ranged)";
            this.PhysicalCheck.UseVisualStyleBackColor = true;
            // 
            // RangedCheck
            // 
            this.RangedCheck.AccessibleName = "RangedCheck";
            this.RangedCheck.AutoSize = true;
            this.RangedCheck.Location = new System.Drawing.Point(499, 86);
            this.RangedCheck.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RangedCheck.Name = "RangedCheck";
            this.RangedCheck.Size = new System.Drawing.Size(80, 21);
            this.RangedCheck.TabIndex = 4;
            this.RangedCheck.Text = "Ranged";
            this.RangedCheck.UseVisualStyleBackColor = true;
            // 
            // MeleeCheck
            // 
            this.MeleeCheck.AccessibleName = "MeleeCheck";
            this.MeleeCheck.AutoSize = true;
            this.MeleeCheck.Location = new System.Drawing.Point(9, 86);
            this.MeleeCheck.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MeleeCheck.Name = "MeleeCheck";
            this.MeleeCheck.Size = new System.Drawing.Size(68, 21);
            this.MeleeCheck.TabIndex = 3;
            this.MeleeCheck.Text = "Melee";
            this.MeleeCheck.UseVisualStyleBackColor = true;
            // 
            // ShieldCheck
            // 
            this.ShieldCheck.AccessibleName = "ShieldCheck";
            this.ShieldCheck.AutoSize = true;
            this.ShieldCheck.Location = new System.Drawing.Point(915, 25);
            this.ShieldCheck.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ShieldCheck.Name = "ShieldCheck";
            this.ShieldCheck.Size = new System.Drawing.Size(69, 21);
            this.ShieldCheck.TabIndex = 2;
            this.ShieldCheck.Text = "Shield";
            this.ShieldCheck.UseVisualStyleBackColor = true;
            // 
            // ArmorCheck
            // 
            this.ArmorCheck.AccessibleName = "ArmorCheck";
            this.ArmorCheck.AutoSize = true;
            this.ArmorCheck.Location = new System.Drawing.Point(499, 25);
            this.ArmorCheck.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ArmorCheck.Name = "ArmorCheck";
            this.ArmorCheck.Size = new System.Drawing.Size(68, 21);
            this.ArmorCheck.TabIndex = 1;
            this.ArmorCheck.Text = "Armor";
            this.ArmorCheck.UseVisualStyleBackColor = true;
            // 
            // WeaponCheck
            // 
            this.WeaponCheck.AccessibleName = "WeaponCheck";
            this.WeaponCheck.AutoSize = true;
            this.WeaponCheck.Location = new System.Drawing.Point(9, 25);
            this.WeaponCheck.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WeaponCheck.Name = "WeaponCheck";
            this.WeaponCheck.Size = new System.Drawing.Size(83, 21);
            this.WeaponCheck.TabIndex = 0;
            this.WeaponCheck.Text = "Weapon";
            this.WeaponCheck.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 751);
            this.Controls.Add(this.FiltersType);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.FiltersType.ResumeLayout(false);
            this.FiltersType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox FiltersType;
        private System.Windows.Forms.CheckBox ConsumableCheck;
        private System.Windows.Forms.CheckBox CosmeticCheck;
        private System.Windows.Forms.CheckBox MagicalCheck;
        private System.Windows.Forms.CheckBox PhysicalCheck;
        private System.Windows.Forms.CheckBox RangedCheck;
        private System.Windows.Forms.CheckBox MeleeCheck;
        private System.Windows.Forms.CheckBox ShieldCheck;
        private System.Windows.Forms.CheckBox ArmorCheck;
        private System.Windows.Forms.CheckBox WeaponCheck;
        private System.Windows.Forms.Button Search;
    }
}