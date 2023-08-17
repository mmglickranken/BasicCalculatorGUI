using System;
using System.Windows.Forms;

namespace Project3._1_BasicCalculatorGUI01
{
    public partial class frmBasicCalculator : Form
    {
        public frmBasicCalculator()
        {
            InitializeComponent();
        }

        // Instantiate a new Calculator object.
        private Calculator calc = new Calculator();

        private void frmBasicCalculator_Load(object sender, EventArgs e)
        {
            // This will set txtAnswer to 0 when the form is loaded.
            lblAnswer.Text = calc.DisplayString;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            calc.RemoveLastCharacter();

            lblAnswer.Text = calc.DisplayString;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calc.Clear();

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calc.Append(((Button)sender).Tag.ToString());

            lblAnswer.Text = calc.DisplayString;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            calc.ToggleSign();

            lblAnswer.Text = calc.DisplayString;
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
            calc.AddDecimalPoint();

            lblAnswer.Text += calc.DisplayString;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calc.Divide();

            lblAnswer.Text += calc.DisplayString;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calc.Multiply();

            lblAnswer.Text += calc.DisplayString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.Add();

            lblAnswer.Text += calc.DisplayString;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calc.Subtract();

            lblAnswer.Text += calc.DisplayString;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            calc.SquareRoot();

            lblAnswer.Text += calc.DisplayString;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            // Ensure that an error message will show when attempting to divide by zero.
            try
            {
                calc.Reciprocal();

                lblAnswer.Text += calc.DisplayString;
            }

            catch (DivideByZeroException dbze)
            {
                lblAnswer.Text += dbze.ToString();
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                // The following line will preform the mathematic operations.
                calc.Equals();

                lblAnswer.Text += calc.DisplayString;
            }

            // If the user is attempting to divide by zero, display the associated error message.
            catch (DivideByZeroException dbze)
            {
                lblAnswer.Text += dbze.ToString();
            }

            lblAnswer.Text = calc.DisplayString;
        }
    }
}
