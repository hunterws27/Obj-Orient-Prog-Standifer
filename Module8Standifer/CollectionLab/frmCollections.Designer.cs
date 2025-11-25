namespace CollectionLab
{
    partial class frmCollections
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
            lblEnterNumber = new Label();
            txtNumberInput = new TextBox();
            btnAddNumber = new Button();
            btnShowStats = new Button();
            btnReset = new Button();
            btnExit = new Button();
            rtbCollectionDisplay = new RichTextBox();
            rtbStatsDisplay = new RichTextBox();
            SuspendLayout();
            // 
            // lblEnterNumber
            // 
            lblEnterNumber.AutoSize = true;
            lblEnterNumber.BackColor = Color.FromArgb(0, 64, 0);
            lblEnterNumber.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterNumber.ForeColor = Color.White;
            lblEnterNumber.Location = new Point(36, 70);
            lblEnterNumber.Name = "lblEnterNumber";
            lblEnterNumber.Size = new Size(252, 41);
            lblEnterNumber.TabIndex = 0;
            lblEnterNumber.Text = "Enter a Number:";
            // 
            // txtNumberInput
            // 
            txtNumberInput.Location = new Point(303, 80);
            txtNumberInput.Name = "txtNumberInput";
            txtNumberInput.Size = new Size(252, 31);
            txtNumberInput.TabIndex = 1;
            // 
            // btnAddNumber
            // 
            btnAddNumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNumber.Location = new Point(612, 21);
            btnAddNumber.Name = "btnAddNumber";
            btnAddNumber.Size = new Size(140, 80);
            btnAddNumber.TabIndex = 2;
            btnAddNumber.Text = "Add to Collecttion";
            btnAddNumber.UseVisualStyleBackColor = true;
            btnAddNumber.Click += btnAddNumber_Click;
            // 
            // btnShowStats
            // 
            btnShowStats.Font = new Font("Times New Roman", 12F);
            btnShowStats.Location = new Point(612, 124);
            btnShowStats.Name = "btnShowStats";
            btnShowStats.Size = new Size(140, 80);
            btnShowStats.TabIndex = 3;
            btnShowStats.Text = "Show Statistics";
            btnShowStats.UseVisualStyleBackColor = true;
            btnShowStats.Click += btnShowStats_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 12F);
            btnReset.Location = new Point(612, 231);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(140, 80);
            btnReset.TabIndex = 4;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F);
            btnExit.Location = new Point(612, 341);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 80);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // rtbCollectionDisplay
            // 
            rtbCollectionDisplay.BackColor = Color.FromArgb(255, 128, 128);
            rtbCollectionDisplay.Location = new Point(38, 177);
            rtbCollectionDisplay.Name = "rtbCollectionDisplay";
            rtbCollectionDisplay.ReadOnly = true;
            rtbCollectionDisplay.Size = new Size(250, 200);
            rtbCollectionDisplay.TabIndex = 6;
            rtbCollectionDisplay.TabStop = false;
            rtbCollectionDisplay.Text = "";
            // 
            // rtbStatsDisplay
            // 
            rtbStatsDisplay.BackColor = Color.FromArgb(128, 128, 255);
            rtbStatsDisplay.Location = new Point(332, 177);
            rtbStatsDisplay.Name = "rtbStatsDisplay";
            rtbStatsDisplay.ReadOnly = true;
            rtbStatsDisplay.Size = new Size(250, 200);
            rtbStatsDisplay.TabIndex = 7;
            rtbStatsDisplay.TabStop = false;
            rtbStatsDisplay.Text = "";
            // 
            // frmCollections
            // 
            AcceptButton = btnAddNumber;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbStatsDisplay);
            Controls.Add(rtbCollectionDisplay);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnShowStats);
            Controls.Add(btnAddNumber);
            Controls.Add(txtNumberInput);
            Controls.Add(lblEnterNumber);
            Name = "frmCollections";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Collection Lab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterNumber;
        private TextBox txtNumberInput;
        private Button btnAddNumber;
        private Button btnShowStats;
        private Button btnReset;
        private Button btnExit;
        private RichTextBox rtbCollectionDisplay;
        private RichTextBox rtbStatsDisplay;
    }
}
