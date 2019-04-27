namespace NFAtoDFA
{
    partial class DFA
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
            this.pnl_DFA = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_DFA
            // 
            this.pnl_DFA.Location = new System.Drawing.Point(33, 26);
            this.pnl_DFA.Name = "pnl_DFA";
            this.pnl_DFA.Size = new System.Drawing.Size(740, 385);
            this.pnl_DFA.TabIndex = 0;
            // 
            // DFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_DFA);
            this.Name = "DFA";
            this.Text = "DFA";
            this.Load += new System.EventHandler(this.DFA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DFA;
    }
}