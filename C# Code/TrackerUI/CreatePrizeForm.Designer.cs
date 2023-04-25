namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            headerLabel = new Label();
            teamOneScoreValue = new NumericUpDown();
            placeNumberLabel = new Label();
            entryFeeValue = new NumericUpDown();
            prizeAmountLabel = new Label();
            memberFirstNameValue = new TextBox();
            placeNameLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)teamOneScoreValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entryFeeValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(209, 50);
            headerLabel.TabIndex = 6;
            headerLabel.Text = "Create Prize";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(254, 74);
            teamOneScoreValue.Margin = new Padding(5, 6, 5, 6);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(162, 35);
            teamOneScoreValue.TabIndex = 10;
            teamOneScoreValue.ValueChanged += teamOneScoreValue_ValueChanged;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(28, 70);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 9;
            placeNumberLabel.Text = "Place Number";
            placeNumberLabel.Click += placeNumberLabel_Click;
            // 
            // entryFeeValue
            // 
            entryFeeValue.DecimalPlaces = 2;
            entryFeeValue.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            entryFeeValue.Location = new Point(254, 175);
            entryFeeValue.Margin = new Padding(9, 12, 9, 12);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(162, 35);
            entryFeeValue.TabIndex = 12;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            prizeAmountLabel.Location = new Point(28, 171);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(176, 37);
            prizeAmountLabel.TabIndex = 11;
            prizeAmountLabel.Text = "Prize Amount";
            prizeAmountLabel.Click += entryFeeLabel_Click;
            // 
            // memberFirstNameValue
            // 
            memberFirstNameValue.BorderStyle = BorderStyle.FixedSingle;
            memberFirstNameValue.ForeColor = Color.Black;
            memberFirstNameValue.Location = new Point(254, 124);
            memberFirstNameValue.Name = "memberFirstNameValue";
            memberFirstNameValue.Size = new Size(162, 35);
            memberFirstNameValue.TabIndex = 14;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(28, 120);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 13;
            placeNameLabel.Text = "Place Name";
            placeNameLabel.Click += placeNameLabel_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numericUpDown1.Location = new Point(254, 303);
            numericUpDown1.Margin = new Padding(15, 24, 15, 24);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(162, 35);
            numericUpDown1.TabIndex = 16;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePercentageLabel.Location = new Point(28, 299);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(212, 37);
            prizePercentageLabel.TabIndex = 15;
            prizePercentageLabel.Text = "Prize Percentage";
            prizePercentageLabel.Click += prizePercentageLabel_Click;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(176, 240);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(64, 37);
            orLabel.TabIndex = 17;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(77, 377);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(311, 43);
            createPrizeButton.TabIndex = 22;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(478, 533);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(numericUpDown1);
            Controls.Add(prizePercentageLabel);
            Controls.Add(memberFirstNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            Load += CreatePrizeForm_Load;
            ((System.ComponentModel.ISupportInitialize)teamOneScoreValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)entryFeeValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private NumericUpDown teamOneScoreValue;
        private Label placeNumberLabel;
        private NumericUpDown entryFeeValue;
        private Label prizeAmountLabel;
        private TextBox memberFirstNameValue;
        private Label placeNameLabel;
        private NumericUpDown numericUpDown1;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}