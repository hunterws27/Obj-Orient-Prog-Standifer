using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Hunter Standifer
// ITD: 2343
// Due Date: October 16, 2025

namespace Module6MethodsProjectDL
{
    public partial class frmMethodActing : Form
    {
        // Public Constants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmMethodActing()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CancelButton = btnExit; // Escape key triggers Exit
        }

        // Single method to perform all operations
        private decimal PerformOperation(decimal left, decimal right, byte operation)
        {
            decimal result = 0.0m;

            if (operation == ADD)
                result = left + right;
            else if (operation == SUBTRACT)
                result = left - right;
            else if (operation == MULTIPLY)
                result = left * right;
            else if (operation == DIVIDE)
                result = right != 0 ? left / right : 0;
            else if (operation == MODULUS)
                result = right != 0 ? left % right : 0;

            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);
            decimal dAnswer = PerformOperation(dLeft, dRight, ADD);
            lblResult.Text = txtLeftOperand.Text + " + " + txtRightOperand.Text + " = " + dAnswer.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);
            decimal dAnswer = PerformOperation(dLeft, dRight, SUBTRACT);
            lblResult.Text = txtLeftOperand.Text + " - " + txtRightOperand.Text + " = " + dAnswer.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);
            decimal dAnswer = PerformOperation(dLeft, dRight, MULTIPLY);
            lblResult.Text = txtLeftOperand.Text + " * " + txtRightOperand.Text + " = " + dAnswer.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);
            decimal dAnswer = PerformOperation(dLeft, dRight, DIVIDE);
            lblResult.Text = txtLeftOperand.Text + " / " + txtRightOperand.Text + " = " + dAnswer.ToString();
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            decimal dLeft = Convert.ToDecimal(txtLeftOperand.Text);
            decimal dRight = Convert.ToDecimal(txtRightOperand.Text);
            decimal dAnswer = PerformOperation(dLeft, dRight, MODULUS);
            lblResult.Text = txtLeftOperand.Text + " % " + txtRightOperand.Text + " = " + dAnswer.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
