using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Top_Down_Shooter
{
    public partial class Leaderboard_Screen : Form
    {
        // Makes a paramaterless constructor so I can view the leaderboard without having to record a previous game's session's waves and kills. 
        public Leaderboard_Screen()
        {
            InitializeComponent();
            LoadLeaderboard();
        }
        private string filepath = "TextFile1.txt";
        public Leaderboard_Screen(string name, int waves, int kills)
        {
            InitializeComponent();
            SaveScore(name, waves, kills); 
            
            LoadLeaderboard();
        }

        private void SaveScore(string name, int waves, int kills)
        {
            name = Interaction.InputBox("Enter your name for the leaderboard:", "Name Entry", "Player1");
            // Appends a new line: PlayerName,Waves,Kills
            string line = $"{name},{waves},{kills}";
            File.AppendAllLines(filepath, new[] { line });
        }
        private void LoadLeaderboard()
        {
            if (!File.Exists(filepath)) return;

            dataGridView1.Rows.Clear();
            string[] lines = File.ReadAllLines(filepath);

            foreach (string line in lines)
            {
                string[] data = line.Split(','); 
                if (data.Length == 3)
                {
                    dataGridView1.Rows.Add(data[0], data[1], data[2]);
                }
            }

             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Game_Title_Click(object sender, EventArgs e)
        {

        }

        private void ClearLeaderBoardButton_Click(object sender, EventArgs e)
        {
          DialogResult choice = MessageBox.Show("Are you sure you want to clear the leaderboard? This action cannot be undone.", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                string password = Interaction.InputBox("Enter password to clear leaderboard field:", "Password Entry", "");
                if (password == "Password1") // Simple password check to prevent accidental clearing of the leaderboard
                    File.WriteAllText(filepath, string.Empty);
                    LoadLeaderboard();
               if (password != "Password1")
                    MessageBox.Show("Incorrect password. Leaderboard not cleared.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mainmenu = new MainMenu();
            mainmenu.ShowDialog();
        }
    }


}
