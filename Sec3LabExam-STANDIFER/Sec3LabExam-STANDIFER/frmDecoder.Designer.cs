namespace Sec3LabExam_STANDIFER
{
    partial class frmDecoder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rbPlain = new System.Windows.Forms.RadioButton();
            this.rbCipher = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblInput.Location = new System.Drawing.Point(69, 88);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(169, 36);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Enter Text:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(266, 22);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(450, 175);
            this.txtInput.TabIndex = 0;
            // 
            // rbPlain
            // 
            this.rbPlain.AutoSize = true;
            this.rbPlain.Location = new System.Drawing.Point(37, 90);
            this.rbPlain.Name = "rbPlain";
            this.rbPlain.Size = new System.Drawing.Size(182, 31);
            this.rbPlain.TabIndex = 2;
            this.rbPlain.TabStop = true;
            this.rbPlain.Text = "Cipher to Plain";
            this.rbPlain.UseVisualStyleBackColor = true;
            // 
            // rbCipher
            // 
            this.rbCipher.AutoSize = true;
            this.rbCipher.Location = new System.Drawing.Point(37, 43);
            this.rbCipher.Name = "rbCipher";
            this.rbCipher.Size = new System.Drawing.Size(182, 31);
            this.rbCipher.TabIndex = 3;
            this.rbCipher.TabStop = true;
            this.rbCipher.Text = "Plain to Cipher";
            this.rbCipher.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblOutput.Location = new System.Drawing.Point(13, 324);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(225, 36);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Converted Text";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(266, 258);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(450, 175);
            this.txtOutput.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(783, 208);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(146, 37);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(783, 302);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 37);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(783, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCipher);
            this.groupBox1.Controls.Add(this.rbPlain);
            this.groupBox1.Location = new System.Drawing.Point(728, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 150);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Mode";
            // 
            // frmDecoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.ClientSize = new System.Drawing.Size(1040, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Name = "frmDecoder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decoder Wheel – Classes Commence";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rbPlain;
        private System.Windows.Forms.RadioButton rbCipher;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

