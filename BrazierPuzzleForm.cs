using System;
using System.Drawing;
using System.Windows.Forms;

namespace Characterstatgui
{
    // Took my brazier puzzle from old Unity game and converted it work in WindowsForms
    public partial class BrazierPuzzleForm : Form
    {
        // This is my puzzle data ARRAY requirement it contains everything to ensure the puzzle works
        private int[] correctOrder = new int[] { 2, 5, 3, 1, 0, 7, 6, 4 }; // correct sequence
        private bool[] isLit = new bool[8]; // bool array tracks each brazier lit/unlit

        // Tracks the progress of the user 
        private int currentStep = 0;

        // Starting XP and required XP to level up
        private int xp = 0;
        private int xpToLevel = 100; // 100 XP = level up

        // This is how we reward StatsGUI we pass points back
        public int EarnedStatPoints { get; private set; } = 0;

        // Keep buttons in an array for easy updates
        private Button[] brazierButtons;

        public BrazierPuzzleForm()
        {
            InitializeComponent();

            hintLabel.Text = riddleHint;   // hintLabel.Text = riddleHint


            MusicManager.PlayPuzzleTheme();

            // Puts my brazier buttons into an array so we can loop them
            brazierButtons = new Button[]
            {
                brazier0Button, brazier1Button, brazier2Button, brazier3Button,
                brazier4Button, brazier5Button, brazier6Button, brazier7Button,
            };


            UpdateUI();


        }

        // Click Events for each brazier button
        private void brazier0Button_Click(object sender, EventArgs e) => OnBrazierLit(0);
        private void brazier1Button_Click(object sender, EventArgs e) => OnBrazierLit(1);
        private void brazier2Button_Click(object sender, EventArgs e) => OnBrazierLit(2);
        private void brazier3Button_Click(object sender, EventArgs e) => OnBrazierLit(3);
        private void brazier4Button_Click(object sender, EventArgs e) => OnBrazierLit(4);
        private void brazier5Button_Click(object sender, EventArgs e) => OnBrazierLit(5);
        private void brazier6Button_Click(object sender, EventArgs e) => OnBrazierLit(6);
        private void brazier7Button_Click(object sender, EventArgs e) => OnBrazierLit(7);

        // Reset button
        private void resetPuzzleButton_Click(object sender, EventArgs e)
        {
            ResetPuzzle("Puzzle reset.");
        }

        // Riddle hint shown to player
        private string riddleHint =
        "Eight flames whisper in silence...\n" +
        "The third flame wakes the circle.\n" +
        "Then the sixth answers the call.\n" +
        "Followed by the fourth, then second.\n" +
        "The first remembers.\n" +
        "The eighth listens.\n" +
        "The seventh waits.\n" +
        "And finally... the fifth burns bright.";






        // This is the main puzzle logic converted to a Winforms version using my Unity game logic

        private void OnBrazierLit(int brazierIndex)
        {
            // If user clicked the correct brazier for this step
            if (correctOrder[currentStep] == brazierIndex)
            {
                isLit[brazierIndex] = true; // mark lit
                currentStep++;              // move to next step

                // If finished all steps -> solved!
                if (currentStep == correctOrder.Length)
                {
                    UnlockDoor(); // just like Unity but UI message will appear
                }
                else
                {
                    puzzleInfoLabel.Text = $"Correct! Next step: {currentStep + 1}/{correctOrder.Length}";
                }
            }
            else
            {
                ResetPuzzle("Wrong brazier! Puzzle reset.");
            }

            UpdateUI();
        }

        // Called when puzzle is solved
        private void UnlockDoor()
        {
            foreach (Button b in brazierButtons)
            {
                b.Enabled = false;
            }

            puzzleInfoLabel.Text = "Puzzle solved! +100 XP";
            AddXP(100);

            // Enable the return button only after correct sequence
            returnToStatsButton.Enabled = true;
        }

        // Closes the puzzleform
        private void returnToStatsButton_Click(object sender, EventArgs e)
        {
            MusicManager.PlayMainTheme();
            this.Close(); // closes puzzle form
        }

        // Resets puzzle progress
        private void ResetPuzzle(string message)
        {
            currentStep = 0;

            // Turn all braziers off
            for (int i = 0; i < isLit.Length; i++)
            {
                isLit[i] = false;
            }

            puzzleInfoLabel.Text = message;
            UpdateUI();
        }


        // XP + Level Up Reward when user gets the correct sequence

        private void AddXP(int amount)
        {
            xp += amount;

            // if/else + loop requirement
            // If we have enough XP, level up can level multiple times
            while (xp >= xpToLevel)
            {
                xp -= xpToLevel;
                LevelUp();
            }

            UpdateUI();
        }

        private void LevelUp()
        {
            // +5 stat points to spend in StatsGUI
            EarnedStatPoints += 5;

            MessageBox.Show("LEVEL UP! You earned +5 stat points to spend!", "Level Up");
        }


        // Updates button colors and labels
        private void UpdateUI()
        {
            for (int i = 0; i < brazierButtons.Length; i++)
            {
                int displayNumber = i + 1; // convert 0-7 into 1-8

                brazierButtons[i].BackColor =
                    isLit[i] ? Color.OrangeRed : Color.DarkGray;

                brazierButtons[i].Text =
                    isLit[i]
                    ? $"Brazier {displayNumber} (Lit)"
                    : $"Brazier {displayNumber}";
            }

            xpLabel.Text = $"XP: {xp}/{xpToLevel}";
            earnedPointsLabel.Text = $"Earned Stat Points: {EarnedStatPoints}";
        }
    }
}

