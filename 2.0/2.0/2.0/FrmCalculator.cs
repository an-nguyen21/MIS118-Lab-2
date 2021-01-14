//
//Class Name: Calculator
//Author: Annie Nguyen
//Date: 1/13/2021
//Lab: Lab 2 Part 2
//Class Description: The basic calculator app will take two numbers from users and can perform addition,
//subtraction, multiplication, and division operations.
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

namespace _2._0
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Convert inputs to decimal
            //Make variables to store the values in
            decimal x = decimal.Parse(txtInputOne.Text);
            decimal y = decimal.Parse(txtInputTwo.Text);

            //Use the + operator to add two inputs together
            decimal sum = x + y;

            //Store the solution in the textbox
            txtSoln.Text = Convert.ToString(sum);
          
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //Convert user inputs to decimals and store in variables x and y
            decimal x = decimal.Parse(txtInputOne.Text);
            decimal y = decimal.Parse(txtInputTwo.Text);

            //Use - operator to subtract two numbers
            decimal minus = x - y;

            //Print solution in textbox
            txtSoln.Text = Convert.ToString(minus);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            //Convert user inputs to decimals and store in variables x and y
            decimal x = decimal.Parse(txtInputOne.Text);
            decimal y = decimal.Parse(txtInputTwo.Text);

            //Use * operator to mult. two inputs
            decimal product = x * y;

            //Print solution in textbox
            txtSoln.Text = Convert.ToString(product);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //Convert user inputs to decimals and store in variables x and y
            decimal x = decimal.Parse(txtInputOne.Text);
            decimal y = decimal.Parse(txtInputTwo.Text);

            //Use / operator to divide x by y
            decimal quotient = x / y;

            //Print solution in textbox
            txtSoln.Text = Convert.ToString(quotient);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInputOne.Text = "";
            txtInputTwo.Text = "";
            txtSoln.Text = "";
        }
    }
}
