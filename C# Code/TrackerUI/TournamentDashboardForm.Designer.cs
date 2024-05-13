namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            headerLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingtournamentLabel = new Label();
            createTournamentButton = new Button();
            loadTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(48, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(385, 50);
            headerLabel.TabIndex = 7;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(82, 108);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(317, 38);
            loadExistingTournamentDropDown.TabIndex = 18;
            // 
            // loadExistingtournamentLabel
            // 
            loadExistingtournamentLabel.AutoSize = true;
            loadExistingtournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingtournamentLabel.ForeColor = SystemColors.MenuHighlight;
            loadExistingtournamentLabel.Location = new Point(123, 68);
            loadExistingtournamentLabel.Name = "loadExistingtournamentLabel";
            loadExistingtournamentLabel.Size = new Size(235, 37);
            loadExistingtournamentLabel.TabIndex = 17;
            loadExistingtournamentLabel.Text = "Select Tournament";
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(131, 217);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(219, 99);
            createTournamentButton.TabIndex = 23;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.ForeColor = SystemColors.MenuHighlight;
            loadTournamentButton.Location = new Point(82, 152);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(317, 43);
            loadTournamentButton.TabIndex = 24;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(497, 368);
            Controls.Add(loadTournamentButton);
            Controls.Add(createTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingtournamentLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingtournamentLabel;
        private Button createTournamentButton;
        private Button loadTournamentButton;
    }
}