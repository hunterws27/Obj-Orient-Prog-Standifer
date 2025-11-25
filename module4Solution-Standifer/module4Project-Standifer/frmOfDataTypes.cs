namespace module4Project_Standifer
{
    using System;
    using System.Windows.Forms;

    /*
    Hunter Standifer
    ITD 
    Due Date: October 6, 2025
    */

    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
            this.Text = "Week 4 - Data Types";
            this.StartPosition = FormStartPosition.CenterScreen;
            // Wire up events manually
            btnByte.Click += btnByte_Click;
            btnShort.Click += btnShort_Click;
            btnInt.Click += btnInt_Click;
            btnLong.Click += btnLong_Click;
            btnFloat.Click += btnFloat_Click;
            btnDouble.Click += btnDouble_Click;
            btnDecimal.Click += btnDecimal_Click;
            btnPow.Click += btnPow_Click;
            btnRound.Click += btnRound_Click;
            btnSqrt.Click += btnSqrt_Click;
            btnClear.Click += btnClear_Click;
            btnExit.Click += btnExit_Click;

            this.CancelButton = btnExit; // Escape key closes app
        }

        // Byte Addition
        private void btnByte_Click(object sender, EventArgs e)
        {
            // Perform addition with byte values
            byte left = 2, right = 3;
            byte result = (byte)(left + right);
            lblDisplay.Text = String.Format("{0} + {1} = {2}", left, right, result);
        }

        // Short Subtraction
        private void btnShort_Click(object sender, EventArgs e)
        {
            // Perform subtraction with short values
            short left = 10, right = 4;
            short result = (short)(left - right);
            lblDisplay.Text = String.Format("{0} - {1} = {2}", left, right, result);
        }

        // Int Division
        private void btnInt_Click(object sender, EventArgs e)
        {
            // Perform integer division
            int left = 7, right = 2;
            int result = left / right;
            lblDisplay.Text = String.Format("{0} / {1} = {2}", left, right, result);
        }

        // Long Modulus
        private void btnLong_Click(object sender, EventArgs e)
        {
            // Perform modulus with long values
            long left = 17, right = 5;
            long result = left % right;
            lblDisplay.Text = String.Format("{0} % {1} = {2}", left, right, result);
        }

        // Float Modulus
        private void btnFloat_Click(object sender, EventArgs e)
        {
            // Perform modulus with float values
            float left = 7.5f, right = 2.2f;
            float result = left % right;
            lblDisplay.Text = String.Format("{0:F7} % {1:F7} = {2:F7}", left, right, result);
        }

        // Double Division
        private void btnDouble_Click(object sender, EventArgs e)
        {
            // Perform division with double values
            double left = 7.0, right = 2.0;
            double result = left / right;
            lblDisplay.Text = String.Format("{0:F15} / {1:F15} = {2:F15}", left, right, result);
        }

        // Decimal Multiplication
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Perform multiplication with decimal values
            decimal left = 3.1415926535897932384626433832m;
            decimal right = 2.0m;
            decimal result = left * right;
            lblDisplay.Text = String.Format("{0:F28} * {1:F28} = {2:F28}", left, right, result);
        }

        // Math.Pow
        private void btnPow_Click(object sender, EventArgs e)
        {
            // Perform power operation
            double baseNum = 2, exponent = 3;
            double result = Math.Pow(baseNum, exponent);
            lblDisplay.Text = $"The result of {baseNum} raised to the power of {exponent} is {result}";
        }

        // Math.Round
        private void btnRound_Click(object sender, EventArgs e)
        {
            // Perform rounding operation
            double value = 12.3456789;
            int digits = 2;
            double result = Math.Round(value, digits);
            lblDisplay.Text = $"Rounded {value} to {digits} digits is {result}";
        }

        // Math.Sqrt
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            // Perform square root operation
            double value = 16;
            double result = Math.Sqrt(value);
            lblDisplay.Text = $"The square root of {value} is {result}";
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the label text
            lblDisplay.Text = "";
        }

        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}
