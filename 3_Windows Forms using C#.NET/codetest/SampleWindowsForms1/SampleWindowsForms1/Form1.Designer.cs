namespace SampleWindowsForms1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_trans = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(273, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "ClickMe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(273, 54);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(128, 22);
            this.txtb_name.TabIndex = 2;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(263, 132);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(58, 20);
            this.rb_male.TabIndex = 3;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gender: ";
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(263, 158);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(74, 20);
            this.rb_female.TabIndex = 5;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_trans
            // 
            this.rb_trans.AutoSize = true;
            this.rb_trans.Location = new System.Drawing.Point(263, 184);
            this.rb_trans.Name = "rb_trans";
            this.rb_trans.Size = new System.Drawing.Size(63, 20);
            this.rb_trans.TabIndex = 6;
            this.rb_trans.TabStop = true;
            this.rb_trans.Text = "Trans";
            this.rb_trans.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_trans);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_trans;
    }
}

