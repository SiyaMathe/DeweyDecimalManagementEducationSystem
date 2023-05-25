
namespace DeweyDecimalManagmentSystem
{
    partial class ReplaceBooks
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
            this.components = new System.ComponentModel.Container();
            this.lstDrag = new System.Windows.Forms.ListBox();
            this.lstDrop = new System.Windows.Forms.ListBox();
            this.ProgressBarGame = new System.Windows.Forms.ProgressBar();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.btnObtainResults = new System.Windows.Forms.Button();
            this.lstDisplaySorted = new System.Windows.Forms.ListBox();
            this.lblPromptDrag = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDrag
            // 
            this.lstDrag.FormattingEnabled = true;
            this.lstDrag.ItemHeight = 16;
            this.lstDrag.Location = new System.Drawing.Point(45, 126);
            this.lstDrag.Name = "lstDrag";
            this.lstDrag.Size = new System.Drawing.Size(206, 228);
            this.lstDrag.TabIndex = 0;
            this.lstDrag.SelectedIndexChanged += new System.EventHandler(this.lstDrag_SelectedIndexChanged);
            this.lstDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstDrag_MouseDown);
            // 
            // lstDrop
            // 
            this.lstDrop.FormattingEnabled = true;
            this.lstDrop.ItemHeight = 16;
            this.lstDrop.Location = new System.Drawing.Point(623, 126);
            this.lstDrop.Name = "lstDrop";
            this.lstDrop.Size = new System.Drawing.Size(198, 228);
            this.lstDrop.TabIndex = 1;
            this.lstDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDrop_DragDrop);
            this.lstDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstDrop_DragEnter);
            // 
            // ProgressBarGame
            // 
            this.ProgressBarGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBarGame.ForeColor = System.Drawing.Color.Purple;
            this.ProgressBarGame.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarGame.Name = "ProgressBarGame";
            this.ProgressBarGame.Size = new System.Drawing.Size(872, 23);
            this.ProgressBarGame.TabIndex = 2;
            // 
            // btnObtainResults
            // 
            this.btnObtainResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnObtainResults.Location = new System.Drawing.Point(0, 493);
            this.btnObtainResults.Name = "btnObtainResults";
            this.btnObtainResults.Size = new System.Drawing.Size(872, 23);
            this.btnObtainResults.TabIndex = 3;
            this.btnObtainResults.Text = "Obtain Results";
            this.btnObtainResults.UseVisualStyleBackColor = true;
            this.btnObtainResults.Click += new System.EventHandler(this.btnObtainResults_Click);
            // 
            // lstDisplaySorted
            // 
            this.lstDisplaySorted.FormattingEnabled = true;
            this.lstDisplaySorted.ItemHeight = 16;
            this.lstDisplaySorted.Location = new System.Drawing.Point(388, 209);
            this.lstDisplaySorted.Name = "lstDisplaySorted";
            this.lstDisplaySorted.Size = new System.Drawing.Size(120, 84);
            this.lstDisplaySorted.TabIndex = 4;
            // 
            // lblPromptDrag
            // 
            this.lblPromptDrag.AutoSize = true;
            this.lblPromptDrag.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromptDrag.Location = new System.Drawing.Point(25, 39);
            this.lblPromptDrag.Name = "lblPromptDrag";
            this.lblPromptDrag.Size = new System.Drawing.Size(779, 17);
            this.lblPromptDrag.TabIndex = 5;
            this.lblPromptDrag.Text = "Please drag the following elements to the target list in your perceived correct o" +
    "rder";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(620, 81);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(98, 17);
            this.lblTarget.TabIndex = 6;
            this.lblTarget.Text = "Target Listbox";
            // 
            // ReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(872, 516);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblPromptDrag);
            this.Controls.Add(this.lstDisplaySorted);
            this.Controls.Add(this.btnObtainResults);
            this.Controls.Add(this.ProgressBarGame);
            this.Controls.Add(this.lstDrop);
            this.Controls.Add(this.lstDrag);
            this.Name = "ReplaceBooks";
            this.Text = "ReplaceBooks";
            this.Activated += new System.EventHandler(this.ReplaceBooks_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDrag;
        private System.Windows.Forms.ListBox lstDrop;
        private System.Windows.Forms.ProgressBar ProgressBarGame;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Button btnObtainResults;
        private System.Windows.Forms.ListBox lstDisplaySorted;
        private System.Windows.Forms.Label lblPromptDrag;
        private System.Windows.Forms.Label lblTarget;
    }
}