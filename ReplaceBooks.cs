using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FROM THE GET GO DESIGN IS A PROBLEM HOWEVER THIS IS THE PR-LIMINARY DESIGN AND STURCTURE. INITIALLY I INTENDED ON USING USER CONTROLS TO IMPLEMENT THE DRAG AND DROP GAMIFICATION FUNCTIONALITY HOWEVER 
//DUE TO TIME CONSTRAINTS I THUS SETTLED FOR THE LISTBOX OPTION EVERYTHING IS FULLY FUNCTIONAL JUST

namespace DeweyDecimalManagmentSystem
{
    public partial class ReplaceBooks : Form
    {
        //declaration of utilized lists being the sorted list and user answer list thats recorded upon button click for when the user obtains their results at the end of the game

        private const int MAX_NO_OF_CALL_NUM_GENERATION = 10;
        private List<double> SortedListFinal;

        private List<double> UserAnswerList = new List<double>();
        //a method used to receive an unsorted list as a paramter and is sorted using a recursive bubble sort, thus producing a sorted list as a return function
        public List<double> GenerateSortedList(List<double> UnsortedList)
        {
            var n = UnsortedList.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (UnsortedList[j] > UnsortedList[j + 1])
                    {
                        var tempVar = UnsortedList[j];
                        UnsortedList[j] = UnsortedList[j + 1];
                        UnsortedList[j + 1] = tempVar;
                    }



            SortedListFinal = UnsortedList.ToList();

            return UnsortedList;
        }
        //a method used to generate a list of the ten call numbers
        public List<double> GenerateCallNumberList()
        {

            CallNumberGeneration objCallNumberGeneration = new CallNumberGeneration();
            List<double> callnumbers = new List<double>();

            for (int i = 0; i < MAX_NO_OF_CALL_NUM_GENERATION; i++)
            {

                callnumbers.Add(objCallNumberGeneration.CallNum());


            }



            return callnumbers;
        }


        CallNumberGeneration objCallNumberGeneration = new CallNumberGeneration();

        List<double> LocalCaLLNumberList = new List<double>();
        public ReplaceBooks()
        {
            InitializeComponent();
            lstDrag.AllowDrop = true;
            lstDrop.AllowDrop = true;

        }

        private void lstDrag_MouseDown(object sender, MouseEventArgs e)
        {
            lstDrop.DoDragDrop(lstDrag.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void lstDrop_DragEnter(object sender, DragEventArgs e)
        {

            try
            {

                //
                if (e.Data.GetDataPresent(DataFormats.Text))
                {
                    e.Effect = DragDropEffects.Copy;
                    ProgressBarGame.Value = ProgressBarGame.Value + 10;

                }
                else
                {

                    e.Effect = DragDropEffects.None;

                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void lstDrop_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //on the current active drag the receiving list being list drop gets the current active selected data into 

                lstDrop.Items.Add(e.Data.GetData(DataFormats.Text));

                //this is hypothetically supposed to work but isn't removing from the drag list as the listboxs' data source was set to the randomly generated list of call numbers
                //I was battling with this for a couple of hours
                lstDrag.Items.Remove(e.Data.GetData(DataFormats.Text));
            }

            catch(Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void ReplaceBooks_Activated(object sender, EventArgs e)
        {
            try
            {
                //on show the necessary lists shall be populated
                LocalCaLLNumberList = GenerateCallNumberList().ToList();
                lstDrag.DataSource = (LocalCaLLNumberList);
                lstDisplaySorted.DataSource = GenerateSortedList(LocalCaLLNumberList);

                CallNumberGeneration objCallNumberGeneration = new CallNumberGeneration();

                LocalCaLLNumberList = GenerateCallNumberList().ToList();
                GenerateSortedList(GenerateCallNumberList());
                //initializing progress bar and firing timer count
                ProgressBarGame.Minimum = 0;
                ProgressBarGame.Maximum = 100;

                tmrGame.Start();
            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message);
            
            }

        }

        private void btnObtainResults_Click(object sender, EventArgs e)
        {
            try
            {
                lstDrag.Enabled = false;

                foreach (double item in lstDrop.Items)
                {

                    UserAnswerList.Add(item);


                    // same the item to the database

                }

                DetermineOutcome objDetermine = new DetermineOutcome();

                Boolean bUserOrderIsCorrect = objDetermine.CheckIfUserGotTheCorrectOrder(UserAnswerList, SortedListFinal);

                if (bUserOrderIsCorrect == true)
                {
                    tmrGame.Stop();
                    MessageBox.Show("CONGRATULATIONS YOU HAVE SUCCESFULLY ORDERED THE ELEMENTS IN THE CORRECT ORDER");

                }

                else
                {
                    MessageBox.Show("Unfortunately you haven't gotten the list in the correct order");


                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void lstDrag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
