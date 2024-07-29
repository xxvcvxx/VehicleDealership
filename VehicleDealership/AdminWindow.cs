namespace VehicleDealership
{
    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
            DataGroup.Enabled = false;
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            var login = UserNameInput.Text;
            var password = PasswordInput.Text;

            // poszukaj wpisow z loginem i haslem
            var found = DealershipView.FindElements_String(
                $"SELECT Login FROM Accounts WHERE login='{login}' AND password='{password}'");

            // jesli znaleziono wpis pracowanika
            var count = found.Count;
            if (count > 0)
            {
                DataGroup.Enabled = true;
            }
            else
            {
                DataGroup.Enabled = false;
            }
            InitializeBrandSelector();
        }

        private void SendVehicleButton_Click(object sender, EventArgs e)
        {
            var brand = BrandInput.Text;
            var type = TypeInput.Text;
            var engine = EngineInput.Text;

            // definicja polecenia do bazy danych - dodaj wpis do tablicy
            var data = $"INSERT INTO DealershipData (Brand, Type, Engine) VALUES ('{brand}', '{type}' ,'{engine}')";


            using (SqlCommand command = new SqlCommand())
            {
                // ustaw połączenie z bazą danych
                command.Connection = DealershipView.Connection;

                // ustaw jaką komendę chcemy wysłać
                command.CommandText = data;

                // wyslij tą komendę
                command.ExecuteNonQuery();
                InitializeBrandSelector();
                MessageBox.Show("Saved");
            }

            //var id = DealershipView.Dealership.DealershipData.Count;
            //var row = DealershipView.Dealership.DealershipData.NewDealershipDataRow();
            //row.Engine = engine;
            //row.Id = 100;
            //row.AcceptChanges();
        }

        private void SendPaintButton_Click(object sender, EventArgs e)
        {
            var name = ColorInput.Text;
            var color = ColorTranslator.ToHtml(_SelectedColor);
            var metallic = MetallicToggle.Checked;

            if (MetallicToggle.Checked)
            {
                metallic = true;
            }
            else
            {
                metallic = false;
            }



            // definicja polecenia do bazy danych - dodaj wpis do tablicy
            var data = $"INSERT INTO Colors (Name, Color, Metallic) VALUES ('{name}', '{color}' ,'{metallic}')";

            // zdefiniuj nową komendę do przetworzenia
            using (SqlCommand command = new SqlCommand())
            {
                // ustaw połączenie z bazą danych
                command.Connection = DealershipView.Connection;

                // ustaw jaką komendę chcemy wysłać
                command.CommandText = data;

                // wyslij tą komendę
                command.ExecuteNonQuery();
                InitializeBrandSelector();
                MessageBox.Show("Saved");

            }
        }

        private void ColorSelector_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = System.Drawing.Color.Beige;

            // Update the text box color if the user clicks OK
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                _SelectedColor = MyDialog.Color;
                ColorSelector.ForeColor = MyDialog.Color;
            }
        }

        private Color _SelectedColor;

        private void BrandInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColorInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteVehicleButton_Click(object sender, EventArgs e)
        {

        }

        private void BrandSelector_SelectedIndexChanged(object sender, EventArgs e)
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

        }

        private void InitializeBrandSelector()
        {
            // znajdź wszystkie marki samochodów
            var brands = DealershipView.FindElements_String("Select Distinct Brand from DealershipData");

            // przypisz do combo box

            BrandSelector.Items.Clear();
            BrandSelector.Items.AddRange(brands.ToArray());
        }
        private void InitializeTypeSelector(string brand)
        {
            // włącz możliwość wybrania typu samochodu
            TypeSelector.Enabled = true;
            // bazowo wyczyść wybór
            TypeSelector.SelectedIndex = -1;

            var types = DealershipView.FindElements_String($"Select Distinct Type From DealershipData where Brand='{brand}'");

            // przypisz do combo box
            TypeSelector.Items.Clear();
            TypeSelector.Items.AddRange(types.ToArray());
        }
        private void InitializeEngineSelector(string brand, string type)
        {
         
            // bazowo wyczyść wybór
            EngineSelector.SelectedIndex = -1;

            var engines = DealershipView.FindElements_String($"Select Distinct Engine From DealershipData where Brand='{brand}' and Type='{type}'");

            // przypisz do combo box
            EngineSelector.Items.Clear();
            EngineSelector.Items.AddRange(engines.ToArray());
        }
    }

}