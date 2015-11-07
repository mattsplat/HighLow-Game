namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelNewNumber = new System.Windows.Forms.Label();
            this.buttonHigh = new System.Windows.Forms.Button();
            this.buttonLow = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(35, 13);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(60, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "OldNumber";
            this.labelNumber.Click += new System.EventHandler(this.labelNumber_Click);
            // 
            // labelNewNumber
            // 
            this.labelNewNumber.AutoSize = true;
            this.labelNewNumber.Location = new System.Drawing.Point(35, 43);
            this.labelNewNumber.Name = "labelNewNumber";
            this.labelNewNumber.Size = new System.Drawing.Size(66, 13);
            this.labelNewNumber.TabIndex = 1;
            this.labelNewNumber.Text = "NewNumber";
            // 
            // buttonHigh
            // 
            this.buttonHigh.Location = new System.Drawing.Point(38, 99);
            this.buttonHigh.Name = "buttonHigh";
            this.buttonHigh.Size = new System.Drawing.Size(75, 23);
            this.buttonHigh.TabIndex = 2;
            this.buttonHigh.Text = "Higher";
            this.buttonHigh.UseVisualStyleBackColor = true;
            this.buttonHigh.Click += new System.EventHandler(this.buttonHigh_Click);
            // 
            // buttonLow
            // 
            this.buttonLow.Location = new System.Drawing.Point(120, 98);
            this.buttonLow.Name = "buttonLow";
            this.buttonLow.Size = new System.Drawing.Size(75, 23);
            this.buttonLow.TabIndex = 3;
            this.buttonLow.Text = "Lower";
            this.buttonLow.UseMnemonic = false;
            this.buttonLow.UseVisualStyleBackColor = true;
            this.buttonLow.Click += new System.EventHandler(this.buttonLow_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication1.Properties.Settings.Default, "score", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelScore.Location = new System.Drawing.Point(199, 43);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(54, 13);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = global::WindowsFormsApplication1.Properties.Settings.Default.score;
            // 
            // textBoxBet
            // 
            this.textBoxBet.Location = new System.Drawing.Point(90, 187);
            this.textBoxBet.MaxLength = 5;
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(42, 20);
            this.textBoxBet.TabIndex = 5;
            this.textBoxBet.TextChanged += new System.EventHandler(this.textBoxBet_TextChanged);
            this.textBoxBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBet);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonLow);
            this.Controls.Add(this.buttonHigh);
            this.Controls.Add(this.labelNewNumber);
            this.Controls.Add(this.labelNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelNewNumber;
        private System.Windows.Forms.Button buttonHigh;
        private System.Windows.Forms.Button buttonLow;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Label label1;
    }
}

