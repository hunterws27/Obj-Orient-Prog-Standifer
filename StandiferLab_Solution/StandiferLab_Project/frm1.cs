using System;
using System.Drawing;
using System.Windows.Forms;




/*
HunterStandifer
ITD 2343 Programming Lab
Due Date: September 23, 2025
*/

namespace StandiferLab_Project
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();

            // Initial label setup
            lblTheDominator.Text = " ";
            lblTheDominator.BackColor = Color.White;
            lblTheDominator.ForeColor = Color.Black;

            // Form title and Esc key binding
            this.Text = "Standifer - Programming Lab";
            this.CancelButton = btnExit;
        }

        // Color Button Handlers
        private void btnTopLightBlue_Click(object sender, EventArgs e)
        {
            // This button sets the label background color to Light Blue
            SetLabelColor(btnTopLightBlu.BackColor);
        }

        private void btnTopLightGrn_Click(object sender, EventArgs e)
        {
            // This button sets the label background color to Light Green
            SetLabelColor(btnTopLightGrn.BackColor);
        }

        private void btnTopPink_Click(object sender, EventArgs e)
        {
            SetLabelColor(btnTopPink.BackColor);
        }

        private void btnTopRed_Click(object sender, EventArgs e)
        {
            SetLabelColor(btnTopRed.BackColor);
        }

        private void btnTopBlue_Click(object sender, EventArgs e)
        {
            SetLabelColor(btnTopBlue.BackColor);
        }

        private void btnTopGreen_Click(object sender, EventArgs e)
        {
            SetLabelColor(btnTopGreen.BackColor);
        }

        private void btnTopNavy_Click(object sender, EventArgs e)
        {
            SetLabelColor(btnTopNavy.BackColor);
        }

        private void btnTopMaroon_Click(object sender, EventArgs e)
        {
            SetLabelColor(btnTopMaroon.BackColor);
        }

        private void btnTopDarkGrn_Click(object sender, EventArgs e)
        {
            SetLabelColor(btnTopDarkGrn.BackColor);
        }

        // Digit Button Handlers
        private void btnBottom1_Click(object sender, EventArgs e)
        {
            // This button is setting the label text to 1
            lblTheDominator.Text = btnBottom1.Text;
        }

        private void btnBottom2_Click(object sender, EventArgs e)
        {
            // This button is setting the label text to 2
            lblTheDominator.Text = btnBottom2.Text;
        }

        private void btnBottom3_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnBottom3.Text;
        }

        private void btnBottom4_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnBottom4.Text;
        }

        private void btnBottom5_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnBottom5.Text;
        }

        private void btnBottom6_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnBottom6.Text;
        }

        private void btnBottom7_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnBottom7.Text;
        }

        private void btnBottom8_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnBottom8.Text;
        }

        private void btnBottom9_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnBottom9.Text;
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            // This button resets the label to its original state
            lblTheDominator.Text = " ";
            lblTheDominator.BackColor = Color.White;
            lblTheDominator.ForeColor = Color.Black;
        }

        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            // This button closes the application
            this.Close();
        }

        // Extra Credit: Contrast Logic
        private void SetLabelColor(Color bgColor)
        {
            lblTheDominator.BackColor = bgColor;
            lblTheDominator.ForeColor = (bgColor.GetBrightness() < 0.5) ? Color.White : Color.Black;
        }
    }
}
