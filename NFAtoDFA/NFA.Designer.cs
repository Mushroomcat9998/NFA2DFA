namespace NFAtoDFA
{
    partial class NFA
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
            this.lbl_Letters = new System.Windows.Forms.Label();
            this.lbl_NFAStates = new System.Windows.Forms.Label();
            this.lbl_TF = new System.Windows.Forms.Label();
            this.lbl_InitialState = new System.Windows.Forms.Label();
            this.pnl_FinalStates = new System.Windows.Forms.Panel();
            this.txt_Letters = new System.Windows.Forms.TextBox();
            this.txt_NFAStates = new System.Windows.Forms.TextBox();
            this.cbo_FirstState = new System.Windows.Forms.ComboBox();
            this.cbo_Letter = new System.Windows.Forms.ComboBox();
            this.cbo_SecondState = new System.Windows.Forms.ComboBox();
            this.cbo_InitialState = new System.Windows.Forms.ComboBox();
            this.btn_AddLetters = new System.Windows.Forms.Button();
            this.btn_AddNFAStates = new System.Windows.Forms.Button();
            this.btn_AddTF = new System.Windows.Forms.Button();
            this.btn_RemoveTF = new System.Windows.Forms.Button();
            this.lbl_FirstState = new System.Windows.Forms.Label();
            this.lbl_Letter = new System.Windows.Forms.Label();
            this.lbl_SecondState = new System.Windows.Forms.Label();
            this.grp_FinalStates = new System.Windows.Forms.GroupBox();
            this.grp_Letters = new System.Windows.Forms.GroupBox();
            this.lbl_SetOfLetters = new System.Windows.Forms.Label();
            this.grp_NFAStates = new System.Windows.Forms.GroupBox();
            this.lbl_SetOfNFAStates = new System.Windows.Forms.Label();
            this.grp_InitialState = new System.Windows.Forms.GroupBox();
            this.lbl_InitialStateResult = new System.Windows.Forms.Label();
            this.grp_TF = new System.Windows.Forms.GroupBox();
            this.lst_TF = new System.Windows.Forms.ListBox();
            this.grp_SetofFinalStates = new System.Windows.Forms.GroupBox();
            this.lbl_SetOfFinalStates = new System.Windows.Forms.Label();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.grp_FinalStates.SuspendLayout();
            this.grp_Letters.SuspendLayout();
            this.grp_NFAStates.SuspendLayout();
            this.grp_InitialState.SuspendLayout();
            this.grp_TF.SuspendLayout();
            this.grp_SetofFinalStates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Letters
            // 
            this.lbl_Letters.AutoSize = true;
            this.lbl_Letters.Location = new System.Drawing.Point(12, 21);
            this.lbl_Letters.Name = "lbl_Letters";
            this.lbl_Letters.Size = new System.Drawing.Size(42, 13);
            this.lbl_Letters.TabIndex = 0;
            this.lbl_Letters.Text = "Letters:";
            // 
            // lbl_NFAStates
            // 
            this.lbl_NFAStates.AutoSize = true;
            this.lbl_NFAStates.Location = new System.Drawing.Point(12, 54);
            this.lbl_NFAStates.Name = "lbl_NFAStates";
            this.lbl_NFAStates.Size = new System.Drawing.Size(64, 13);
            this.lbl_NFAStates.TabIndex = 1;
            this.lbl_NFAStates.Text = "NFA States:";
            // 
            // lbl_TF
            // 
            this.lbl_TF.AutoSize = true;
            this.lbl_TF.Location = new System.Drawing.Point(12, 91);
            this.lbl_TF.Name = "lbl_TF";
            this.lbl_TF.Size = new System.Drawing.Size(105, 13);
            this.lbl_TF.TabIndex = 2;
            this.lbl_TF.Text = "Transition Functions:";
            // 
            // lbl_InitialState
            // 
            this.lbl_InitialState.AutoSize = true;
            this.lbl_InitialState.Location = new System.Drawing.Point(12, 141);
            this.lbl_InitialState.Name = "lbl_InitialState";
            this.lbl_InitialState.Size = new System.Drawing.Size(62, 13);
            this.lbl_InitialState.TabIndex = 3;
            this.lbl_InitialState.Text = "Initial State:";
            // 
            // pnl_FinalStates
            // 
            this.pnl_FinalStates.Location = new System.Drawing.Point(6, 19);
            this.pnl_FinalStates.Name = "pnl_FinalStates";
            this.pnl_FinalStates.Size = new System.Drawing.Size(405, 222);
            this.pnl_FinalStates.TabIndex = 5;
            // 
            // txt_Letters
            // 
            this.txt_Letters.Location = new System.Drawing.Point(115, 18);
            this.txt_Letters.Name = "txt_Letters";
            this.txt_Letters.Size = new System.Drawing.Size(184, 20);
            this.txt_Letters.TabIndex = 6;
            // 
            // txt_NFAStates
            // 
            this.txt_NFAStates.Location = new System.Drawing.Point(115, 54);
            this.txt_NFAStates.Name = "txt_NFAStates";
            this.txt_NFAStates.Size = new System.Drawing.Size(184, 20);
            this.txt_NFAStates.TabIndex = 7;
            // 
            // cbo_FirstState
            // 
            this.cbo_FirstState.FormattingEnabled = true;
            this.cbo_FirstState.Location = new System.Drawing.Point(115, 111);
            this.cbo_FirstState.Name = "cbo_FirstState";
            this.cbo_FirstState.Size = new System.Drawing.Size(77, 21);
            this.cbo_FirstState.TabIndex = 8;
            // 
            // cbo_Letter
            // 
            this.cbo_Letter.FormattingEnabled = true;
            this.cbo_Letter.Location = new System.Drawing.Point(198, 111);
            this.cbo_Letter.Name = "cbo_Letter";
            this.cbo_Letter.Size = new System.Drawing.Size(74, 21);
            this.cbo_Letter.TabIndex = 9;
            // 
            // cbo_SecondState
            // 
            this.cbo_SecondState.FormattingEnabled = true;
            this.cbo_SecondState.Location = new System.Drawing.Point(278, 111);
            this.cbo_SecondState.Name = "cbo_SecondState";
            this.cbo_SecondState.Size = new System.Drawing.Size(73, 21);
            this.cbo_SecondState.TabIndex = 10;
            // 
            // cbo_InitialState
            // 
            this.cbo_InitialState.FormattingEnabled = true;
            this.cbo_InitialState.Location = new System.Drawing.Point(115, 138);
            this.cbo_InitialState.Name = "cbo_InitialState";
            this.cbo_InitialState.Size = new System.Drawing.Size(100, 21);
            this.cbo_InitialState.TabIndex = 11;
            this.cbo_InitialState.SelectedIndexChanged += new System.EventHandler(this.cbo_InitialState_SelectedIndexChanged);
            // 
            // btn_AddLetters
            // 
            this.btn_AddLetters.Location = new System.Drawing.Point(341, 16);
            this.btn_AddLetters.Name = "btn_AddLetters";
            this.btn_AddLetters.Size = new System.Drawing.Size(91, 23);
            this.btn_AddLetters.TabIndex = 12;
            this.btn_AddLetters.Text = "Add Letters";
            this.btn_AddLetters.UseVisualStyleBackColor = true;
            this.btn_AddLetters.Click += new System.EventHandler(this.btn_AddLetters_Click);
            // 
            // btn_AddNFAStates
            // 
            this.btn_AddNFAStates.Location = new System.Drawing.Point(341, 52);
            this.btn_AddNFAStates.Name = "btn_AddNFAStates";
            this.btn_AddNFAStates.Size = new System.Drawing.Size(91, 23);
            this.btn_AddNFAStates.TabIndex = 13;
            this.btn_AddNFAStates.Text = "Add NFA States";
            this.btn_AddNFAStates.UseVisualStyleBackColor = true;
            this.btn_AddNFAStates.Click += new System.EventHandler(this.btn_AddNFAStates_Click);
            // 
            // btn_AddTF
            // 
            this.btn_AddTF.Location = new System.Drawing.Point(357, 102);
            this.btn_AddTF.Name = "btn_AddTF";
            this.btn_AddTF.Size = new System.Drawing.Size(75, 23);
            this.btn_AddTF.TabIndex = 14;
            this.btn_AddTF.Text = "AddTF";
            this.btn_AddTF.UseVisualStyleBackColor = true;
            this.btn_AddTF.Click += new System.EventHandler(this.btn_AddTF_Click);
            // 
            // btn_RemoveTF
            // 
            this.btn_RemoveTF.Location = new System.Drawing.Point(357, 131);
            this.btn_RemoveTF.Name = "btn_RemoveTF";
            this.btn_RemoveTF.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveTF.TabIndex = 15;
            this.btn_RemoveTF.Text = "RemoveTF";
            this.btn_RemoveTF.UseVisualStyleBackColor = true;
            this.btn_RemoveTF.Click += new System.EventHandler(this.btn_RemoveTF_Click);
            // 
            // lbl_FirstState
            // 
            this.lbl_FirstState.AutoSize = true;
            this.lbl_FirstState.Location = new System.Drawing.Point(115, 92);
            this.lbl_FirstState.Name = "lbl_FirstState";
            this.lbl_FirstState.Size = new System.Drawing.Size(54, 13);
            this.lbl_FirstState.TabIndex = 16;
            this.lbl_FirstState.Text = "First State";
            // 
            // lbl_Letter
            // 
            this.lbl_Letter.AutoSize = true;
            this.lbl_Letter.Location = new System.Drawing.Point(198, 91);
            this.lbl_Letter.Name = "lbl_Letter";
            this.lbl_Letter.Size = new System.Drawing.Size(34, 13);
            this.lbl_Letter.TabIndex = 17;
            this.lbl_Letter.Text = "Letter";
            // 
            // lbl_SecondState
            // 
            this.lbl_SecondState.AutoSize = true;
            this.lbl_SecondState.Location = new System.Drawing.Point(278, 92);
            this.lbl_SecondState.Name = "lbl_SecondState";
            this.lbl_SecondState.Size = new System.Drawing.Size(72, 13);
            this.lbl_SecondState.TabIndex = 18;
            this.lbl_SecondState.Text = "Second State";
            // 
            // grp_FinalStates
            // 
            this.grp_FinalStates.Controls.Add(this.pnl_FinalStates);
            this.grp_FinalStates.Location = new System.Drawing.Point(15, 165);
            this.grp_FinalStates.Name = "grp_FinalStates";
            this.grp_FinalStates.Size = new System.Drawing.Size(417, 247);
            this.grp_FinalStates.TabIndex = 0;
            this.grp_FinalStates.TabStop = false;
            this.grp_FinalStates.Text = "Final States";
            // 
            // grp_Letters
            // 
            this.grp_Letters.Controls.Add(this.lbl_SetOfLetters);
            this.grp_Letters.Location = new System.Drawing.Point(460, 21);
            this.grp_Letters.Name = "grp_Letters";
            this.grp_Letters.Size = new System.Drawing.Size(160, 54);
            this.grp_Letters.TabIndex = 19;
            this.grp_Letters.TabStop = false;
            this.grp_Letters.Text = "Set of Letters";
            // 
            // lbl_SetOfLetters
            // 
            this.lbl_SetOfLetters.AutoSize = true;
            this.lbl_SetOfLetters.Location = new System.Drawing.Point(7, 20);
            this.lbl_SetOfLetters.Name = "lbl_SetOfLetters";
            this.lbl_SetOfLetters.Size = new System.Drawing.Size(0, 13);
            this.lbl_SetOfLetters.TabIndex = 0;
            // 
            // grp_NFAStates
            // 
            this.grp_NFAStates.Controls.Add(this.lbl_SetOfNFAStates);
            this.grp_NFAStates.Location = new System.Drawing.Point(625, 21);
            this.grp_NFAStates.Name = "grp_NFAStates";
            this.grp_NFAStates.Size = new System.Drawing.Size(160, 54);
            this.grp_NFAStates.TabIndex = 20;
            this.grp_NFAStates.TabStop = false;
            this.grp_NFAStates.Text = "Set of NFA States";
            // 
            // lbl_SetOfNFAStates
            // 
            this.lbl_SetOfNFAStates.AutoSize = true;
            this.lbl_SetOfNFAStates.Location = new System.Drawing.Point(7, 20);
            this.lbl_SetOfNFAStates.Name = "lbl_SetOfNFAStates";
            this.lbl_SetOfNFAStates.Size = new System.Drawing.Size(0, 13);
            this.lbl_SetOfNFAStates.TabIndex = 0;
            // 
            // grp_InitialState
            // 
            this.grp_InitialState.Controls.Add(this.lbl_InitialStateResult);
            this.grp_InitialState.Location = new System.Drawing.Point(460, 91);
            this.grp_InitialState.Name = "grp_InitialState";
            this.grp_InitialState.Size = new System.Drawing.Size(160, 41);
            this.grp_InitialState.TabIndex = 21;
            this.grp_InitialState.TabStop = false;
            this.grp_InitialState.Text = "Initial State";
            // 
            // lbl_InitialStateResult
            // 
            this.lbl_InitialStateResult.AutoSize = true;
            this.lbl_InitialStateResult.Location = new System.Drawing.Point(7, 20);
            this.lbl_InitialStateResult.Name = "lbl_InitialStateResult";
            this.lbl_InitialStateResult.Size = new System.Drawing.Size(0, 13);
            this.lbl_InitialStateResult.TabIndex = 0;
            // 
            // grp_TF
            // 
            this.grp_TF.Controls.Add(this.lst_TF);
            this.grp_TF.Location = new System.Drawing.Point(460, 165);
            this.grp_TF.Name = "grp_TF";
            this.grp_TF.Size = new System.Drawing.Size(325, 241);
            this.grp_TF.TabIndex = 22;
            this.grp_TF.TabStop = false;
            this.grp_TF.Text = "Transition Functions";
            // 
            // lst_TF
            // 
            this.lst_TF.FormattingEnabled = true;
            this.lst_TF.Location = new System.Drawing.Point(10, 19);
            this.lst_TF.Name = "lst_TF";
            this.lst_TF.Size = new System.Drawing.Size(309, 212);
            this.lst_TF.TabIndex = 0;
            // 
            // grp_SetofFinalStates
            // 
            this.grp_SetofFinalStates.Controls.Add(this.lbl_SetOfFinalStates);
            this.grp_SetofFinalStates.Location = new System.Drawing.Point(627, 91);
            this.grp_SetofFinalStates.Name = "grp_SetofFinalStates";
            this.grp_SetofFinalStates.Size = new System.Drawing.Size(160, 41);
            this.grp_SetofFinalStates.TabIndex = 23;
            this.grp_SetofFinalStates.TabStop = false;
            this.grp_SetofFinalStates.Text = "Set of Final States";
            // 
            // lbl_SetOfFinalStates
            // 
            this.lbl_SetOfFinalStates.AutoSize = true;
            this.lbl_SetOfFinalStates.Location = new System.Drawing.Point(8, 19);
            this.lbl_SetOfFinalStates.Name = "lbl_SetOfFinalStates";
            this.lbl_SetOfFinalStates.Size = new System.Drawing.Size(0, 13);
            this.lbl_SetOfFinalStates.TabIndex = 0;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(146, 434);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(175, 23);
            this.btn_Convert.TabIndex = 24;
            this.btn_Convert.Text = "Convert NFA to DFA";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(568, 434);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(107, 23);
            this.btn_Exit.TabIndex = 25;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // NFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.grp_SetofFinalStates);
            this.Controls.Add(this.grp_TF);
            this.Controls.Add(this.grp_InitialState);
            this.Controls.Add(this.grp_NFAStates);
            this.Controls.Add(this.grp_Letters);
            this.Controls.Add(this.grp_FinalStates);
            this.Controls.Add(this.lbl_SecondState);
            this.Controls.Add(this.lbl_Letter);
            this.Controls.Add(this.lbl_FirstState);
            this.Controls.Add(this.btn_RemoveTF);
            this.Controls.Add(this.btn_AddTF);
            this.Controls.Add(this.btn_AddNFAStates);
            this.Controls.Add(this.btn_AddLetters);
            this.Controls.Add(this.cbo_InitialState);
            this.Controls.Add(this.cbo_SecondState);
            this.Controls.Add(this.cbo_Letter);
            this.Controls.Add(this.cbo_FirstState);
            this.Controls.Add(this.txt_NFAStates);
            this.Controls.Add(this.txt_Letters);
            this.Controls.Add(this.lbl_InitialState);
            this.Controls.Add(this.lbl_TF);
            this.Controls.Add(this.lbl_NFAStates);
            this.Controls.Add(this.lbl_Letters);
            this.Name = "NFA";
            this.Text = "NFA";
            this.grp_FinalStates.ResumeLayout(false);
            this.grp_Letters.ResumeLayout(false);
            this.grp_Letters.PerformLayout();
            this.grp_NFAStates.ResumeLayout(false);
            this.grp_NFAStates.PerformLayout();
            this.grp_InitialState.ResumeLayout(false);
            this.grp_InitialState.PerformLayout();
            this.grp_TF.ResumeLayout(false);
            this.grp_SetofFinalStates.ResumeLayout(false);
            this.grp_SetofFinalStates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Letters;
        private System.Windows.Forms.Label lbl_NFAStates;
        private System.Windows.Forms.Label lbl_TF;
        private System.Windows.Forms.Label lbl_InitialState;
        private System.Windows.Forms.Panel pnl_FinalStates;
        private System.Windows.Forms.TextBox txt_Letters;
        private System.Windows.Forms.TextBox txt_NFAStates;
        private System.Windows.Forms.ComboBox cbo_FirstState;
        private System.Windows.Forms.ComboBox cbo_Letter;
        private System.Windows.Forms.ComboBox cbo_SecondState;
        private System.Windows.Forms.ComboBox cbo_InitialState;
        private System.Windows.Forms.Button btn_AddLetters;
        private System.Windows.Forms.Button btn_AddNFAStates;
        private System.Windows.Forms.Button btn_AddTF;
        private System.Windows.Forms.Button btn_RemoveTF;
        private System.Windows.Forms.Label lbl_FirstState;
        private System.Windows.Forms.Label lbl_Letter;
        private System.Windows.Forms.Label lbl_SecondState;
        private System.Windows.Forms.GroupBox grp_FinalStates;
        private System.Windows.Forms.GroupBox grp_Letters;
        private System.Windows.Forms.GroupBox grp_NFAStates;
        private System.Windows.Forms.GroupBox grp_InitialState;
        private System.Windows.Forms.GroupBox grp_TF;
        private System.Windows.Forms.GroupBox grp_SetofFinalStates;
        private System.Windows.Forms.Label lbl_SetOfLetters;
        private System.Windows.Forms.Label lbl_SetOfNFAStates;
        private System.Windows.Forms.Label lbl_InitialStateResult;
        private System.Windows.Forms.Label lbl_SetOfFinalStates;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListBox lst_TF;
    }
}

