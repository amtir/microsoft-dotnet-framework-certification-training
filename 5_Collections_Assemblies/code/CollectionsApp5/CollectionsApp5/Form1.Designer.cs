namespace CollectionsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnReverseString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "REVERSE";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(120, 82);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(97, 16);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Enter a number";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(120, 154);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(84, 16);
            this.lblStr.TabIndex = 4;
            this.lblStr.Text = "Enter a string";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(394, 70);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(108, 40);
            this.btnReverse.TabIndex = 5;
            this.btnReverse.Text = "REVERSE NUMBER";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnReverseString
            // 
            this.btnReverseString.Location = new System.Drawing.Point(394, 138);
            this.btnReverseString.Name = "btnReverseString";
            this.btnReverseString.Size = new System.Drawing.Size(108, 41);
            this.btnReverseString.TabIndex = 6;
            this.btnReverseString.Text = "REVERSE STRING";
            this.btnReverseString.UseVisualStyleBackColor = true;
            this.btnReverseString.Click += new System.EventHandler(this.btnReverseString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 263);
            this.Controls.Add(this.btnReverseString);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "REVERSE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnReverseString;
    }
}

