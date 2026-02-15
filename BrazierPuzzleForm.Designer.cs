namespace Characterstatgui
{
    partial class BrazierPuzzleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrazierPuzzleForm));
            brazier0Button = new Button();
            brazier1Button = new Button();
            brazier2Button = new Button();
            brazier3Button = new Button();
            brazier4Button = new Button();
            brazier5Button = new Button();
            brazier6Button = new Button();
            brazier7Button = new Button();
            puzzleInfoLabel = new Label();
            xpLabel = new Label();
            resetPuzzleButton = new Button();
            earnedPointsLabel = new Label();
            returnToStatsButton = new Button();
            hintLabel = new Label();
            SuspendLayout();
            // 
            // brazier0Button
            // 
            brazier0Button.Location = new Point(669, 342);
            brazier0Button.Name = "brazier0Button";
            brazier0Button.Size = new Size(75, 23);
            brazier0Button.TabIndex = 0;
            brazier0Button.Text = "Brazier 1";
            brazier0Button.UseVisualStyleBackColor = true;
            brazier0Button.Click += brazier0Button_Click;
            // 
            // brazier1Button
            // 
            brazier1Button.Location = new Point(106, 244);
            brazier1Button.Name = "brazier1Button";
            brazier1Button.Size = new Size(75, 23);
            brazier1Button.TabIndex = 1;
            brazier1Button.Text = "Brazier 2";
            brazier1Button.UseVisualStyleBackColor = true;
            brazier1Button.Click += brazier1Button_Click;
            // 
            // brazier2Button
            // 
            brazier2Button.Location = new Point(360, 366);
            brazier2Button.Name = "brazier2Button";
            brazier2Button.Size = new Size(75, 23);
            brazier2Button.TabIndex = 2;
            brazier2Button.Text = "Brazier 3";
            brazier2Button.UseVisualStyleBackColor = true;
            brazier2Button.Click += brazier2Button_Click;
            // 
            // brazier3Button
            // 
            brazier3Button.Location = new Point(226, 219);
            brazier3Button.Name = "brazier3Button";
            brazier3Button.Size = new Size(75, 23);
            brazier3Button.TabIndex = 3;
            brazier3Button.Text = "Brazier 4";
            brazier3Button.UseVisualStyleBackColor = true;
            brazier3Button.Click += brazier3Button_Click;
            // 
            // brazier4Button
            // 
            brazier4Button.Location = new Point(57, 342);
            brazier4Button.Name = "brazier4Button";
            brazier4Button.Size = new Size(75, 23);
            brazier4Button.TabIndex = 4;
            brazier4Button.Text = "Brazier 5";
            brazier4Button.UseVisualStyleBackColor = true;
            brazier4Button.Click += brazier4Button_Click;
            // 
            // brazier5Button
            // 
            brazier5Button.Location = new Point(500, 219);
            brazier5Button.Name = "brazier5Button";
            brazier5Button.Size = new Size(75, 23);
            brazier5Button.TabIndex = 5;
            brazier5Button.Text = "Brazier 6";
            brazier5Button.UseVisualStyleBackColor = true;
            brazier5Button.Click += brazier5Button_Click;
            // 
            // brazier6Button
            // 
            brazier6Button.Location = new Point(360, 162);
            brazier6Button.Name = "brazier6Button";
            brazier6Button.Size = new Size(75, 23);
            brazier6Button.TabIndex = 6;
            brazier6Button.Text = "Brazier 7";
            brazier6Button.UseVisualStyleBackColor = true;
            brazier6Button.Click += brazier6Button_Click;
            // 
            // brazier7Button
            // 
            brazier7Button.Location = new Point(625, 244);
            brazier7Button.Name = "brazier7Button";
            brazier7Button.Size = new Size(75, 23);
            brazier7Button.TabIndex = 7;
            brazier7Button.Text = "Brazier 8";
            brazier7Button.UseVisualStyleBackColor = true;
            brazier7Button.Click += brazier7Button_Click;
            // 
            // puzzleInfoLabel
            // 
            puzzleInfoLabel.AutoSize = true;
            puzzleInfoLabel.Location = new Point(374, 9);
            puzzleInfoLabel.Name = "puzzleInfoLabel";
            puzzleInfoLabel.Size = new Size(50, 15);
            puzzleInfoLabel.TabIndex = 9;
            puzzleInfoLabel.Text = "Step 1/8";
            // 
            // xpLabel
            // 
            xpLabel.AutoSize = true;
            xpLabel.Location = new Point(723, 9);
            xpLabel.Name = "xpLabel";
            xpLabel.Size = new Size(53, 15);
            xpLabel.TabIndex = 10;
            xpLabel.Text = "XP:0/100";
            // 
            // resetPuzzleButton
            // 
            resetPuzzleButton.Location = new Point(12, 424);
            resetPuzzleButton.Name = "resetPuzzleButton";
            resetPuzzleButton.Size = new Size(75, 23);
            resetPuzzleButton.TabIndex = 11;
            resetPuzzleButton.Text = "Reset";
            resetPuzzleButton.UseVisualStyleBackColor = true;
            resetPuzzleButton.Click += resetPuzzleButton_Click;
            // 
            // earnedPointsLabel
            // 
            earnedPointsLabel.AutoSize = true;
            earnedPointsLabel.Location = new Point(625, 9);
            earnedPointsLabel.Name = "earnedPointsLabel";
            earnedPointsLabel.Size = new Size(79, 15);
            earnedPointsLabel.TabIndex = 12;
            earnedPointsLabel.Text = "Points Earned";
            // 
            // returnToStatsButton
            // 
            returnToStatsButton.Location = new Point(658, 27);
            returnToStatsButton.Name = "returnToStatsButton";
            returnToStatsButton.Size = new Size(109, 23);
            returnToStatsButton.TabIndex = 13;
            returnToStatsButton.Text = "Return to Stats";
            returnToStatsButton.UseVisualStyleBackColor = true;
            returnToStatsButton.Click += returnToStatsButton_Click;
            // 
            // hintLabel
            // 
            hintLabel.BackColor = Color.Transparent;
            hintLabel.ForeColor = Color.Gold;
            hintLabel.Location = new Point(2, 2);
            hintLabel.Name = "hintLabel";
            hintLabel.Size = new Size(226, 183);
            hintLabel.TabIndex = 14;
            // 
            // BrazierPuzzleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.BrazierPuzzleBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(hintLabel);
            Controls.Add(returnToStatsButton);
            Controls.Add(earnedPointsLabel);
            Controls.Add(resetPuzzleButton);
            Controls.Add(xpLabel);
            Controls.Add(puzzleInfoLabel);
            Controls.Add(brazier7Button);
            Controls.Add(brazier6Button);
            Controls.Add(brazier5Button);
            Controls.Add(brazier4Button);
            Controls.Add(brazier3Button);
            Controls.Add(brazier2Button);
            Controls.Add(brazier1Button);
            Controls.Add(brazier0Button);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BrazierPuzzleForm";
            Text = "BrazierPuzzleForm";
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Button brazier0Button;
        private Button brazier1Button;
        private Button brazier2Button;
        private Button brazier3Button;
        private Button brazier4Button;
        private Button brazier5Button;
        private Button brazier6Button;
        private Button brazier7Button;
        private Button brazier8Button;
        private Label puzzleInfoLabel;
        private Label xpLabel;
        private Button resetPuzzleButton;
        private Label earnedPointsLabel;
        private Button returnToStatsButton;
        private Label hintLabel;
    }
}