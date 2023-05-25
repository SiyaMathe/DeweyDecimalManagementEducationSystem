using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalManagmentSystem
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }
        //
        private void blbWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnReplaceBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmReplaceBooks = new ReplaceBooks();
            frmReplaceBooks.Show();
            

        }

        private void btnIdentifyingAreas_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form frmIdentifyingTasks = new IdentifyingTasks();
            frmIdentifyingTasks.Show();
        }

        private void btnFindingCallNumbers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmFindingCallNumbers = new FindingCallNumbers();
            frmFindingCallNumbers.Show();
        }

        private void btnCallNumberWorking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmWorkingFindCallNumber = new WorkingFindCallNumberQuiz();
            frmWorkingFindCallNumber.Show();
        }
    }
}
