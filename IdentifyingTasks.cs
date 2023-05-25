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
    public partial class IdentifyingTasks : Form
    {

       // count index variable to monitor position whilst iterating through the data structures(lists,dictionaries)

       private  int iCount;
        //dictionaries to store the the call numbers and their corresponding descriptions. I opted to store the call numbers using string because its a simple match , no calculations etc.
        //just purely using the lisbox and the selected index to obtain the correct key value combination for each pair 

        Dictionary<string, string> DeweyDecimalDictonary = new Dictionary<string, string>();
        Dictionary<string, string> WrongUserCombinations = new Dictionary<string, string>();
        private int UserScore;

        public int UserScore1 { get => UserScore; set => UserScore = value; }
        private Random ranGenerator = new Random();
        private const int SCORE_DECREASE_AMOUNT= 5;
        private const int SCORE_INCREASE_AMOUNT = 10;

        public IdentifyingTasks()
        {
            InitializeComponent();
        }

        private void IdentifyingTasks_Load(object sender, EventArgs e)
        {

        }
        private void RandomiseKeyDisplayListbox()
        {

            //randomising and populating call numbers through iterating through structure using the number of elements and random object generator 
            try
            {
                int count = this.lstKeys.Items.Count;
                object item;

                for (int index = 0; index <= count - 2; index++)
                {
                    item = this.lstKeys.Items[this.ranGenerator.Next(index, count)];
                    this.lstKeys.Items.Remove(item);
                    this.lstKeys.Items.Insert(index, item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RandomiseValueDisplayListbox()
        {
            //randomising and populating descriptions through iterating through structure using the number of elements and random object generator 
            
            try
            {
                int count = this.lstValues.Items.Count;
                object item;

                for (int index = 0; index <= count - 2; index++)
                {
                    item = this.lstValues.Items[this.ranGenerator.Next(index, count)];
                    this.lstValues.Items.Remove(item);
                    this.lstValues.Items.Insert(index, item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateLists()
        {
            try
            {
                iCount++;
                lstKeys.Items.Clear();
                lstValues.Items.Clear();
                lblDisplayScore.Text = lblDisplayScore.Text+UserScore.ToString();
                Random random = new Random();
                int index;

                DeweyDecimalDictonary = new Dictionary<string, string>(){  //stores all the dictionary data 
                {"001-099", "Generalities"},
                {"100-199", "Philosophy and Psychology"},
                {"200-299", "Religion"},
                {"300-399", "Social Science"},
                {"400-499", "Languages"},
                {"500-599", "Natural Science"},
                {"600-699", "Applied Science"},
                {"700-799", "Arts and Recreation"},
                {"800-899", "Literature"},
                {"900-999", "Geography and History"},
                {"92 & 920", "Biography and Collective Biography"}
            };

                //evaluating whether index count/position of current position in the list we first evaluate whether the index is even and then we figure out which index range bound the
                //currently selected index is in so we populate the corresponding lists using the alternate rule of seven answers for four questions and vice versa dependent on the count variable
                //which enables us to keep track of when we need to alternate

                if (iCount % 2 == 0)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        while (lstKeys.Items.Count <= 3 || lstValues.Items.Count <= 6)
                        {
                            index = random.Next(DeweyDecimalDictonary.Count);

                            KeyValuePair<string, string> pair = DeweyDecimalDictonary.ElementAt(index);

                            if (lstKeys.Items.Count != 4)
                            {

                                lstKeys.Items.Add(pair.Key);
                                DeweyDecimalDictonary.Remove(pair.Key);
                                RandomiseKeyDisplayListbox();
                            }
                            if (lstValues.Items.Count != 7)
                            {
                                lstValues.Items.Add(pair.Value);
                                DeweyDecimalDictonary.Remove(pair.Value);
                                RandomiseValueDisplayListbox();
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        while (lstKeys.Items.Count <= 6 || lstValues.Items.Count <= 3)
                        {
                            index = random.Next(DeweyDecimalDictonary.Count);

                            KeyValuePair<string, string> pair = DeweyDecimalDictonary.ElementAt(index);

                            if (lstKeys.Items.Count != 7)
                            {

                                lstKeys.Items.Add(pair.Key);
                                DeweyDecimalDictonary.Remove(pair.Key);
                                RandomiseKeyDisplayListbox();
                            }
                            if (lstValues.Items.Count != 4)
                            {
                                lstValues.Items.Add(pair.Value);
                                DeweyDecimalDictonary.Remove(pair.Value);
                                RandomiseValueDisplayListbox();
                            }
                        }
                    }
                }
                if (lstKeys.Items.Count.Equals(0))
                {
                    lstKeys.Items.Clear();
                }
                if (lstValues.Items.Count.Equals(0))
                {
                    lstValues.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }



        private void btnPopulateLists_Click(object sender, EventArgs e)
        {
            PopulateLists();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {

            try
            {
                DeweyDecimalDictonary = new Dictionary<string, string>(){
                {"001-099", "Generalities"},
                {"100-199", "Philosophy and Psychology"},
                {"200-299", "Religion"},
                {"300-399", "Social Science"},
                {"400-499", "Languages"},
                {"500-599", "Natural Science"},
                {"600-699", "Applied Science"},
                {"700-799", "Arts and Recreation"},
                {"800-899", "Literature"},
                {"900-999", "Geography and History"},
                {"92 & 920", "Biography and Collective Biography"}
            };

                string lstKeyItem;
                string lstValuelItem;

                if (DetermineParemetersForAMatchCombinationAreActive() == true) {

                    lstKeyItem = lstKeys.SelectedItem.ToString();
                    lstValuelItem = lstValues.SelectedItem.ToString();
                    DetermineAnswerOutcome(lstKeyItem, lstValuelItem);

                    if (lstKeys.Items.Count.Equals(0))
                    {
                        lstKeys.Items.Clear();
                        if (lstValues.Items.Count.Equals(0))
                        {
                            lstValues.Items.Clear();
                        }
                    }


                }
                
                    
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private Boolean DetermineParemetersForAMatchCombinationAreActive()
        {
            Boolean isBothListsSelected = false;
            //-1 representing out of bounds index(hasn't been selected yet)
            if (lstKeys.SelectedIndex.Equals(-1))
                MessageBox.Show("Please ensure you have selected a call number!");
            if (lstValues.SelectedIndex.Equals(-1))
                MessageBox.Show("Please ensure you have selected a description!");
            else
            {
                isBothListsSelected = true;

            }

            return isBothListsSelected;
        }

        private Boolean DetermineAnswerOutcome(string selectedCallNumber, string selectedDescription)
        {

            Boolean isCorrect = false;
            if (DeweyDecimalDictonary.ContainsKey(selectedCallNumber.ToString()) && DeweyDecimalDictonary[selectedCallNumber.ToString()].Equals(selectedDescription.ToString()))
            {
                lblMatchStatus.Text = "Congratulations on the correct combination!";
                lstKeys.Items.RemoveAt(lstKeys.SelectedIndex);
                lstValues.Items.RemoveAt(lstValues.SelectedIndex);
                UserScore = UserScore + SCORE_INCREASE_AMOUNT;
                isCorrect = true;
                lblDisplayScore.Text = lblDisplayScore.Text+ UserScore.ToString();
                Alternate();

            }
            else
            {
                lblMatchStatus.Text = "Wrong combination, please try again!";
                WrongUserCombinations.Add(selectedCallNumber, selectedDescription);
                UserScore = UserScore - SCORE_DECREASE_AMOUNT;
                isCorrect = false;
                lblDisplayScore.Text = lblDisplayScore.Text + UserScore.ToString();

            }

            return isCorrect;
        }

        private void Alternate()
        {
            lstValues.Focus();
        }
    }
}
