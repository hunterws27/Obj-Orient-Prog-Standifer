
namespace Week2_Standifer_Project
{
    partial class frmFall2025
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
            lblPrompt = new Label();
            txtUserInput = new TextBox();
            lblDisplay = new Label();
            btnWipe = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrompt.ForeColor = Color.Black;
            lblPrompt.Location = new Point(74, 56);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(232, 36);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter Text Here";
            lblPrompt.TextAlign = ContentAlignment.MiddleRight;
            lblPrompt.Click += lblDisplay_Click;
            // 
            // txtUserInput
            // 
            txtUserInput.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserInput.Location = new Point(310, 54);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(464, 44);
            txtUserInput.TabIndex = 1;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = Color.FromArgb(0, 64, 0);
            lblDisplay.Font = new Font("Courier New", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplay.ForeColor = Color.Black;
            lblDisplay.Location = new Point(74, 101);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(687, 242);
            lblDisplay.TabIndex = 2;
            lblDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnWipe
            // 
            btnWipe.BackColor = Color.White;
            btnWipe.ForeColor = Color.Black;
            btnWipe.Location = new Point(74, 346);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(112, 34);
            btnWipe.TabIndex = 0;
            btnWipe.Text = "&Wipe Clear";
            btnWipe.UseVisualStyleBackColor = false;
            btnWipe.Click += btnWipe_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 255);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(310, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(491, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Ca&ncel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Yellow;
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(662, 346);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmFall2025
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnWipe);
            Controls.Add(lblDisplay);
            Controls.Add(txtUserInput);
            Controls.Add(lblPrompt);
            Name = "frmFall2025";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fall 2025 - Standifer";
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtUserInput;
        private Label lblDisplay;
        private Button btnWipe;
        private Button btnSave;
        private Button btnCancel;
        private Button btnExit;
    }
}
