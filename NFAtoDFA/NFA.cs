using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFAtoDFA
{
    public partial class NFA : Form
    {
        public ArrayList SetOfLetters = new ArrayList();
        public ArrayList SetOfNFAStates = new ArrayList();
        public ArrayList SetOfFinalStates = new ArrayList();
        public ArrayList TransitionFunctions = new ArrayList();

        public string InitialState = string.Empty;

        public NFA()
        {
            InitializeComponent();
        }

        private void btn_AddLetters_Click(object sender, EventArgs e)
        {
            // Refresh Letters' fields
            lbl_SetOfLetters.Text = string.Empty;
            cbo_Letter.Items.Clear();
            SetOfLetters.Clear();

            string[] arrSetOfLetters = txt_Letters.Text.Split(' ').Distinct().ToArray();
            foreach (var letter in arrSetOfLetters)
            {
                if (letter == string.Empty) continue;

                SetOfLetters.Add(letter.ToString());
                lbl_SetOfLetters.Text += letter + "  ";
                cbo_Letter.Items.Add(letter);
            }
        }

        private void btn_AddNFAStates_Click(object sender, EventArgs e)
        {
            // Refresh NFA States' fields
            lbl_SetOfNFAStates.Text = string.Empty;
            cbo_FirstState.Items.Clear();
            cbo_SecondState.Items.Clear();
            cbo_InitialState.Items.Clear();
            SetOfNFAStates.Clear();

            string[] arrSetOfNFAStates = txt_NFAStates.Text.Split(' ').Distinct().ToArray();
            foreach (var state in arrSetOfNFAStates)
            {
                if (state == string.Empty) continue;

                SetOfNFAStates.Add(state.ToString());
                lbl_SetOfNFAStates.Text += state + "  ";
                cbo_InitialState.Items.Add(state);
                cbo_FirstState.Items.Add(state);
                cbo_SecondState.Items.Add(state);

                cbo_InitialState.SelectedIndex = 0;
            }
            InitChkFinalStates();
        }

        private void btn_AddTF_Click(object sender, EventArgs e)
        {
            TransitionFunction TF = new TransitionFunction();
            TF.FirstState = cbo_FirstState.SelectedItem.ToString();
            TF.SecondState = cbo_SecondState.SelectedItem.ToString();
            TF.Letter = cbo_Letter.SelectedItem.ToString();

            // Check if added function has existed
            foreach (TransitionFunction func in TransitionFunctions)
            {
                if (TF.FirstState == func.FirstState && TF.SecondState == func.SecondState
                    && TF.Letter == func.Letter)
                    return;
            }

            TransitionFunctions.Add(TF);

            lst_TF.Items.Clear();
            foreach (TransitionFunction func in TransitionFunctions)
            {
                string temp = string.Empty;
                temp += func.FirstState + " read " + func.Letter + " --> " + func.SecondState;
                lst_TF.Items.Add(temp);
            }
        }

        private void cbo_InitialState_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_InitialStateResult.Text = cbo_InitialState.Text;
            InitialState = cbo_InitialState.Text;
        }

        private void InitChkFinalStates()
        {
            int i = 0;
            pnl_FinalStates.Controls.Clear();
            foreach (var state in SetOfNFAStates)
            {
                CheckBox chkFinalStates = new CheckBox();
                chkFinalStates.Name = "chkFinalState" + state;
                chkFinalStates.Text = state.ToString();
                chkFinalStates.Width = 50;
                chkFinalStates.Location = new Point(10, 20 * i);
                pnl_FinalStates.Controls.Add(chkFinalStates);
                chkFinalStates.CheckStateChanged += new EventHandler(this.chkFinalStates_SelectedIndexChanged);
                i++;
            }
        }

        private void chkFinalStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_SetOfFinalStates.Text = string.Empty;
            foreach (var state in SetOfNFAStates)
            {
                CheckBox chk = (CheckBox)pnl_FinalStates.Controls.Find("chkFinalState" + state.ToString(), true)[0];
                if (chk.Checked)
                {
                    lbl_SetOfFinalStates.Text += state.ToString() + "  ";
                    SetOfFinalStates.Add(state.ToString());
                }
            }
        }

        private bool isNFA()
        {
            foreach (TransitionFunction func1 in TransitionFunctions)
            {
                foreach (TransitionFunction func2 in TransitionFunctions)
                {
                    if (func1.FirstState == func2.FirstState && func1.Letter == func2.Letter &&
                            func1.SecondState != func2.SecondState)
                        return true;
                }
            }
            return false;
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if (isNFA())
                {
                    DFA DFA = new NFAtoDFA.DFA(this);
                    DFA.SetOfLetters = this.SetOfLetters;
                    DFA.SetOfNFAStates = this.SetOfNFAStates;
                    DFA.SetOfFinalStates = this.SetOfFinalStates;
                    DFA.TransitionFuntions = this.TransitionFunctions;
                    DFA.InitialState = this.InitialState;
                    DFA.Show();
                }
                else
                    MessageBox.Show("This is not a NFA");
            }
            catch(Exception ex)
            {
                string error = "Please enter all Letter(s) or(and) State(s)"
                    + "\nError:\n" + ex.Message;
                MessageBox.Show(error);
            }
        }

        private void btn_RemoveTF_Click(object sender, EventArgs e)
        {
            if (lst_TF.SelectedIndex != -1)
            { 
                TransitionFunctions.RemoveAt(lst_TF.SelectedIndex);
                lst_TF.Items.RemoveAt(lst_TF.SelectedIndex);
            }

            lst_TF.Items.Clear();
            foreach (TransitionFunction func in TransitionFunctions)
            {
                string temp = string.Empty;
                temp += func.FirstState + " read " + func.Letter + " --> " + func.SecondState;
                lst_TF.Items.Add(temp);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
