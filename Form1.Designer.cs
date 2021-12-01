namespace Group1Game
{
    partial class Form1
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
            this.PlayerSpeedLabel = new System.Windows.Forms.Label();
            this.PlayerHealthLabel = new System.Windows.Forms.Label();
            this.PlayerSpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerHealthNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.EnemyGroupBox = new System.Windows.Forms.GroupBox();
            this.EnemyHealthNumeric = new System.Windows.Forms.NumericUpDown();
            this.EnemySpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.EnemyHealthLabel = new System.Windows.Forms.Label();
            this.EnemySpeedLabel = new System.Windows.Forms.Label();
            this.ProjectileGroupBox = new System.Windows.Forms.GroupBox();
            this.ProjectileDamageNumeric = new System.Windows.Forms.NumericUpDown();
            this.ProjectileSpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.ProjectileDamageLabel = new System.Windows.Forms.Label();
            this.ProjectileSpeedLabel = new System.Windows.Forms.Label();
            this.Enterbutton = new System.Windows.Forms.Button();
            this.BossGroupBox = new System.Windows.Forms.GroupBox();
            this.BossHealthNumeric = new System.Windows.Forms.NumericUpDown();
            this.BossSpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.BossHealthLabel = new System.Windows.Forms.Label();
            this.BossSpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSpeedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealthNumeric)).BeginInit();
            this.PlayerGroupBox.SuspendLayout();
            this.EnemyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySpeedNumeric)).BeginInit();
            this.ProjectileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectileDamageNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectileSpeedNumeric)).BeginInit();
            this.BossGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BossHealthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossSpeedNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerSpeedLabel
            // 
            this.PlayerSpeedLabel.AutoSize = true;
            this.PlayerSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSpeedLabel.Location = new System.Drawing.Point(21, 108);
            this.PlayerSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerSpeedLabel.Name = "PlayerSpeedLabel";
            this.PlayerSpeedLabel.Size = new System.Drawing.Size(103, 32);
            this.PlayerSpeedLabel.TabIndex = 0;
            this.PlayerSpeedLabel.Text = "Speed";
            // 
            // PlayerHealthLabel
            // 
            this.PlayerHealthLabel.AutoSize = true;
            this.PlayerHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHealthLabel.Location = new System.Drawing.Point(21, 211);
            this.PlayerHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerHealthLabel.Name = "PlayerHealthLabel";
            this.PlayerHealthLabel.Size = new System.Drawing.Size(104, 32);
            this.PlayerHealthLabel.TabIndex = 1;
            this.PlayerHealthLabel.Text = "Health";
            // 
            // PlayerSpeedNumeric
            // 
            this.PlayerSpeedNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSpeedNumeric.Location = new System.Drawing.Point(195, 105);
            this.PlayerSpeedNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerSpeedNumeric.Name = "PlayerSpeedNumeric";
            this.PlayerSpeedNumeric.Size = new System.Drawing.Size(147, 39);
            this.PlayerSpeedNumeric.TabIndex = 2;
            this.PlayerSpeedNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PlayerHealthNumeric
            // 
            this.PlayerHealthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHealthNumeric.Location = new System.Drawing.Point(195, 208);
            this.PlayerHealthNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerHealthNumeric.Name = "PlayerHealthNumeric";
            this.PlayerHealthNumeric.Size = new System.Drawing.Size(147, 39);
            this.PlayerHealthNumeric.TabIndex = 3;
            this.PlayerHealthNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // PlayerGroupBox
            // 
            this.PlayerGroupBox.Controls.Add(this.PlayerHealthNumeric);
            this.PlayerGroupBox.Controls.Add(this.PlayerSpeedNumeric);
            this.PlayerGroupBox.Controls.Add(this.PlayerHealthLabel);
            this.PlayerGroupBox.Controls.Add(this.PlayerSpeedLabel);
            this.PlayerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PlayerGroupBox.Location = new System.Drawing.Point(18, 118);
            this.PlayerGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerGroupBox.Name = "PlayerGroupBox";
            this.PlayerGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerGroupBox.Size = new System.Drawing.Size(351, 300);
            this.PlayerGroupBox.TabIndex = 4;
            this.PlayerGroupBox.TabStop = false;
            this.PlayerGroupBox.Text = "Player";
            // 
            // EnemyGroupBox
            // 
            this.EnemyGroupBox.Controls.Add(this.EnemyHealthNumeric);
            this.EnemyGroupBox.Controls.Add(this.EnemySpeedNumeric);
            this.EnemyGroupBox.Controls.Add(this.EnemyHealthLabel);
            this.EnemyGroupBox.Controls.Add(this.EnemySpeedLabel);
            this.EnemyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EnemyGroupBox.Location = new System.Drawing.Point(447, 118);
            this.EnemyGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnemyGroupBox.Name = "EnemyGroupBox";
            this.EnemyGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnemyGroupBox.Size = new System.Drawing.Size(351, 300);
            this.EnemyGroupBox.TabIndex = 5;
            this.EnemyGroupBox.TabStop = false;
            this.EnemyGroupBox.Text = "Enemy";
            // 
            // EnemyHealthNumeric
            // 
            this.EnemyHealthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHealthNumeric.Location = new System.Drawing.Point(195, 208);
            this.EnemyHealthNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnemyHealthNumeric.Name = "EnemyHealthNumeric";
            this.EnemyHealthNumeric.Size = new System.Drawing.Size(147, 39);
            this.EnemyHealthNumeric.TabIndex = 3;
            this.EnemyHealthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EnemySpeedNumeric
            // 
            this.EnemySpeedNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemySpeedNumeric.Location = new System.Drawing.Point(195, 105);
            this.EnemySpeedNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnemySpeedNumeric.Name = "EnemySpeedNumeric";
            this.EnemySpeedNumeric.Size = new System.Drawing.Size(147, 39);
            this.EnemySpeedNumeric.TabIndex = 2;
            this.EnemySpeedNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EnemyHealthLabel
            // 
            this.EnemyHealthLabel.AutoSize = true;
            this.EnemyHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHealthLabel.Location = new System.Drawing.Point(21, 211);
            this.EnemyHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyHealthLabel.Name = "EnemyHealthLabel";
            this.EnemyHealthLabel.Size = new System.Drawing.Size(104, 32);
            this.EnemyHealthLabel.TabIndex = 1;
            this.EnemyHealthLabel.Text = "Health";
            // 
            // EnemySpeedLabel
            // 
            this.EnemySpeedLabel.AutoSize = true;
            this.EnemySpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemySpeedLabel.Location = new System.Drawing.Point(21, 108);
            this.EnemySpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemySpeedLabel.Name = "EnemySpeedLabel";
            this.EnemySpeedLabel.Size = new System.Drawing.Size(103, 32);
            this.EnemySpeedLabel.TabIndex = 0;
            this.EnemySpeedLabel.Text = "Speed";
            // 
            // ProjectileGroupBox
            // 
            this.ProjectileGroupBox.Controls.Add(this.ProjectileDamageNumeric);
            this.ProjectileGroupBox.Controls.Add(this.ProjectileSpeedNumeric);
            this.ProjectileGroupBox.Controls.Add(this.ProjectileDamageLabel);
            this.ProjectileGroupBox.Controls.Add(this.ProjectileSpeedLabel);
            this.ProjectileGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProjectileGroupBox.Location = new System.Drawing.Point(18, 460);
            this.ProjectileGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectileGroupBox.Name = "ProjectileGroupBox";
            this.ProjectileGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectileGroupBox.Size = new System.Drawing.Size(351, 300);
            this.ProjectileGroupBox.TabIndex = 6;
            this.ProjectileGroupBox.TabStop = false;
            this.ProjectileGroupBox.Text = "Projectile";
            // 
            // ProjectileDamageNumeric
            // 
            this.ProjectileDamageNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectileDamageNumeric.Location = new System.Drawing.Point(195, 208);
            this.ProjectileDamageNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectileDamageNumeric.Name = "ProjectileDamageNumeric";
            this.ProjectileDamageNumeric.Size = new System.Drawing.Size(147, 39);
            this.ProjectileDamageNumeric.TabIndex = 3;
            this.ProjectileDamageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProjectileSpeedNumeric
            // 
            this.ProjectileSpeedNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectileSpeedNumeric.Location = new System.Drawing.Point(195, 105);
            this.ProjectileSpeedNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectileSpeedNumeric.Name = "ProjectileSpeedNumeric";
            this.ProjectileSpeedNumeric.Size = new System.Drawing.Size(147, 39);
            this.ProjectileSpeedNumeric.TabIndex = 2;
            this.ProjectileSpeedNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ProjectileDamageLabel
            // 
            this.ProjectileDamageLabel.AutoSize = true;
            this.ProjectileDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectileDamageLabel.Location = new System.Drawing.Point(9, 211);
            this.ProjectileDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectileDamageLabel.Name = "ProjectileDamageLabel";
            this.ProjectileDamageLabel.Size = new System.Drawing.Size(128, 32);
            this.ProjectileDamageLabel.TabIndex = 1;
            this.ProjectileDamageLabel.Text = "Damage";
            // 
            // ProjectileSpeedLabel
            // 
            this.ProjectileSpeedLabel.AutoSize = true;
            this.ProjectileSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectileSpeedLabel.Location = new System.Drawing.Point(21, 108);
            this.ProjectileSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectileSpeedLabel.Name = "ProjectileSpeedLabel";
            this.ProjectileSpeedLabel.Size = new System.Drawing.Size(103, 32);
            this.ProjectileSpeedLabel.TabIndex = 0;
            this.ProjectileSpeedLabel.Text = "Speed";
            // 
            // Enterbutton
            // 
            this.Enterbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Enterbutton.Location = new System.Drawing.Point(280, 787);
            this.Enterbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Enterbutton.Name = "Enterbutton";
            this.Enterbutton.Size = new System.Drawing.Size(249, 166);
            this.Enterbutton.TabIndex = 7;
            this.Enterbutton.Text = "Enter";
            this.Enterbutton.UseVisualStyleBackColor = true;
            this.Enterbutton.Click += new System.EventHandler(this.Enterbutton_Click);
            // 
            // BossGroupBox
            // 
            this.BossGroupBox.Controls.Add(this.BossHealthNumeric);
            this.BossGroupBox.Controls.Add(this.BossSpeedNumeric);
            this.BossGroupBox.Controls.Add(this.BossHealthLabel);
            this.BossGroupBox.Controls.Add(this.BossSpeedLabel);
            this.BossGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BossGroupBox.Location = new System.Drawing.Point(447, 460);
            this.BossGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BossGroupBox.Name = "BossGroupBox";
            this.BossGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BossGroupBox.Size = new System.Drawing.Size(351, 300);
            this.BossGroupBox.TabIndex = 8;
            this.BossGroupBox.TabStop = false;
            this.BossGroupBox.Text = "Boss";
            // 
            // BossHealthNumeric
            // 
            this.BossHealthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossHealthNumeric.Location = new System.Drawing.Point(195, 208);
            this.BossHealthNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BossHealthNumeric.Name = "BossHealthNumeric";
            this.BossHealthNumeric.Size = new System.Drawing.Size(147, 39);
            this.BossHealthNumeric.TabIndex = 3;
            this.BossHealthNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // BossSpeedNumeric
            // 
            this.BossSpeedNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossSpeedNumeric.Location = new System.Drawing.Point(195, 105);
            this.BossSpeedNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BossSpeedNumeric.Name = "BossSpeedNumeric";
            this.BossSpeedNumeric.Size = new System.Drawing.Size(147, 39);
            this.BossSpeedNumeric.TabIndex = 2;
            this.BossSpeedNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // BossHealthLabel
            // 
            this.BossHealthLabel.AutoSize = true;
            this.BossHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossHealthLabel.Location = new System.Drawing.Point(9, 211);
            this.BossHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BossHealthLabel.Name = "BossHealthLabel";
            this.BossHealthLabel.Size = new System.Drawing.Size(104, 32);
            this.BossHealthLabel.TabIndex = 1;
            this.BossHealthLabel.Text = "Health";
            // 
            // BossSpeedLabel
            // 
            this.BossSpeedLabel.AutoSize = true;
            this.BossSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossSpeedLabel.Location = new System.Drawing.Point(21, 108);
            this.BossSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BossSpeedLabel.Name = "BossSpeedLabel";
            this.BossSpeedLabel.Size = new System.Drawing.Size(103, 32);
            this.BossSpeedLabel.TabIndex = 0;
            this.BossSpeedLabel.Text = "Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 1002);
            this.Controls.Add(this.BossGroupBox);
            this.Controls.Add(this.Enterbutton);
            this.Controls.Add(this.ProjectileGroupBox);
            this.Controls.Add(this.EnemyGroupBox);
            this.Controls.Add(this.PlayerGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Stats Generator";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSpeedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealthNumeric)).EndInit();
            this.PlayerGroupBox.ResumeLayout(false);
            this.PlayerGroupBox.PerformLayout();
            this.EnemyGroupBox.ResumeLayout(false);
            this.EnemyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHealthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySpeedNumeric)).EndInit();
            this.ProjectileGroupBox.ResumeLayout(false);
            this.ProjectileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectileDamageNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectileSpeedNumeric)).EndInit();
            this.BossGroupBox.ResumeLayout(false);
            this.BossGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BossHealthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossSpeedNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PlayerSpeedLabel;
        private System.Windows.Forms.Label PlayerHealthLabel;
        private System.Windows.Forms.NumericUpDown PlayerSpeedNumeric;
        private System.Windows.Forms.NumericUpDown PlayerHealthNumeric;
        private System.Windows.Forms.GroupBox PlayerGroupBox;
        private System.Windows.Forms.GroupBox EnemyGroupBox;
        private System.Windows.Forms.NumericUpDown EnemyHealthNumeric;
        private System.Windows.Forms.NumericUpDown EnemySpeedNumeric;
        private System.Windows.Forms.Label EnemyHealthLabel;
        private System.Windows.Forms.Label EnemySpeedLabel;
        private System.Windows.Forms.GroupBox ProjectileGroupBox;
        private System.Windows.Forms.NumericUpDown ProjectileDamageNumeric;
        private System.Windows.Forms.NumericUpDown ProjectileSpeedNumeric;
        private System.Windows.Forms.Label ProjectileDamageLabel;
        private System.Windows.Forms.Label ProjectileSpeedLabel;
        private System.Windows.Forms.Button Enterbutton;
        private System.Windows.Forms.GroupBox BossGroupBox;
        private System.Windows.Forms.NumericUpDown BossHealthNumeric;
        private System.Windows.Forms.NumericUpDown BossSpeedNumeric;
        private System.Windows.Forms.Label BossHealthLabel;
        private System.Windows.Forms.Label BossSpeedLabel;
    }
}