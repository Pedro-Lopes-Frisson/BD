namespace VirtualShopC
{
    partial class Form4
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
            this.MagicalCheck = new System.Windows.Forms.CheckBox();
            this.PhysicalCheck = new System.Windows.Forms.CheckBox();
            this.MeleeCheck = new System.Windows.Forms.CheckBox();
            this.ShieldCheck = new System.Windows.Forms.CheckBox();
            this.ArmorCheck = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemType = new System.Windows.Forms.GroupBox();
            this.ItemAttributes = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // MagicalCheck
            // 
            this.MagicalCheck.AccessibleName = "MagicalCheck";
            this.MagicalCheck.AutoSize = true;
            this.MagicalCheck.Location = new System.Drawing.Point(403, 33);
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
            this.PhysicalCheck.Location = new System.Drawing.Point(247, 33);
            this.PhysicalCheck.Margin = new System.Windows.Forms.Padding(5);
            this.PhysicalCheck.Name = "PhysicalCheck";
            this.PhysicalCheck.Size = new System.Drawing.Size(146, 21);
            this.PhysicalCheck.TabIndex = 10;
            this.PhysicalCheck.Text = "Physical (Ranged)";
            this.PhysicalCheck.UseVisualStyleBackColor = true;
            this.PhysicalCheck.CheckedChanged += new System.EventHandler(this.PhysicalCheck_CheckedChanged);
            // 
            // MeleeCheck
            // 
            this.MeleeCheck.AccessibleName = "MeleeCheck";
            this.MeleeCheck.AutoSize = true;
            this.MeleeCheck.Location = new System.Drawing.Point(8, 33);
            this.MeleeCheck.Margin = new System.Windows.Forms.Padding(5);
            this.MeleeCheck.Name = "MeleeCheck";
            this.MeleeCheck.Size = new System.Drawing.Size(68, 21);
            this.MeleeCheck.TabIndex = 9;
            this.MeleeCheck.Text = "Melee";
            this.MeleeCheck.UseVisualStyleBackColor = true;
            this.MeleeCheck.CheckedChanged += new System.EventHandler(this.MeleeCheck_CheckedChanged);
            // 
            // ShieldCheck
            // 
            this.ShieldCheck.AccessibleName = "ShieldCheck";
            this.ShieldCheck.AutoSize = true;
            this.ShieldCheck.Location = new System.Drawing.Point(167, 33);
            this.ShieldCheck.Margin = new System.Windows.Forms.Padding(6);
            this.ShieldCheck.Name = "ShieldCheck";
            this.ShieldCheck.Size = new System.Drawing.Size(69, 21);
            this.ShieldCheck.TabIndex = 8;
            this.ShieldCheck.Text = "Shield";
            this.ShieldCheck.UseVisualStyleBackColor = true;
            this.ShieldCheck.CheckedChanged += new System.EventHandler(this.ShieldCheck_CheckedChanged);
            // 
            // ArmorCheck
            // 
            this.ArmorCheck.AccessibleName = "ArmorCheck";
            this.ArmorCheck.AutoSize = true;
            this.ArmorCheck.Location = new System.Drawing.Point(87, 33);
            this.ArmorCheck.Margin = new System.Windows.Forms.Padding(6);
            this.ArmorCheck.Name = "ArmorCheck";
            this.ArmorCheck.Size = new System.Drawing.Size(68, 21);
            this.ArmorCheck.TabIndex = 7;
            this.ArmorCheck.Text = "Armor";
            this.ArmorCheck.UseVisualStyleBackColor = true;
            this.ArmorCheck.CheckedChanged += new System.EventHandler(this.ArmorCheck_CheckedChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(229, 29);
            this.Title.TabIndex = 12;
            this.Title.Text = "Register New Item";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ItemType
            // 
            this.ItemType.Controls.Add(this.MeleeCheck);
            this.ItemType.Controls.Add(this.ArmorCheck);
            this.ItemType.Controls.Add(this.ShieldCheck);
            this.ItemType.Controls.Add(this.MagicalCheck);
            this.ItemType.Controls.Add(this.PhysicalCheck);
            this.ItemType.Location = new System.Drawing.Point(12, 46);
            this.ItemType.Name = "ItemType";
            this.ItemType.Size = new System.Drawing.Size(551, 79);
            this.ItemType.TabIndex = 14;
            this.ItemType.TabStop = false;
            this.ItemType.Text = "Item Type";
            this.ItemType.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ItemAttributes
            // 
            this.ItemAttributes.Location = new System.Drawing.Point(12, 152);
            this.ItemAttributes.Name = "ItemAttributes";
            this.ItemAttributes.Size = new System.Drawing.Size(551, 249);
            this.ItemAttributes.TabIndex = 15;
            this.ItemAttributes.TabStop = false;
            this.ItemAttributes.Text = "Item Attributes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Register Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ItemAttributes);
            this.Controls.Add(this.ItemType);
            this.Controls.Add(this.Title);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ItemType.ResumeLayout(false);
            this.ItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MagicalCheck;
        private System.Windows.Forms.CheckBox PhysicalCheck;
        private System.Windows.Forms.CheckBox MeleeCheck;
        private System.Windows.Forms.CheckBox ShieldCheck;
        private System.Windows.Forms.CheckBox ArmorCheck;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox ItemType;
        private System.Windows.Forms.GroupBox ItemAttributes;
        private System.Windows.Forms.Button button1;
    }
}