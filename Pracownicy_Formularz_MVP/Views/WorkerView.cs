using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace Pracownicy_MVP.Views
{
    public partial class WorkerView : Form, IWorkerView
    {
        public WorkerView()
        {
            InitializeComponent();
            AssosiateAndRaiseViewEvents();
        }

        private void AssosiateAndRaiseViewEvents()
        {
            name_textBox.Text = "";
            add_button.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                if (name_textBox.Text != "" && surname_textBox.Text != "" &&
                    salary_numericUpDown.Text != "0" && position_comboBox.Text != "")
                {
                    listBox.Items.Add(Name + " " + Surname + ", " + date_TimePicker.Text.Trim() + ", " + Convert.ToInt32(Salary) + " PLN, " + Position + ", " + Contract);
                }
                else
                {
                    NameValidated(null, null);
                    SurnameValidated(null, null);
                    SalaryValidated(null, null);
                    PositionValidated(null, null);
                }
            };

            remove_button.Click += delegate
            {
                RemoveEvent?.Invoke(this, EventArgs.Empty);
                if (listBox.SelectedIndex >= 0)
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
            };

            save_button.Click += delegate
            {

                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (listBox.Items.Count == 0)
                    return;

                var path = SaveButtonMessagebox();

                if (path == "")
                    return;

                XDocument document = new XDocument(new XElement("Pracownicy"));

                foreach (var i in listBox.Items)
                {
                    XElement root = new XElement("Pracownik");
                    string[] arr = i.ToString().Split(',');
                    string[] nameSurname = arr[0].Split(' ');
                    string[] date = arr[1].Split('.');
                    int day = int.Parse(date[0]);
                    int month = int.Parse(date[1]);
                    int year = int.Parse(date[2]);
                    string salary = arr[2].Split(' ')[1];
                    string name = "";
                    for (int j = 0; j < nameSurname.Length - 1; j++)
                        name += nameSurname[j];

                    date_TimePicker.Value = new DateTime(year, month, day);
                    string date1 = day.ToString() + '.' + month.ToString() + '.' + year.ToString();
                    int position = position_comboBox.Items.IndexOf(arr[3].Trim());
                    position_comboBox.SelectedIndex = position;
                    int salary1 = int.Parse(salary);
                    salary_numericUpDown.Value = salary1;
                    root.Add(new XElement("Imie", name));
                    root.Add(new XElement("Nazwisko", nameSurname[nameSurname.Length - 1]));
                    root.Add(new XElement("Data", date1));
                    root.Add(new XElement("Stanowisko", position_comboBox.SelectedItem));
                    root.Add(new XElement("Zarobki", salary1));
                    if (arr[arr.Length - 1] == " Umowa na czas nieokreślony")
                        root.Add(new XElement("Umowa", "Umowa na czas nieokreślony"));
                    else if (arr[arr.Length - 1] == " Umowa na czas określony")
                        root.Add(new XElement("Umowa", "Umowa na czas określony"));
                    else
                        root.Add(new XElement("Umowa", "Umowa zlecenie"));
                    document.Element("Pracownicy")?.Add(root);
                }
                document.Save(path);
            };

            load_button.Click += delegate
            {
                LoadEvent?.Invoke(this, EventArgs.Empty);
                var path = LoadButtonMessagebox();

                if (path == "")
                    return;

                listBox.Items.Clear();

                XmlTextReader reader = new XmlTextReader(path);
                string name = "";
                string surname = "";
                string date = "";
                string salary = "";
                string position = "";
                string contract = "";
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name == "Imie")
                            {
                                reader.Read();
                                name = reader.Value;
                            }
                            else if (reader.Name == "Nazwisko")
                            {
                                reader.Read();
                                surname = reader.Value;
                            }
                            else if (reader.Name == "Data")
                            {
                                reader.Read();
                                date = reader.Value;
                            }
                            else if (reader.Name == "Zarobki")
                            {
                                reader.Read();
                                salary = reader.Value;
                            }
                            else if (reader.Name == "Stanowisko")
                            {
                                reader.Read();
                                position = reader.Value;
                            }
                            else if (reader.Name == "Umowa")
                            {
                                reader.Read();
                                contract = reader.Value;
                            }
                            break;

                        case XmlNodeType.EndElement:
                            if (reader.Name == "Umowa")
                            {
                                listBox.Items.Add(name.Trim() + " " + surname.Trim() + ", " + date.Trim() + ", " + Convert.ToInt32(salary.Trim()) + " PLN, " + position.Trim() + ", " + contract.Trim());
                            }
                            break;
                    }
                }
                reader.Close();
            };

            listBox.Click += delegate
            {
                ListBoxEvent?.Invoke(this, EventArgs.Empty);
                if (listBox.SelectedItem == null)
                    return;
                string temp = listBox.SelectedItem.ToString();
                if (temp == "")
                    return;
                string[] arr = temp.Split(',');
                string[] nameSurname = arr[0].Split(' ');
                string[] date = arr[1].Split('.');
                int day = int.Parse(date[0]);
                int month = int.Parse(date[1]);
                int year = int.Parse(date[2]);
                string salary = arr[2].Split(' ')[1];
                string name = "";
                for (int i = 0; i < nameSurname.Length - 1; i++)
                    name += nameSurname[i];

                name_textBox.Text = name;
                surname_textBox.Text = nameSurname[nameSurname.Length - 1];
                date_TimePicker.Value = new DateTime(year, month, day);
                int position = position_comboBox.Items.IndexOf(arr[3].Trim());
                position_comboBox.SelectedIndex = position;
                int salary1 = int.Parse(salary);
                salary_numericUpDown.Value = salary1;
                if (arr[arr.Length - 1] == " Umowa na czas nieokreślony")
                    nieokreslony_radioButton.Checked = true;
                else if (arr[arr.Length - 1] == " Umowa na czas określony")
                    okreslony_radioButton.Checked = true;
                else
                    zlecenie_radioButton.Checked = true;

            };
        }

        private string SaveButtonMessagebox()
        {
            string message, title, defaultValue;
            object myValue;

            message = "Wpisz ścieżkę zapisu pliku xml: \n(np. C:\\Users) \n\nNazwa nowego pliku to: \"workers.xml\"";
            title = "Zapisz";
            defaultValue = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            myValue = Interaction.InputBox(message, title, defaultValue);

            if ((string)myValue == "")
                return "";

            if (Directory.Exists(myValue.ToString()))
            {
                MessageBox.Show("Zapisano pomyślnie w ścieżce: \n" + myValue + @"\workers.xml");
                return @"" + myValue + @"\\workers.xml";
            }
            
            MessageBox.Show("Błędna ścieżka.");
            return "";
        }

        private string LoadButtonMessagebox()
        {
            string message, title, defaultValue;
            object myValue;

            message = "Wpisz ścieżkę lokalizacji pliku xml do odczytu: \n(np. C:\\Users\\plik.xml)";
            title = "Wczytaj";
            defaultValue = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            myValue = Interaction.InputBox(message, title, defaultValue);

            if ((string)myValue == "")
                return "";

            if (File.Exists(myValue.ToString()))
            {
                MessageBox.Show("Pomyślnie wczytano plik.");
                return @"" + myValue;
            }

            MessageBox.Show("Nie znaleziono pliku.");
            return "";
        }

        public new string Name
        { get => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name_textBox.Text.Trim().ToLower());
            set => name_textBox.Text = value; }
        public string Surname
        { get => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(surname_textBox.Text.Trim().ToLower());
            set => surname_textBox.Text = value; }
        public DateTime Date
        { get => date_TimePicker.Value; set => date_TimePicker.Value = value; }
        public decimal Salary
        { get => salary_numericUpDown.Value; set => salary_numericUpDown.Value = value; }
        public string Position
        { get => position_comboBox.Text; set => position_comboBox.Text = value; }
        public string Contract { get => GetContract(); set => SetContract(); }

        private string GetContract()
        {
            if (zlecenie_radioButton.Checked)
                return "Umowa na zlecenie";
            else if (okreslony_radioButton.Checked)
                return "Umowa na czas określony";
            else
                return "Umowa na czas nieokreślony";
        }
        private void SetContract()
        {
            if (GetContract() == "Umowa na zlecenie")
                zlecenie_radioButton.Checked = true;
            else if (GetContract() == "Umowa na czas określony")
                okreslony_radioButton.Checked = true;
            else
                nieokreslony_radioButton.Checked = true;
        }

        public event EventHandler AddEvent;
        public event EventHandler RemoveEvent;
        public event EventHandler SaveEvent;
        public event EventHandler LoadEvent;
        public event EventHandler ListBoxEvent;

        private void NameValidated(object sender, EventArgs e)
        {
            if (name_textBox.Text.Trim().Length == 0)
                ErrorProvider.SetError(name_textBox, "To pole nie może być puste.");
            else if (name_textBox.Text.Any(char.IsDigit))
                ErrorProvider.SetError(name_textBox, "Imię nie może zawierać cyfr.");
            else if (name_textBox.Text.Trim().Any(ch => !char.IsLetter(ch)))
                ErrorProvider.SetError(name_textBox, "Imię nie może zawierać znaków specjalnych.");
            else
                ErrorProvider.SetError(name_textBox, null);
        }

        private void SurnameValidated(object sender, EventArgs e)
        {
            if (surname_textBox.Text.Length == 0)
                ErrorProvider.SetError(surname_textBox, "To pole nie może być puste.");
            else if (surname_textBox.Text.Any(char.IsDigit))
                ErrorProvider.SetError(surname_textBox, "Nazwisko nie może zawierać cyfr.");
            else if (surname_textBox.Text.Trim().Any(ch => !char.IsLetter(ch)))
                ErrorProvider.SetError(surname_textBox, "Nazwisko nie może zawierać znaków specjalnych.");
            else
                ErrorProvider.SetError(surname_textBox, null);
        }

        private void SalaryValidated(object sender, EventArgs e)
        {
            if (salary_numericUpDown.Text == "0")
                ErrorProvider.SetError(salary_numericUpDown, "Zarobki muszą być większe niż 0 PLN.");
            else
                ErrorProvider.SetError(salary_numericUpDown, null);
        }

        private void PositionValidated(object sender, EventArgs e)
        {
            if (position_comboBox.Text.Length == 0)
                ErrorProvider.SetError(position_comboBox, "To pole nie może być puste.");
            else
                ErrorProvider.SetError(position_comboBox, null);
        }
    }
}
