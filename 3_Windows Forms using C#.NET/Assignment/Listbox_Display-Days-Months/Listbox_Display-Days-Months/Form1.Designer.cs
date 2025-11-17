namespace Listbox_Display_Days_Months
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
            this.lblListbox = new System.Windows.Forms.Label();
            this.btnDays = new System.Windows.Forms.Button();
            this.btnMonths = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblListbox
            // 
            this.lblListbox.AutoSize = true;
            this.lblListbox.Location = new System.Drawing.Point(12, 37);
            this.lblListbox.Name = "lblListbox";
            this.lblListbox.Size = new System.Drawing.Size(41, 13);
            this.lblListbox.TabIndex = 0;
            this.lblListbox.Text = "Listbox";
            // 
            // btnDays
            // 
            this.btnDays.Location = new System.Drawing.Point(263, 37);
            this.btnDays.Name = "btnDays";
            this.btnDays.Size = new System.Drawing.Size(68, 46);
            this.btnDays.TabIndex = 1;
            this.btnDays.Text = "Days";
            this.btnDays.UseVisualStyleBackColor = true;
            this.btnDays.Click += new System.EventHandler(this.btnDays_Click);
            // 
            // btnMonths
            // 
            this.btnMonths.Location = new System.Drawing.Point(263, 114);
            this.btnMonths.Name = "btnMonths";
            this.btnMonths.Size = new System.Drawing.Size(67, 46);
            this.btnMonths.TabIndex = 2;
            this.btnMonths.Text = "Months";
            this.btnMonths.UseVisualStyleBackColor = true;
            this.btnMonths.Click += new System.EventHandler(this.btnMonths_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(96, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 228);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 290);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMonths);
            this.Controls.Add(this.btnDays);
            this.Controls.Add(this.lblListbox);
            this.Name = "Form1";
            this.Text = "Listbox Display Days Months";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListbox;
        private System.Windows.Forms.Button btnDays;
        private System.Windows.Forms.Button btnMonths;
        private System.Windows.Forms.ListBox listBox1;
    }
}

