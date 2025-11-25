/*Hunter Standifer
 * ITD2343 Obj-Orient Prg Using C#
 * Due Date: 09/16/2025 */

using System;
using System.Windows.Forms;

namespace Week2_Standifer_Project
{
    public partial class frmFall2025 : Form
    {
        public frmFall2025()
        {
            InitializeComponent();
        }

        // Save button - copy textbox to label
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = txtUserInput.Text;
        }

        // Wipe button - clear label only
        private void btnWipe_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }

        // Cancel button - clear textbox only
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = "";
        }

        // Exit button - close form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


