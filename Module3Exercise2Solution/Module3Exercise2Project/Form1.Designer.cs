namespace Module3Exercise2Project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(32, 25);
            this.btnRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(140, 69);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "&R";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(564, 25);
            this.btnBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(140, 69);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "&B";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(569, 239);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(140, 69);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "&R";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(32, 239);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(140, 69);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "&L";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(200, 365);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(328, 149);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 283);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(722, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Color and Direction Demo";
            this.ResumeLayout(false);

        }

        #endregion

        // FIXED: Renamed all buttons
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}


