namespace MathTrainer
{
    partial class MainForm
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
            this.lblTopNumber = new System.Windows.Forms.Label();
            this.lblBottomNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOperand = new System.Windows.Forms.Label();
            this.lblCorrectIncorrect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoneyEarned = new System.Windows.Forms.Label();
            this.cboFunction = new System.Windows.Forms.ComboBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.cboCrap = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTopNumber
            // 
            this.lblTopNumber.AutoSize = true;
            this.lblTopNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopNumber.Location = new System.Drawing.Point(164, 88);
            this.lblTopNumber.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTopNumber.Name = "lblTopNumber";
            this.lblTopNumber.Size = new System.Drawing.Size(292, 55);
            this.lblTopNumber.TabIndex = 0;
            this.lblTopNumber.Text = "Top Number";
            // 
            // lblBottomNumber
            // 
            this.lblBottomNumber.AutoSize = true;
            this.lblBottomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomNumber.Location = new System.Drawing.Point(164, 143);
            this.lblBottomNumber.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblBottomNumber.Name = "lblBottomNumber";
            this.lblBottomNumber.Size = new System.Drawing.Size(291, 55);
            this.lblBottomNumber.TabIndex = 1;
            this.lblBottomNumber.Text = "Bottom Num";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(164, 212);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 55);
            this.lblAnswer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "-----------------";
            // 
            // lblOperand
            // 
            this.lblOperand.AutoSize = true;
            this.lblOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperand.Location = new System.Drawing.Point(111, 143);
            this.lblOperand.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblOperand.Name = "lblOperand";
            this.lblOperand.Size = new System.Drawing.Size(52, 55);
            this.lblOperand.TabIndex = 4;
            this.lblOperand.Text = "+";
            // 
            // lblCorrectIncorrect
            // 
            this.lblCorrectIncorrect.AutoSize = true;
            this.lblCorrectIncorrect.Location = new System.Drawing.Point(177, 273);
            this.lblCorrectIncorrect.Name = "lblCorrectIncorrect";
            this.lblCorrectIncorrect.Size = new System.Drawing.Size(122, 37);
            this.lblCorrectIncorrect.TabIndex = 5;
            this.lblCorrectIncorrect.Text = "Correct";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Money Earned";
            // 
            // lblMoneyEarned
            // 
            this.lblMoneyEarned.AutoSize = true;
            this.lblMoneyEarned.Location = new System.Drawing.Point(799, 88);
            this.lblMoneyEarned.Name = "lblMoneyEarned";
            this.lblMoneyEarned.Size = new System.Drawing.Size(35, 37);
            this.lblMoneyEarned.TabIndex = 7;
            this.lblMoneyEarned.Text = "0";
            // 
            // cboFunction
            // 
            this.cboFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunction.FormattingEnabled = true;
            this.cboFunction.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
            this.cboFunction.Location = new System.Drawing.Point(100, 12);
            this.cboFunction.Name = "cboFunction";
            this.cboFunction.Size = new System.Drawing.Size(183, 45);
            this.cboFunction.TabIndex = 8;
            this.cboFunction.SelectedIndexChanged += new System.EventHandler(this.HandleFunctionChanged);
            this.cboFunction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleFormKeyPress);
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboLevel.Location = new System.Drawing.Point(366, 12);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(121, 45);
            this.cboLevel.TabIndex = 9;
            this.cboLevel.SelectedIndexChanged += new System.EventHandler(this.OnCBOLevelSelectedIndexChanged);
            this.cboLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleFormKeyPress);
            // 
            // cboCrap
            // 
            this.cboCrap.FormattingEnabled = true;
            this.cboCrap.Location = new System.Drawing.Point(622, 26);
            this.cboCrap.Name = "cboCrap";
            this.cboCrap.Size = new System.Drawing.Size(121, 45);
            this.cboCrap.TabIndex = 10;
            this.cboCrap.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1028);
            this.Controls.Add(this.cboCrap);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.cboFunction);
            this.Controls.Add(this.lblMoneyEarned);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCorrectIncorrect);
            this.Controls.Add(this.lblOperand);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblBottomNumber);
            this.Controls.Add(this.lblTopNumber);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "MainForm";
            this.Text = "Math Trainer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleFormKeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopNumber;
        private System.Windows.Forms.Label lblBottomNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOperand;
        private System.Windows.Forms.Label lblCorrectIncorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoneyEarned;
        private System.Windows.Forms.ComboBox cboFunction;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.ComboBox cboCrap;
    }
}

