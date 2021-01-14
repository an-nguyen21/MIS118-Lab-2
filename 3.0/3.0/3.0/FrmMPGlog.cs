//
//Class Name: frmMPGlog
//Author: Annie Nguyen
//Date: 1/14/2021
//Lab: Lab 2 Part 3
//Class Description: frmMPGlog takes input in the form of miles driven and fuel used to generate a log
//for the user to keep track of. 
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._0
{
    public partial class FrmMPGlog : Form
    {
        public FrmMPGlog()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            //Convert inputs to decimals and assign a variable to them
            decimal miles = decimal.Parse(txtMilesDriven.Text);
            decimal fuel = decimal.Parse(txtFuelused.Text);

            //Used / operator to find miles per gallon with new variables
            decimal mpg = miles / fuel;

            //Add mpg results to listbox
            lstbox.Items.Add(mpg);
        }
    }
}
