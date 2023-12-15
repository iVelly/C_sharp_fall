using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{

    public class GamePlayer
    {
        private string playerName;
        private int lives;
        private double hoursPlayed;
        private int health;
        private int strength;
        private int armor;
        private DateTime playingSince;  // Date when the player started playing
        private int playerID;  
        private string feedback;

        public GamePlayer()
        {
            feedback = ""; // Initialize feedback to an empty string
        }

        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }

        // Property for playerID
        public int PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public string PlayerName
        {
            get { return playerName; }
            set
            {
                if (!ValidOrBuggin.IsItFilledIn(value, 1)) // Assuming player name should be at least 1 character
                {
                    feedback += "\nERROR: Player name must be filled in.";
                }
                else
                {
                    playerName = value;
                }
            }
        }

        public int Lives
        {
            get { return lives; }
            set
            {
                if (value < 0)
                {
                    feedback += "\nERROR: Number of lives cannot be negative.";
                }
                else
                {
                    lives = value;
                }
            }
        }

        public double HoursPlayed
        {
            get { return hoursPlayed; }
            set
            {
                if (value < 0)
                {
                    feedback += "\nERROR: Hours played cannot be negative.";
                }
                else
                {
                    hoursPlayed = value;
                }
            }
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0 || value > 100)
                {
                    feedback += "\nERROR: Health must be between 0 and 100.";
                }
                else
                {
                    health = value;
                }
            }
        }

        public int Strength
        {
            get { return strength; }
            set
            {
                if (value < 2 || value > 15)
                {
                    feedback += "\nERROR: Strength must be between 2 and 15.";
                }
                else
                {
                    strength = value;
                }
            }
        }

        public int Armor
        {
            get { return armor; }
            set
            {
                if (value < 0 || value > 100)
                {
                    feedback += "\nERROR: Armor must be between 0 and 100.";
                }
                else
                {
                    armor = value;
                }
            }
        }

        public DateTime PlayingSince
        {
            get { return playingSince; }
            set
            {
              
                if (!ValidOrBuggin.IsNotAFutureDate(value))
                {
                    feedback += "\nERROR: Invalid date...can't be in the future";
                }
                else
                {
                    playingSince = value;
                }
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////////
       
        

        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE133_LGermeil;User Id=SE133_LGermeil;Password=008017491;";
        }

        public DataSet SearchPlayers(string playerName)
        {
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();

            string strSQL = "SELECT PlayerID, PlayerName, Lives, HoursPlayed, Health, Strength, Armor, PlayingSince FROM Players WHERE 1=1";

            if (!string.IsNullOrEmpty(playerName))
            {
                strSQL += " AND PlayerName LIKE @PlayerName";
                comm.Parameters.AddWithValue("@PlayerName", "%" + playerName + "%");
            }

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnected();
            comm.Connection = conn;
            comm.CommandText = strSQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();
            da.Fill(ds, "Players_Temp");
            conn.Close();

            return ds;
        }

        public string AddPlayer()
        {
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "INSERT INTO Players (PlayerName, Lives, HoursPlayed, Health, Strength, Armor, PlayingSince) " +
                               "VALUES (@PlayerName, @Lives, @HoursPlayed, @Health, @Strength, @Armor, @PlayingSince)";

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PlayerName", this.PlayerName);
            comm.Parameters.AddWithValue("@Lives", this.Lives);
            comm.Parameters.AddWithValue("@HoursPlayed", this.HoursPlayed);
            comm.Parameters.AddWithValue("@Health", this.Health);
            comm.Parameters.AddWithValue("@Strength", this.Strength);
            comm.Parameters.AddWithValue("@Armor", this.Armor);
            comm.Parameters.AddWithValue("@PlayingSince", this.PlayingSince);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Inserted {intRecs} records.";
                conn.Close();
            }
            catch (Exception err)
            {
                Feedback = "ERROR: " + err.Message;
            }

            return Feedback;
        }

        public string UpdatePlayer(int playerID)
        {
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "UPDATE Players SET PlayerName = @PlayerName, Lives = @Lives, " +
                               "HoursPlayed = @HoursPlayed, Health = @Health, Strength = @Strength, Armor = @Armor, PlayingSince = @PlayingSince " +
                               "WHERE PlayerID = @PlayerID";

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PlayerName", this.PlayerName);
            comm.Parameters.AddWithValue("@Lives", this.Lives);
            comm.Parameters.AddWithValue("@HoursPlayed", this.HoursPlayed);
            comm.Parameters.AddWithValue("@Health", this.Health);
            comm.Parameters.AddWithValue("@Strength", this.Strength);
            comm.Parameters.AddWithValue("@Armor", this.Armor);
            comm.Parameters.AddWithValue("@PlayingSince", this.PlayingSince);
            comm.Parameters.AddWithValue("@PlayerID", playerID);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Updated {intRecs} records.";
                conn.Close();
            }
            catch (Exception err)
            {
                Feedback = "ERROR: " + err.Message;
            }

            return Feedback;
        }

        public string DeletePlayer(int playerID)
        {
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "DELETE FROM Players WHERE PlayerID = @PlayerID";

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PlayerID", playerID);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Deleted {intRecs} records.";
                conn.Close();
            }
            catch (Exception err)
            {
                Feedback = "ERROR: " + err.Message;
            }

            return Feedback;
        }

        public SqlDataReader FindOnePlayer(int playerID)
        {
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "SELECT * FROM Players WHERE PlayerID = @PlayerID";
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PlayerID", playerID);

            conn.Open();
            return comm.ExecuteReader(); // Caller must close the connection!
        }
        //////////////////////////////////////////////////
        public static double CalculateAverageHoursPlayed(List<GamePlayer> players)
        {
            if (players.Count == 0) return 0;

            double totalHoursPlayed = 0;
            foreach (var player in players)
            {
                totalHoursPlayed += player.HoursPlayed;
            }

            return totalHoursPlayed / players.Count;
        }


        public static double CalculateTotalHoursPlayed(List<GamePlayer> players)
        {
            double totalHours = 0;
            foreach (var player in players)
            {
                totalHours += player.HoursPlayed;
            }

            return totalHours;
        }
        /////////////////////////////////////////////////////

    }

}
