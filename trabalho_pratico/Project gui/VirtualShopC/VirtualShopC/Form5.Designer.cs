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
            this.ItemType = new System.Windows.Forms.GroupBox();
            this.ConsumableCheck = new System.Windows.Forms.CheckBox();
            this.CosmeticCheck = new System.Windows.Forms.CheckBox();
            this.FilterItems = new System.Windows.Forms.Button();
            this.MeleeCheck = new System.Windows.Forms.CheckBox();
            this.ArmorCheck = new System.Windows.Forms.CheckBox();
            this.ShieldCheck = new System.Windows.Forms.CheckBox();
            this.MagicalCheck = new System.Windows.Forms.CheckBox();
            this.PhysicalCheck = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.Label();
            this.ItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemList
            // 
            this.ItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 16;
            this.ItemList.Location = new System.Drawing.Point(0, 217);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(1441, 534);
            this.ItemList.TabIndex = 20;
            // 
            // ItemType
            // 
            this.ItemType.Controls.Add(this.ConsumableCheck);
            this.ItemType.Controls.Add(this.CosmeticCheck);
            this.ItemType.Controls.Add(this.FilterItems);
            this.ItemType.Controls.Add(this.MeleeCheck);
            this.ItemType.Controls.Add(this.ArmorCheck);
            this.ItemType.Controls.Add(this.ShieldCheck);
            this.ItemType.Controls.Add(this.MagicalCheck);
            this.ItemType.Controls.Add(this.PhysicalCheck);
            this.ItemType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemType.Location = new System.Drawing.Point(0, 29);
            this.ItemType.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.ItemType.Name = "ItemType";
            this.ItemType.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ItemType.Size = new System.Drawing.Size(1441, 188);
            this.ItemType.TabIndex = 19;
            this.ItemType.TabStop = false;
            this.ItemType.Text = "Item Type";
            // 
            // ConsumableCheck
            // 
            this.ConsumableCheck.AccessibleName = "MagicalCheck";
            this.ConsumableCheck.AutoSize = true;
            this.ConsumableCheck.Location = new System.Drawing.Point(1325, 26);
            this.ConsumableCheck.Margin = new System.Windows.Forms.Padding(5);
            this.ConsumableCheck.Name = "ConsumableCheck";
            this.ConsumableCheck.Size = new System.Drawing.Size(108, 21);
            this.ConsumableCheck.TabIndex = 14;
            this.ConsumableCheck.Text = "Consumable";
            this.ConsumableCheck.UseVisualStyleBackColor = true;
            this.ConsumableCheck.CheckedChanged += new System.EventHandler(this.ConsumableCheck_CheckedChanged);
            // 
            // CosmeticCheck
            // 
            this.CosmeticCheck.AccessibleName = "MagicalCheck";
            this.CosmeticCheck.AutoSize = true;
            this.CosmeticCheck.Location = new System.Drawing.Point(1119, 26);
            this.CosmeticCheck.Margin = new System.Windows.Forms.Padding(5);
            this.CosmeticCheck.Name = "CosmeticCheck";
            this.CosmeticCheck.Size = new System.Drawing.Size(87, 21);
            this.CosmeticCheck.TabIndex = 13;
            this.CosmeticCheck.Text = "Cosmetic";
            this.CosmeticCheck.UseVisualStyleBackColor = true;
            this.CosmeticCheck.CheckedChanged += new System.EventHandler(this.CosmeticCheck_CheckedChanged);
            // 
            // FilterItems
            // 
            this.FilterItems.AutoSize = true;
            this.FilterItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterItems.Location = new System.Drawing.Point(660, 114);
            this.FilterItems.Name = "FilterItems";
            this.FilterItems.Size = new System.Drawing.Size(86, 27);
            this.FilterItems.TabIndex = 12;
            this.FilterItems.Text = "Filter Items";
            this.FilterItems.UseVisualStyleBackColor = true;
            // 
            // MeleeCheck
            // 
            this.MeleeCheck.AccessibleName = "MeleeCheck";
            this.MeleeCheck.AutoSize = true;
            this.MeleeCheck.Location = new System.Drawing.Point(8, 26);
            this.MeleeCheck.Margin = new System.Windows.Forms.Padding(5);
            this.MeleeCheck.Name = "MeleeCheck";
            this.MeleeCheck.Size = new System.Drawing.Size(68, 21);
            this.MeleeCheck.TabIndex = 9;
            this.MeleeCheck.Text = "Melee";
            this.MeleeCheck.UseVisualStyleBackColor = true;
            this.MeleeCheck.CheckedChanged += new System.EventHandler(this.MeleeCheck_CheckedChanged);
            // 
            // ArmorCheck
            // 
            this.ArmorCheck.AccessibleName = "ArmorCheck";
            this.ArmorCheck.AutoSize = true;
            this.ArmorCheck.Location = new System.Drawing.Point(201, 27);
            this.ArmorCheck.Margin = new System.Windows.Forms.Padding(6);
            this.ArmorCheck.Name = "ArmorCheck";
            this.ArmorCheck.Size = new System.Drawing.Size(68, 21);
            this.ArmorCheck.TabIndex = 7;
            this.ArmorCheck.Text = "Armor";
            this.ArmorCheck.UseVisualStyleBackColor = true;
            this.ArmorCheck.CheckedChanged += new System.EventHandler(this.ArmorCheck_CheckedChanged);
            // 
            // ShieldCheck
            // 
            this.ShieldCheck.AccessibleName = "ShieldCheck";
            this.ShieldCheck.AutoSize = true;
            this.ShieldCheck.Location = new System.Drawing.Point(378, 26);
            this.ShieldCheck.Margin = new System.Windows.Forms.Padding(6);
            this.ShieldCheck.Name = "ShieldCheck";
            this.ShieldCheck.Size = new System.Drawing.Size(69, 21);
            this.ShieldCheck.TabIndex = 8;
            this.ShieldCheck.Text = "Shield";
            this.ShieldCheck.UseVisualStyleBackColor = true;
            this.ShieldCheck.CheckedChanged += new System.EventHandler(this.ShieldCheck_CheckedChanged);
            // 
            // MagicalCheck
            // 
            this.MagicalCheck.AccessibleName = "MagicalCheck";
            this.MagicalCheck.AutoSize = true;
            this.MagicalCheck.Location = new System.Drawing.Point(827, 26);
            this.MagicalCheck.Margin = new System.Windows.Forms.Padding(5);
            this.MagicalCheck.Name = "MagicalCheck";
            this.MagicalCheck.Size = new System.Drawing.Size(142, 21);
            this.MagicalCheck.TabIndex = 11;
            this.MagicalCheck.Text = "Magical (Ranged)";
            this.MagicalCheck.UseVisualStyleBackColor = true;
            this.MagicalCheck.CheckedChanged += new System.EventHandler(this.MagicalCheck_CheckedChanged);
            // 
            // PhysicalCheck
            // 
            this.PhysicalCheck.AccessibleName = "PhysicalCheck";
            this.PhysicalCheck.AutoSize = true;
            this.PhysicalCheck.Location = new System.Drawing.Point(564, 26);
            this.PhysicalCheck.Margin = new System.Windows.Forms.Padding(5);
            this.PhysicalCheck.Name = "PhysicalCheck";
            this.PhysicalCheck.Size = new System.Drawing.Size(146, 21);
            this.PhysicalCheck.TabIndex = 10;
            this.PhysicalCheck.Text = "Physical (Ranged)";
            this.PhysicalCheck.UseVisualStyleBackColor = true;
            this.PhysicalCheck.CheckedChanged += new System.EventHandler(this.PhysicalCheck_CheckedChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(140, 29);
            this.Title.TabIndex = 18;
            this.Title.Text = "Your Stash";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 751);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.ItemType);
            this.Controls.Add(this.Title);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ItemType.ResumeLayout(false);
            this.ItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.GroupBox ItemType;
        private System.Windows.Forms.CheckBox ConsumableCheck;
        private System.Windows.Forms.CheckBox CosmeticCheck;
        private System.Windows.Forms.Button FilterItems;
        private System.Windows.Forms.CheckBox MeleeCheck;
        private System.Windows.Forms.CheckBox ArmorCheck;
        private System.Windows.Forms.CheckBox ShieldCheck;
        private System.Windows.Forms.CheckBox MagicalCheck;
        private System.Windows.Forms.CheckBox PhysicalCheck;
        private System.Windows.Forms.Label Title;
    }
}