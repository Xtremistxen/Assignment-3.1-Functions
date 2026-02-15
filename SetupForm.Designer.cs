namespace Characterstatgui
{
    partial class SetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            nameTextBox = new TextBox();
            classComboBox = new ComboBox();
            infoLabel = new Label();
            nameLabel = new Label();
            classLabel = new Label();
            startButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(235, 127);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(121, 23);
            nameTextBox.TabIndex = 0;
            nameTextBox.TextChanged += InputsChanged;
            // 
            // classComboBox
            // 
            classComboBox.FormattingEnabled = true;
            classComboBox.Items.AddRange(new object[] { "Barbarian", "Sorceress" });
            classComboBox.Location = new Point(453, 127);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(121, 23);
            classComboBox.TabIndex = 1;
            classComboBox.SelectedIndexChanged += InputsChanged;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(380, 58);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(10, 15);
            infoLabel.TabIndex = 2;
            infoLabel.Text = ":";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(235, 106);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new Point(453, 106);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(34, 15);
            classLabel.TabIndex = 4;
            classLabel.Text = "Class";
            // 
            // startButton
            // 
            startButton.BackColor = Color.Black;
            startButton.Image = (Image)resources.GetObject("startButton.Image");
            startButton.Location = new Point(193, 291);
            startButton.Name = "startButton";
            startButton.Size = new Size(180, 50);
            startButton.TabIndex = 5;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Black;
            clearButton.Image = (Image)resources.GetObject("clearButton.Image");
            clearButton.Location = new Point(424, 291);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(180, 50);
            clearButton.TabIndex = 6;
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSetup;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(startButton);
            Controls.Add(classLabel);
            Controls.Add(nameLabel);
            Controls.Add(infoLabel);
            Controls.Add(classComboBox);
            Controls.Add(nameTextBox);
            DoubleBuffered = true;
            Name = "SetupForm";
            Text = "Character Builder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private ComboBox classComboBox;
        private Label infoLabel;
        private Label nameLabel;
        private Label classLabel;
        private Button startButton;
        private Button clearButton;
    }
}