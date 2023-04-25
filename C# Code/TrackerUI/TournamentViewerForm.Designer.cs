namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            headerLabel = new Label();
            tournamentNameLabel = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneNameLabel = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new NumericUpDown();
            versusLabel = new Label();
            teamTwoScoreValue = new NumericUpDown();
            teamTwoScoreLabel = new Label();
            teamTwoNameLabel = new Label();
            scoreButton = new Button();
            ((System.ComponentModel.ISupportInitialize)teamOneScoreValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamTwoScoreValue).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(232, 9);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(150, 50);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(12, 106);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(112, 105);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(209, 38);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckBox.Location = new Point(112, 149);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(209, 41);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(12, 196);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(309, 242);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneNameLabel
            // 
            teamOneNameLabel.AutoSize = true;
            teamOneNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneNameLabel.Location = new Point(327, 196);
            teamOneNameLabel.Name = "teamOneNameLabel";
            teamOneNameLabel.Size = new Size(165, 37);
            teamOneNameLabel.TabIndex = 6;
            teamOneNameLabel.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(327, 233);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(88, 37);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score:";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(421, 237);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(71, 35);
            teamOneScoreValue.TabIndex = 8;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = SystemColors.MenuHighlight;
            versusLabel.Location = new Point(368, 302);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(92, 37);
            versusLabel.TabIndex = 9;
            versusLabel.Text = "--VS--";
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(421, 403);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(71, 35);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoScoreLabel.Location = new Point(327, 399);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(88, 37);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score:";
            // 
            // teamTwoNameLabel
            // 
            teamTwoNameLabel.AutoSize = true;
            teamTwoNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoNameLabel.Location = new Point(327, 362);
            teamTwoNameLabel.Name = "teamTwoNameLabel";
            teamTwoNameLabel.Size = new Size(165, 37);
            teamTwoNameLabel.TabIndex = 10;
            teamTwoNameLabel.Text = "<team one>";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(530, 302);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(85, 43);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(876, 512);
            Controls.Add(scoreButton);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoNameLabel);
            Controls.Add(versusLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneNameLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament View";
            ((System.ComponentModel.ISupportInitialize)teamOneScoreValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamTwoScoreValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameLabel;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneNameLabel;
        private Label teamOneScoreLabel;
        private NumericUpDown teamOneScoreValue;
        private Label versusLabel;
        private NumericUpDown teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoNameLabel;
        private Button scoreButton;
    }
}