namespace Top_Down_Shooter
{
    partial class MainMenu
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
            this.Game_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Leaderboard_viewer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Game_Title
            // 
            this.Game_Title.AutoSize = true;
            this.Game_Title.BackColor = System.Drawing.Color.Transparent;
            this.Game_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Game_Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Game_Title.Font = new System.Drawing.Font("Snap ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Title.ForeColor = System.Drawing.Color.Red;
            this.Game_Title.Location = new System.Drawing.Point(666, 23);
            this.Game_Title.Name = "Game_Title";
            this.Game_Title.Size = new System.Drawing.Size(539, 84);
            this.Game_Title.TabIndex = 0;
            this.Game_Title.Text = "Zombie Killer";
            this.Game_Title.Click += new System.EventHandler(this.Game_Title_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(797, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.label1.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // Leaderboard_viewer
            // 
            this.Leaderboard_viewer.AutoSize = true;
            this.Leaderboard_viewer.BackColor = System.Drawing.SystemColors.Desktop;
            this.Leaderboard_viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Leaderboard_viewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Leaderboard_viewer.Font = new System.Drawing.Font("Snap ITC", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leaderboard_viewer.ForeColor = System.Drawing.Color.DarkRed;
            this.Leaderboard_viewer.Location = new System.Drawing.Point(739, 558);
            this.Leaderboard_viewer.Name = "Leaderboard_viewer";
            this.Leaderboard_viewer.Size = new System.Drawing.Size(390, 50);
            this.Leaderboard_viewer.TabIndex = 2;
            this.Leaderboard_viewer.Text = "See LeaderBoard";
            this.Leaderboard_viewer.Click += new System.EventHandler(this.Leaderboard_viewer_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Top_Down_Shooter.Properties.Resources.Title_Screen_image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1483, 805);
            this.Controls.Add(this.Leaderboard_viewer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Game_Title);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Game_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Leaderboard_viewer;
    }
}