
namespace DeweyDecimalManagmentSystem
{
    partial class IdentifyingTasks
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
            this.lstValues = new System.Windows.Forms.ListBox();
            this.lstKeys = new System.Windows.Forms.ListBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnPopulateLists = new System.Windows.Forms.Button();
            this.lblCallNumbers = new System.Windows.Forms.Label();
            this.lblDescriptions = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblDisplayScore = new System.Windows.Forms.Label();
            this.lblMatchStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstValues
            // 
            this.lstValues.FormattingEnabled = true;
            this.lstValues.ItemHeight = 16;
            this.lstValues.Location = new System.Drawing.Point(586, 86);
            this.lstValues.Name = "lstValues";
            this.lstValues.Size = new System.Drawing.Size(223, 228);
            this.lstValues.TabIndex = 0;
            // 
            // lstKeys
            // 
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.ItemHeight = 16;
            this.lstKeys.Location = new System.Drawing.Point(101, 86);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.Size = new System.Drawing.Size(222, 228);
            this.lstKeys.TabIndex = 1;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(268, 399);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(366, 34);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.Text = "MATCH";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnPopulateLists
            // 
            this.btnPopulateLists.Location = new System.Drawing.Point(378, 324);
            this.btnPopulateLists.Name = "btnPopulateLists";
            this.btnPopulateLists.Size = new System.Drawing.Size(142, 44);
            this.btnPopulateLists.TabIndex = 3;
            this.btnPopulateLists.Text = "Populate Lists";
            this.btnPopulateLists.UseVisualStyleBackColor = true;
            this.btnPopulateLists.Click += new System.EventHandler(this.btnPopulateLists_Click);
            // 
            // lblCallNumbers
            // 
            this.lblCallNumbers.AutoSize = true;
            this.lblCallNumbers.Location = new System.Drawing.Point(101, 44);
            this.lblCallNumbers.Name = "lblCallNumbers";
            this.lblCallNumbers.Size = new System.Drawing.Size(96, 17);
            this.lblCallNumbers.TabIndex = 4;
            this.lblCallNumbers.Text = "Call Numbers:";
            // 
            // lblDescriptions
            // 
            this.lblDescriptions.AutoSize = true;
            this.lblDescriptions.Location = new System.Drawing.Point(586, 43);
            this.lblDescriptions.Name = "lblDescriptions";
            this.lblDescriptions.Size = new System.Drawing.Size(90, 17);
            this.lblDescriptions.TabIndex = 5;
            this.lblDescriptions.Text = "Descriptions:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(923, 17);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "PLEASE ENSURE THAT YOU SELECT BOTH PREDICTED COLUMNS BEFORE ANSWERING THE MATCH C" +
    "OMBINATION BELOW ";
            // 
            // lblDisplayScore
            // 
            this.lblDisplayScore.AutoSize = true;
            this.lblDisplayScore.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblDisplayScore.Location = new System.Drawing.Point(2, 499);
            this.lblDisplayScore.Name = "lblDisplayScore";
            this.lblDisplayScore.Size = new System.Drawing.Size(143, 17);
            this.lblDisplayScore.TabIndex = 7;
            this.lblDisplayScore.Text = "Current Score: ";
            // 
            // lblMatchStatus
            // 
            this.lblMatchStatus.AutoSize = true;
            this.lblMatchStatus.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblMatchStatus.Location = new System.Drawing.Point(589, 498);
            this.lblMatchStatus.Name = "lblMatchStatus";
            this.lblMatchStatus.Size = new System.Drawing.Size(135, 17);
            this.lblMatchStatus.TabIndex = 8;
            this.lblMatchStatus.Text = "Match Status: ";
            // 
            // IdentifyingTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(984, 525);
            this.Controls.Add(this.lblMatchStatus);
            this.Controls.Add(this.lblDisplayScore);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblDescriptions);
            this.Controls.Add(this.lblCallNumbers);
            this.Controls.Add(this.btnPopulateLists);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.lstKeys);
            this.Controls.Add(this.lstValues);
            this.Name = "IdentifyingTasks";
            this.Text = "IdentifyingTasks";
            this.Load += new System.EventHandler(this.IdentifyingTasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstValues;
        private System.Windows.Forms.ListBox lstKeys;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnPopulateLists;
        private System.Windows.Forms.Label lblCallNumbers;
        private System.Windows.Forms.Label lblDescriptions;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblDisplayScore;
        private System.Windows.Forms.Label lblMatchStatus;
    }
}