using System;
using System.Windows.Forms;

namespace Characterstatgui
{    // Updated for new form, new stats and new classes for Barb, Sorc removed some old code since it no longer need to be here.
    // Change a lot in my statsgui
    public partial class StatsGUI : Form
    {
        // Stores how many points a player can spend
        int points = 5;
        int strength = 0;
        int dexterity = 0;
        int intelligence = 0;
        int vitality = 0;
        int energy = 0;

        // Stores the characters class
        string characterClass = "";
        // Checks if a character has been created
        bool characterCreated = false;
        string characterName = "";

        // Default constructor (optional)
        public StatsGUI()
        {
            InitializeComponent(); // Loads a GUI from the designer
            UpdateLabels(); // displays the starting value on the form
            infoLabel.Text = "Loaded stats screen.";
        }

        // Constructor used when SetupForm passes data into this form
        public StatsGUI(CharacterData data)
        {
            InitializeComponent(); // Loads a GUI from the designer

            // Load character data from SetupForm into this form
            characterName = data.Name;
            characterClass = data.ClassInfo.ClassName;
            characterCreated = true;

            // Load starting stats/points
            points = data.Points;
            strength = data.Strength;
            dexterity = data.Dexterity;
            intelligence = data.Intelligence;
            vitality = data.Vitality;
            energy = data.Energy;

            infoLabel.Text = $"Loaded {characterName} ({characterClass}). Spend points!";
            UpdateLabels(); // displays values on the form
        }

        // When clicked it runs the ADD points to STR, DEX, INT, VIT, or ENG
        private void addStrButton_Click(object sender, EventArgs e) { HandleStatAdd("STR"); }
        private void addDexButton_Click(object sender, EventArgs e) { HandleStatAdd("DEX"); }
        private void addIntButton_Click(object sender, EventArgs e) { HandleStatAdd("INT"); }
        private void addVitButton_Click(object sender, EventArgs e) { HandleStatAdd("VIT"); }
        private void addEnergyButton_Click(object sender, EventArgs e) { HandleStatAdd("ENG"); }

        // Reset button will reset all the stats that are allocated into either STR, DEX, INT, VIT, ENG
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Basic reset back to defaults for this screen
            points = 5;
            strength = 0;
            dexterity = 0;
            intelligence = 0;
            vitality = 0;
            energy = 0;

            infoLabel.Text = "Reset complete.";
            UpdateLabels();
        }

        // Below are the custom function for parameters + non-void return types

        // Returns bool checks if points are available
        private bool CanSpendPoint(int currentPoints) // Bool check if can spend skill points
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

        // Returns string builds label text nice and simple as it should be
        private string MakeStatText(string statName, int value)
        {
            return statName + ": " + value;
        }

        // Helper that runs when any + button is clicked
        private void HandleStatAdd(string statCode)
        {
            // Added try/catch for exception requirement
            try
            {
                if (CanSpendPoint(points))
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
                    else if (statCode == "VIT")
                    {
                        (points, vitality) = AllocateStat(points, vitality);
                        infoLabel.Text = "Added 1 Vitality.";
                    }
                    else if (statCode == "ENG")
                    {
                        (points, energy) = AllocateStat(points, energy);
                        infoLabel.Text = "Added 1 Energy.";
                    }

                    UpdateLabels();
                }
                else
                {
                    throw new InvalidOperationException("No points left!");
                }
            }
            catch (InvalidOperationException ex)
            {
                infoLabel.Text = ex.Message;
            }
        }

        // Updates labels so values show on the form 
        private void UpdateLabels()
        {
            pointsLabel.Text = MakeStatText("Points", points);
            strLabel.Text = MakeStatText("Strength", strength);
            dexLabel.Text = MakeStatText("Dexterity", dexterity);
            intLabel.Text = MakeStatText("Intelligence", intelligence);
            vitLabel.Text = MakeStatText("Vitality", vitality);
            energyLabel.Text = MakeStatText("Energy", energy);
        }
    }
}

