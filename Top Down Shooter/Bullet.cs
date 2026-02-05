using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace Top_Down_Shooter
{ //creating a bullet class to manage the bullets being fired by the player
    class Bullet
    {
        //sorting the variables for the bullet class
        public string direction;
        public int bullet_left;
        public int bullet_top;

        private int bullet_speed = 100;
        private PictureBox bullet = new PictureBox(); //creates a space for the bullet drawing
        private Timer bullet_timer = new Timer();

        //method to make the bullet appear on the form
        public void Make_Bullet(Form form) 
        {
            bullet.Image = Properties.Resources.Bullet_left;
            bullet.Size = new Size(20, 20);
            bullet.Tag = "bullet";  
            bullet.Left = bullet_left;
            bullet.Top = bullet_top;
            bullet.BringToFront();
            form.Controls.Add(bullet);

            //setting up the timer for the bullet movement
            bullet_timer.Interval = bullet_speed;
            bullet_timer.Tick += new EventHandler(Bullet_Timer_Event);
            bullet_timer.Start();

            
        }

        private void Bullet_Timer_Event(object sender, EventArgs e)
        {   //moving the bullet in the correct direction based on where the player is facing
            switch (direction)
            {
                case "left":
                    bullet.Left -= bullet_speed ;
                    break;
                case "right":
                    bullet.Left += bullet_speed;
                    break;
                case "up":
                    bullet.Top -= bullet_speed;
                    break;
                case "down":
                    bullet.Top += bullet_speed;
                    break;
            }
            //removes bullet if it goes off screen - prevents game from slowing down or crashing
            //due to too many bullets on screen (even if off screen)
            if (bullet.Left < 0 || bullet.Left > 1600 || bullet.Top < 0 || bullet.Top > 900)
            {
                bullet_timer.Stop();
                bullet_timer.Dispose();
                bullet.Dispose();
                bullet_timer = null;
                bullet = null;
            }
        }







    }
}
