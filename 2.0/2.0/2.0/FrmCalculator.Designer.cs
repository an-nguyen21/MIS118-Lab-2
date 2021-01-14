namespace _2._0
{
    partial class FrmCalculator
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
            this.lblNumOne = new System.Windows.Forms.Label();
            this.lblNumTwo = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblSoln = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtInputOne = new System.Windows.Forms.TextBox();
            this.txtInputTwo = new System.Windows.Forms.TextBox();
            this.txtSoln = new System.Windows.Forms.TextBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumOne
            // 
            this.lblNumOne.AutoSize = true;
            this.lblNumOne.Location = new System.Drawing.Point(39, 44);
            this.lblNumOne.Name = "lblNumOne";
            this.lblNumOne.Size = new System.Drawing.Size(68, 17);
            this.lblNumOne.TabIndex = 0;
            this.lblNumOne.Text = "number 1";
            // 
            // lblNumTwo
            // 
            this.lblNumTwo.AutoSize = true;
            this.lblNumTwo.Location = new System.Drawing.Point(39, 89);
            this.lblNumTwo.Name = "lblNumTwo";
            this.lblNumTwo.Size = new System.Drawing.Size(68, 17);
            this.lblNumTwo.TabIndex = 1;
            this.lblNumTwo.Text = "number 2";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(39, 154);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(132, 17);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.Text = "choose an operator";
            // 
            // lblSoln
            // 
            this.lblSoln.AutoSize = true;
            this.lblSoln.Location = new System.Drawing.Point(39, 225);
            this.lblSoln.Name = "lblSoln";
            this.lblSoln.Size = new System.Drawing.Size(63, 17);
            this.lblSoln.TabIndex = 3;
            this.lblSoln.Text = "Solution:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(42, 282);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtInputOne
            // 
            this.txtInputOne.Location = new System.Drawing.Point(161, 39);
            this.txtInputOne.Name = "txtInputOne";
            this.txtInputOne.Size = new System.Drawing.Size(270, 22);
            this.txtInputOne.TabIndex = 5;
            // 
            // txtInputTwo
            // 
            this.txtInputTwo.Location = new System.Drawing.Point(161, 86);
            this.txtInputTwo.Name = "txtInputTwo";
            this.txtInputTwo.Size = new System.Drawing.Size(270, 22);
            this.txtInputTwo.TabIndex = 6;
            // 
            // txtSoln
            // 
            this.txtSoln.Location = new System.Drawing.Point(161, 222);
            this.txtSoln.Name = "txtSoln";
            this.txtSoln.ReadOnly = true;
            this.txtSoln.Size = new System.Drawing.Size(270, 22);
            this.txtSoln.TabIndex = 7;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(268, 148);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(32, 28);
            this.btnSubtract.TabIndex = 8;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(332, 148);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(32, 28);
            this.btnMult.TabIndex = 9;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(399, 148);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(32, 28);
            this.btnDivide.TabIndex = 11;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 333);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.txtSoln);
            this.Controls.Add(this.txtInputTwo);
            this.Controls.Add(this.txtInputOne);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblSoln);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblNumTwo);
            this.Controls.Add(this.lblNumOne);
            this.Name = "FrmCalculator";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOne;
        private System.Windows.Forms.Label lblNumTwo;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblSoln;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtInputOne;
        private System.Windows.Forms.TextBox txtInputTwo;
        private System.Windows.Forms.TextBox txtSoln;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDivide;
    }
}

