namespace VehicleDealership
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;
    

    /// <summary>
    /// ctrl+r,r - zmień nazwę
    /// </summary>
    public sealed partial class DealershipView : Form
    {
        public static SqlConnection Connection;
        public static DealershipDatabaseDataSet Dealership;

        private AdminWindow _AdminWindow;

        public DealershipView()

        {
           
            InitializeComponent();
            
        }

        private  void DealershipView_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dealershipDatabaseDataSet.DealershipData' table. You can move, or remove it, as needed.
            this.dealershipDataTableAdapter.Fill(this.dealershipDatabaseDataSet.DealershipData);
            Dealership = this.dealershipDatabaseDataSet;

            // otwórz połączenie do bazy danych
            // używając wygenerowanego klucza połączenia
            Connection = new SqlConnection(Properties.Settings.Default.DealershipDatabaseConnectionString);
            Connection.Open();

            // wyłączamy elementy niedostępne przed wyborem określonych kategorii
            TypeSelector.Enabled = false;
            ComponentsGroup.Enabled = false;
            PaintGroup.Enabled = false;

            InitializeBrandSelector();
        }

        private void BrandSelector_SelectedIndexChanged(object sender, EventArgs args)
        {
            var brand = (string)BrandSelector.SelectedItem;
            InitializeTypeSelector(brand);
        }
        private void TypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var brand = (string)BrandSelector.SelectedItem;
            var type = (string)TypeSelector.SelectedItem;
            InitializeEngineSelector(brand, type);
        }
        private void EngineSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializePaintSelector();
        }
        private void ColorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = (string)ColorSelector.SelectedItem;

            // sprawdzamy czy kolor został zdefiniowany (nie jest pusty albo null)
            if (string.IsNullOrEmpty(color)) { return; }

            var value = FindElement_String($"Select Color from Colors where Name='{color}'");
            // kolory zapisane sa w bazie danych jako stringi w formacie HTML (0xRRGGBB)
            // wiec musimy zamienic je na Color
            BackColor = ColorTranslator.FromHtml(value);
        }
        private void MetallicToggle_CheckedChanged(object sender, EventArgs args)
        {
            InitializePaintSelector();
        }

        private void InitializeBrandSelector()
        {
            // znajdź wszystkie marki samochodów
            var brands = FindElements_String("Select Distinct Brand from DealershipData");

            // przypisz do combo box
         
            BrandSelector.Items.Clear();
            BrandSelector.Items.AddRange(brands.ToArray());
        }
        private  void InitializeTypeSelector(string brand)
        {
            // włącz możliwość wybrania typu samochodu
            TypeSelector.Enabled = true;
            // bazowo wyczyść wybór
            TypeSelector.SelectedIndex = -1;

            var types = FindElements_String($"Select Distinct Type From DealershipData where Brand='{brand}'");

            // przypisz do combo box
            TypeSelector.Items.Clear();
            TypeSelector.Items.AddRange(types.ToArray());
        }
        private void InitializeEngineSelector(string brand, string type)
        {
            // włącz grupę odpowiedzialną za wybór elementów samochodu
            ComponentsGroup.Enabled = true;
            // bazowo wyczyść wybór
            EngineSelector.SelectedIndex = -1;

            var engines = FindElements_String($"Select Distinct Engine From DealershipData where Brand='{brand}' and Type='{type}'");

            // przypisz do combo box
            EngineSelector.Items.Clear();
            EngineSelector.Items.AddRange(engines.ToArray());
        }
        private void InitializePaintSelector()
        {
            // włącz grupę zawierającą elementy wyboru koloru
            PaintGroup.Enabled = true;
            // bazowo wyczyść wybór
            ColorSelector.SelectedIndex = -1;

            // wyszukaj kolorow, z uwzglednieniem kolorow metalicznych
            string command;
            if (MetallicToggle.Checked == false)
            {
                // wszystkie kolory
                command = "Select Name From Colors";
            }
            else
            {
                // tylko kolory ktore wspierają kolor metaliczny
                command = "Select Name From Colors where Metallic='True'";
            }

            var colors = FindElements_String(command);

            // przypisz do combo box
            ColorSelector.Items.Clear();
            ColorSelector.Items.AddRange(colors.ToArray());
        }

        /// <summary>
        /// Znajdź pojedynczy element typu string zadaną komendą
        /// </summary>
        public static string FindElement_String(string commandString)
        {
            return FindElements_String(commandString)[0];
        }

        /// <summary>
        /// Znajdź elementy typu string zadaną komendą
        /// </summary>
        public static List<string> FindElements_String(string commandString)
        {
            // stwórz komendę w oparciu o podany parametr
            var command = new SqlCommand(commandString, Connection);

            // zainicjalizuj liste rezultatów
            var results = new List<string>();

            // wykonaj utworzoną komendę
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // dopóki czytacz zwraca wyniki
                while (reader.Read())
                {
                    // zinterpertuj przeczytaną wartość jako zmienna typu string
                    var stringResult = reader.GetString(0);

                    // dodaj do zwracanych rezultatów
                    results.Add(stringResult);
                }
            }

            return results;
        }

        /// <summary>
        /// Obsługa ekranu administratora
        /// </summary>
        private void AdminPanel_Click(object sender, EventArgs e)
        {
            // stworz panel administratora
            {
                // schowaj aktualne okienko
                Hide();
                

                // stworz i pokaz okienko administratora
                _AdminWindow = new AdminWindow();
                _AdminWindow.Show();
                

                // na wydarzeniu: okienko zamkniete, wywolaj funkcje
                _AdminWindow.FormClosed += AdminWindowOnFormClosed;
            }
        }

        private void AdminWindowOnFormClosed(object sender, FormClosedEventArgs e)
     
        {
            // po zamknieciu okienka administratora, pokaz okienko głowne i na nowo pobierze rzeczy z sql
            InitializeBrandSelector();
         
            InitializePaintSelector();
            Show();
            
            
        }
    }
}