//
//Class name: FrmArithmetic
//Author: Annie Nguyen
//Date: 1/12/2021
//Lab: Lab 2 Part 1.2
//Class description: FrmArithmetic take two numbers from the user and displays the sum, average, product,
//smallest and largest of the two numbers.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2
{
    public partial class FrmArithmetic : Form
    {
        public FrmArithmetic()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Making a variable for the first and second input and converting to decimal
            decimal inputOne = decimal.Parse(txtInputOne.Text);
            decimal inputTwo = decimal.Parse(txtInputTwo.Text);

            //Defined a variable and calculated sum, concatenate to display text
            decimal sum = inputOne + inputTwo;
            lblSum.Text = "The sum is " + sum;

            //Used order of precedence for avg, concatenate mean and text
            decimal mean = (inputOne + inputTwo) / 2;
            lblAverage.Text = "The average is " + mean;

            //Used * operator to multiply two inputs, concatenation to display message
            decimal product = inputOne * inputTwo;
            lblProduct.Text = "The product is " + product;

            //Displays the smallest value with Math.Min from the Math class
            decimal min = Math.Min(inputOne, inputTwo);
            lblMin.Text = "The smallest number is " + min;

            //Displays the largest value with Math.Max from the Math class
            decimal max = Math.Max(inputOne, inputTwo);
            lblMax.Text = "The largest number is " + max;
        }
    }
}
