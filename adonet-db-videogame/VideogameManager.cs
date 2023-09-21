using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet_db_videogame
{
    public static class VideogameManager
    {
        private static string connectionString = "Data Source=localhost;Initial Catalog = videogames; Integrated Security = True";

        public static List<Videogame> GetGames()
        {
            List<Videogame> videogames = new List<Videogame>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader data = cmd.ExecuteReader())
                    {
                        while (data.Read())
                        {

                        }
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return videogames;
        }


    }
}
