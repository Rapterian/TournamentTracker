namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            headerLabel = new Label();
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeValue = new NumericUpDown();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrize = new Button();
            tournamentTeamsListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPlayersButton = new Button();
            tournamentPrizesListBox = new ListBox();
            prizesLabel = new Label();
            deleteSelectedPrizesButton = new Button();
            createTournamentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)entryFeeValue).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(317, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(12, 88);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(242, 37);
            tournamentNameLabel.TabIndex = 3;
            tournamentNameLabel.Text = "Tournament Name:";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.ForeColor = Color.Black;
            tournamentNameValue.Location = new Point(12, 128);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(317, 35);
            tournamentNameValue.TabIndex = 4;
            // 
            // entryFeeValue
            // 
            entryFeeValue.DecimalPlaces = 2;
            entryFeeValue.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            entryFeeValue.Location = new Point(178, 198);
            entryFeeValue.Margin = new Padding(5, 6, 5, 6);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(151, 35);
            entryFeeValue.TabIndex = 10;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(12, 194);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(131, 37);
            entryFeeLabel.TabIndex = 9;
            entryFeeLabel.Text = "Entry Fee:";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(12, 303);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(317, 38);
            selectTeamDropDown.TabIndex = 12;
            selectTeamDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(12, 263);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(162, 37);
            selectTeamLabel.TabIndex = 11;
            selectTeamLabel.Text = "Select Team:";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(208, 269);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(114, 30);
            createNewTeamLink.TabIndex = 13;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(49, 359);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(242, 43);
            addTeamButton.TabIndex = 14;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrize
            // 
            createPrize.FlatAppearance.BorderColor = Color.Silver;
            createPrize.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrize.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrize.FlatStyle = FlatStyle.Flat;
            createPrize.ForeColor = SystemColors.MenuHighlight;
            createPrize.Location = new Point(49, 416);
            createPrize.Name = "createPrize";
            createPrize.Size = new Size(242, 43);
            createPrize.TabIndex = 15;
            createPrize.Text = "Create Prize";
            createPrize.UseVisualStyleBackColor = true;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 30;
            tournamentTeamsListBox.Location = new Point(409, 88);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(309, 152);
            tournamentTeamsListBox.TabIndex = 16;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayersLabel.Location = new Point(409, 48);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(204, 37);
            tournamentPlayersLabel.TabIndex = 17;
            tournamentPlayersLabel.Text = "Teams / Players:";
            // 
            // deleteSelectedPlayersButton
            // 
            deleteSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayersButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPlayersButton.Location = new Point(735, 128);
            deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            deleteSelectedPlayersButton.Size = new Size(107, 73);
            deleteSelectedPlayersButton.TabIndex = 18;
            deleteSelectedPlayersButton.Text = "Delete Selected";
            deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPrizesListBox
            // 
            tournamentPrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPrizesListBox.FormattingEnabled = true;
            tournamentPrizesListBox.ItemHeight = 30;
            tournamentPrizesListBox.Location = new Point(409, 307);
            tournamentPrizesListBox.Name = "tournamentPrizesListBox";
            tournamentPrizesListBox.Size = new Size(309, 152);
            tournamentPrizesListBox.TabIndex = 16;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = SystemColors.MenuHighlight;
            prizesLabel.Location = new Point(409, 267);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(85, 37);
            prizesLabel.TabIndex = 17;
            prizesLabel.Text = "Prizes";
            // 
            // deleteSelectedPrizesButton
            // 
            deleteSelectedPrizesButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizesButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizesButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPrizesButton.Location = new Point(735, 347);
            deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
            deleteSelectedPrizesButton.Size = new Size(107, 73);
            deleteSelectedPrizesButton.TabIndex = 18;
            deleteSelectedPrizesButton.Text = "Delete Selected";
            deleteSelectedPrizesButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(12, 478);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(830, 43);
            createTournamentButton.TabIndex = 19;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += button1_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(860, 556);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizesButton);
            Controls.Add(deleteSelectedPlayersButton);
            Controls.Add(prizesLabel);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPrizesListBox);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrize);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            Load += CreateTournamentForm_Load;
            ((System.ComponentModel.ISupportInitialize)entryFeeValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private NumericUpDown entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrize;
        private ListBox tournamentTeamsListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPlayersButton;
        private ListBox tournamentPrizesListBox;
        private Label prizesLabel;
        private Button deleteSelectedPrizesButton;
        private Button createTournamentButton;
    }
}