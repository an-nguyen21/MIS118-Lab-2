namespace _1._2
{
    partial class FrmArithmetic
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
            this.txtInputOne = new System.Windows.Forms.TextBox();
            this.txtInputTwo = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumOne
            // 
            this.lblNumOne.AutoSize = true;
            this.lblNumOne.Location = new System.Drawing.Point(24, 51);
            this.lblNumOne.Name = "lblNumOne";
            this.lblNumOne.Size = new System.Drawing.Size(149, 17);
            this.lblNumOne.TabIndex = 0;
            this.lblNumOne.Text = "Enter the first number:";
            // 
            // lblNumTwo
            // 
            this.lblNumTwo.AutoSize = true;
            this.lblNumTwo.Location = new System.Drawing.Point(24, 90);
            this.lblNumTwo.Name = "lblNumTwo";
            this.lblNumTwo.Size = new System.Drawing.Size(172, 17);
            this.lblNumTwo.TabIndex = 1;
            this.lblNumTwo.Text = "Enter the second number:";
            // 
            // txtInputOne
            // 
            this.txtInputOne.Location = new System.Drawing.Point(216, 48);
            this.txtInputOne.Name = "txtInputOne";
            this.txtInputOne.Size = new System.Drawing.Size(100, 22);
            this.txtInputOne.TabIndex = 2;
            // 
            // txtInputTwo
            // 
            this.txtInputTwo.Location = new System.Drawing.Point(216, 87);
            this.txtInputTwo.Name = "txtInputTwo";
            this.txtInputTwo.Size = new System.Drawing.Size(100, 22);
            this.txtInputTwo.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(351, 78);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(93, 32);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(33, 161);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(13, 17);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "-";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(33, 203);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(13, 17);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "-";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(33, 247);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(13, 17);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "-";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(33, 290);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(13, 17);
            this.lblMin.TabIndex = 8;
            this.lblMin.Text = "-";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(33, 334);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(13, 17);
            this.lblMax.TabIndex = 9;
            this.lblMax.Text = "-";
            // 
            // FrmArithmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 400);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtInputTwo);
            this.Controls.Add(this.txtInputOne);
            this.Controls.Add(this.lblNumTwo);
            this.Controls.Add(this.lblNumOne);
            this.Name = "FrmArithmetic";
            this.Text = "Arithmetic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOne;
        private System.Windows.Forms.Label lblNumTwo;
        private System.Windows.Forms.TextBox txtInputOne;
        private System.Windows.Forms.TextBox txtInputTwo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
    }
}

