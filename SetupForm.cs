using System;
using System.Windows.Forms;

namespace Characterstatgui
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();

            startButton.Enabled = false;
            infoLabel.Text = "Enter a name and choose a class.";
        
            MusicManager.PlayMainTheme();   // Main music starts here

            startButton.Enabled = false;
            infoLabel.Text = "Enter a name and choose a class.";
        }

        // Runs when name or class changes
        private void InputsChanged(object sender, EventArgs e)
        {
            bool hasName = nameTextBox.Text.Trim() != "";
            bool hasClass = classComboBox.SelectedIndex != -1;

            if (hasName && hasClass)
                startButton.Enabled = true;
            else
                startButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                CharacterData data = BuildCharacter(
                    nameTextBox.Text,
                    classComboBox.SelectedItem?.ToString() ?? ""
                );

                StatsGUI statsForm = new StatsGUI(data);
                statsForm.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                infoLabel.Text = ex.Message;
            }
            catch (InvalidOperationException ex)
            {
                infoLabel.Text = ex.Message;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            bool cleared = ClearInputs(true);

            if (cleared)
                infoLabel.Text = "Cleared. Enter a name and choose a class.";
        }

        // Builds character object
        private CharacterData BuildCharacter(string name, string cls)
        {
            if (name.Trim() == "")
                throw new ArgumentException("Name cannot be empty.");

            if (cls.Trim() == "")
                throw new InvalidOperationException("You must choose a class.");

            CharacterClass chosenClass;

            if (cls == "Barbarian")
                chosenClass = new Barbarian();
            else
                chosenClass = new Sorceress();

            return new CharacterData(name, chosenClass);
        }

        // Clears inputs (includes loop)
        private bool ClearInputs(bool resetClass)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                    tb.Text = "";
            }

            if (resetClass)
                classComboBox.SelectedIndex = -1;

            startButton.Enabled = false;
            return true;
        }
    }
}

