using System;
using System.Windows.Forms;
using System.Drawing;


namespace Characterstatgui
{
    partial class StatsGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsGUI));
            resetButton = new Button();
            pointsLabel = new Label();
            strLabel = new Label();
            addDexButton = new Button();
            addIntButton = new Button();
            dexLabel = new Label();
            intLabel = new Label();
            infoLabel = new Label();
            addVitButton = new Button();
            addEnergyButton = new Button();
            vitLabel = new Label();
            energyLabel = new Label();
            openPuzzleButton = new Button();
            addStrButton = new Button();
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Location = new Point(469, 447);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset Stats";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Location = new Point(457, 110);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(40, 15);
            pointsLabel.TabIndex = 4;
            pointsLabel.Text = "Points";
            // 
            // strLabel
            // 
            strLabel.AutoSize = true;
            strLabel.Location = new Point(369, 204);
            strLabel.Name = "strLabel";
            strLabel.Size = new Size(10, 15);
            strLabel.TabIndex = 5;
            strLabel.Text = ":";
            // 
            // addDexButton
            // 
            addDexButton.BackColor = Color.Black;
            addDexButton.Image = (Image)resources.GetObject("addDexButton.Image");
            addDexButton.Location = new Point(243, 245);
            addDexButton.Name = "addDexButton";
            addDexButton.Size = new Size(120, 40);
            addDexButton.TabIndex = 9;
            addDexButton.UseVisualStyleBackColor = false;
            addDexButton.Click += addDexButton_Click;
            // 
            // addIntButton
            // 
            addIntButton.BackColor = Color.Black;
            addIntButton.Image = (Image)resources.GetObject("addIntButton.Image");
            addIntButton.Location = new Point(243, 287);
            addIntButton.Name = "addIntButton";
            addIntButton.Size = new Size(120, 40);
            addIntButton.TabIndex = 10;
            addIntButton.UseVisualStyleBackColor = false;
            addIntButton.Click += addIntButton_Click;
            // 
            // dexLabel
            // 
            dexLabel.AutoSize = true;
            dexLabel.Location = new Point(369, 258);
            dexLabel.Name = "dexLabel";
            dexLabel.Size = new Size(10, 15);
            dexLabel.TabIndex = 11;
            dexLabel.Text = ":";
            // 
            // intLabel
            // 
            intLabel.AutoSize = true;
            intLabel.Location = new Point(369, 300);
            intLabel.Name = "intLabel";
            intLabel.Size = new Size(10, 15);
            intLabel.TabIndex = 12;
            intLabel.Text = ":";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(496, 473);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(12, 15);
            infoLabel.TabIndex = 13;
            infoLabel.Text = "\"";
            // 
            // addVitButton
            // 
            addVitButton.BackColor = Color.Black;
            addVitButton.BackgroundImageLayout = ImageLayout.None;
            addVitButton.Image = (Image)resources.GetObject("addVitButton.Image");
            addVitButton.Location = new Point(243, 333);
            addVitButton.Name = "addVitButton";
            addVitButton.Size = new Size(120, 40);
            addVitButton.TabIndex = 10;
            addVitButton.UseVisualStyleBackColor = false;
            addVitButton.Click += addVitButton_Click;
            // 
            // addEnergyButton
            // 
            addEnergyButton.BackColor = Color.Black;
            addEnergyButton.Image = (Image)resources.GetObject("addEnergyButton.Image");
            addEnergyButton.Location = new Point(243, 379);
            addEnergyButton.Name = "addEnergyButton";
            addEnergyButton.Size = new Size(120, 40);
            addEnergyButton.TabIndex = 16;
            addEnergyButton.UseVisualStyleBackColor = false;
            addEnergyButton.Click += addEnergyButton_Click;
            // 
            // vitLabel
            // 
            vitLabel.AutoSize = true;
            vitLabel.Location = new Point(369, 346);
            vitLabel.Name = "vitLabel";
            vitLabel.Size = new Size(10, 15);
            vitLabel.TabIndex = 17;
            vitLabel.Text = ":";
            // 
            // energyLabel
            // 
            energyLabel.AutoSize = true;
            energyLabel.Location = new Point(369, 392);
            energyLabel.Name = "energyLabel";
            energyLabel.Size = new Size(10, 15);
            energyLabel.TabIndex = 18;
            energyLabel.Text = ":";
            // 
            // openPuzzleButton
            // 
            openPuzzleButton.Location = new Point(686, 447);
            openPuzzleButton.Name = "openPuzzleButton";
            openPuzzleButton.Size = new Size(87, 23);
            openPuzzleButton.TabIndex = 19;
            openPuzzleButton.Text = "Go to Puzzle";
            openPuzzleButton.UseVisualStyleBackColor = true;
            openPuzzleButton.Click += openPuzzleButton_Click;
            // 
            // addStrButton
            // 
            addStrButton.BackColor = Color.Black;
            addStrButton.Image = (Image)resources.GetObject("addStrButton.Image");
            addStrButton.Location = new Point(243, 197);
            addStrButton.Name = "addStrButton";
            addStrButton.Size = new Size(120, 40);
            addStrButton.TabIndex = 20;
            addStrButton.UseVisualStyleBackColor = false;
            addStrButton.Click += addStrButton_Click;
            // 
            // StatsGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = Properties.Resources.Backgroundstats;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 563);
            Controls.Add(addStrButton);
            Controls.Add(openPuzzleButton);
            Controls.Add(energyLabel);
            Controls.Add(vitLabel);
            Controls.Add(addEnergyButton);
            Controls.Add(addVitButton);
            Controls.Add(infoLabel);
            Controls.Add(intLabel);
            Controls.Add(dexLabel);
            Controls.Add(addIntButton);
            Controls.Add(addDexButton);
            Controls.Add(strLabel);
            Controls.Add(pointsLabel);
            Controls.Add(resetButton);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StatsGUI";
            Text = "StatusGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button resetButton;
        private Label pointsLabel;
        private Label strLabel;
        private Button addDexButton;
        private Button addIntButton;
        private Label dexLabel;
        private Label intLabel;
        private Label infoLabel;
        private Button addVitButton;
        private Button addEnergyButton;
        private Label vitLabel;
        private Label energyLabel;
        private Button openPuzzleButton;
        private Button addStrButton;
    }
}
