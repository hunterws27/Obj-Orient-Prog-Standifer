using System;
using System.Windows.Forms;

namespace CollectionLab
{
    public partial class frmCollections : Form
    {
        // Constants
        private const int MAX_ELEMENTS = 17;
        private const int MIN_VALUE = -1217;
        private const int MAX_VALUE = 1217;

        // Collection and index
        private int[] numberCollection = new int[MAX_ELEMENTS];
        private int currentIndex = 0;

        public frmCollections()
        {
            InitializeComponent();

            // Form setup
            this.Text = "Collection Lab";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnAddNumber;
            this.CancelButton = btnExit;

            // Display boxes setup
            rtbCollectionDisplay.ReadOnly = true;
            rtbCollectionDisplay.TabStop = false;
            rtbStatsDisplay.ReadOnly = true;
            rtbStatsDisplay.TabStop = false;
        }

        // Add Number button click
        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            rtbCollectionDisplay.Clear();
            rtbStatsDisplay.Clear();

            if (ValidateInput(out int number))
            {
                numberCollection[currentIndex++] = number;
                txtNumberInput.Text = "";
            }
            else
            {
                txtNumberInput.Text = "";
            }
        }

        // Validate input method
        private bool ValidateInput(out int validNumber)
        {
            validNumber = 0;
            string input = txtNumberInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                DisplayMessage("Input is empty. Please enter a number.");
                return false;
            }

            if (!int.TryParse(input, out validNumber))
            {
                DisplayMessage("Invalid input. Only whole numbers are allowed.");
                return false;
            }

            if (validNumber < MIN_VALUE)
            {
                DisplayMessage($"Value too small. Minimum allowed is {MIN_VALUE}.");
                return false;
            }

            if (validNumber > MAX_VALUE)
            {
                DisplayMessage($"Value too large. Maximum allowed is {MAX_VALUE}.");
                return false;
            }

            if (currentIndex >= MAX_ELEMENTS)
            {
                DisplayMessage("Collection is full. Maximum of 17 numbers allowed.");
                return false;
            }

            return true;
        }

        // Show Statistics button click
        private void btnShowStats_Click(object sender, EventArgs e)
        {
            if (currentIndex == 0)
            {
                DisplayMessage("Collection is empty. Add numbers before viewing statistics.");
                return;
            }

            rtbCollectionDisplay.Clear();
            rtbStatsDisplay.Clear();

            int sum = 0;
            int high = numberCollection[0];
            int low = numberCollection[0];

            for (int i = 0; i < currentIndex; i++)
            {
                int num = numberCollection[i];
                rtbCollectionDisplay.AppendText(num + Environment.NewLine);
                sum += num;
                if (num > high) high = num;
                if (num < low) low = num;
            }

            double average = (double)sum / currentIndex;

            rtbStatsDisplay.AppendText($"Total Numbers: {currentIndex}\n");
            rtbStatsDisplay.AppendText($"High Number: {high}\n");
            rtbStatsDisplay.AppendText($"Low Number: {low}\n");
            rtbStatsDisplay.AppendText($"Average: {average:F4}\n");

            // Reset collection
            currentIndex = 0;
            numberCollection = new int[MAX_ELEMENTS];
            txtNumberInput.Text = "";
        }

        // Reset button click
        private void btnReset_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            numberCollection = new int[MAX_ELEMENTS];
            rtbCollectionDisplay.Clear();
            rtbStatsDisplay.Text = "Collection has been cleared.";
            txtNumberInput.Text = "";
        }

        // Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Helper method to display messages
        private void DisplayMessage(string message)
        {
            rtbStatsDisplay.Text = message;
        }
    }
}
