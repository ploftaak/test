using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Escaperoom.Classes
{
    class ConnectieDB
    {
        //Connectie maken met database.
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Proftaak2\Escaperoom\Escaperoom\Escaperoom\Database1.mdf;Integrated Security=True";
        private SqlConnection con = new SqlConnection(connectionString);

        public int inlogcheck(string username, string password)
        {
            int check = 0;
            //Maak query.
            // string query = "SELECT User FROM userid WHERE Username '" + gebruikersnaam + "' AND password'" + wachtwoord + "'";
            // is onveilig, SQL injection > parameterize query.
            string query = "SELECT * FROM [User] WHERE (username=@username AND password=@password COLLATE SQL_Latin1_General_CP1_CS_AS)";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            //Voer de query uit.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    check = reader.GetInt32(0);
                }
            }
            con.Close();
            return check;
        }

        public DataTable GetScenario()
        {
            
            //Maak query.
            // string query = "SELECT User FROM userid WHERE Username '" + gebruikersnaam + "' AND password'" + wachtwoord + "'";
            // is onveilig, SQL injection > parameterize query.
            string query = "SELECT [Scenarionaam] FROM [Scenario]";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            DataTable scenario = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(scenario);

            con.Close();

            return scenario;          

        }

        public string GetBeschrijving(string scenario)
        {
            
            string query = "SELECT [Beschrijving] FROM [Scenario] WHERE (Scenarionaam = @scenarionaam)";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@scenarionaam", SqlDbType.VarChar).Value = scenario;

            string beschrijving = (string)cmd.ExecuteScalar();

            con.Close();

            return beschrijving;
        }

        public int AddGroep(string Groep)
        {
            string query = "INSERT INTO Groep OUTPUT INSERTED.ID SELECT @Groepsnaam WHERE NOT EXISTS (SELECT * FROM Groep WHERE Groepsnaam = @Groepsnaam)";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@Groepsnaam", SqlDbType.VarChar).Value = Groep;

            if (cmd.ExecuteNonQuery() == 0)
            {
                con.Close();
                return -1;
            }
            else
            {
                Int32 newId = (Int32)cmd.ExecuteScalar();
                con.Close();
                return newId;
            }
        }

        public void AddLeerling(string LeerlingNaam)
        {
            string query = "INSERT INTO Leerling (Naam) VALUES (@Leerlingnaam)";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@Leerlingnaam", SqlDbType.VarChar).Value = LeerlingNaam;

            int result = cmd.ExecuteNonQuery();

            con.Close();
            // Check Error
            if (result == 0)
            MessageBox.Show("Error inserting data into Database!");
        }

        public void AddLeerlingToGroep(int leerling_id, int groep_id)
        {

        }

        public List<Groep> GetGroepenLijst()
        {
            List<Groep> groepLijst = new List<Groep>();
            /*
            string query = "SELECT Groep.Groepsnaam FROM Leerling_groep INNER JOIN Groep ON Groep.GroepID = Leerling_groep.GroepRef";
            */
            string query = "SELECT * FROM Groep"; 
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Groep g = new Groep(reader.GetString(1), reader.GetInt32(0));
                    groepLijst.Add(g);
                }
            }
            con.Close();
            return groepLijst;
        }
        public List<Leerling> GetLeerlingenLijst(int GroepID)
        {
            List<Leerling> leerlingLijst = new List<Leerling>();
            /*
            string query = "SELECT Groep.Groepsnaam FROM Leerling_groep INNER JOIN Groep ON Groep.GroepID = Leerling_groep.GroepRef";
            */
            string query = "SELECT Leerling.LeerlingID, Leerling.Naam FROM ((Leerling_groep INNER JOIN Leerling ON Leerling_groep.LeerlingRef = Leerling.LeerlingID) INNER JOIN Groep ON Leerling_groep.GroepRef = groep.GroepID) WHERE Leerling_groep.GroepRef = @GroepID";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@GroepID", SqlDbType.Int).Value = GroepID;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Leerling g = new Leerling(reader.GetString(1), reader.GetInt32(0));
                    leerlingLijst.Add(g);
                }
            }
            con.Close();
            return leerlingLijst;
        }

        /*
        public List<string> GetLeerlingen(string groepsNaam)
        {
            string query = "SELECT Leerling.Naam FROM Leerling_groep INNER JOIN Leerling ON Leerling.LeerlingID = Leerling_groep.LeerlingRef";
        }

    */

    }
}
