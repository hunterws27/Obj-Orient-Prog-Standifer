// Hunter Standifer
// ITD2343
// Due Date: November 7, 2025

using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Week9Lab_Standifer
{
    public partial class frmCheckDigit : Form
    {
        public frmCheckDigit()
        {
            InitializeComponent();
            this.AcceptButton = btnProcess;
            this.CancelButton = btnExit;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string confirm = txtConfirm.Text.Trim();
            string amountRaw = txtAmount.Text.Trim();

            string message = ValidateInputs(account, confirm, amountRaw);
            lblMessage.Text = message;
        }

        private void ClearForm()
        {
            txtAccount.Text = "";
            txtConfirm.Text = "";
            txtAmount.Text = "";
            lblMessage.Text = "";
            txtAccount.Focus();
        }

        private string ValidateInputs(string account, string confirm, string amountRaw)
        {
            if (string.IsNullOrWhiteSpace(account) ||
                string.IsNullOrWhiteSpace(confirm) ||
                string.IsNullOrWhiteSpace(amountRaw))
            {
                return "Error: All fields must be filled.";
            }

            if (!account.All(char.IsDigit) || !confirm.All(char.IsDigit))
            {
                return "Error: Account numbers must contain only digits.";
            }

            if (account != confirm)
            {
                return "Error: Account numbers do not match.";
            }

            if (account.Length != 8)
            {
                return "Error: Account number must be exactly 8 digits.";
            }

            if (!IsValidCheckDigit(account))
            {
                return "Error: Invalid check digit in account number.";
            }

            string formattedAmount = FormatPayment(amountRaw);
            if (formattedAmount == null)
            {
                return "Error: Payment amount is not valid.";
            }

            return $"A payment of {formattedAmount} was applied to account {account} on {DateTime.Now:MMMM dd}.";
        }

        private bool IsValidCheckDigit(string account)
        {
            int sum = account
                .Take(7)
                .Select(c => int.Parse(c.ToString()))
                .Sum();

            int checkDigit = sum % 10;
            return checkDigit == int.Parse(account[7].ToString());
        }

        private string FormatPayment(string input)
        {
            if (decimal.TryParse(input, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal amount))
            {
                return amount.ToString("C");
            }
            return null;
        }
    }
}

