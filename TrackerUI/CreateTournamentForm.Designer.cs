
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLable = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.tournamentTeamsListLabel = new System.Windows.Forms.Label();
            this.tournamentPrizeListLabel = new System.Windows.Forms.Label();
            this.tournamentPrizeListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedTeamButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(32, 18);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(478, 74);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(32, 156);
            this.tournamentNameValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(452, 26);
            this.tournamentNameValue.TabIndex = 12;
            this.tournamentNameValue.TextChanged += new System.EventHandler(this.teamOneScoreValue_TextChanged_1);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentNameLabel.Location = new System.Drawing.Point(32, 98);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(351, 54);
            this.tournamentNameLabel.TabIndex = 11;
            this.tournamentNameLabel.Text = "Tournament Name";
            this.tournamentNameLabel.Click += new System.EventHandler(this.teamOneScoreLabel_Click_1);
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(201, 217);
            this.entryFeeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(97, 26);
            this.entryFeeValue.TabIndex = 14;
            this.entryFeeValue.Text = "0";
            this.entryFeeValue.TextChanged += new System.EventHandler(this.teamOneScoreValue_TextChanged_2);
            // 
            // entryFeeLable
            // 
            this.entryFeeLable.AutoSize = true;
            this.entryFeeLable.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.entryFeeLable.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeLable.Location = new System.Drawing.Point(33, 197);
            this.entryFeeLable.Name = "entryFeeLable";
            this.entryFeeLable.Size = new System.Drawing.Size(174, 48);
            this.entryFeeLable.TabIndex = 13;
            this.entryFeeLable.Text = "Entry Fee:";
            this.entryFeeLable.Click += new System.EventHandler(this.teamOneScoreLabel_Click_2);
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(32, 330);
            this.selectTeamDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(452, 28);
            this.selectTeamDropDown.TabIndex = 16;
            this.selectTeamDropDown.SelectedIndexChanged += new System.EventHandler(this.selectTeamDropDown_SelectedIndexChanged);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamLabel.Location = new System.Drawing.Point(32, 274);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(240, 54);
            this.selectTeamLabel.TabIndex = 15;
            this.selectTeamLabel.Text = "Select Team:";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(376, 292);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(87, 20);
            this.createNewTeamLink.TabIndex = 17;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTeamButton.Location = new System.Drawing.Point(144, 388);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(239, 63);
            this.addTeamButton.TabIndex = 18;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createPrizeButton.Location = new System.Drawing.Point(144, 471);
            this.createPrizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(239, 60);
            this.createPrizeButton.TabIndex = 19;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 20;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(553, 174);
            this.tournamentTeamsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(417, 202);
            this.tournamentTeamsListBox.TabIndex = 20;
            this.tournamentTeamsListBox.SelectedIndexChanged += new System.EventHandler(this.tournamentTeamsListBox_SelectedIndexChanged);
            // 
            // tournamentTeamsListLabel
            // 
            this.tournamentTeamsListLabel.AutoSize = true;
            this.tournamentTeamsListLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.tournamentTeamsListLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentTeamsListLabel.Location = new System.Drawing.Point(702, 111);
            this.tournamentTeamsListLabel.Name = "tournamentTeamsListLabel";
            this.tournamentTeamsListLabel.Size = new System.Drawing.Size(123, 48);
            this.tournamentTeamsListLabel.TabIndex = 21;
            this.tournamentTeamsListLabel.Text = "Teams";
            // 
            // tournamentPrizeListLabel
            // 
            this.tournamentPrizeListLabel.AutoSize = true;
            this.tournamentPrizeListLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.tournamentPrizeListLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentPrizeListLabel.Location = new System.Drawing.Point(702, 380);
            this.tournamentPrizeListLabel.Name = "tournamentPrizeListLabel";
            this.tournamentPrizeListLabel.Size = new System.Drawing.Size(115, 48);
            this.tournamentPrizeListLabel.TabIndex = 23;
            this.tournamentPrizeListLabel.Text = "Prizes";
            // 
            // tournamentPrizeListBox
            // 
            this.tournamentPrizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPrizeListBox.FormattingEnabled = true;
            this.tournamentPrizeListBox.ItemHeight = 20;
            this.tournamentPrizeListBox.Location = new System.Drawing.Point(553, 436);
            this.tournamentPrizeListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tournamentPrizeListBox.Name = "tournamentPrizeListBox";
            this.tournamentPrizeListBox.Size = new System.Drawing.Size(417, 122);
            this.tournamentPrizeListBox.TabIndex = 22;
            this.tournamentPrizeListBox.SelectedIndexChanged += new System.EventHandler(this.tournamentPrizeListBox_SelectedIndexChanged);
            // 
            // deleteSelectedTeamButton
            // 
            this.deleteSelectedTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedTeamButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteSelectedTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedTeamButton.Location = new System.Drawing.Point(866, 117);
            this.deleteSelectedTeamButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            this.deleteSelectedTeamButton.Size = new System.Drawing.Size(104, 47);
            this.deleteSelectedTeamButton.TabIndex = 24;
            this.deleteSelectedTeamButton.Text = "Delete";
            this.deleteSelectedTeamButton.UseVisualStyleBackColor = true;
            this.deleteSelectedTeamButton.Click += new System.EventHandler(this.deleteSelectedTeamButton_Click);
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(866, 388);
            this.deleteSelectedPrizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(104, 42);
            this.deleteSelectedPrizeButton.TabIndex = 25;
            this.deleteSelectedPrizeButton.Text = "Delete";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            this.deleteSelectedPrizeButton.Click += new System.EventHandler(this.deleteSelectedPrizeButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTournamentButton.Location = new System.Drawing.Point(335, 581);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(326, 68);
            this.createTournamentButton.TabIndex = 26;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.deleteSelectedTeamButton);
            this.Controls.Add(this.tournamentPrizeListLabel);
            this.Controls.Add(this.tournamentPrizeListBox);
            this.Controls.Add(this.tournamentTeamsListLabel);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLable);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLable;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label tournamentTeamsListLabel;
        private System.Windows.Forms.Label tournamentPrizeListLabel;
        private System.Windows.Forms.ListBox tournamentPrizeListBox;
        private System.Windows.Forms.Button deleteSelectedTeamButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}