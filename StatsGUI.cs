using System;
using System.Windows.Forms;

namespace Characterstatgui
{    // Updated for functions/args for assigment added DEX, INT and a class dropComboBox to choose either Barb or Sorc
    public partial class StatsGUI : Form
    {
        // Stores how many points a player can spend
        int points = 5;
        // Stores the players strength, dexterity or intelligence
        int strength = 0;
        int dexterity = 0;
        int intelligence = 0;
        // Stores the characters class
        string characterClass = "";
        // Checks if a character has been created
        bool characterCreated = false;

        // This is our constructor, runs the when the form is first created
        public StatsGUI()
        {
            InitializeComponent(); // Loads a GUI from the designer
            UpdateLabels(); // displays the starting value on the form
            infoLabel.Text = "Enter name + class, then spend points."; // New label explains to enter name,class and points
        }

        // When clicked it runs the ADD either points to STR, DEX or INT
        private void addStrButton_Click(object sender, EventArgs e)
        {
            HandleStatAdd("STR");
        }
        private void addDexButton_Click(object sender, EventArgs e)
        {
            HandleStatAdd("DEX");
        }
        private void addIntButton_Click(object sender, EventArgs e)
        {
            HandleStatAdd("INT");
        }

        // Reset button will reset all the stats that are allocated into either STR, DEX, INT name, class
        private void resetButton_Click(object sender, EventArgs e)
        {
            points = GetStartingPoints(""); // default points
            strength = 0;
            dexterity = 0;
            intelligence = 0;
            characterClass = "";
            characterCreated = false;

            nameTextBox.Text = "";
            // ComboBox reset: clear selection
            classComboBox.SelectedIndex = -1;

            infoLabel.Text = "Reset complete.";
            UpdateLabels();
        }

        // Class text has changed to comboDropBox
        // Runs when the user picks Barbarian or Sorceress from the drop down
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected class text from the ComboBox
            string cls = classComboBox.SelectedItem?.ToString() ?? "";

            points = GetStartingPoints(cls);
            infoLabel.Text = "Class set. Starting points updated.";
            UpdateLabels();
        }

        // Below are the custom function for parameters + non-void return types

        // Returns bool checks if inputs are filled in
        private bool IsInputValid(string name, string cls) //  New function(1) Bool for name and class check
        {
            return name != "" && cls != "";
        }

        // Returns bool checks if points are available
        private bool CanSpendPoint(int currentPoints) // New function(2) bool check if can spend skill points
        {
            return currentPoints > 0;
        }

        // Returns (int,int) generic stat allocation spend 1 point, add 1 stat
        private (int newPoints, int newStat) AllocateStat(int currentPoints, int currentStat)
        {
            int newPoints = currentPoints - 1;
            int newStat = currentStat + 1;
            return (newPoints, newStat);
        }

        // Returns int starting points based on class text
        private int GetStartingPoints(string cls) // New function(3) checks which class is chosen with additional points
        {
            string c = cls.ToLower();

            if (c == "barbarian") return 7;
            else if (c == "sorceress") return 6;
            else return 5;
        }

        // Returns string builds label text nice and simple as it should be
        private string MakeStatText(string statName, int value) // New function(4) checks stat name and value being added to a stat
        {
            return statName + ": " + value;
        }

        // Updated my helper that runs when any + button is clicked
        private void HandleStatAdd(string statCode)
        {
            string name = nameTextBox.Text;

            // Get class from ComboBox instead of TextBox
            string cls = classComboBox.SelectedItem?.ToString() ?? "";

            // Conditional set validate input
            if (IsInputValid(name, cls) == false)
            {
                infoLabel.Text = "Please enter a Name and Class first.";
                return;
            }
            else
            {
                characterCreated = true;
                characterClass = cls;
            }

            // Conditional set check points
            if (CanSpendPoint(points) == true)
            {
                if (statCode == "STR")
                {
                    (points, strength) = AllocateStat(points, strength);
                    infoLabel.Text = "Added 1 Strength.";
                }
                else if (statCode == "DEX")
                {
                    (points, dexterity) = AllocateStat(points, dexterity);
                    infoLabel.Text = "Added 1 Dexterity.";
                }
                else if (statCode == "INT")
                {
                    (points, intelligence) = AllocateStat(points, intelligence);
                    infoLabel.Text = "Added 1 Intelligence.";
                }

                UpdateLabels();
            }
            else
            {
                infoLabel.Text = "No points left!";
            }
        }

        // Updates labels so values show on the form 
        private void UpdateLabels()
        {
            pointsLabel.Text = MakeStatText("Points", points);
            strLabel.Text = MakeStatText("Strength", strength);
            dexLabel.Text = MakeStatText("Dexterity", dexterity);
            intLabel.Text = MakeStatText("Intelligence", intelligence);
        }
    }
}

