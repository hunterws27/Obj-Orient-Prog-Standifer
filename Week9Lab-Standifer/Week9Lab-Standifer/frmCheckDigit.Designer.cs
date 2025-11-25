namespace Week9Lab_Standifer
{
    partial class frmCheckDigit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAccount = new TextBox();
            txtConfirm = new TextBox();
            txtAmount = new TextBox();
            lblAccount = new Label();
            lblConfirm = new Label();
            lblAmount = new Label();
            btnProcess = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(12, 146);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(335, 45);
            txtAccount.TabIndex = 0;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(434, 146);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(335, 45);
            txtConfirm.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(850, 146);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(335, 45);
            txtAmount.TabIndex = 2;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.ForeColor = SystemColors.ButtonFace;
            lblAccount.Location = new Point(71, 39);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(228, 38);
            lblAccount.TabIndex = 3;
            lblAccount.Text = "Account Number";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.ForeColor = SystemColors.ButtonFace;
            lblConfirm.Location = new Point(447, 39);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(335, 38);
            lblConfirm.TabIndex = 4;
            lblConfirm.Text = "Confirm Account Number";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.ForeColor = SystemColors.ButtonFace;
            lblAmount.Location = new Point(914, 39);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(234, 38);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Payment Number";
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(111, 289);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(150, 45);
            btnProcess.TabIndex = 6;
            btnProcess.Text = "&Process";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(530, 289);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 45);
            btnReset.TabIndex = 7;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(950, 289);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 45);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = SystemColors.ButtonFace;
            lblMessage.Dock = DockStyle.Bottom;
            lblMessage.Location = new Point(0, 402);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(1200, 282);
            lblMessage.TabIndex = 9;
            // 
            // frmCheckDigit
            // 
            AcceptButton = btnProcess;
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            CancelButton = btnExit;
            ClientSize = new Size(1200, 684);
            Controls.Add(lblMessage);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnProcess);
            Controls.Add(lblAmount);
            Controls.Add(lblConfirm);
            Controls.Add(lblAccount);
            Controls.Add(txtAmount);
            Controls.Add(txtConfirm);
            Controls.Add(txtAccount);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCheckDigit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check Digit Verification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccount;
        private TextBox txtConfirm;
        private TextBox txtAmount;
        private Label lblAccount;
        private Label lblConfirm;
        private Label lblAmount;
        private Button btnProcess;
        private Button btnReset;
        private Button btnExit;
        private Label lblMessage;
    }
}
