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
            nameTextBox = new TextBox();
            addStrButton = new Button();
            resetButton = new Button();
            pointsLabel = new Label();
            strLabel = new Label();
            nameLabel = new Label();
            classLabel = new Label();
            addDexButton = new Button();
            addIntButton = new Button();
            dexLabel = new Label();
            intLabel = new Label();
            infoLabel = new Label();
            classComboBox = new ComboBox();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 9F);
            nameTextBox.Location = new Point(243, 142);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(180, 23);
            nameTextBox.TabIndex = 0;
            // 
            // addStrButton
            // 
            addStrButton.Location = new Point(243, 211);
            addStrButton.Name = "addStrButton";
            addStrButton.Size = new Size(75, 23);
            addStrButton.TabIndex = 2;
            addStrButton.Text = "add STR";
            addStrButton.UseVisualStyleBackColor = true;
            addStrButton.Click += addStrButton_Click;
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
            pointsLabel.Location = new Point(469, 150);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(40, 15);
            pointsLabel.TabIndex = 4;
            pointsLabel.Text = "Points";
            // 
            // strLabel
            // 
            strLabel.AutoSize = true;
            strLabel.Location = new Point(324, 219);
            strLabel.Name = "strLabel";
            strLabel.Size = new Size(10, 15);
            strLabel.TabIndex = 5;
            strLabel.Text = ":";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(257, 124);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new Point(606, 124);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(34, 15);
            classLabel.TabIndex = 8;
            classLabel.Text = "Class";
            // 
            // addDexButton
            // 
            addDexButton.Location = new Point(243, 249);
            addDexButton.Name = "addDexButton";
            addDexButton.Size = new Size(75, 23);
            addDexButton.TabIndex = 9;
            addDexButton.Text = "add DEX";
            addDexButton.UseVisualStyleBackColor = true;
            addDexButton.Click += addDexButton_Click;
            // 
            // addIntButton
            // 
            addIntButton.Location = new Point(243, 287);
            addIntButton.Name = "addIntButton";
            addIntButton.Size = new Size(75, 23);
            addIntButton.TabIndex = 10;
            addIntButton.Text = "add INT";
            addIntButton.UseVisualStyleBackColor = true;
            addIntButton.Click += addIntButton_Click;
            // 
            // dexLabel
            // 
            dexLabel.AutoSize = true;
            dexLabel.Location = new Point(324, 257);
            dexLabel.Name = "dexLabel";
            dexLabel.Size = new Size(10, 15);
            dexLabel.TabIndex = 11;
            dexLabel.Text = ":";
            // 
            // intLabel
            // 
            intLabel.AutoSize = true;
            intLabel.Location = new Point(324, 295);
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
            // classComboBox
            // 
            classComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            classComboBox.FormattingEnabled = true;
            classComboBox.Items.AddRange(new object[] { "barbarian", "sorceress" });
            classComboBox.Location = new Point(576, 142);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(121, 23);
            classComboBox.TabIndex = 14;
            classComboBox.SelectedIndexChanged += classComboBox_SelectedIndexChanged;
            // 
            // StatsGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = Properties.Resources.Backgroundstats;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 563);
            Controls.Add(classComboBox);
            Controls.Add(infoLabel);
            Controls.Add(intLabel);
            Controls.Add(dexLabel);
            Controls.Add(addIntButton);
            Controls.Add(addDexButton);
            Controls.Add(classLabel);
            Controls.Add(nameLabel);
            Controls.Add(strLabel);
            Controls.Add(pointsLabel);
            Controls.Add(resetButton);
            Controls.Add(addStrButton);
            Controls.Add(nameTextBox);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StatsGUI";
            Text = "StatusGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Button addStrButton;
        private Button resetButton;
        private Label pointsLabel;
        private Label strLabel;
        private Label nameLabel;
        private Label classLabel;
        private Button addDexButton;
        private Button addIntButton;
        private Label dexLabel;
        private Label intLabel;
        private Label infoLabel;
        private ComboBox classComboBox;
    }
}
