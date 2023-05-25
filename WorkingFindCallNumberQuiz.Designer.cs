
namespace DeweyDecimalManagmentSystem
{
    partial class WorkingFindCallNumberQuiz
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
            this.btnAddDescriptions = new System.Windows.Forms.Button();
            this.lblFindingCallnumbers = new System.Windows.Forms.Label();
            this.txtQuizQuestion = new System.Windows.Forms.TextBox();
            this.lstAnswers = new System.Windows.Forms.ListBox();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblUserScoreDescrip = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDescriptions
            // 
            this.btnAddDescriptions.Location = new System.Drawing.Point(391, 132);
            this.btnAddDescriptions.Name = "btnAddDescriptions";
            this.btnAddDescriptions.Size = new System.Drawing.Size(176, 23);
            this.btnAddDescriptions.TabIndex = 0;
            this.btnAddDescriptions.Text = "Add Descriptions";
            this.btnAddDescriptions.UseVisualStyleBackColor = true;
            this.btnAddDescriptions.Click += new System.EventHandler(this.btnAddDescriptions_Click);
            // 
            // lblFindingCallnumbers
            // 
            this.lblFindingCallnumbers.AutoSize = true;
            this.lblFindingCallnumbers.Location = new System.Drawing.Point(115, 25);
            this.lblFindingCallnumbers.Name = "lblFindingCallnumbers";
            this.lblFindingCallnumbers.Size = new System.Drawing.Size(761, 17);
            this.lblFindingCallnumbers.TabIndex = 1;
            this.lblFindingCallnumbers.Text = "WELCOME TO THE FINDING CALL NUMBER QUIZ PLEASE CLICK ON THE ADD DESCRITPIONS BUTT" +
    "ON TO START";
            // 
            // txtQuizQuestion
            // 
            this.txtQuizQuestion.Location = new System.Drawing.Point(227, 88);
            this.txtQuizQuestion.Name = "txtQuizQuestion";
            this.txtQuizQuestion.Size = new System.Drawing.Size(495, 22);
            this.txtQuizQuestion.TabIndex = 2;
            // 
            // lstAnswers
            // 
            this.lstAnswers.FormattingEnabled = true;
            this.lstAnswers.ItemHeight = 16;
            this.lstAnswers.Location = new System.Drawing.Point(306, 202);
            this.lstAnswers.Name = "lstAnswers";
            this.lstAnswers.Size = new System.Drawing.Size(357, 84);
            this.lstAnswers.TabIndex = 3;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(441, 326);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAnswer.TabIndex = 4;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(13, 421);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 17);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score:";
            // 
            // lblUserScoreDescrip
            // 
            this.lblUserScoreDescrip.AutoSize = true;
            this.lblUserScoreDescrip.Location = new System.Drawing.Point(880, 421);
            this.lblUserScoreDescrip.Name = "lblUserScoreDescrip";
            this.lblUserScoreDescrip.Size = new System.Drawing.Size(120, 17);
            this.lblUserScoreDescrip.TabIndex = 6;
            this.lblUserScoreDescrip.Text = "Score Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WorkingFindCallNumberQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUserScoreDescrip);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.lstAnswers);
            this.Controls.Add(this.txtQuizQuestion);
            this.Controls.Add(this.lblFindingCallnumbers);
            this.Controls.Add(this.btnAddDescriptions);
            this.Name = "WorkingFindCallNumberQuiz";
            this.Text = "WorkingFindCallNumberQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDescriptions;
        private System.Windows.Forms.Label lblFindingCallnumbers;
        private System.Windows.Forms.TextBox txtQuizQuestion;
        private System.Windows.Forms.ListBox lstAnswers;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblUserScoreDescrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}