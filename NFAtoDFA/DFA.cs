using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFAtoDFA
{
    public partial class DFA : Form
    {
        public ArrayList SetOfLetters = new ArrayList();
        public ArrayList SetOfNFAStates = new ArrayList();
        public ArrayList SetOfFinalStates = new ArrayList();
        public ArrayList TransitionFuntions = new ArrayList();
        public ArrayList SetOfDFAStates = new ArrayList();
        public string InitialState = "";

        public DFA()
        {
            InitializeComponent();
        }

        public DFA(NFA NFA)
        {
            InitializeComponent();
        }

        private void DFA_Load(object sender, EventArgs e)
        {
            SetOfDFAStates.Add(InitialState);
            for (int i = 0; i < SetOfLetters.Count; i++)
            {
                // Initialize group boxes that contain letters
                GroupBox grp_Letter = new GroupBox();
                grp_Letter.Width = 90;
                grp_Letter.Height = 40;
                grp_Letter.Location = new Point(120 + 90 * i, 0);
                pnl_DFA.Controls.Add(grp_Letter);

                // Initialize a label in each group box that displays letter
                Label lbl_Letter = new Label();
                lbl_Letter.Width = 80;
                lbl_Letter.Location = new Point(10, 10);
                lbl_Letter.Text = SetOfLetters[i].ToString();
                grp_Letter.Controls.Add(lbl_Letter);
            }

            int j = 0;
            while (true)
            {
                // Initialize group boxes that contain states
                GroupBox grp_FirstState = new GroupBox();
                grp_FirstState.Width = 90;
                grp_FirstState.Height = 40;
                grp_FirstState.Location = new Point(30, 40 + 40 * j);
                pnl_DFA.Controls.Add(grp_FirstState);

                // Initialize a label in each group box that displays state
                Label lbl_FirstState = new Label();
                lbl_FirstState.Width = 80;
                lbl_FirstState.Location = new Point(10, 10);
                lbl_FirstState.Text = SetOfDFAStates[j].ToString();
                grp_FirstState.Controls.Add(lbl_FirstState);

                for (int k = 0; k < SetOfLetters.Count; k++)
                {
                    GroupBox grp_SecondState = new GroupBox();
                    grp_SecondState.Width = 90;
                    grp_SecondState.Height = 40;
                    grp_SecondState.Location = new Point(120 + 90 * k, 40 + 40 * j);
                    pnl_DFA.Controls.Add(grp_SecondState);

                    string tempState = string.Empty;
                    string[] DFAStates = SetOfDFAStates[j].ToString().Split(' ');
                    for (int n = 0; n < DFAStates.Length; n++)
                    {
                        if (DFAStates[n] == string.Empty) continue;

                        foreach (TransitionFunction func in TransitionFuntions)
                        {
                            if (func.FirstState == DFAStates[n] && func.Letter == SetOfLetters[k].ToString())
                            {
                                if (!tempState.Contains(func.SecondState.ToString()))
                                {
                                    tempState += func.SecondState.ToString() + "  ";
                                }
                            }
                        }
                    }

                    Label lbl_SecondState = new Label();
                    lbl_SecondState.Width = 80;
                    lbl_SecondState.Location = new Point(10, 10);
                    lbl_SecondState.Text = tempState;
                    grp_SecondState.Controls.Add(lbl_SecondState);

                    bool needAdd = true;
                    foreach (object state in SetOfDFAStates)
                    {
                        if (state.ToString() == tempState || tempState == string.Empty)
                            needAdd = false;
                    }
                    if (needAdd) SetOfDFAStates.Add(tempState);
                }
                j++;

                if (j >= SetOfDFAStates.Count) return;
            }
        }
    }
}
