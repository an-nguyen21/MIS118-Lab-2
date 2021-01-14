namespace _3._0
{
    partial class FrmMPGlog
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
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblmpg = new System.Windows.Forms.Label();
            this.lstbox = new System.Windows.Forms.ListBox();
            this.txtMilesDriven = new System.Windows.Forms.TextBox();
            this.txtFuelused = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(26, 75);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(85, 17);
            this.lblMiles.TabIndex = 0;
            this.lblMiles.Text = "Miles Driven";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(26, 150);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(72, 17);
            this.lblFuel.TabIndex = 1;
            this.lblFuel.Text = "Fuel Used";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(29, 210);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(97, 35);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // lblmpg
            // 
            this.lblmpg.AutoSize = true;
            this.lblmpg.Location = new System.Drawing.Point(271, 38);
            this.lblmpg.Name = "lblmpg";
            this.lblmpg.Size = new System.Drawing.Size(111, 17);
            this.lblmpg.TabIndex = 3;
            this.lblmpg.Text = "Miles Per Gallon";
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.ItemHeight = 16;
            this.lstbox.Location = new System.Drawing.Point(263, 72);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(133, 164);
            this.lstbox.TabIndex = 4;
            // 
            // txtMilesDriven
            // 
            this.txtMilesDriven.Location = new System.Drawing.Point(135, 72);
            this.txtMilesDriven.Name = "txtMilesDriven";
            this.txtMilesDriven.Size = new System.Drawing.Size(100, 22);
            this.txtMilesDriven.TabIndex = 5;
            // 
            // txtFuelused
            // 
            this.txtFuelused.Location = new System.Drawing.Point(135, 147);
            this.txtFuelused.Name = "txtFuelused";
            this.txtFuelused.Size = new System.Drawing.Size(100, 22);
            this.txtFuelused.TabIndex = 6;
            // 
            // FrmMPGlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 295);
            this.Controls.Add(this.txtFuelused);
            this.Controls.Add(this.txtMilesDriven);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.lblmpg);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblMiles);
            this.Name = "FrmMPGlog";
            this.Text = "MPG Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblmpg;
        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.TextBox txtMilesDriven;
        private System.Windows.Forms.TextBox txtFuelused;
    }
}

