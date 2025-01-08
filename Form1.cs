using System.Diagnostics.Metrics;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private List<Kontinente> kontinentelist;
        private List<Laender> laenderlist;
        private List<Spieler> spielerlist;
        private List<HighScore> highscorelist;
        private List<Fragen> fragenlist;
        private List<Antworten> antwortenlist;
        private DatenBank db;
        public Form1()
        {
            InitializeComponent();
            db = new DatenBank();
            kontinentelist = new List<Kontinente>();
            laenderlist = new List<Laender>();
            spielerlist = new List<Spieler>();
            highscorelist = new List<HighScore>();
            fragenlist = new List<Fragen>();
            antwortenlist = new List<Antworten>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hier können Sie Initialisierungscode einfügen, z.B. Laden von Kontinenten, Ländern, Spielern, etc.
            LoadKontinente();
            LoadLaender();
            LoadSpieler();
            // usw.
        }

        private void LoadKontinente()
        {
            // Beispiel: Laden der Kontinente aus der Datenbank
            db.oeffnen();
            kontinentelist = db.GetKontinente(); // Implementieren Sie diese Methode in Ihrer Datenbankklasse
            db.schliessen();
        }

        private void LoadLaender()
        {
            // Beispiel: Laden der Länder aus der Datenbank
            db.oeffnen();
            laenderlist = db.GetLaender(); // Implementieren Sie diese Methode in Ihrer Datenbankklasse
            db.schliessen();
        }

        private void LoadSpieler()
        {
            spielerlist = db.GetSpieler();
            comboBox3.Items.Clear();

            foreach (Spieler sp in spielerlist)
            {
                // Hier setzen wir den Anzeigetext für jedes Spielerobjekt
                comboBox3.Items.Add(sp.SpName); // Füge den Spielername zur ComboBox hinzu
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string spname = textBox1.Text;
                int sppas = Convert.ToInt32(textBox2.Text);


                db.SpeichereSpieler(new Spieler(-1, spname, sppas));
                LoadSpieler(); // Spieler neu laden nach dem Speichern
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern des Spielers: {ex.Message}");
               
            }

              
        }
    }
}

