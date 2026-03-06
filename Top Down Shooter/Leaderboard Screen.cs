using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;


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
        public Leaderboard_Screen(int waves, int kills)
        {
            
            SaveScore("Player1", waves, kills); 
            
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

            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Game_Title_Click(object sender, EventArgs e)
        {

        }

        private void Name_Enter_TextChanged(object sender, EventArgs e)
        {
            string playerName = Name_Enter.Text;
        }
    }


}
