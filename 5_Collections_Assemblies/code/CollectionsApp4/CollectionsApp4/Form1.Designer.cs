namespace CollectionsApp4
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
            this.lblInt = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtRemoveKey = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COLLECTIONS - SORTEDLIST";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(59, 218);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(89, 16);
            this.lblInt.TabIndex = 1;
            this.lblInt.Text = "Enter int items";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(59, 246);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(90, 16);
            this.lblStr.TabIndex = 2;
            this.lblStr.Text = "Enter str items";
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(59, 342);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(115, 13);
            this.lblRemove.TabIndex = 3;
            this.lblRemove.Text = "Enter int no. to remove";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(105, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 132);
            this.listBox1.TabIndex = 4;
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(186, 209);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(100, 22);
            this.txtInt.TabIndex = 5;
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(186, 237);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(100, 22);
            this.txtStr.TabIndex = 6;
            // 
            // txtRemoveKey
            // 
            this.txtRemoveKey.Location = new System.Drawing.Point(241, 342);
            this.txtRemoveKey.Name = "txtRemoveKey";
            this.txtRemoveKey.Size = new System.Drawing.Size(100, 22);
            this.txtRemoveKey.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(143, 279);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(83, 31);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(255, 279);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 31);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 406);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRemoveKey);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtRemoveKey;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRemove;
    }
}

