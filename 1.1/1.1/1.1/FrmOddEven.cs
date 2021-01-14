//
//Class name: FrmOddEven
//Author: Annie Nguyen
//Date: 1/12/2021
//Lab: Lab 2 Part 1
//Class description: FrmOddEven takes an integer from the user and calculates whether that number is 
//odd or even.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1
{
    public partial class FrmOddEven : Form
    {
        public FrmOddEven()
        {
            InitializeComponent();
        }

        private void lblEnterNum_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Make a variable to store user input
            int userinput = int.Parse(txtInput.Text);

            //Make an if statement to calculate even numbers
            if (userinput % 2 == 0)
            {
                lblMessage.Text = "Your number is even.";
            } 

            //Make an if statement to calculate odd numbers
            if (userinput % 2 != 0)
            {
                lblMessage.Text = "Your number is odd.";
            }

            
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
