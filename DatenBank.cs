using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz
{
    public class DatenBank
    {
        private MySqlConnection konn;

        public DatenBank()
        {
            string konStr = "SERVER=localhost;DATABASE=quiz;UID=root;PASSWORD=''";
            konn = new MySqlConnection(konStr);
        }

        public void oeffnen()
        {
            try
            {
                konn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void schliessen()
        {
            if (konn != null && konn.State == System.Data.ConnectionState.Open)
            {
                konn.Close();
            }
        }

        public List<Kontinente> GetKontinente()
        {
            List<Kontinente> kontinente = new List<Kontinente>();
            string query = "SELECT * FROM Kontinent";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, konn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int knr = Convert.ToInt32(dataReader["KNr"]);
                    string kname = dataReader["KName"].ToString();

                    Kontinente kontinent = new Kontinente(knr, kname);
                    kontinente.Add(kontinent);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Kontinente: {ex.Message}");
            }

            return kontinente;
        }

        public List<Laender> GetLaender()
        {
            List<Laender> laender = new List<Laender>();
            string query = "SELECT * FROM Laender";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, konn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int lnr = Convert.ToInt32(dataReader["LNr"]);
                    int lk = Convert.ToInt32(dataReader["LK"]);
                    string lname = dataReader["LName"].ToString();
                    string lhauptstadt = dataReader["LHauptstadt"].ToString();
                    string lkontinent = dataReader["LKontinent"].ToString();

                    Laender land = new Laender(lnr, lname, lhauptstadt, lkontinent);
                    laender.Add(land);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Länder: {ex.Message}");
            }

            return laender;
        }

        public List<Spieler> GetSpieler()
        {
            List<Spieler> spieler = new List<Spieler>();
            string query = "SELECT * FROM Spieler";
            oeffnen();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, konn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int spnr = Convert.ToInt32(dataReader["SPNr"]);
                    string spname = dataReader["SPName"].ToString();
                    int sppass = Convert.ToInt32(dataReader["SPPass"]);

                    Spieler player = new Spieler(spnr, spname, sppass);
                    spieler.Add(player);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Spieler: {ex.Message}");
            }
            finally
            {
                schliessen();
            }

            return spieler;
        }
        private void speichereSpieler(Spieler sp)
        {
            oeffnen(); // Datenbankverbindung öffnen
            MySqlCommand cmd = konn.CreateCommand();
            string s;

            try
            {
                s = string.Format("INSERT INTO Spieler (SPName, SPPass) VALUES ('{0}', {1})", sp.SpName, sp.SpPass);
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern des Spielers: {ex.Message}");
            }
            finally
            {
                schliessen(); // Datenbankverbindung schließen
            }
        }
        public List<Spieler> GetSpielers()
        {
            List<Spieler> spieler = new List<Spieler>();
            string query = "SELECT * FROM Spieler";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, konn);
                konn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int spnr = Convert.ToInt32(dataReader["SPNr"]);
                    string spname = dataReader["SPName"].ToString();
                    int sppass = Convert.ToInt32(dataReader["SPPass"]);

                    Spieler player = new Spieler(spnr, spname, sppass);
                    spieler.Add(player);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Fehler beim Laden der Spieler: {ex.Message}");
            }
            finally
            {
                konn.Close();
            }

            return spieler;
        }
        public void SpeichereSpieler(Spieler sp)
        {
            oeffnen(); // Datenbankverbindung öffnen
            MySqlCommand cmd = konn.CreateCommand();
            string s;

            try
            {
                s = string.Format("INSERT INTO Spieler (SPName, SPPass) VALUES ('{0}', {1})", sp.SpName, sp.SpPass);
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern des Spielers: {ex.Message}");
            }
            finally
            {
                schliessen(); // Datenbankverbindung schließen
            }
        }

    }
}
