namespace Project5Standifer
{
    partial class frmChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoices));
            lblInstructions = new Label();
            lblLeftNumber = new Label();
            lblRightNumber = new Label();
            txtLeftNumber = new TextBox();
            txtRightNumber = new TextBox();
            lblMiddleNumber = new Label();
            txtMiddleNumber = new TextBox();
            btnClear = new Button();
            btnCheck = new Button();
            btnExit = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.Dock = DockStyle.Top;
            lblInstructions.ForeColor = Color.White;
            lblInstructions.Location = new Point(15, 15);
            lblInstructions.MaximumSize = new Size(1325, 100);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(1325, 100);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = resources.GetString("lblInstructions.Text");
            lblInstructions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLeftNumber
            // 
            lblLeftNumber.Location = new Point(45, 189);
            lblLeftNumber.Name = "lblLeftNumber";
            lblLeftNumber.Size = new Size(300, 40);
            lblLeftNumber.TabIndex = 1;
            lblLeftNumber.Text = "Left Number";
            lblLeftNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRightNumber
            // 
            lblRightNumber.Location = new Point(1032, 189);
            lblRightNumber.Name = "lblRightNumber";
            lblRightNumber.Size = new Size(300, 40);
            lblRightNumber.TabIndex = 2;
            lblRightNumber.Text = "Right Number";
            lblRightNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLeftNumber
            // 
            txtLeftNumber.Location = new Point(45, 279);
            txtLeftNumber.Name = "txtLeftNumber";
            txtLeftNumber.Size = new Size(300, 40);
            txtLeftNumber.TabIndex = 3;
            // 
            // txtRightNumber
            // 
            txtRightNumber.Location = new Point(1032, 279);
            txtRightNumber.Name = "txtRightNumber";
            txtRightNumber.Size = new Size(300, 40);
            txtRightNumber.TabIndex = 4;
            // 
            // lblMiddleNumber
            // 
            lblMiddleNumber.Location = new Point(542, 189);
            lblMiddleNumber.MinimumSize = new Size(300, 40);
            lblMiddleNumber.Name = "lblMiddleNumber";
            lblMiddleNumber.Size = new Size(300, 40);
            lblMiddleNumber.TabIndex = 5;
            lblMiddleNumber.Text = "Number to be Checked";
            lblMiddleNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMiddleNumber
            // 
            txtMiddleNumber.Location = new Point(542, 279);
            txtMiddleNumber.Name = "txtMiddleNumber";
            txtMiddleNumber.Size = new Size(300, 40);
            txtMiddleNumber.TabIndex = 6;
            txtMiddleNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(129, 366);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clea&r";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Lime;
            btnCheck.ForeColor = Color.Black;
            btnCheck.Location = new Point(628, 366);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(120, 40);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "&Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(1129, 366);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 40);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.FromArgb(192, 192, 255);
            lblMessage.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Location = new Point(3, 473);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(1370, 100);
            lblMessage.TabIndex = 10;
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmChoices
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(1378, 594);
            Controls.Add(lblMessage);
            Controls.Add(btnExit);
            Controls.Add(btnCheck);
            Controls.Add(btnClear);
            Controls.Add(txtMiddleNumber);
            Controls.Add(lblMiddleNumber);
            Controls.Add(txtRightNumber);
            Controls.Add(txtLeftNumber);
            Controls.Add(lblRightNumber);
            Controls.Add(lblLeftNumber);
            Controls.Add(lblInstructions);
            Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmChoices";
            Padding = new Padding(15, 15, 15, 10);
            Text = "Standifer Choices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstructions;
        private Label lblLeftNumber;
        private Label lblRightNumber;
        private TextBox txtLeftNumber;
        private TextBox txtRightNumber;
        private Label lblMiddleNumber;
        private TextBox txtMiddleNumber;
        private Button btnClear;
        private Button btnCheck;
        private Button btnExit;
        private Label lblMessage;
    }
}
