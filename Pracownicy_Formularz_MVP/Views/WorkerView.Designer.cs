namespace Pracownicy_MVP.Views
{
    partial class WorkerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dane_GroupBox = new System.Windows.Forms.GroupBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.zlecenie_radioButton = new System.Windows.Forms.RadioButton();
            this.okreslony_radioButton = new System.Windows.Forms.RadioButton();
            this.nieokreslony_radioButton = new System.Windows.Forms.RadioButton();
            this.position_comboBox = new System.Windows.Forms.ComboBox();
            this.salary_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.date_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.rodzajUmowy_label = new System.Windows.Forms.Label();
            this.stanowisko_label = new System.Windows.Forms.Label();
            this.pensja_label = new System.Windows.Forms.Label();
            this.dataUrodzenia_label = new System.Windows.Forms.Label();
            this.nazwisko_label = new System.Windows.Forms.Label();
            this.imie_label = new System.Windows.Forms.Label();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.zapiszWczytaj_groupBox = new System.Windows.Forms.GroupBox();
            this.load_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dane_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_numericUpDown)).BeginInit();
            this.zapiszWczytaj_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dane_GroupBox
            // 
            this.dane_GroupBox.Controls.Add(this.remove_button);
            this.dane_GroupBox.Controls.Add(this.add_button);
            this.dane_GroupBox.Controls.Add(this.zlecenie_radioButton);
            this.dane_GroupBox.Controls.Add(this.okreslony_radioButton);
            this.dane_GroupBox.Controls.Add(this.nieokreslony_radioButton);
            this.dane_GroupBox.Controls.Add(this.position_comboBox);
            this.dane_GroupBox.Controls.Add(this.salary_numericUpDown);
            this.dane_GroupBox.Controls.Add(this.date_TimePicker);
            this.dane_GroupBox.Controls.Add(this.rodzajUmowy_label);
            this.dane_GroupBox.Controls.Add(this.stanowisko_label);
            this.dane_GroupBox.Controls.Add(this.pensja_label);
            this.dane_GroupBox.Controls.Add(this.dataUrodzenia_label);
            this.dane_GroupBox.Controls.Add(this.nazwisko_label);
            this.dane_GroupBox.Controls.Add(this.imie_label);
            this.dane_GroupBox.Controls.Add(this.surname_textBox);
            this.dane_GroupBox.Controls.Add(this.name_textBox);
            this.dane_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dane_GroupBox.Location = new System.Drawing.Point(9, 10);
            this.dane_GroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.dane_GroupBox.Name = "dane_GroupBox";
            this.dane_GroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.dane_GroupBox.Size = new System.Drawing.Size(304, 362);
            this.dane_GroupBox.TabIndex = 0;
            this.dane_GroupBox.TabStop = false;
            this.dane_GroupBox.Text = "Dane pracownika";
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(15, 321);
            this.remove_button.Margin = new System.Windows.Forms.Padding(2);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(275, 28);
            this.remove_button.TabIndex = 10;
            this.remove_button.Text = "Usuń";
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(15, 282);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(275, 28);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Dodaj";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // zlecenie_radioButton
            // 
            this.zlecenie_radioButton.AutoSize = true;
            this.zlecenie_radioButton.Location = new System.Drawing.Point(114, 252);
            this.zlecenie_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.zlecenie_radioButton.Name = "zlecenie_radioButton";
            this.zlecenie_radioButton.Size = new System.Drawing.Size(115, 19);
            this.zlecenie_radioButton.TabIndex = 8;
            this.zlecenie_radioButton.TabStop = true;
            this.zlecenie_radioButton.Text = "umowa zlecenie";
            this.zlecenie_radioButton.UseVisualStyleBackColor = true;
            // 
            // okreslony_radioButton
            // 
            this.okreslony_radioButton.AutoSize = true;
            this.okreslony_radioButton.Location = new System.Drawing.Point(114, 229);
            this.okreslony_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.okreslony_radioButton.Name = "okreslony_radioButton";
            this.okreslony_radioButton.Size = new System.Drawing.Size(166, 19);
            this.okreslony_radioButton.TabIndex = 7;
            this.okreslony_radioButton.TabStop = true;
            this.okreslony_radioButton.Text = "umowa na czas określony";
            this.okreslony_radioButton.UseVisualStyleBackColor = true;
            // 
            // nieokreslony_radioButton
            // 
            this.nieokreslony_radioButton.AutoSize = true;
            this.nieokreslony_radioButton.Checked = true;
            this.nieokreslony_radioButton.Location = new System.Drawing.Point(114, 206);
            this.nieokreslony_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.nieokreslony_radioButton.Name = "nieokreslony_radioButton";
            this.nieokreslony_radioButton.Size = new System.Drawing.Size(183, 19);
            this.nieokreslony_radioButton.TabIndex = 6;
            this.nieokreslony_radioButton.TabStop = true;
            this.nieokreslony_radioButton.Text = "umowa na czas nieokreślony";
            this.nieokreslony_radioButton.UseVisualStyleBackColor = true;
            // 
            // position_comboBox
            // 
            this.position_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position_comboBox.FormattingEnabled = true;
            this.position_comboBox.Items.AddRange(new object[] {
            "Tester",
            "Projektant",
            "Inżynier",
            "Młodszy Programista",
            "Starszy Programista"});
            this.position_comboBox.Location = new System.Drawing.Point(114, 165);
            this.position_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.position_comboBox.Name = "position_comboBox";
            this.position_comboBox.Size = new System.Drawing.Size(166, 23);
            this.position_comboBox.TabIndex = 5;
            this.position_comboBox.Validated += new System.EventHandler(this.PositionValidated);
            // 
            // salary_numericUpDown
            // 
            this.salary_numericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.salary_numericUpDown.Location = new System.Drawing.Point(114, 131);
            this.salary_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.salary_numericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.salary_numericUpDown.Name = "salary_numericUpDown";
            this.salary_numericUpDown.Size = new System.Drawing.Size(93, 21);
            this.salary_numericUpDown.TabIndex = 4;
            this.salary_numericUpDown.ThousandsSeparator = true;
            this.salary_numericUpDown.Validated += new System.EventHandler(this.SalaryValidated);
            // 
            // date_TimePicker
            // 
            this.date_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_TimePicker.Location = new System.Drawing.Point(114, 96);
            this.date_TimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.date_TimePicker.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.date_TimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date_TimePicker.Name = "date_TimePicker";
            this.date_TimePicker.Size = new System.Drawing.Size(93, 21);
            this.date_TimePicker.TabIndex = 3;
            this.date_TimePicker.Value = new System.DateTime(2023, 4, 3, 14, 40, 2, 0);
            // 
            // rodzajUmowy_label
            // 
            this.rodzajUmowy_label.AutoSize = true;
            this.rodzajUmowy_label.Location = new System.Drawing.Point(12, 206);
            this.rodzajUmowy_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rodzajUmowy_label.Name = "rodzajUmowy_label";
            this.rodzajUmowy_label.Size = new System.Drawing.Size(91, 15);
            this.rodzajUmowy_label.TabIndex = 1;
            this.rodzajUmowy_label.Text = "Rodzaj umowy:";
            // 
            // stanowisko_label
            // 
            this.stanowisko_label.AutoSize = true;
            this.stanowisko_label.Location = new System.Drawing.Point(12, 171);
            this.stanowisko_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stanowisko_label.Name = "stanowisko_label";
            this.stanowisko_label.Size = new System.Drawing.Size(73, 15);
            this.stanowisko_label.TabIndex = 1;
            this.stanowisko_label.Text = "Stanowisko:";
            // 
            // pensja_label
            // 
            this.pensja_label.AutoSize = true;
            this.pensja_label.Location = new System.Drawing.Point(12, 136);
            this.pensja_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pensja_label.Name = "pensja_label";
            this.pensja_label.Size = new System.Drawing.Size(48, 15);
            this.pensja_label.TabIndex = 1;
            this.pensja_label.Text = "Pensja:";
            // 
            // dataUrodzenia_label
            // 
            this.dataUrodzenia_label.AutoSize = true;
            this.dataUrodzenia_label.Location = new System.Drawing.Point(12, 100);
            this.dataUrodzenia_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataUrodzenia_label.Name = "dataUrodzenia_label";
            this.dataUrodzenia_label.Size = new System.Drawing.Size(94, 15);
            this.dataUrodzenia_label.TabIndex = 1;
            this.dataUrodzenia_label.Text = "Data urodzenia:";
            // 
            // nazwisko_label
            // 
            this.nazwisko_label.AutoSize = true;
            this.nazwisko_label.Location = new System.Drawing.Point(12, 65);
            this.nazwisko_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nazwisko_label.Name = "nazwisko_label";
            this.nazwisko_label.Size = new System.Drawing.Size(63, 15);
            this.nazwisko_label.TabIndex = 1;
            this.nazwisko_label.Text = "Nazwisko:";
            // 
            // imie_label
            // 
            this.imie_label.AutoSize = true;
            this.imie_label.Location = new System.Drawing.Point(12, 33);
            this.imie_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imie_label.Name = "imie_label";
            this.imie_label.Size = new System.Drawing.Size(34, 15);
            this.imie_label.TabIndex = 1;
            this.imie_label.Text = "Imię:";
            // 
            // surname_textBox
            // 
            this.surname_textBox.Location = new System.Drawing.Point(114, 63);
            this.surname_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(166, 21);
            this.surname_textBox.TabIndex = 2;
            this.surname_textBox.Validated += new System.EventHandler(this.SurnameValidated);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(114, 31);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(166, 21);
            this.name_textBox.TabIndex = 1;
            this.name_textBox.Validated += new System.EventHandler(this.NameValidated);
            // 
            // zapiszWczytaj_groupBox
            // 
            this.zapiszWczytaj_groupBox.Controls.Add(this.load_button);
            this.zapiszWczytaj_groupBox.Controls.Add(this.save_button);
            this.zapiszWczytaj_groupBox.Location = new System.Drawing.Point(9, 373);
            this.zapiszWczytaj_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.zapiszWczytaj_groupBox.Name = "zapiszWczytaj_groupBox";
            this.zapiszWczytaj_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.zapiszWczytaj_groupBox.Size = new System.Drawing.Size(304, 59);
            this.zapiszWczytaj_groupBox.TabIndex = 1;
            this.zapiszWczytaj_groupBox.TabStop = false;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(155, 17);
            this.load_button.Margin = new System.Windows.Forms.Padding(2);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(134, 28);
            this.load_button.TabIndex = 12;
            this.load_button.Text = "Wczytaj";
            this.load_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(14, 17);
            this.save_button.Margin = new System.Windows.Forms.Padding(2);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(134, 28);
            this.save_button.TabIndex = 11;
            this.save_button.Text = "Zapisz";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(317, 17);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(493, 420);
            this.listBox.TabIndex = 13;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // WorkerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(820, 444);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.zapiszWczytaj_groupBox);
            this.Controls.Add(this.dane_GroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 483);
            this.MinimumSize = new System.Drawing.Size(836, 483);
            this.Name = "WorkerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pracownicy by Paweł Kasztura";
            this.dane_GroupBox.ResumeLayout(false);
            this.dane_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_numericUpDown)).EndInit();
            this.zapiszWczytaj_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dane_GroupBox;
        private System.Windows.Forms.Label imie_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label dataUrodzenia_label;
        private System.Windows.Forms.Label nazwisko_label;
        private System.Windows.Forms.TextBox surname_textBox;
        private System.Windows.Forms.DateTimePicker date_TimePicker;
        private System.Windows.Forms.Label pensja_label;
        private System.Windows.Forms.NumericUpDown salary_numericUpDown;
        private System.Windows.Forms.ComboBox position_comboBox;
        private System.Windows.Forms.Label stanowisko_label;
        private System.Windows.Forms.RadioButton nieokreslony_radioButton;
        private System.Windows.Forms.Label rodzajUmowy_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.RadioButton zlecenie_radioButton;
        private System.Windows.Forms.RadioButton okreslony_radioButton;
        private System.Windows.Forms.GroupBox zapiszWczytaj_groupBox;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}

