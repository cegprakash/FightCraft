namespace FightCraft
{
    partial class WeaponsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponsForm));
            this.MyGold = new System.Windows.Forms.Label();
            this.GoldImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuyHealButton = new System.Windows.Forms.Button();
            this.BuyWeaponBasicButton = new System.Windows.Forms.Button();
            this.BuyWeaponUltraButton = new System.Windows.Forms.Button();
            this.BuyArmorBasicButton = new System.Windows.Forms.Button();
            this.BuyArmorUltraButton = new System.Windows.Forms.Button();
            this.ShopToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GoldImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MyGold
            // 
            this.MyGold.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyGold.Location = new System.Drawing.Point(92, 21);
            this.MyGold.Name = "MyGold";
            this.MyGold.Size = new System.Drawing.Size(83, 26);
            this.MyGold.TabIndex = 34;
            this.MyGold.Text = "0";
            this.MyGold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GoldImage
            // 
            this.GoldImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoldImage.BackgroundImage")));
            this.GoldImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoldImage.Location = new System.Drawing.Point(52, 21);
            this.GoldImage.Name = "GoldImage";
            this.GoldImage.Size = new System.Drawing.Size(34, 26);
            this.GoldImage.TabIndex = 33;
            this.GoldImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(90, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Buy Healers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(373, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "Buy Weapons";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(661, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 42;
            this.label3.Text = "Buy Armor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyHealButton
            // 
            this.BuyHealButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuyHealButton.BackgroundImage")));
            this.BuyHealButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuyHealButton.Location = new System.Drawing.Point(115, 216);
            this.BuyHealButton.Name = "BuyHealButton";
            this.BuyHealButton.Size = new System.Drawing.Size(60, 60);
            this.BuyHealButton.TabIndex = 43;
            this.ShopToolTip.SetToolTip(this.BuyHealButton, "Regenerates +50 health instantly. Costs 2 gold.");
            this.BuyHealButton.UseVisualStyleBackColor = true;
            this.BuyHealButton.Click += new System.EventHandler(this.BuyHealButton_Click);
            // 
            // BuyWeaponBasicButton
            // 
            this.BuyWeaponBasicButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuyWeaponBasicButton.BackgroundImage")));
            this.BuyWeaponBasicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuyWeaponBasicButton.Location = new System.Drawing.Point(405, 216);
            this.BuyWeaponBasicButton.Name = "BuyWeaponBasicButton";
            this.BuyWeaponBasicButton.Size = new System.Drawing.Size(60, 60);
            this.BuyWeaponBasicButton.TabIndex = 44;
            this.ShopToolTip.SetToolTip(this.BuyWeaponBasicButton, "Adds +6 damage to physical attacks. Costs 4 gold.");
            this.BuyWeaponBasicButton.UseVisualStyleBackColor = true;
            this.BuyWeaponBasicButton.Click += new System.EventHandler(this.BuyWeaponBasicButton_Click);
            // 
            // BuyWeaponUltraButton
            // 
            this.BuyWeaponUltraButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuyWeaponUltraButton.BackgroundImage")));
            this.BuyWeaponUltraButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuyWeaponUltraButton.Location = new System.Drawing.Point(405, 346);
            this.BuyWeaponUltraButton.Name = "BuyWeaponUltraButton";
            this.BuyWeaponUltraButton.Size = new System.Drawing.Size(60, 60);
            this.BuyWeaponUltraButton.TabIndex = 45;
            this.ShopToolTip.SetToolTip(this.BuyWeaponUltraButton, "+15 Damage to Physical Attacks. Costs 8 Gold.");
            this.BuyWeaponUltraButton.UseVisualStyleBackColor = true;
            this.BuyWeaponUltraButton.Click += new System.EventHandler(this.BuyWeaponUltraButton_Click);
            // 
            // BuyArmorBasicButton
            // 
            this.BuyArmorBasicButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuyArmorBasicButton.BackgroundImage")));
            this.BuyArmorBasicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuyArmorBasicButton.Location = new System.Drawing.Point(685, 216);
            this.BuyArmorBasicButton.Name = "BuyArmorBasicButton";
            this.BuyArmorBasicButton.Size = new System.Drawing.Size(60, 60);
            this.BuyArmorBasicButton.TabIndex = 46;
            this.ShopToolTip.SetToolTip(this.BuyArmorBasicButton, "+2 Armor. Costs 3 Gold.");
            this.BuyArmorBasicButton.UseVisualStyleBackColor = true;
            this.BuyArmorBasicButton.Click += new System.EventHandler(this.BuyArmorBasicButton_Click);
            // 
            // BuyArmorUltraButton
            // 
            this.BuyArmorUltraButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuyArmorUltraButton.BackgroundImage")));
            this.BuyArmorUltraButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuyArmorUltraButton.Location = new System.Drawing.Point(685, 346);
            this.BuyArmorUltraButton.Name = "BuyArmorUltraButton";
            this.BuyArmorUltraButton.Size = new System.Drawing.Size(60, 60);
            this.BuyArmorUltraButton.TabIndex = 47;
            this.ShopToolTip.SetToolTip(this.BuyArmorUltraButton, "+8 armor. Costs 8 Gold.");
            this.BuyArmorUltraButton.UseVisualStyleBackColor = true;
            this.BuyArmorUltraButton.Click += new System.EventHandler(this.BuyArmorUltraButton_Click);
            // 
            // WeaponsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 436);
            this.Controls.Add(this.BuyArmorUltraButton);
            this.Controls.Add(this.BuyArmorBasicButton);
            this.Controls.Add(this.BuyWeaponUltraButton);
            this.Controls.Add(this.BuyWeaponBasicButton);
            this.Controls.Add(this.BuyHealButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyGold);
            this.Controls.Add(this.GoldImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeaponsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FightCraft Shop";
            ((System.ComponentModel.ISupportInitialize)(this.GoldImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyGold;
        private System.Windows.Forms.PictureBox GoldImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuyHealButton;
        private System.Windows.Forms.Button BuyWeaponBasicButton;
        private System.Windows.Forms.Button BuyWeaponUltraButton;
        private System.Windows.Forms.Button BuyArmorBasicButton;
        private System.Windows.Forms.Button BuyArmorUltraButton;
        private System.Windows.Forms.ToolTip ShopToolTip;
    }
}