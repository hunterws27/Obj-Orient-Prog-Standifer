namespace week10LabStandifer

{
    partial class frmRadioStar
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Label lblLeftOperand;
        private System.Windows.Forms.TextBox txtLeftOperand;
        private System.Windows.Forms.Label lblRightOperand;
        private System.Windows.Forms.TextBox txtRightOperand;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSubtract;
        private System.Windows.Forms.RadioButton rdoMultiply;
        private System.Windows.Forms.RadioButton rdoDivide;
        private System.Windows.Forms.RadioButton rdoModulus;
        private System.Windows.Forms.CheckBox chkVerbose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLeftOperand = new Label();
            txtLeftOperand = new TextBox();
            lblRightOperand = new Label();
            txtRightOperand = new TextBox();
            grpOperations = new GroupBox();
            rdoAdd = new RadioButton();
            rdoSubtract = new RadioButton();
            rdoMultiply = new RadioButton();
            rdoDivide = new RadioButton();
            rdoModulus = new RadioButton();
            chkVerbose = new CheckBox();
            btnCalculate = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            grpOperations.SuspendLayout();
            SuspendLayout();
            // 
            // lblLeftOperand
            // 
            lblLeftOperand.AutoSize = true;
            lblLeftOperand.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeftOperand.Location = new Point(15, 32);
            lblLeftOperand.Margin = new Padding(4, 0, 4, 0);
            lblLeftOperand.Name = "lblLeftOperand";
            lblLeftOperand.Size = new Size(190, 38);
            lblLeftOperand.TabIndex = 0;
            lblLeftOperand.Text = "Left Operand";
            // 
            // txtLeftOperand
            // 
            txtLeftOperand.BackColor = Color.LightYellow;
            txtLeftOperand.Location = new Point(213, 40);
            txtLeftOperand.Margin = new Padding(4, 5, 4, 5);
            txtLeftOperand.Name = "txtLeftOperand";
            txtLeftOperand.Size = new Size(200, 31);
            txtLeftOperand.TabIndex = 1;
            // 
            // lblRightOperand
            // 
            lblRightOperand.AutoSize = true;
            lblRightOperand.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRightOperand.Location = new Point(535, 33);
            lblRightOperand.Margin = new Padding(4, 0, 4, 0);
            lblRightOperand.Name = "lblRightOperand";
            lblRightOperand.Size = new Size(209, 38);
            lblRightOperand.TabIndex = 2;
            lblRightOperand.Text = "Right Operand";
            // 
            // txtRightOperand
            // 
            txtRightOperand.BackColor = Color.LightYellow;
            txtRightOperand.Location = new Point(773, 39);
            txtRightOperand.Margin = new Padding(4, 5, 4, 5);
            txtRightOperand.Name = "txtRightOperand";
            txtRightOperand.Size = new Size(200, 31);
            txtRightOperand.TabIndex = 3;
            // 
            // grpOperations
            // 
            grpOperations.Controls.Add(rdoAdd);
            grpOperations.Controls.Add(rdoSubtract);
            grpOperations.Controls.Add(rdoMultiply);
            grpOperations.Controls.Add(rdoDivide);
            grpOperations.Controls.Add(rdoModulus);
            grpOperations.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpOperations.Location = new Point(38, 100);
            grpOperations.Margin = new Padding(4, 5, 4, 5);
            grpOperations.Name = "grpOperations";
            grpOperations.Padding = new Padding(4, 5, 4, 5);
            grpOperations.Size = new Size(730, 175);
            grpOperations.TabIndex = 4;
            grpOperations.TabStop = false;
            grpOperations.Text = "Math Operations Available";
            // 
            // rdoAdd
            // 
            rdoAdd.AutoSize = true;
            rdoAdd.Checked = true;
            rdoAdd.Location = new Point(32, 48);
            rdoAdd.Margin = new Padding(4, 5, 4, 5);
            rdoAdd.Name = "rdoAdd";
            rdoAdd.Size = new Size(135, 42);
            rdoAdd.TabIndex = 0;
            rdoAdd.TabStop = true;
            rdoAdd.Text = "Add (+)";
            // 
            // rdoSubtract
            // 
            rdoSubtract.AutoSize = true;
            rdoSubtract.Location = new Point(229, 48);
            rdoSubtract.Margin = new Padding(4, 5, 4, 5);
            rdoSubtract.Name = "rdoSubtract";
            rdoSubtract.Size = new Size(179, 42);
            rdoSubtract.TabIndex = 1;
            rdoSubtract.Text = "Subtract (-)";
            // 
            // rdoMultiply
            // 
            rdoMultiply.AutoSize = true;
            rdoMultiply.Location = new Point(470, 48);
            rdoMultiply.Margin = new Padding(4, 5, 4, 5);
            rdoMultiply.Name = "rdoMultiply";
            rdoMultiply.Size = new Size(179, 42);
            rdoMultiply.TabIndex = 2;
            rdoMultiply.Text = "Multiply (*)";
            // 
            // rdoDivide
            // 
            rdoDivide.AutoSize = true;
            rdoDivide.Location = new Point(107, 125);
            rdoDivide.Margin = new Padding(4, 5, 4, 5);
            rdoDivide.Name = "rdoDivide";
            rdoDivide.Size = new Size(155, 42);
            rdoDivide.TabIndex = 3;
            rdoDivide.Text = "Divide (/)";
            // 
            // rdoModulus
            // 
            rdoModulus.AutoSize = true;
            rdoModulus.Location = new Point(330, 125);
            rdoModulus.Margin = new Padding(4, 5, 4, 5);
            rdoModulus.Name = "rdoModulus";
            rdoModulus.Size = new Size(197, 42);
            rdoModulus.TabIndex = 4;
            rdoModulus.Text = "Modulus (%)";
            // 
            // chkVerbose
            // 
            chkVerbose.AutoSize = true;
            chkVerbose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkVerbose.Location = new Point(70, 321);
            chkVerbose.Margin = new Padding(4, 5, 4, 5);
            chkVerbose.Name = "chkVerbose";
            chkVerbose.Size = new Size(381, 36);
            chkVerbose.TabIndex = 5;
            chkVerbose.Text = "Check to turn on Verbose mode";
            chkVerbose.CheckedChanged += chkVerbose_CheckedChanged;
            chkVerbose.CheckStateChanged += chkVerbose_CheckedChanged;
            chkVerbose.Click += chkVerbose_CheckedChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(823, 169);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 36);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(823, 248);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 36);
            btnReset.TabIndex = 7;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(823, 321);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 36);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.GhostWhite;
            lblMessage.Dock = DockStyle.Bottom;
            lblMessage.Font = new Font("Segoe UI", 14F);
            lblMessage.Location = new Point(0, 394);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(978, 300);
            lblMessage.TabIndex = 9;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRadioStar
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            CancelButton = btnExit;
            ClientSize = new Size(978, 694);
            Controls.Add(lblLeftOperand);
            Controls.Add(txtLeftOperand);
            Controls.Add(lblRightOperand);
            Controls.Add(txtRightOperand);
            Controls.Add(grpOperations);
            Controls.Add(chkVerbose);
            Controls.Add(btnCalculate);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(lblMessage);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRadioStar";
            Text = "Radio Buttons in Action";
            grpOperations.ResumeLayout(false);
            grpOperations.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

