using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class TotalScreen : Form
    {
        public TotalScreen()
        {
            InitializeComponent();
        }
        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE133_LGermeil;User Id=SE133_LGermeil;Password=008017491;";
        }

        private List<GamePlayer> GetPlayersFromDataSource()
        {
            List<GamePlayer> players = new List<GamePlayer>();

            using (SqlConnection connection = new SqlConnection(GetConnected()))
            {
                connection.Open();

                string sqlQuery = "SELECT PlayerID, PlayerName, Lives, HoursPlayed, Health, Strength, Armor, PlayingSince FROM Players";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GamePlayer player = new GamePlayer
                            {
                                PlayerID = Convert.ToInt32(reader["PlayerID"]),
                                PlayerName = reader["PlayerName"].ToString(),
                                Lives = Convert.ToInt32(reader["Lives"]),
                                HoursPlayed = Convert.ToDouble(reader["HoursPlayed"]),
                                Health = Convert.ToInt32(reader["Health"]),
                                Strength = Convert.ToInt32(reader["Strength"]),
                                Armor = Convert.ToInt32(reader["Armor"]),
                                PlayingSince = Convert.ToDateTime(reader["PlayingSince"])
                            };

                            players.Add(player);
                        }
                    }
                }

                connection.Close();
            }

            return players;
        }

        private void TotalScreen_Load(object sender, EventArgs e)
        {

        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlayerTotal_Click(object sender, EventArgs e)
        {
            List<GamePlayer> players = GetPlayersFromDataSource();

            double totalHours = GamePlayer.CalculateTotalHoursPlayed(players);

            lblFeedback.Text = $"Total Hours Played: {totalHours:F2}";

            lstPlayers.Items.Clear();

            foreach (GamePlayer player in players)
            {
                lstPlayers.Items.Add($"{player.PlayerName}, Played {player.HoursPlayed:F2} hours");
            }
        }
    }
}
