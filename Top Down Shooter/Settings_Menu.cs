using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top_Down_Shooter
{
    public partial class Settings_Menu : Form
    {
        public Settings_Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Back_To_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new MainMenu();
            Form1.ShowDialog();
        }

        private void Toggle_Blood_Click(object sender, EventArgs e)
        {

        }
    }
}
