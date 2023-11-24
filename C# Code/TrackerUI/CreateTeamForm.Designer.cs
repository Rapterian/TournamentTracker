namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            addTeamMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            groupBox1 = new GroupBox();
            createMemberButton = new Button();
            memberCellphoneValue = new TextBox();
            memberCellphoneLabel = new Label();
            memberEmailValue = new TextBox();
            memberEmailLabel = new Label();
            memberLastNameValue = new TextBox();
            memberLastNameLabel = new Label();
            memberFirstNameValue = new TextBox();
            memberFirstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedMembersButton = new Button();
            createTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.BorderStyle = BorderStyle.FixedSingle;
            teamNameValue.ForeColor = Color.Black;
            teamNameValue.Location = new Point(12, 105);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(317, 35);
            teamNameValue.TabIndex = 7;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(12, 65);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(163, 37);
            teamNameLabel.TabIndex = 6;
            teamNameLabel.Text = "Team Name:";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(213, 50);
            headerLabel.TabIndex = 5;
            headerLabel.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.ForeColor = SystemColors.MenuHighlight;
            addTeamMemberButton.Location = new Point(49, 227);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(242, 43);
            addTeamMemberButton.TabIndex = 17;
            addTeamMemberButton.Text = "Add Team Member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            addTeamMemberButton.Click += addTeamMemberButton_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(12, 183);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(317, 38);
            selectTeamMemberDropDown.TabIndex = 16;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.Location = new Point(12, 143);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(269, 37);
            selectTeamMemberLabel.TabIndex = 15;
            selectTeamMemberLabel.Text = "Select Team Member:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createMemberButton);
            groupBox1.Controls.Add(memberCellphoneValue);
            groupBox1.Controls.Add(memberCellphoneLabel);
            groupBox1.Controls.Add(memberEmailValue);
            groupBox1.Controls.Add(memberEmailLabel);
            groupBox1.Controls.Add(memberLastNameValue);
            groupBox1.Controls.Add(memberLastNameLabel);
            groupBox1.Controls.Add(memberFirstNameValue);
            groupBox1.Controls.Add(memberFirstNameLabel);
            groupBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(12, 293);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 314);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(37, 247);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(242, 54);
            createMemberButton.TabIndex = 18;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // memberCellphoneValue
            // 
            memberCellphoneValue.BorderStyle = BorderStyle.FixedSingle;
            memberCellphoneValue.ForeColor = Color.Black;
            memberCellphoneValue.Location = new Point(150, 198);
            memberCellphoneValue.Name = "memberCellphoneValue";
            memberCellphoneValue.Size = new Size(161, 43);
            memberCellphoneValue.TabIndex = 12;
            // 
            // memberCellphoneLabel
            // 
            memberCellphoneLabel.AutoSize = true;
            memberCellphoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            memberCellphoneLabel.ForeColor = SystemColors.MenuHighlight;
            memberCellphoneLabel.Location = new Point(6, 197);
            memberCellphoneLabel.Name = "memberCellphoneLabel";
            memberCellphoneLabel.Size = new Size(144, 37);
            memberCellphoneLabel.TabIndex = 11;
            memberCellphoneLabel.Text = "Cellphone:";
            // 
            // memberEmailValue
            // 
            memberEmailValue.BorderStyle = BorderStyle.FixedSingle;
            memberEmailValue.ForeColor = Color.Black;
            memberEmailValue.Location = new Point(150, 149);
            memberEmailValue.Name = "memberEmailValue";
            memberEmailValue.Size = new Size(161, 43);
            memberEmailValue.TabIndex = 10;
            // 
            // memberEmailLabel
            // 
            memberEmailLabel.AutoSize = true;
            memberEmailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            memberEmailLabel.ForeColor = SystemColors.MenuHighlight;
            memberEmailLabel.Location = new Point(6, 148);
            memberEmailLabel.Name = "memberEmailLabel";
            memberEmailLabel.Size = new Size(88, 37);
            memberEmailLabel.TabIndex = 9;
            memberEmailLabel.Text = "Email:";
            // 
            // memberLastNameValue
            // 
            memberLastNameValue.BorderStyle = BorderStyle.FixedSingle;
            memberLastNameValue.ForeColor = Color.Black;
            memberLastNameValue.Location = new Point(150, 100);
            memberLastNameValue.Name = "memberLastNameValue";
            memberLastNameValue.Size = new Size(161, 43);
            memberLastNameValue.TabIndex = 8;
            // 
            // memberLastNameLabel
            // 
            memberLastNameLabel.AutoSize = true;
            memberLastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            memberLastNameLabel.ForeColor = SystemColors.MenuHighlight;
            memberLastNameLabel.Location = new Point(6, 99);
            memberLastNameLabel.Name = "memberLastNameLabel";
            memberLastNameLabel.Size = new Size(148, 37);
            memberLastNameLabel.TabIndex = 7;
            memberLastNameLabel.Text = "Last Name:";
            // 
            // memberFirstNameValue
            // 
            memberFirstNameValue.BorderStyle = BorderStyle.FixedSingle;
            memberFirstNameValue.ForeColor = Color.Black;
            memberFirstNameValue.Location = new Point(150, 51);
            memberFirstNameValue.Name = "memberFirstNameValue";
            memberFirstNameValue.Size = new Size(161, 43);
            memberFirstNameValue.TabIndex = 6;
            // 
            // memberFirstNameLabel
            // 
            memberFirstNameLabel.AutoSize = true;
            memberFirstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            memberFirstNameLabel.ForeColor = SystemColors.MenuHighlight;
            memberFirstNameLabel.Location = new Point(6, 50);
            memberFirstNameLabel.Name = "memberFirstNameLabel";
            memberFirstNameLabel.Size = new Size(150, 37);
            memberFirstNameLabel.TabIndex = 5;
            memberFirstNameLabel.Text = "First Name:";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(378, 65);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(309, 542);
            teamMembersListBox.TabIndex = 19;
            // 
            // removeSelectedMembersButton
            // 
            removeSelectedMembersButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedMembersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedMembersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedMembersButton.FlatStyle = FlatStyle.Flat;
            removeSelectedMembersButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedMembersButton.Location = new Point(702, 300);
            removeSelectedMembersButton.Name = "removeSelectedMembersButton";
            removeSelectedMembersButton.Size = new Size(107, 73);
            removeSelectedMembersButton.TabIndex = 20;
            removeSelectedMembersButton.Text = "Remove Selected";
            removeSelectedMembersButton.UseVisualStyleBackColor = true;
            removeSelectedMembersButton.Click += removeSelectedMembersButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(12, 613);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(797, 43);
            createTeamButton.TabIndex = 21;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(822, 665);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMembersButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox groupBox1;
        private TextBox memberFirstNameValue;
        private Label memberFirstNameLabel;
        private Button createMemberButton;
        private TextBox memberCellphoneValue;
        private Label memberCellphoneLabel;
        private TextBox memberEmailValue;
        private Label memberEmailLabel;
        private TextBox memberLastNameValue;
        private Label memberLastNameLabel;
        private ListBox teamMembersListBox;
        private Button removeSelectedMembersButton;
        private Button createTeamButton;
    }
}