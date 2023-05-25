
namespace DeweyDecimalManagmentSystem
{
    partial class frmWelcome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnReplaceBooks = new System.Windows.Forms.Button();
            this.btnIdentifyingAreas = new System.Windows.Forms.Button();
            this.btnFindingCallNumbers = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnCallNumberWorking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(21, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(842, 35);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME TO THE EDUCATIONAL DEWEY DECIMAL SYSTEM";
            this.lblWelcome.Click += new System.EventHandler(this.blbWelcome_Click);
            // 
            // btnReplaceBooks
            // 
            this.btnReplaceBooks.Location = new System.Drawing.Point(380, 173);
            this.btnReplaceBooks.Name = "btnReplaceBooks";
            this.btnReplaceBooks.Size = new System.Drawing.Size(163, 23);
            this.btnReplaceBooks.TabIndex = 1;
            this.btnReplaceBooks.Text = "Replace Books";
            this.btnReplaceBooks.UseVisualStyleBackColor = true;
            this.btnReplaceBooks.Click += new System.EventHandler(this.btnReplaceBooks_Click);
            // 
            // btnIdentifyingAreas
            // 
            this.btnIdentifyingAreas.Location = new System.Drawing.Point(380, 221);
            this.btnIdentifyingAreas.Name = "btnIdentifyingAreas";
            this.btnIdentifyingAreas.Size = new System.Drawing.Size(163, 23);
            this.btnIdentifyingAreas.TabIndex = 2;
            this.btnIdentifyingAreas.Text = "Identifying Areas";
            this.btnIdentifyingAreas.UseVisualStyleBackColor = true;
            this.btnIdentifyingAreas.Click += new System.EventHandler(this.btnIdentifyingAreas_Click);
            // 
            // btnFindingCallNumbers
            // 
            this.btnFindingCallNumbers.Location = new System.Drawing.Point(380, 288);
            this.btnFindingCallNumbers.Name = "btnFindingCallNumbers";
            this.btnFindingCallNumbers.Size = new System.Drawing.Size(163, 23);
            this.btnFindingCallNumbers.TabIndex = 3;
            this.btnFindingCallNumbers.Text = "Finding Call Numbers";
            this.btnFindingCallNumbers.UseVisualStyleBackColor = true;
            this.btnFindingCallNumbers.Click += new System.EventHandler(this.btnFindingCallNumbers_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(324, 119);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(283, 17);
            this.lblPrompt.TabIndex = 4;
            this.lblPrompt.Text = "Please click on one of the following buttons:";
            // 
            // btnCallNumberWorking
            // 
            this.btnCallNumberWorking.Location = new System.Drawing.Point(380, 334);
            this.btnCallNumberWorking.Name = "btnCallNumberWorking";
            this.btnCallNumberWorking.Size = new System.Drawing.Size(182, 23);
            this.btnCallNumberWorking.TabIndex = 5;
            this.btnCallNumberWorking.Text = "Working Call Number Quiz";
            this.btnCallNumberWorking.UseVisualStyleBackColor = true;
            this.btnCallNumberWorking.Click += new System.EventHandler(this.btnCallNumberWorking_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.btnCallNumberWorking);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnFindingCallNumbers);
            this.Controls.Add(this.btnIdentifyingAreas);
            this.Controls.Add(this.btnReplaceBooks);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmWelcome";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnReplaceBooks;
        private System.Windows.Forms.Button btnIdentifyingAreas;
        private System.Windows.Forms.Button btnFindingCallNumbers;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnCallNumberWorking;
    }
}

