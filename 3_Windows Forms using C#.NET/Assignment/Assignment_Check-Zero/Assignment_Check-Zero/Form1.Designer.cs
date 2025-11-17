namespace Assignment_Check_Zero
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
            this.lblNumberCheck = new System.Windows.Forms.Label();
            this.lblZeroResult = new System.Windows.Forms.Label();
            this.txtNumberCheck = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberCheck
            // 
            this.lblNumberCheck.AutoSize = true;
            this.lblNumberCheck.Location = new System.Drawing.Point(56, 53);
            this.lblNumberCheck.Name = "lblNumberCheck";
            this.lblNumberCheck.Size = new System.Drawing.Size(103, 16);
            this.lblNumberCheck.TabIndex = 0;
            this.lblNumberCheck.Text = "Enter a number: ";
            // 
            // lblZeroResult
            // 
            this.lblZeroResult.AutoSize = true;
            this.lblZeroResult.Location = new System.Drawing.Point(162, 143);
            this.lblZeroResult.Name = "lblZeroResult";
            this.lblZeroResult.Size = new System.Drawing.Size(9, 13);
            this.lblZeroResult.TabIndex = 1;
            this.lblZeroResult.Text = "-";
            // 
            // txtNumberCheck
            // 
            this.txtNumberCheck.Location = new System.Drawing.Point(165, 53);
            this.txtNumberCheck.Name = "txtNumberCheck";
            this.txtNumberCheck.Size = new System.Drawing.Size(100, 22);
            this.txtNumberCheck.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(165, 95);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 243);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtNumberCheck);
            this.Controls.Add(this.lblZeroResult);
            this.Controls.Add(this.lblNumberCheck);
            this.Name = "Form1";
            this.Text = "Check Zero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberCheck;
        private System.Windows.Forms.Label lblZeroResult;
        private System.Windows.Forms.TextBox txtNumberCheck;
        private System.Windows.Forms.Button btnCheck;
    }
}

