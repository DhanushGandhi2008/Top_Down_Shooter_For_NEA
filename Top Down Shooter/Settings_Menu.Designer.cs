namespace Top_Down_Shooter
{
    partial class Settings_Menu
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
            this.Back_To_Main = new System.Windows.Forms.Label();
            this.Toggle_Blood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_To_Main
            // 
            this.Back_To_Main.AutoSize = true;
            this.Back_To_Main.BackColor = System.Drawing.SystemColors.Desktop;
            this.Back_To_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Back_To_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_To_Main.Font = new System.Drawing.Font("Snap ITC", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Back_To_Main.ForeColor = System.Drawing.Color.DarkRed;
            this.Back_To_Main.Location = new System.Drawing.Point(761, 425);
            this.Back_To_Main.Name = "Back_To_Main";
            this.Back_To_Main.Size = new System.Drawing.Size(444, 50);
            this.Back_To_Main.TabIndex = 0;
            this.Back_To_Main.Text = "Back to Main Menu";
            this.Back_To_Main.Click += new System.EventHandler(this.Back_To_Main_Click);
            // 
            // Toggle_Blood
            // 
            this.Toggle_Blood.AutoSize = true;
            this.Toggle_Blood.BackColor = System.Drawing.SystemColors.Desktop;
            this.Toggle_Blood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Toggle_Blood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Toggle_Blood.Font = new System.Drawing.Font("Snap ITC", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Toggle_Blood.ForeColor = System.Drawing.Color.DarkRed;
            this.Toggle_Blood.Location = new System.Drawing.Point(848, 628);
            this.Toggle_Blood.Name = "Toggle_Blood";
            this.Toggle_Blood.Size = new System.Drawing.Size(289, 50);
            this.Toggle_Blood.TabIndex = 1;
            this.Toggle_Blood.Text = "Toggle blood";
            this.Toggle_Blood.Click += new System.EventHandler(this.Toggle_Blood_Click);
            // 
            // Settings_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Top_Down_Shooter.Properties.Resources.Title_Screen_image1;
            this.ClientSize = new System.Drawing.Size(1664, 817);
            this.Controls.Add(this.Toggle_Blood);
            this.Controls.Add(this.Back_To_Main);
            this.Name = "Settings_Menu";
            this.Text = "Settings_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Back_To_Main;
        private System.Windows.Forms.Label Toggle_Blood;
    }
}