using System;
using System.Windows.Forms;

/*
Hunter Standifer
ITD 2343
Due Date: October 7, 2025
*/

namespace Project5Standifer
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();

            // Set the form title and startup position
            this.Text = "Standifer Choices";
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;

            // Tie Enter key to Check button and Escape key to Exit button
            this.AcceptButton = btnCheck;
            this.CancelButton = btnExit;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtLeftNumber.Text = "";
            txtMiddleNumber.Text = "";
            txtRightNumber.Text = "";

            // Clear the message label
            lblMessage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Try parsing all three numbers
            bool isLeftValid = int.TryParse(txtLeftNumber.Text, out int leftNum);
            bool isRightValid = int.TryParse(txtRightNumber.Text, out int rightNum);
            bool isCheckValid = int.TryParse(txtMiddleNumber.Text, out int checkNum);

            if (!isLeftValid || !isRightValid || !isCheckValid)
            {
                // One or more inputs are invalid
                lblMessage.Text = "Please enter valid numbers in all fields.";
                return;
            }

            // Begin range logic
            if (checkNum == leftNum)
            {
                // Check number equals the lower bound
                lblMessage.Text = $"The number {checkNum} is equal to the lower end of the range.";
            }
            else if (checkNum == rightNum)
            {
                // Check number equals the upper bound
                lblMessage.Text = $"The number {checkNum} is equal to the upper end of the range.";
            }
            else if (checkNum < leftNum)
            {
                // Check number is below the range
                lblMessage.Text = $"The number {checkNum} is lower than the range starting at {leftNum}.";
            }
            else if (checkNum > rightNum)
            {
                // Check number is above the range
                lblMessage.Text = $"The number {checkNum} is higher than the range ending at {rightNum}.";
            }
            else
            {
                // Check number is within the range
                lblMessage.Text = $"The number {checkNum} is in the range of {leftNum} to {rightNum}.";
            }

            // Clear the middle textbox for next entry
            txtMiddleNumber.Text = "";

            // Return focus to middle textbox
            txtMiddleNumber.Focus();
        }
    }
}
