namespace ConsoleApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIntInput = new System.Windows.Forms.TextBox();
            this.btnAddInt = new System.Windows.Forms.Button();
            this.btnShowInt = new System.Windows.Forms.Button();
            this.btnContainsInt = new System.Windows.Forms.Button();
            this.btnAddString = new System.Windows.Forms.Button();
            this.btnShowString = new System.Windows.Forms.Button();
            this.btnContainsStr = new System.Windows.Forms.Button();
            this.txtIntCheck = new System.Windows.Forms.TextBox();
            this.txtStrInput = new System.Windows.Forms.TextBox();
            this.txtStrCheck = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERICS - HASHSET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter int items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter str item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Check str";
            // 
            // txtIntInput
            // 
            this.txtIntInput.Location = new System.Drawing.Point(250, 88);
            this.txtIntInput.Name = "txtIntInput";
            this.txtIntInput.Size = new System.Drawing.Size(100, 22);
            this.txtIntInput.TabIndex = 5;
            // 
            // btnAddInt
            // 
            this.btnAddInt.Location = new System.Drawing.Point(148, 123);
            this.btnAddInt.Name = "btnAddInt";
            this.btnAddInt.Size = new System.Drawing.Size(78, 37);
            this.btnAddInt.TabIndex = 6;
            this.btnAddInt.Text = "ADD_INT";
            this.btnAddInt.UseVisualStyleBackColor = true;
            this.btnAddInt.Click += new System.EventHandler(this.btnAddInt_Click);
            // 
            // btnShowInt
            // 
            this.btnShowInt.Location = new System.Drawing.Point(232, 123);
            this.btnShowInt.Name = "btnShowInt";
            this.btnShowInt.Size = new System.Drawing.Size(99, 36);
            this.btnShowInt.TabIndex = 7;
            this.btnShowInt.Text = "SHOW_INT";
            this.btnShowInt.UseVisualStyleBackColor = true;
            this.btnShowInt.Click += new System.EventHandler(this.btnShowInt_Click);
            // 
            // btnContainsInt
            // 
            this.btnContainsInt.Location = new System.Drawing.Point(343, 123);
            this.btnContainsInt.Name = "btnContainsInt";
            this.btnContainsInt.Size = new System.Drawing.Size(140, 37);
            this.btnContainsInt.TabIndex = 8;
            this.btnContainsInt.Text = "CONTAINS_INT";
            this.btnContainsInt.UseVisualStyleBackColor = true;
            this.btnContainsInt.Click += new System.EventHandler(this.btnContainsInt_Click);
            // 
            // btnAddString
            // 
            this.btnAddString.Location = new System.Drawing.Point(65, 284);
            this.btnAddString.Name = "btnAddString";
            this.btnAddString.Size = new System.Drawing.Size(104, 34);
            this.btnAddString.TabIndex = 9;
            this.btnAddString.Text = "ADD_STRING";
            this.btnAddString.UseVisualStyleBackColor = true;
            this.btnAddString.Click += new System.EventHandler(this.btnAddString_Click);
            // 
            // btnShowString
            // 
            this.btnShowString.Location = new System.Drawing.Point(175, 284);
            this.btnShowString.Name = "btnShowString";
            this.btnShowString.Size = new System.Drawing.Size(142, 34);
            this.btnShowString.TabIndex = 10;
            this.btnShowString.Text = "SHOW_STRING";
            this.btnShowString.UseVisualStyleBackColor = true;
            this.btnShowString.Click += new System.EventHandler(this.btnShowString_Click);
            // 
            // btnContainsStr
            // 
            this.btnContainsStr.Location = new System.Drawing.Point(323, 284);
            this.btnContainsStr.Name = "btnContainsStr";
            this.btnContainsStr.Size = new System.Drawing.Size(115, 34);
            this.btnContainsStr.TabIndex = 11;
            this.btnContainsStr.Text = "CONTAINS_STR";
            this.btnContainsStr.UseVisualStyleBackColor = true;
            this.btnContainsStr.Click += new System.EventHandler(this.btnContainsStr_Click);
            // 
            // txtIntCheck
            // 
            this.txtIntCheck.Location = new System.Drawing.Point(250, 183);
            this.txtIntCheck.Name = "txtIntCheck";
            this.txtIntCheck.Size = new System.Drawing.Size(100, 22);
            this.txtIntCheck.TabIndex = 12;
            // 
            // txtStrInput
            // 
            this.txtStrInput.Location = new System.Drawing.Point(250, 234);
            this.txtStrInput.Name = "txtStrInput";
            this.txtStrInput.Size = new System.Drawing.Size(100, 22);
            this.txtStrInput.TabIndex = 13;
            // 
            // txtStrCheck
            // 
            this.txtStrCheck.Location = new System.Drawing.Point(234, 334);
            this.txtStrCheck.Name = "txtStrCheck";
            this.txtStrCheck.Size = new System.Drawing.Size(100, 22);
            this.txtStrCheck.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(489, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 228);
            this.listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 458);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtStrCheck);
            this.Controls.Add(this.txtStrInput);
            this.Controls.Add(this.txtIntCheck);
            this.Controls.Add(this.btnContainsStr);
            this.Controls.Add(this.btnShowString);
            this.Controls.Add(this.btnAddString);
            this.Controls.Add(this.btnContainsInt);
            this.Controls.Add(this.btnShowInt);
            this.Controls.Add(this.btnAddInt);
            this.Controls.Add(this.txtIntInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Collectioon 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIntInput;
        private System.Windows.Forms.Button btnAddInt;
        private System.Windows.Forms.Button btnShowInt;
        private System.Windows.Forms.Button btnContainsInt;
        private System.Windows.Forms.Button btnAddString;
        private System.Windows.Forms.Button btnShowString;
        private System.Windows.Forms.Button btnContainsStr;
        private System.Windows.Forms.TextBox txtIntCheck;
        private System.Windows.Forms.TextBox txtStrInput;
        private System.Windows.Forms.TextBox txtStrCheck;
        private System.Windows.Forms.ListBox listBox1;
    }
}

