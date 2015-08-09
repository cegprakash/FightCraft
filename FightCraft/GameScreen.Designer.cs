namespace FightCraft
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.GameConsole = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MyHealthBar = new System.Windows.Forms.ProgressBar();
            this.MyManaBar = new System.Windows.Forms.ProgressBar();
            this.MyArmorBar = new System.Windows.Forms.ProgressBar();
            this.MyDamageBar = new System.Windows.Forms.ProgressBar();
            this.EnemyDamageBar = new System.Windows.Forms.ProgressBar();
            this.EnemyArmorBar = new System.Windows.Forms.ProgressBar();
            this.EnemyManaBar = new System.Windows.Forms.ProgressBar();
            this.EnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.EnemyHeroImage = new System.Windows.Forms.PictureBox();
            this.MyHeroImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MyLevelLabel = new System.Windows.Forms.Label();
            this.EnemyLevelLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PhysicalAttackButton = new System.Windows.Forms.Button();
            this.MagicalAttackButton = new System.Windows.Forms.Button();
            this.ShopButton = new System.Windows.Forms.Button();
            this.GoldImage = new System.Windows.Forms.PictureBox();
            this.MyGold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHeroImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyHeroImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoldImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GameConsole
            // 
            this.GameConsole.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GameConsole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameConsole.Enabled = false;
            this.GameConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameConsole.ForeColor = System.Drawing.SystemColors.MenuText;
            this.GameConsole.Location = new System.Drawing.Point(12, 509);
            this.GameConsole.Name = "GameConsole";
            this.GameConsole.Size = new System.Drawing.Size(940, 151);
            this.GameConsole.TabIndex = 0;
            this.GameConsole.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(467, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Health";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(469, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mana";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(469, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Armor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(463, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Damage";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyHealthBar
            // 
            this.MyHealthBar.Location = new System.Drawing.Point(87, 241);
            this.MyHealthBar.Name = "MyHealthBar";
            this.MyHealthBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyHealthBar.RightToLeftLayout = true;
            this.MyHealthBar.Size = new System.Drawing.Size(331, 23);
            this.MyHealthBar.TabIndex = 13;
            this.MyHealthBar.Value = 100;
            // 
            // MyManaBar
            // 
            this.MyManaBar.ForeColor = System.Drawing.Color.Blue;
            this.MyManaBar.Location = new System.Drawing.Point(87, 280);
            this.MyManaBar.Name = "MyManaBar";
            this.MyManaBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyManaBar.RightToLeftLayout = true;
            this.MyManaBar.Size = new System.Drawing.Size(331, 23);
            this.MyManaBar.TabIndex = 14;
            this.MyManaBar.Value = 100;
            // 
            // MyArmorBar
            // 
            this.MyArmorBar.Location = new System.Drawing.Point(87, 328);
            this.MyArmorBar.Name = "MyArmorBar";
            this.MyArmorBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyArmorBar.RightToLeftLayout = true;
            this.MyArmorBar.Size = new System.Drawing.Size(331, 23);
            this.MyArmorBar.TabIndex = 15;
            this.MyArmorBar.Value = 20;
            // 
            // MyDamageBar
            // 
            this.MyDamageBar.Location = new System.Drawing.Point(87, 372);
            this.MyDamageBar.Name = "MyDamageBar";
            this.MyDamageBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyDamageBar.RightToLeftLayout = true;
            this.MyDamageBar.Size = new System.Drawing.Size(331, 23);
            this.MyDamageBar.TabIndex = 16;
            this.MyDamageBar.Value = 30;
            // 
            // EnemyDamageBar
            // 
            this.EnemyDamageBar.Location = new System.Drawing.Point(566, 372);
            this.EnemyDamageBar.Name = "EnemyDamageBar";
            this.EnemyDamageBar.Size = new System.Drawing.Size(331, 23);
            this.EnemyDamageBar.TabIndex = 20;
            this.EnemyDamageBar.Value = 30;
            // 
            // EnemyArmorBar
            // 
            this.EnemyArmorBar.Location = new System.Drawing.Point(566, 328);
            this.EnemyArmorBar.Name = "EnemyArmorBar";
            this.EnemyArmorBar.Size = new System.Drawing.Size(331, 23);
            this.EnemyArmorBar.TabIndex = 19;
            this.EnemyArmorBar.Value = 20;
            // 
            // EnemyManaBar
            // 
            this.EnemyManaBar.ForeColor = System.Drawing.Color.Blue;
            this.EnemyManaBar.Location = new System.Drawing.Point(566, 280);
            this.EnemyManaBar.Name = "EnemyManaBar";
            this.EnemyManaBar.Size = new System.Drawing.Size(331, 23);
            this.EnemyManaBar.TabIndex = 18;
            this.EnemyManaBar.Value = 100;
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.Location = new System.Drawing.Point(566, 241);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.Size = new System.Drawing.Size(331, 23);
            this.EnemyHealthBar.TabIndex = 17;
            this.EnemyHealthBar.Value = 100;
            // 
            // EnemyHeroImage
            // 
            this.EnemyHeroImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnemyHeroImage.Location = new System.Drawing.Point(566, 98);
            this.EnemyHeroImage.Name = "EnemyHeroImage";
            this.EnemyHeroImage.Size = new System.Drawing.Size(60, 60);
            this.EnemyHeroImage.TabIndex = 21;
            this.EnemyHeroImage.TabStop = false;
            // 
            // MyHeroImage
            // 
            this.MyHeroImage.Image = ((System.Drawing.Image)(resources.GetObject("MyHeroImage.Image")));
            this.MyHeroImage.ImageLocation = "";
            this.MyHeroImage.Location = new System.Drawing.Point(87, 98);
            this.MyHeroImage.Name = "MyHeroImage";
            this.MyHeroImage.Size = new System.Drawing.Size(60, 60);
            this.MyHeroImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyHeroImage.TabIndex = 23;
            this.MyHeroImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(181, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "YOU";
            // 
            // MyLevelLabel
            // 
            this.MyLevelLabel.AutoSize = true;
            this.MyLevelLabel.Location = new System.Drawing.Point(192, 145);
            this.MyLevelLabel.Name = "MyLevelLabel";
            this.MyLevelLabel.Size = new System.Drawing.Size(42, 13);
            this.MyLevelLabel.TabIndex = 25;
            this.MyLevelLabel.Text = "Level 1";
            // 
            // EnemyLevelLabel
            // 
            this.EnemyLevelLabel.AutoSize = true;
            this.EnemyLevelLabel.Location = new System.Drawing.Point(674, 145);
            this.EnemyLevelLabel.Name = "EnemyLevelLabel";
            this.EnemyLevelLabel.Size = new System.Drawing.Size(42, 13);
            this.EnemyLevelLabel.TabIndex = 27;
            this.EnemyLevelLabel.Text = "Level 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(663, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "ENEMY";
            // 
            // PhysicalAttackButton
            // 
            this.PhysicalAttackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PhysicalAttackButton.BackgroundImage")));
            this.PhysicalAttackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PhysicalAttackButton.Location = new System.Drawing.Point(298, 436);
            this.PhysicalAttackButton.Name = "PhysicalAttackButton";
            this.PhysicalAttackButton.Size = new System.Drawing.Size(64, 57);
            this.PhysicalAttackButton.TabIndex = 28;
            this.PhysicalAttackButton.UseVisualStyleBackColor = true;
            this.PhysicalAttackButton.Click += new System.EventHandler(this.PhysicalAttackButton_Click);
            // 
            // MagicalAttackButton
            // 
            this.MagicalAttackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MagicalAttackButton.BackgroundImage")));
            this.MagicalAttackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MagicalAttackButton.Location = new System.Drawing.Point(416, 436);
            this.MagicalAttackButton.Name = "MagicalAttackButton";
            this.MagicalAttackButton.Size = new System.Drawing.Size(64, 57);
            this.MagicalAttackButton.TabIndex = 29;
            this.MagicalAttackButton.UseVisualStyleBackColor = true;
            this.MagicalAttackButton.Click += new System.EventHandler(this.MagicalAttackButton_Click);
            // 
            // ShopButton
            // 
            this.ShopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShopButton.BackgroundImage")));
            this.ShopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShopButton.Location = new System.Drawing.Point(689, 436);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(64, 57);
            this.ShopButton.TabIndex = 30;
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Visible = false;
            // 
            // GoldImage
            // 
            this.GoldImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoldImage.BackgroundImage")));
            this.GoldImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoldImage.Location = new System.Drawing.Point(87, 12);
            this.GoldImage.Name = "GoldImage";
            this.GoldImage.Size = new System.Drawing.Size(34, 26);
            this.GoldImage.TabIndex = 31;
            this.GoldImage.TabStop = false;
            // 
            // MyGold
            // 
            this.MyGold.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyGold.Location = new System.Drawing.Point(127, 12);
            this.MyGold.Name = "MyGold";
            this.MyGold.Size = new System.Drawing.Size(83, 26);
            this.MyGold.TabIndex = 32;
            this.MyGold.Text = "0";
            this.MyGold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameScreen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(964, 672);
            this.Controls.Add(this.MyGold);
            this.Controls.Add(this.GoldImage);
            this.Controls.Add(this.ShopButton);
            this.Controls.Add(this.MagicalAttackButton);
            this.Controls.Add(this.PhysicalAttackButton);
            this.Controls.Add(this.EnemyLevelLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MyLevelLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MyHeroImage);
            this.Controls.Add(this.EnemyHeroImage);
            this.Controls.Add(this.EnemyDamageBar);
            this.Controls.Add(this.EnemyArmorBar);
            this.Controls.Add(this.EnemyManaBar);
            this.Controls.Add(this.EnemyHealthBar);
            this.Controls.Add(this.MyDamageBar);
            this.Controls.Add(this.MyArmorBar);
            this.Controls.Add(this.MyManaBar);
            this.Controls.Add(this.MyHealthBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameConsole);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(980, 710);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(980, 710);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight Craft";
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHeroImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyHeroImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoldImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox GameConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar MyHealthBar;
        private System.Windows.Forms.ProgressBar MyManaBar;
        private System.Windows.Forms.ProgressBar MyArmorBar;
        private System.Windows.Forms.ProgressBar MyDamageBar;
        private System.Windows.Forms.ProgressBar EnemyDamageBar;
        private System.Windows.Forms.ProgressBar EnemyArmorBar;
        private System.Windows.Forms.ProgressBar EnemyManaBar;
        private System.Windows.Forms.ProgressBar EnemyHealthBar;
        private System.Windows.Forms.PictureBox EnemyHeroImage;
        private System.Windows.Forms.PictureBox MyHeroImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MyLevelLabel;
        private System.Windows.Forms.Label EnemyLevelLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PhysicalAttackButton;
        private System.Windows.Forms.Button MagicalAttackButton;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.PictureBox GoldImage;
        private System.Windows.Forms.Label MyGold;
    }
}