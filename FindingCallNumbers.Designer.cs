
namespace DeweyDecimalManagmentSystem
{
    partial class FindingCallNumbers
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
            this.lblQuizQuestion = new System.Windows.Forms.Label();
            this.btnGenerateQuiz = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblDisplayScore = new System.Windows.Forms.Label();
            this.lstQuiz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblQuizQuestion
            // 
            this.lblQuizQuestion.AutoSize = true;
            this.lblQuizQuestion.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizQuestion.Location = new System.Drawing.Point(350, 124);
            this.lblQuizQuestion.Name = "lblQuizQuestion";
            this.lblQuizQuestion.Size = new System.Drawing.Size(94, 17);
            this.lblQuizQuestion.TabIndex = 0;
            this.lblQuizQuestion.Text = " Question:";
            // 
            // btnGenerateQuiz
            // 
            this.btnGenerateQuiz.Location = new System.Drawing.Point(378, 420);
            this.btnGenerateQuiz.Name = "btnGenerateQuiz";
            this.btnGenerateQuiz.Size = new System.Drawing.Size(181, 23);
            this.btnGenerateQuiz.TabIndex = 2;
            this.btnGenerateQuiz.Text = "Generate Quiz!";
            this.btnGenerateQuiz.UseVisualStyleBackColor = true;
            this.btnGenerateQuiz.Click += new System.EventHandler(this.btnGenerateQuiz_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(378, 479);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(181, 23);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblDisplayScore
            // 
            this.lblDisplayScore.AutoSize = true;
            this.lblDisplayScore.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblDisplayScore.Location = new System.Drawing.Point(13, 552);
            this.lblDisplayScore.Name = "lblDisplayScore";
            this.lblDisplayScore.Size = new System.Drawing.Size(59, 17);
            this.lblDisplayScore.TabIndex = 4;
            this.lblDisplayScore.Text = "Score:";
            // 
            // lstQuiz
            // 
            this.lstQuiz.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstQuiz.FormattingEnabled = true;
            this.lstQuiz.ItemHeight = 16;
            this.lstQuiz.Location = new System.Drawing.Point(353, 193);
            this.lstQuiz.Name = "lstQuiz";
            this.lstQuiz.Size = new System.Drawing.Size(221, 212);
            this.lstQuiz.TabIndex = 5;
            // 
            // FindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(988, 594);
            this.Controls.Add(this.lstQuiz);
            this.Controls.Add(this.lblDisplayScore);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnGenerateQuiz);
            this.Controls.Add(this.lblQuizQuestion);
            this.Name = "FindingCallNumbers";
            this.Text = "FindingCallNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuizQuestion;
        private System.Windows.Forms.Button btnGenerateQuiz;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblDisplayScore;
        private System.Windows.Forms.ListBox lstQuiz;
    }
}