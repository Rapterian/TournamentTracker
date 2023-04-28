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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.memberCellphoneValue = new System.Windows.Forms.TextBox();
            this.memberCellphoneLabel = new System.Windows.Forms.Label();
            this.memberEmailValue = new System.Windows.Forms.TextBox();
            this.memberEmailLabel = new System.Windows.Forms.Label();
            this.memberLastNameValue = new System.Windows.Forms.TextBox();
            this.memberLastNameLabel = new System.Windows.Forms.Label();
            this.memberFirstNameValue = new System.Windows.Forms.TextBox();
            this.memberFirstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedMembersButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamNameValue.ForeColor = System.Drawing.Color.Black;
            this.teamNameValue.Location = new System.Drawing.Point(12, 105);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(317, 35);
            this.teamNameValue.TabIndex = 7;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamNameLabel.Location = new System.Drawing.Point(12, 65);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(163, 37);
            this.teamNameLabel.TabIndex = 6;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(213, 50);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTeamMemberButton.Location = new System.Drawing.Point(49, 227);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(242, 43);
            this.addTeamMemberButton.TabIndex = 17;
            this.addTeamMemberButton.Text = "Add Team Member";
            this.addTeamMemberButton.UseVisualStyleBackColor = true;
            this.addTeamMemberButton.Click += new System.EventHandler(this.addTeamMemberButton_Click);
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(12, 183);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(317, 38);
            this.selectTeamMemberDropDown.TabIndex = 16;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(12, 143);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(269, 37);
            this.selectTeamMemberLabel.TabIndex = 15;
            this.selectTeamMemberLabel.Text = "Select Team Member:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createMemberButton);
            this.groupBox1.Controls.Add(this.memberCellphoneValue);
            this.groupBox1.Controls.Add(this.memberCellphoneLabel);
            this.groupBox1.Controls.Add(this.memberEmailValue);
            this.groupBox1.Controls.Add(this.memberEmailLabel);
            this.groupBox1.Controls.Add(this.memberLastNameValue);
            this.groupBox1.Controls.Add(this.memberLastNameLabel);
            this.groupBox1.Controls.Add(this.memberFirstNameValue);
            this.groupBox1.Controls.Add(this.memberFirstNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 314);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createMemberButton.Location = new System.Drawing.Point(37, 247);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(242, 54);
            this.createMemberButton.TabIndex = 18;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // memberCellphoneValue
            // 
            this.memberCellphoneValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberCellphoneValue.ForeColor = System.Drawing.Color.Black;
            this.memberCellphoneValue.Location = new System.Drawing.Point(150, 198);
            this.memberCellphoneValue.Name = "memberCellphoneValue";
            this.memberCellphoneValue.Size = new System.Drawing.Size(161, 43);
            this.memberCellphoneValue.TabIndex = 12;
            // 
            // memberCellphoneLabel
            // 
            this.memberCellphoneLabel.AutoSize = true;
            this.memberCellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberCellphoneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memberCellphoneLabel.Location = new System.Drawing.Point(6, 197);
            this.memberCellphoneLabel.Name = "memberCellphoneLabel";
            this.memberCellphoneLabel.Size = new System.Drawing.Size(144, 37);
            this.memberCellphoneLabel.TabIndex = 11;
            this.memberCellphoneLabel.Text = "Cellphone:";
            // 
            // memberEmailValue
            // 
            this.memberEmailValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberEmailValue.ForeColor = System.Drawing.Color.Black;
            this.memberEmailValue.Location = new System.Drawing.Point(150, 149);
            this.memberEmailValue.Name = "memberEmailValue";
            this.memberEmailValue.Size = new System.Drawing.Size(161, 43);
            this.memberEmailValue.TabIndex = 10;
            // 
            // memberEmailLabel
            // 
            this.memberEmailLabel.AutoSize = true;
            this.memberEmailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberEmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memberEmailLabel.Location = new System.Drawing.Point(6, 148);
            this.memberEmailLabel.Name = "memberEmailLabel";
            this.memberEmailLabel.Size = new System.Drawing.Size(88, 37);
            this.memberEmailLabel.TabIndex = 9;
            this.memberEmailLabel.Text = "Email:";
            // 
            // memberLastNameValue
            // 
            this.memberLastNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberLastNameValue.ForeColor = System.Drawing.Color.Black;
            this.memberLastNameValue.Location = new System.Drawing.Point(150, 100);
            this.memberLastNameValue.Name = "memberLastNameValue";
            this.memberLastNameValue.Size = new System.Drawing.Size(161, 43);
            this.memberLastNameValue.TabIndex = 8;
            // 
            // memberLastNameLabel
            // 
            this.memberLastNameLabel.AutoSize = true;
            this.memberLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberLastNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memberLastNameLabel.Location = new System.Drawing.Point(6, 99);
            this.memberLastNameLabel.Name = "memberLastNameLabel";
            this.memberLastNameLabel.Size = new System.Drawing.Size(148, 37);
            this.memberLastNameLabel.TabIndex = 7;
            this.memberLastNameLabel.Text = "Last Name:";
            // 
            // memberFirstNameValue
            // 
            this.memberFirstNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberFirstNameValue.ForeColor = System.Drawing.Color.Black;
            this.memberFirstNameValue.Location = new System.Drawing.Point(150, 51);
            this.memberFirstNameValue.Name = "memberFirstNameValue";
            this.memberFirstNameValue.Size = new System.Drawing.Size(161, 43);
            this.memberFirstNameValue.TabIndex = 6;
            // 
            // memberFirstNameLabel
            // 
            this.memberFirstNameLabel.AutoSize = true;
            this.memberFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberFirstNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.memberFirstNameLabel.Location = new System.Drawing.Point(6, 50);
            this.memberFirstNameLabel.Name = "memberFirstNameLabel";
            this.memberFirstNameLabel.Size = new System.Drawing.Size(150, 37);
            this.memberFirstNameLabel.TabIndex = 5;
            this.memberFirstNameLabel.Text = "First Name:";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(378, 65);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(309, 542);
            this.teamMembersListBox.TabIndex = 19;
            // 
            // removeSelectedMembersButton
            // 
            this.removeSelectedMembersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMembersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedMembersButton.Location = new System.Drawing.Point(702, 300);
            this.removeSelectedMembersButton.Name = "removeSelectedMembersButton";
            this.removeSelectedMembersButton.Size = new System.Drawing.Size(107, 73);
            this.removeSelectedMembersButton.TabIndex = 20;
            this.removeSelectedMembersButton.Text = "Remove Selected";
            this.removeSelectedMembersButton.UseVisualStyleBackColor = true;
            this.removeSelectedMembersButton.Click += new System.EventHandler(this.removeSelectedMembersButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTeamButton.Location = new System.Drawing.Point(12, 613);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(797, 43);
            this.createTeamButton.TabIndex = 21;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 665);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedMembersButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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