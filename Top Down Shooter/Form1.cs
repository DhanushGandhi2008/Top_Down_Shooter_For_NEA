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

namespace Top_Down_Shooter
{
    public partial class Level1 : Form
    {
        bool Go_left;
        bool Go_right;
        bool Go_up;
        bool Go_down;
        bool isGameOver = false;
        string facing = "up";
        int PlayerHealth = 100;
        int Speed_Of_Player = 15;
        int Speead_Of_Enemy = 20;
        int Kills = 0;
        string txtKills;
        int waves;
        Random randnum = new Random();

        List<PictureBox> EnemyList = new List<PictureBox>();
        
            
        public Level1()
        {
            InitializeComponent();
        }

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
            if (PlayerHealth > 1)
            {
                progressBar1.Value = PlayerHealth;
            }
            else
            {
                isGameOver = true;
                MainGameTimer.Stop();
                this.Hide();
                Form MeinMenu = new MainMenu();
                MeinMenu.ShowDialog();

            }
            label1.Text = "Kills: " + Kills;
            Wave_Number.Text = "Wave(s): " + waves;

            if (Go_left && Shooter_User.Left > 0)
            {
                Shooter_User.Left -= Speed_Of_Player;
            }
            if (Go_right && Shooter_User.Left + Shooter_User.Width < this.ClientSize.Width)
            {
                Shooter_User.Left += Speed_Of_Player;
            }
            if (Go_up && Shooter_User.Top > 0)
            {
                Shooter_User.Top -= Speed_Of_Player;
            }
            if (Go_down && Shooter_User.Top + Shooter_User.Height < this.ClientSize.Height)
            {
                Shooter_User.Top += Speed_Of_Player;
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
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

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Go_right = false;
               
            }


            if (e.KeyCode == Keys.Down)
            {
                Go_down = false;
               
            }


            if (e.KeyCode == Keys.Left)
            {
                Go_left = false;
               
            }


            if (e.KeyCode == Keys.Up)
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



        }

        private void Enemy_Creation()
        {

        }

        private void ResetGame()
        {

        }

        private void Wave_Number_Click(object sender, EventArgs e)
        {

        }
    }
}
