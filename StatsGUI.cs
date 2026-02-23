using System;
using System.IO;
using System.Windows.Forms;

namespace Characterstatgui
{    // Updated for new form, new stats and new classes for Barb, Sorc removed some old code since it no longer need to be here.
    // Change a lot in my statsgui
    public partial class StatsGUI : Form
    {
        // Below will the be example data for the save/load 
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

        // This will save our Save/Load data will save.
        private string saveFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "savegame.txt");
        private string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzlelog.txt");


        // Default constructor 
        public StatsGUI()
        {
            InitializeComponent(); // Loads a GUI from the designer

            MusicManager.PlayMainTheme(); // Plays the same music from theme

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

        // Turns stat buttons on/off depending on remaining points if 0
        private void UpdateStatButtons()
        {
            bool canSpend = points > 0;

            addStrButton.Enabled = canSpend;
            addDexButton.Enabled = canSpend;
            addIntButton.Enabled = canSpend;
            addVitButton.Enabled = canSpend;
            addEnergyButton.Enabled = canSpend;

            MessageBox.Show("Loaded character from savegame.txt!", "Load Complete");

            // Also load and show the log file (FILE #2)
            if (File.Exists(logFilePath))
            {
                string[] logLines = File.ReadAllLines(logFilePath);

                // OPTIONAL: show log in a ListBox if you added one
                if (logListBox != null)
                {
                    logListBox.Items.Clear();
                    foreach (string log in logLines)
                        logListBox.Items.Add(log);
                }
            }
        }



          private void openPuzzleButton_Click(object sender, EventArgs e)
        {
            // Open puzzle form
            using (BrazierPuzzleForm puzzle = new BrazierPuzzleForm())
            {
                puzzle.ShowDialog();   // Pauses StatsGUI until puzzle closes


                // After puzzle closes, get earned stat points
                points += puzzle.EarnedStatPoints;

                UpdateLabels();        // Refresh stat display
                UpdateStatButtons(); // Disables stat buttons
            }
        }

        // saveButton_Cick "SAVE" will write to 2 files when saving
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // FILE #1: this will save character/stats as simple lines of text
                
                string saveText =
                    characterName + "\n" +
                    characterClass + "\n" +
                    points + "\n" +
                    strength + "\n" +
                    dexterity + "\n" +
                    intelligence + "\n" +
                    vitality + "\n" +
                    energy;

                File.WriteAllText(saveFilePath, saveText);

                // FILE #2: Append a log entry it will keep adding lines over times!
                string logLine = DateTime.Now.ToString() + " - Saved character.\n";
                File.AppendAllText(logFilePath, logLine);

                MessageBox.Show("Saved!\n\n" +
                                "savegame.txt + puzzlelog.txt were written.",
                                "Save Complete");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Save failed: No permission to write files here.", "Error");
            }
            catch (IOException)
            {
                MessageBox.Show("Save failed: File is in use or path is invalid.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error");
            }

        }
        // loadButton_Click will load from the read file from save and reads the file log
        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure save file exists before reading
                if (!File.Exists(saveFilePath))
                {
                    MessageBox.Show("No savegame.txt found yet. Click Save first.", "Load");
                    return;
                }

                // Read all lines from savegame.txt
                string[] lines = File.ReadAllLines(saveFilePath);

                // Expected format = 8 lines
                // (we validate so we don't crash if file is edited or corrupted)
                if (lines.Length < 8)
                {
                    MessageBox.Show("Save file is missing data (corrupted or edited).", "Load Error");
                    return;
                }

                // Load data back into variables
                characterName = lines[0];
                characterClass = lines[1];

                points = int.Parse(lines[2]);
                strength = int.Parse(lines[3]);
                dexterity = int.Parse(lines[4]);
                intelligence = int.Parse(lines[5]);
                vitality = int.Parse(lines[6]);
                energy = int.Parse(lines[7]);

                // Update UI labels after loading
                UpdateLabels();
                UpdateStatButtons();

                MessageBox.Show("Loaded character from savegame.txt!", "Load Complete");

                // FILE #2: read log and show it
                if (File.Exists(logFilePath))
                {
                    string logText = File.ReadAllText(logFilePath);

                    if (string.IsNullOrWhiteSpace(logText))
                        logText = "(Log is empty.)";

                    MessageBox.Show(logText, "Puzzle Log");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Load failed: Save file contains invalid numbers.", "Error");
            }
            catch (IOException)
            {
                MessageBox.Show("Load failed: File is in use or unreadable.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed: " + ex.Message, "Error");
            }
        }
    }
}

