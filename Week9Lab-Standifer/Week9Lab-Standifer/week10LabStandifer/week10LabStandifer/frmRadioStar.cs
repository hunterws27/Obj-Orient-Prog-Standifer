// Hunter Standifer
// ITD2343
// Due Date: November 11, 2025
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace week10LabStandifer
{
    public partial class frmRadioStar : Form
    {
        // your form logic here



        public frmRadioStar()
        {
            InitializeComponent();
            this.AcceptButton = btnCalculate;
            this.CancelButton = btnExit;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblMessage.Text = "";
            rdoAdd.Checked = true;
            chkVerbose.Checked = true;
            txtLeftOperand.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            List<string> errors = new List<string>();

            string leftText = txtLeftOperand.Text.Trim();
            string rightText = txtRightOperand.Text.Trim();

            if (string.IsNullOrEmpty(leftText))
                errors.Add("Left operand is missing.");
            if (string.IsNullOrEmpty(rightText))
                errors.Add("Right operand is missing.");

            if (errors.Count > 0)
            {
                lblMessage.Text = string.Join(" ", errors);
                return;
            }

            int left, right;
            if (!int.TryParse(leftText, out left))
                errors.Add("Left operand must be a whole number.");
            if (!int.TryParse(rightText, out right))
                errors.Add("Right operand must be a whole number.");

            if (errors.Count > 0)
            {
                lblMessage.Text = string.Join(" ", errors);
                return;
            }

            string operation = "";
            int result = 0;
            bool valid = true;

            if (rdoAdd.Checked)
            {
                result = left + right;
                operation = "+";
            }
            else if (rdoSubtract.Checked)
            {
                result = left - right;
                operation = "-";
            }
            else if (rdoMultiply.Checked)
            {
                result = left * right;
                operation = "*";
            }
            else if (rdoDivide.Checked)
            {
                if (right == 0)
                {
                    errors.Add("Cannot divide by zero.");
                    valid = false;
                }
                else
                {
                    result = left / right;
                    operation = "/";
                }
            }
            else if (rdoModulus.Checked)
            {
                if (right == 0)
                {
                    errors.Add("Cannot perform modulus with zero.");
                    valid = false;
                }
                else if (left < 0 || right < 0)
                {
                    errors.Add("Modulus operation does not allow negative numbers.");
                    valid = false;
                }
                else
                {
                    result = left % right;
                    operation = "%";
                }
            }

            if (!valid || errors.Count > 0)
            {
                lblMessage.Text = string.Join(" ", errors);
                return;
            }

            if (chkVerbose.Checked)
                lblMessage.Text = $"{left} {operation} {right} = {result}";
            else
                lblMessage.Text = $"The Answer is {result}";
        }

        private void chkVerbose_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

