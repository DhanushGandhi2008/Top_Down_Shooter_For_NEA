namespace Top_Down_Shooter
{
    partial class Level1
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
            this.label1 = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Shooter_User = new System.Windows.Forms.PictureBox();
            this.MainGameTimer = new System.Windows.Forms.Timer(this.components);
            this.Wave_Number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Shooter_User)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kills: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HealthLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.Location = new System.Drawing.Point(996, 16);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(209, 54);
            this.HealthLabel.TabIndex = 2;
            this.HealthLabel.Text = "Health";
            this.HealthLabel.Click += new System.EventHandler(this.HealthLabel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1221, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(199, 35);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 100;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Shooter_User
            // 
            this.Shooter_User.BackColor = System.Drawing.Color.Transparent;
            this.Shooter_User.Image = global::Top_Down_Shooter.Properties.Resources.Shooter_Guy_Up;
            this.Shooter_User.Location = new System.Drawing.Point(685, 359);
            this.Shooter_User.Name = "Shooter_User";
            this.Shooter_User.Size = new System.Drawing.Size(133, 112);
            this.Shooter_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shooter_User.TabIndex = 4;
            this.Shooter_User.TabStop = false;
            this.Shooter_User.Click += new System.EventHandler(this.Shooter_User_Click);
            // 
            // MainGameTimer
            // 
            this.MainGameTimer.Enabled = true;
            this.MainGameTimer.Interval = 25;
            this.MainGameTimer.Tick += new System.EventHandler(this.MainGameTimer_Tick);
            // 
            // Wave_Number
            // 
            this.Wave_Number.AutoSize = true;
            this.Wave_Number.BackColor = System.Drawing.Color.Transparent;
            this.Wave_Number.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wave_Number.Location = new System.Drawing.Point(583, 16);
            this.Wave_Number.Name = "Wave_Number";
            this.Wave_Number.Size = new System.Drawing.Size(302, 54);
            this.Wave_Number.TabIndex = 5;
            this.Wave_Number.Text = "Wave(s):  0";
            this.Wave_Number.Click += new System.EventHandler(this.Wave_Number_Click);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImage = global::Top_Down_Shooter.Properties.Resources.Pixel_Art_Sand1;
            this.ClientSize = new System.Drawing.Size(1449, 709);
            this.Controls.Add(this.Wave_Number);
            this.Controls.Add(this.Shooter_User);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Level1";
            this.Text = "Level1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Shooter_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox Shooter_User;
        private System.Windows.Forms.Timer MainGameTimer;
        private System.Windows.Forms.Label Wave_Number;
    }
}

