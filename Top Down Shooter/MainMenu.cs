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
using WMPLib;

namespace Top_Down_Shooter
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Game_Title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Mouse_Hover(sender, e);
            this.Hide();
            Form Form1 = new Level1();
            Form1.ShowDialog();
        }

        private void Leaderboard_viewer_Click(object sender, EventArgs e)
        {

        }

        private void Mouse_Hover(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void Settings_Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Settings_Menu();
            Form2.ShowDialog();
        }
    }

    
}