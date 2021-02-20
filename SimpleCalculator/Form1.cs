using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        double firstnum, secondnum, result;

        private void n1_Click(object sender, EventArgs e)
        {
            if(display.Text == "0" && display.Text != null)
            {
                display.Text = "1";
            }
            else
            {
                display.Text = display.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "2";
            }
            else
            {
                display.Text = display.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "3";
            }
            else
            {
                display.Text = display.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "4";
            }
            else
            {
                display.Text = display.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "5";
            }
            else
            {
                display.Text = display.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "6";
            }
            else
            {
                display.Text = display.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "7";
            }
            else
            {
                display.Text = display.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "8";
            }
            else
            {
                display.Text = display.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "9";
            }
            else
            {
                display.Text = display.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void addition_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(display.Text);
            display.Text = "0";
            operation = "+";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(display.Text);
            display.Text = "0";
            operation = "-";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(display.Text);
            display.Text = "0";
            operation = "x";
        }

        private void division_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(display.Text);
            display.Text = "0";
            operation = "/";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            secondnum = Convert.ToDouble(display.Text);

            if(operation == "+")
            {
                result = (firstnum + secondnum);
                display.Text = Convert.ToString(result);
                firstnum = result;
            }

            if (operation == "-")
            {
                result = (firstnum - secondnum);
                display.Text = Convert.ToString(result);
                firstnum = result;
            }

            if (operation == "x")
            {
                result = (firstnum * secondnum);
                display.Text = Convert.ToString(result);
                firstnum = result;
            }

            if (operation == "/")
            {
                if (secondnum == 0)
                {
                    display.Text = "Answer is infinite, try again!";
                }
                else
                {
                    result = (firstnum + secondnum);
                    display.Text = Convert.ToString(result);
                    firstnum = result;
                }
            }
        }

        string operation;
        public Calculator()
        {
            InitializeComponent();
        }
    }
}
