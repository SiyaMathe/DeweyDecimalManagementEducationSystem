using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeweyDecimalManagmentSystem.Node_Working_Tree_;


namespace DeweyDecimalManagmentSystem
{
    public partial class WorkingFindCallNumberQuiz : Form
    {

        public List<int> CallNumList = new List<int>();
        public List<string> ColumnTest = new List<string>();
        public int UserScore;

        public int intCount;
        public string key;
        public string value;

        private Random randomiser = new Random();

        private const int SCORE_DECREASE_AMOUNT = 5;
        private const int SCORE_INCREASE_AMOUNT = 10;

        Tree<string> tree = new Tree<string>();

        public string s1 = "\t";
        public string s2 = "\t\t";
        public string line;
        public string file_contents = "";
        public int index;
        public int index3;
        public List<string> temp = new List<string>();
        public List<int> indexList = new List<int>();
        public List<int> indexList3 = new List<int>();
        public List<string> indexList2 = new List<string>();
        public List<string> indexList4 = new List<string>();
        public List<string> indexList5 = new List<string>();
        public List<string> indexList6 = new List<string>();
        public int num = 0;
        public int num3 = 0;
        public int randomCall = 0;      //random level 3 call number 
        public int newRand = 0;
        public int newRand2 = 0;
        public int newRand3 = 0;
        public string strRand = "";
        public List<string> firstCall = new List<string>();     //stores first level call number 
        public List<string> secondCall = new List<string>();    //stores second level call number 
        public List<string> thirdCall = new List<string>();     //stores third level call number 
        public string newstring;
        public string newstring2;
        public string newstring3;
        public string strRand2;
        public string strRand3;
        public string strRand4;
        public Random rand = new Random();
        
        public WorkingFindCallNumberQuiz()
        {
            InitializeComponent();


            button3.Visible = false;
            btnSubmitAnswer.Visible = false;

            tree.Root = new TreeNode<string>() { Data = "DeweyDecimal" };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (!line.Contains(s1))
                        temp.Add(line);
                }
            }       //streamreader that fills the tree with call number level 1 
            tree.Root.Children = new List<TreeNode<string>>
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(0), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(1), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(2), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(3), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(4), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(5), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(6), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(7), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(8), Parent = tree.Root},
                        new TreeNode<string>() {Data = temp.ElementAt(9), Parent = tree.Root}
                    };                     //loads the tree 
            temp.Clear();
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //2nd call number 
                {
                    line = sr.ReadLine();
                    if (!line.Contains(s2) && line.Contains(s1))

                        temp.Add(line);
                }
            }       //streamreader that fills tree with call number level 2
            tree.Root.Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(0), Parent = tree.Root.Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(1), Parent = tree.Root.Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(2), Parent = tree.Root.Children[0] }
                    };      //loads the tree 
            tree.Root.Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(3), Parent = tree.Root.Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(4), Parent = tree.Root.Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(5), Parent = tree.Root.Children[1] }
                    };
            tree.Root.Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(6), Parent = tree.Root.Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(7), Parent = tree.Root.Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(8), Parent = tree.Root.Children[2] }
                    };
            tree.Root.Children[3].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(9), Parent = tree.Root.Children[3] },
                        new TreeNode<string>() {Data = temp.ElementAt(10), Parent = tree.Root.Children[3] },
                        new TreeNode<string>() {Data = temp.ElementAt(11), Parent = tree.Root.Children[3] }
                    };
            tree.Root.Children[4].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(12), Parent = tree.Root.Children[4] },
                        new TreeNode<string>() {Data = temp.ElementAt(13), Parent = tree.Root.Children[4] },
                        new TreeNode<string>() {Data = temp.ElementAt(14), Parent = tree.Root.Children[4] }
                    };
            tree.Root.Children[5].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(15), Parent = tree.Root.Children[5] },
                        new TreeNode<string>() {Data = temp.ElementAt(16), Parent = tree.Root.Children[5] },
                        new TreeNode<string>() {Data = temp.ElementAt(17), Parent = tree.Root.Children[5] }
                    };
            tree.Root.Children[6].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(18), Parent = tree.Root.Children[6] },
                        new TreeNode<string>() {Data = temp.ElementAt(19), Parent = tree.Root.Children[6] },
                        new TreeNode<string>() {Data = temp.ElementAt(20), Parent = tree.Root.Children[6] }
                    };
            tree.Root.Children[7].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(21), Parent = tree.Root.Children[7] },
                        new TreeNode<string>() {Data = temp.ElementAt(22), Parent = tree.Root.Children[7] },
                        new TreeNode<string>() {Data = temp.ElementAt(23), Parent = tree.Root.Children[7] }
                    };
            tree.Root.Children[8].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(24), Parent = tree.Root.Children[8] },
                        new TreeNode<string>() {Data = temp.ElementAt(25), Parent = tree.Root.Children[8] },
                        new TreeNode<string>() {Data = temp.ElementAt(26), Parent = tree.Root.Children[8] }
                    };
            tree.Root.Children[9].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(27), Parent = tree.Root.Children[9] },
                        new TreeNode<string>() {Data = temp.ElementAt(28), Parent = tree.Root.Children[9] },
                        new TreeNode<string>() {Data = temp.ElementAt(29), Parent = tree.Root.Children[9] }
                    };
            temp.Clear();
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }       //streamreader that fills the tree with call number level 3 
            tree.Root.Children[0].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(0), Parent = tree.Root.Children[0].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(1), Parent = tree.Root.Children[0].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(2), Parent = tree.Root.Children[0].Children[0] }
                    }; //loads the tree 
            tree.Root.Children[0].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(3), Parent = tree.Root.Children[0].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(4), Parent = tree.Root.Children[0].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(5), Parent = tree.Root.Children[0].Children[1] }
                    };
            tree.Root.Children[0].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(6), Parent = tree.Root.Children[0].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(7), Parent = tree.Root.Children[0].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(8), Parent = tree.Root.Children[0].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[1].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(9), Parent = tree.Root.Children[1].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(10), Parent = tree.Root.Children[1].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(11), Parent = tree.Root.Children[1].Children[0] }
                    };
            tree.Root.Children[1].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(12), Parent = tree.Root.Children[1].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(13), Parent = tree.Root.Children[1].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(14), Parent = tree.Root.Children[1].Children[1] }
                    };
            tree.Root.Children[1].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(15), Parent = tree.Root.Children[1].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(16), Parent = tree.Root.Children[1].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(17), Parent = tree.Root.Children[1].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[2].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(18), Parent = tree.Root.Children[2].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(19), Parent = tree.Root.Children[2].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(20), Parent = tree.Root.Children[2].Children[0] }
                    };
            tree.Root.Children[2].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(21), Parent = tree.Root.Children[2].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(22), Parent = tree.Root.Children[2].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(23), Parent = tree.Root.Children[2].Children[1] }
                    };
            tree.Root.Children[2].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(24), Parent = tree.Root.Children[2].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(25), Parent = tree.Root.Children[2].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(26), Parent = tree.Root.Children[2].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[3].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(27), Parent = tree.Root.Children[3].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(28), Parent = tree.Root.Children[3].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(29), Parent = tree.Root.Children[3].Children[0] }
                    };
            tree.Root.Children[3].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(30), Parent = tree.Root.Children[3].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(31), Parent = tree.Root.Children[3].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(32), Parent = tree.Root.Children[3].Children[1] }
                    };
            tree.Root.Children[3].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(33), Parent = tree.Root.Children[3].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(34), Parent = tree.Root.Children[3].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(35), Parent = tree.Root.Children[3].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[4].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(36), Parent = tree.Root.Children[4].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(37), Parent = tree.Root.Children[4].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(38), Parent = tree.Root.Children[4].Children[0] }
                    };
            tree.Root.Children[4].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(39), Parent = tree.Root.Children[4].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(40), Parent = tree.Root.Children[4].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(41), Parent = tree.Root.Children[4].Children[1] }
                    };
            tree.Root.Children[4].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(42), Parent = tree.Root.Children[4].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(43), Parent = tree.Root.Children[4].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(44), Parent = tree.Root.Children[4].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[5].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(45), Parent = tree.Root.Children[5].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(46), Parent = tree.Root.Children[5].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(47), Parent = tree.Root.Children[5].Children[0] }
                    };
            tree.Root.Children[5].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(48), Parent = tree.Root.Children[5].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(49), Parent = tree.Root.Children[5].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(50), Parent = tree.Root.Children[5].Children[1] }
                    };
            tree.Root.Children[5].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(51), Parent = tree.Root.Children[5].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(52), Parent = tree.Root.Children[5].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(53), Parent = tree.Root.Children[5].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[6].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(54), Parent = tree.Root.Children[6].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(55), Parent = tree.Root.Children[6].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(56), Parent = tree.Root.Children[6].Children[0] }
                    };
            tree.Root.Children[6].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(57), Parent = tree.Root.Children[6].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(58), Parent = tree.Root.Children[6].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(59), Parent = tree.Root.Children[6].Children[1] }
                    };
            tree.Root.Children[6].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(60), Parent = tree.Root.Children[6].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(61), Parent = tree.Root.Children[6].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(62), Parent = tree.Root.Children[6].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[7].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(63), Parent = tree.Root.Children[7].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(64), Parent = tree.Root.Children[7].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(65), Parent = tree.Root.Children[7].Children[0] }
                    };
            tree.Root.Children[7].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(66), Parent = tree.Root.Children[7].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(67), Parent = tree.Root.Children[7].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(68), Parent = tree.Root.Children[7].Children[1] }
                    };
            tree.Root.Children[7].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(69), Parent = tree.Root.Children[7].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(70), Parent = tree.Root.Children[7].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(71), Parent = tree.Root.Children[7].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[8].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(72), Parent = tree.Root.Children[8].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(73), Parent = tree.Root.Children[8].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(74), Parent = tree.Root.Children[8].Children[0] }
                    };
            tree.Root.Children[8].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(75), Parent = tree.Root.Children[8].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(76), Parent = tree.Root.Children[8].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(77), Parent = tree.Root.Children[8].Children[1] }
                    };
            tree.Root.Children[8].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(78), Parent = tree.Root.Children[8].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(79), Parent = tree.Root.Children[8].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(80), Parent = tree.Root.Children[8].Children[2] }
                    };
            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream) //3rd call number 
                {
                    line = sr.ReadLine();
                    if (line.Contains(s1) && line.Contains(s2))
                        temp.Add(line);
                }
            }
            tree.Root.Children[9].Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(81), Parent = tree.Root.Children[9].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(82), Parent = tree.Root.Children[9].Children[0] },
                        new TreeNode<string>() {Data = temp.ElementAt(83), Parent = tree.Root.Children[9].Children[0] }
                    };
            tree.Root.Children[9].Children[1].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(84), Parent = tree.Root.Children[9].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(85), Parent = tree.Root.Children[9].Children[1] },
                        new TreeNode<string>() {Data = temp.ElementAt(86), Parent = tree.Root.Children[9].Children[1] }
                    };
            tree.Root.Children[9].Children[2].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string>() {Data = temp.ElementAt(87), Parent = tree.Root.Children[9].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(88), Parent = tree.Root.Children[9].Children[2] },
                        new TreeNode<string>() {Data = temp.ElementAt(89), Parent = tree.Root.Children[9].Children[2] }
                    };

            for (int i = 0; i < 10; i++)
            {
                indexList.Add(index);
                index++;
            }
            for (int i = 0; i < 3; i++)
            {
                indexList3.Add(index3);
                index3++;
            }
        }

        private void btnAddDescriptions_Click(object sender, EventArgs e)
        {
            lstAnswers.Items.Clear();
            txtQuizQuestion.Text = "";
            num = indexList.ElementAt(randomiser.Next(index));
            num3 = indexList3.ElementAt(randomiser.Next(index3));

            foreach (var node in tree.Root.Children[num].Children[num3].Children) //this gets all the tree data
            {
                lblScore.Text = UserScore.ToString();
                newstring = node.Data;
                newstring2 = node.Parent.Data.ToString();
                newstring3 = node.Parent.Parent.Data.ToString();
                newstring3 = newstring3.Trim();
                indexList2.Add(newstring);
                indexList5.Add(newstring2);
                indexList4.Add(newstring3);

            }

            randomCall = rand.Next(indexList2.Count);
            string strRand = indexList2[randomCall];
            strRand = strRand.Trim();
            strRand = strRand.Substring(4);
            txtQuizQuestion.Text = strRand;         //choices the random call number level 3
            lstAnswers.Items.Add(indexList4.ElementAt(randomCall)); //puts the correct answer in the listbox 

            using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (!line.Contains(s1))
                        thirdCall.Add(line);
                }
            }
            while (!lstAnswers.Items.Count.Equals(4))         //fills the list box with incorrect answers 
            {
                newRand = rand.Next(thirdCall.Count);
                strRand2 = thirdCall[newRand];
                if (!strRand2.Equals(indexList4.ElementAt(randomCall)) && !lstAnswers.Items.Contains(strRand2) && !lstAnswers.Items.Equals(newstring3) && !lstAnswers.Items.Contains(strRand2))
                {
                    lstAnswers.Items.Add(strRand2);
                    strRand2 = "";
                }
            }
            lstAnswers.Sorted = true;
            button1.Visible = true;
            button3.Visible = false;
            btnSubmitAnswer.Visible = false;

        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (lstAnswers.SelectedIndex.Equals(-1))
                MessageBox.Show("Please select an Item first!");
            else
            {
                if (lstAnswers.SelectedItem.Equals(indexList2.ElementAt(randomCall))) //checks if answer is correct 
                {
                    lstAnswers.Items.Clear();
                    txtQuizQuestion.Text = "Well Done, you have completed the quiz!";
                    lblUserScoreDescrip.Text = "Well Done \n +20";         //gamification feature code 
                    UserScore = UserScore + SCORE_INCREASE_AMOUNT;
                    lblScore.Text =lblScore.Text+ UserScore.ToString();

                    button1.Visible = false;
                    button3.Visible = false;
                    btnSubmitAnswer.Visible = true;

                }
                else if (!lstAnswers.SelectedItem.Equals(indexList2.ElementAt(randomCall)))
                {
                    lblUserScoreDescrip.Text = "Incorrect \n -10";
                    UserScore = UserScore - SCORE_DECREASE_AMOUNT;
                    lblScore.Text = UserScore.ToString();
                    lstAnswers.Items.Clear();
                    txtQuizQuestion.Text = "";
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (lstAnswers.SelectedIndex.Equals(-1))
                MessageBox.Show("Please select an Item first!");
            else
            {
                if (lstAnswers.SelectedItem.Equals(indexList5.ElementAt(randomCall)))
                {
                    lstAnswers.Items.Clear();
                    lstAnswers.Items.Add(indexList2.ElementAt(randomCall)); //puts the correct answer in the listbox 

                    using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
                    {
                        while (!sr.EndOfStream) //3rd call number 
                        {
                            line = sr.ReadLine();
                            if (line.Contains(s1) && line.Contains(s2))
                                firstCall.Add(line);
                        }
                    }

                    while (!lstAnswers.Items.Count.Equals(4))//fills the list box with incorrect answers 
                    {
                        newRand3 = rand.Next(firstCall.Count);
                        strRand4 = firstCall[newRand3];
                        if (!lstAnswers.Items.Contains(strRand4))
                        {
                            lstAnswers.Items.Add(strRand4);
                            strRand4 = "";
                        }
                    }
                    UserScore = UserScore + 20;
                    lblScore.Text = UserScore.ToString();
                    lblUserScoreDescrip.Text = "Well Done \n +20";
                    button1.Visible = false;
                    button3.Visible = false;
                    btnSubmitAnswer.Visible = true;
                }
                else if (!lstAnswers.SelectedItem.Equals(indexList5.ElementAt(randomCall)))
                {
                    lblUserScoreDescrip.Text = "Incorrect \n -10";
                    UserScore = UserScore - 10;
                    lblScore.Text = UserScore.ToString();
                    lstAnswers.Items.Clear();
                    txtQuizQuestion.Text = "";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstAnswers.SelectedIndex.Equals(-1))
                MessageBox.Show("Please select an Item first!");
            else
            {
                if (lstAnswers.SelectedItem.Equals(indexList4.ElementAt(randomCall)))
                {
                    lstAnswers.Items.Clear();
                    lstAnswers.Items.Add(indexList5.ElementAt(randomCall)); //puts the correct answer in the listbox 
                    using (StreamReader sr = new StreamReader("DeweyDecimalTreeDataSoucre.txt"))
                    {
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
                            if (!line.Contains(s2) && line.Contains(s1))
                                secondCall.Add(line);
                        }
                    }
                    while (!lstAnswers.Items.Count.Equals(4))//fills the list box with incorrect answers 
                    {
                        newRand2 = rand.Next(secondCall.Count);
                        strRand3 = secondCall[newRand2];
                        if (!strRand3.Equals(indexList5.ElementAt(randomCall)) && !lstAnswers.Items.Contains(strRand3) && !lstAnswers.Items.Equals(newstring3))
                        {
                            lstAnswers.Items.Add(strRand3);
                            strRand3 = "";
                        }
                    }
                    UserScore = UserScore + 20;
                    lblUserScoreDescrip.Text = UserScore.ToString();
                    lblUserScoreDescrip.Text = "Well Done \n +20";
                    button1.Visible = false;
                    button3.Visible = true;
                    btnSubmitAnswer.Visible = false;
                }
                else if (!lstAnswers.SelectedItem.Equals(indexList4.ElementAt(randomCall)))
                {
                    lblUserScoreDescrip.Text = "Incorrect \n -10";
                    UserScore = UserScore - 10;
                    lblScore.Text = UserScore.ToString();
                    lstAnswers.Items.Clear();
                    txtQuizQuestion.Text = "";
                }
            }
        }
    }
}
