using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

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

                    string query = "SELECT id, name, release_date FROM videogames";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader data = cmd.ExecuteReader())
                    {
                        while (data.Read())
                        {
                           Videogame videogameReaded = new Videogame(data.GetInt64(0), data.GetString(1), data.GetDateTime(2));
                            videogames.Add(videogameReaded);
                        }
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return videogames;
        }

        public static Videogame SearchGamesFromId()
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    Console.WriteLine("Inserisci la parola chiave da ricercare");
                    string searchByKeyword = Console.ReadLine();

                    string query = "SELECT id, name, release_date FROM videogames WHERE name LIKE @keyword ";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add(new SqlParameter("@keyword", searchByKeyword));

                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        long id = data.GetInt64(0);
                        string name = data.GetString(1);
                        DateTime relase_date = data.GetDateTime(2);

                        return new Videogame(id, name, relase_date);   
                    }
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return null;
            }
        }

        public static List<Videogame> SearchGamesFromKeyword()
        {
            List<Videogame> videogames = new List<Videogame>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    Console.WriteLine("Inserisci la parola chiave che si desidera ricercare");
                    string searchByKeyword = "%"+ Console.ReadLine() +"%";

                    string query = "SELECT id, name, release_date FROM videogames WHERE name LIKE @keyword";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add(new SqlParameter("@keyword", searchByKeyword));

                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {

                        Videogame videogameSearched = new Videogame(data.GetInt64(0), data.GetString(1), data.GetDateTime(2));
                        videogames.Add(videogameSearched);
 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return videogames;
            }
        }


    }
}
