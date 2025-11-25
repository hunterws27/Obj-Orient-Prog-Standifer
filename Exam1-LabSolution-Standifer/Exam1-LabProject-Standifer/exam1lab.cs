using System;
using System.Windows.Forms;
namespace Exam1_LabProject_Standifer
{


    public partial class exam1lab : Form
    {
        public exam1lab()
        {
            InitializeComponent();

            // Form setup
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            };

            // Tab order and access keys
            btn_clear.TabIndex = 0;
            btn_send.TabIndex = 1;
            txt_message.TabStop = false;
            lbl_message.TabStop = false;

            // Disable typing
            txt_message.ReadOnly = true;
            txt_message.Enabled = false;
        }

        // Shared handler for input buttons
        private void btnInput_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            txt_message.Text = txt_message.Text + clicked.Text;
        }

        // Clear button
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_message.Text = "";
        }

        // Send button
        private void btn_send_Click(object sender, EventArgs e)
        {
            lbl_message.Text = txt_message.Text;
            txt_message.Text = "";
        }
    }
}

  
