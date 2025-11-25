using System;
using System.Windows.Forms;

namespace Sec3LabExam_STANDIFER
{
    public partial class frmDecoder : Form
    {
        private Decoder decoder = new Decoder();

        // Class-level counters
        private int plainToCipherCount = 0; // tracks Plain → Cipher conversions
        private int cipherToPlainCount = 0; // tracks Cipher → Plain conversions

        public frmDecoder()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            string errorMessage = "";

            if (string.IsNullOrEmpty(input))
                errorMessage += "Input cannot be empty.\n";

            if (!rbPlain.Checked && !rbCipher.Checked)
                errorMessage += "Please select a conversion mode.\n";

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool toCipher = rbPlain.Checked; // Plain → Cipher if rbPlain is checked
            string output = decoder.ConvertText(input, toCipher);
            txtOutput.Text = output;

            if (toCipher) plainToCipherCount++;
            else cipherToPlainCount++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
            rbPlain.Checked = false;
            rbCipher.Checked = false;
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = $"Conversions this session:\n" +
                             $"Plain → Cipher: {plainToCipherCount}\n" +
                             $"Cipher → Plain: {cipherToPlainCount}";
            MessageBox.Show(message, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

