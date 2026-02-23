using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Top_Down_Shooter
{
    public partial class Level1 : Form
    {   //lists all the key variables needed in the levels
        bool Go_left;
        bool Go_right;
        bool Go_up;
        bool Go_down;
        bool isGameOver = false;
        string facing = "up";
        int PlayerHealth = 100;
        int Speed_Of_Player = 20;
        int Speed_Of_Enemy = 1;
        int Kills = 0;
        string txtKills;
        int waves;

       
        
        Random randnum = new Random();//will randomise the interval between each zombie spawn

        List<PictureBox> EnemyList = new List<PictureBox>();
        
            
        public Level1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // stopped the sprites (and bullet) from flickering when moving across the screen - makes game smoother and more enjoyable.

            this.WindowState = FormWindowState.Maximized;
            MessageBox.Show("Welcome to the game! \n\nUse arrow keys to move.\n\nPress Space to shoot.\n\nGood luck!");
            ResetGame();
        }
        //loads up the Level screen
        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HealthLabel_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Shooter_User_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimer_Tick(object sender, EventArgs e)
        {
            if (PlayerHealth > 1) //carries on the game until the player is dead (health =  0)
            {
                progressBar1.Value = PlayerHealth;
            }
            else
            {
                isGameOver = true;
                MainGameTimer.Stop();
                MessageBox.Show("Game over!");
                this.Hide();
                Form MainMenu = new MainMenu();
                MainMenu.ShowDialog();

            }
            //changes the number next to kills and waves on the Form1.cs [Design]
            label1.Text = "Kills: " + Kills;
            Wave_Number.Text = "Wave(s): " + waves;

            //makes sure character doesnt go out of the screen - the blocks within the if statements make it so
            //the character won't go through the labels

            if (Go_left && Shooter_User.Left > 0)
            {
                Shooter_User.Left -= Speed_Of_Player;
                if (Shooter_User.Bounds.IntersectsWith(label1.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
                if (Shooter_User.Bounds.IntersectsWith(HealthLabel.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
                if (Shooter_User.Bounds.IntersectsWith(Wave_Number.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
                if (Shooter_User.Bounds.IntersectsWith(progressBar1.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
            }
            if (Go_right && Shooter_User.Left + Shooter_User.Width < this.ClientSize.Width)
            {
                Shooter_User.Left += Speed_Of_Player;
                if (Shooter_User.Bounds.IntersectsWith(label1.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
                if (Shooter_User.Bounds.IntersectsWith(HealthLabel.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
                if (Shooter_User.Bounds.IntersectsWith(Wave_Number.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
                if (Shooter_User.Bounds.IntersectsWith(progressBar1.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;

                }
            }
            if (Go_up && Shooter_User.Top > 0)
            {
                Shooter_User.Top -= Speed_Of_Player;
                if (Shooter_User.Bounds.IntersectsWith(label1.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
                if (Shooter_User.Bounds.IntersectsWith(HealthLabel.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
                if (Shooter_User.Bounds.IntersectsWith(Wave_Number.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
                if (Shooter_User.Bounds.IntersectsWith(progressBar1.Bounds))
                {
                    Shooter_User.Top += Speed_Of_Player;
                }
            }
            if (Go_down && Shooter_User.Top + Shooter_User.Height < this.ClientSize.Height)
            {
                Shooter_User.Top += Speed_Of_Player;
            }

            if (EnemyList.Count <= 0) //spawns a new enemy if there are less than 5 enemies on the screen
            {
                    ResetWave();
                    waves += 1; //adds 1 to the wave count when all the enemies on the screen are killed
                    Speed_Of_Enemy += 1;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    if (x.Left > Shooter_User.Left)
                    {

                        x.Left -= Speed_Of_Enemy;
                        ((PictureBox)x).Image = Properties.Resources.Enemy_Left;
                    }
                    if (x.Left < Shooter_User.Left)
                    {

                        x.Left += Speed_Of_Enemy;
                        ((PictureBox)x).Image = Properties.Resources.Enemy_Right;
                    }
                    if (x.Top > Shooter_User.Top)
                    {

                        x.Top -= Speed_Of_Enemy;
                        ((PictureBox)x).Image = Properties.Resources.Enemy_Up;
                    }
                    if (x.Top < Shooter_User.Top)
                    {

                        x.Top += Speed_Of_Enemy;
                        ((PictureBox)x).Image = Properties.Resources.Enemy_Down;
                    }





                    // 4. Check for Player Collision (Damage)
                    if (x.Bounds.IntersectsWith(Shooter_User.Bounds))
                    {

                        PlayerHealth -= 1; // Enemy is touching the player
                    }


                }

                foreach (Control y in this.Controls)
                {
                    if (y is PictureBox && (string)y.Tag == "bullet" && x is PictureBox && (string)x.Tag == "enemy")
                    {
                        if (x.Bounds.IntersectsWith(y.Bounds)) //if the bullet hits the enemy, the enemy and bullet are removed from the form and the enemy list
                        {
                            Kills += 1; //adds 1 to the kill count
                            this.Controls.Remove(y);
                            this.Controls.Remove(x);
                            EnemyList.Remove((PictureBox)x);
                        }

                        if (PlayerHealth <= 50) //changes the colour of the health bar to orange when the player's health is at 50
                        {
                            progressBar1.BackColor = Color.Orange;
                        }
                    }


                }
            }
        }

       

        //manages player movement
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) //Allows player to use WASD aswell as the arrow keys
            {
                Go_right = true;
                facing = "right";
                Shooter_User.Image = Properties.Resources.Shooter_Guy_Right;
            }


            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                Go_down = true;
                facing = "down";
                Shooter_User.Image = Properties.Resources.Shooter_Guy_Down;
            }


            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                Go_left = true;
                facing = "left";
                Shooter_User.Image = Properties.Resources.Shooter_Guy_Left;
            }


            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                Go_up = true;
                facing = "up";
                Shooter_User.Image = Properties.Resources.Shooter_Guy_Up;
            }


        }

        //allows the game to know when a key isnt pressed so the character doesnt continuously go in one direction even if the key is released
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                Go_right = false;              
               
            }


            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                Go_down = false;
               
            }


            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                Go_left = false; 
               
            }


            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                Go_up = false;
               
            }


            if ( e.KeyCode == Keys.Space)
            {
                Shoot(facing);
            }   
            
                
            

        }

        private void Shoot(string direction)
        {
            Bullet shoot = new Bullet(); //creates bullet object when the player shoots
            shoot.direction = direction; //shoots bullet in direction player is facing
            shoot.bullet_left = Shooter_User.Left + (Shooter_User.Width/2); //ensures bullet comes out of the player's middle
            shoot.bullet_top = Shooter_User.Top + (Shooter_User.Height/2);// same thing as the previous line of code
            shoot.Make_Bullet(this); //grabs bullet from bullet class and uses it in this form (Level1.cs)
        }

        private void Enemy_Creation()
        {

            PictureBox Enemy = new PictureBox(); //creates picturebox for enemy to be drawn
            Enemy.BackColor =Color.Transparent; 
            Enemy.Tag = "enemy"; //makes the game identify what the picturebox is - similar with the bullet class
            Enemy.Image = Properties.Resources.Enemy_Down;
            Enemy.Size = new Size(100, 100);//sets the enemy image down as default
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy.Left = randnum.Next(0, this.ClientSize.Width - Enemy.Width); //randomises the left position of the enemy within the screen width
            Enemy.Top = randnum.Next(50, this.ClientSize.Height - Enemy.Height); //randomises the top position of the enemy within the screen height
            this.Controls.Add(Enemy); //adds the enemy to the form so it can be seen on the screen
            EnemyList.Add(Enemy); //adds the enemy to a list so that it can be managed with other enemies in the game 
            Enemy.BringToFront(); //makes it so the player picturebox is infront of the enemy - on the off chance the enemy spawns ontop of the player, the sprite is still visible
        }

        private async Task ResetGame()
        {
            Shooter_User.Image = Properties.Resources.Shooter_Guy_Up; //resets the player image to the default one
            
            for (int i = 0; i < EnemyList.Count; i++) //removes all the enemies from the form and the enemy list so that the game can be restarted without any enemies on the screen
            {
                this.Controls.Remove(EnemyList[i]);
            }   
            
            EnemyList.Clear(); //clears the enemy list
            for (int i = 0; i < 5;  i++) //Doesn't allow more than 5 zombies on a screen
            {
                
                Enemy_Creation();
                await Task.Delay(randnum.Next(500, 1500));


            }

            Go_up = false; 
            Go_down= false;
            Go_left = false;
            Go_right = false;

            PlayerHealth = 100; //resets player health to 100
            Kills = 0; //resets kills to 0
            waves = 0; //resets waves to 0
            MainGameTimer.Start();

        }

        private async Task ResetWave()
        {


           

            EnemyList.Clear(); //clears the enemy list
            for (int i = 0; i < 5; i++) //Doesn't allow more than 5 zombies on a screen
            {

                Enemy_Creation();
                await Task.Delay(randnum.Next(500, 1500));

            }

            Go_up = false;
            Go_down = false;
            Go_left = false;
            Go_right = false;

            
            

        }

        private void Wave_Number_Click(object sender, EventArgs e)
        {

        }
    }
}
