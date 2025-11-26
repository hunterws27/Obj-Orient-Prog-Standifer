using System;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // FIXED: Escape key triggers Exit button
            this.CancelButton = btnExit;
        }

        // FIXED: Red button click updates label
        private void btnRed_Click(object sender, EventArgs e)
        {
            label1.Text = "Red";
            label1.BackColor = btnRed.BackColor;
        }

        // FIXED: Blue button click updates label
        private void btnBlue_Click(object sender, EventArgs e)
        {
            label1.Text = "Blue";
            label1.BackColor = btnBlue.BackColor;
        }

        // FIXED: Left button click updates label
        private void btnLeft_Click(object sender, EventArgs e)
        {
            label1.Text = "Left";
        }

        // FIXED: Right button click updates label
        private void btnRight_Click(object sender, EventArgs e)
        {
            label1.Text = "Right";
        }

        // FIXED: Exit button closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
