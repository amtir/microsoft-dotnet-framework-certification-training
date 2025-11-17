namespace Assignment_Checkboxes
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
            this.lblSelectFruit = new System.Windows.Forms.Label();
            this.chkApple = new System.Windows.Forms.CheckBox();
            this.chkBanana = new System.Windows.Forms.CheckBox();
            this.chkKiwi = new System.Windows.Forms.CheckBox();
            this.chkMango = new System.Windows.Forms.CheckBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectFruit
            // 
            this.lblSelectFruit.AutoSize = true;
            this.lblSelectFruit.Location = new System.Drawing.Point(21, 31);
            this.lblSelectFruit.Name = "lblSelectFruit";
            this.lblSelectFruit.Size = new System.Drawing.Size(81, 16);
            this.lblSelectFruit.TabIndex = 0;
            this.lblSelectFruit.Text = "Select fruits: ";
            // 
            // chkApple
            // 
            this.chkApple.AutoSize = true;
            this.chkApple.Location = new System.Drawing.Point(140, 30);
            this.chkApple.Name = "chkApple";
            this.chkApple.Size = new System.Drawing.Size(72, 20);
            this.chkApple.TabIndex = 1;
            this.chkApple.Text = "APPLE";
            this.chkApple.UseVisualStyleBackColor = true;
            // 
            // chkBanana
            // 
            this.chkBanana.AutoSize = true;
            this.chkBanana.Location = new System.Drawing.Point(140, 57);
            this.chkBanana.Name = "chkBanana";
            this.chkBanana.Size = new System.Drawing.Size(85, 20);
            this.chkBanana.TabIndex = 2;
            this.chkBanana.Text = "BANANA";
            this.chkBanana.UseVisualStyleBackColor = true;
            // 
            // chkKiwi
            // 
            this.chkKiwi.AutoSize = true;
            this.chkKiwi.Location = new System.Drawing.Point(140, 109);
            this.chkKiwi.Name = "chkKiwi";
            this.chkKiwi.Size = new System.Drawing.Size(56, 20);
            this.chkKiwi.TabIndex = 4;
            this.chkKiwi.Text = "KIWI";
            this.chkKiwi.UseVisualStyleBackColor = true;
            // 
            // chkMango
            // 
            this.chkMango.AutoSize = true;
            this.chkMango.Location = new System.Drawing.Point(140, 83);
            this.chkMango.Name = "chkMango";
            this.chkMango.Size = new System.Drawing.Size(79, 20);
            this.chkMango.TabIndex = 3;
            this.chkMango.Text = "MANGO";
            this.chkMango.UseVisualStyleBackColor = true;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(146, 135);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 33);
            this.btnClick.TabIndex = 5;
            this.btnClick.Text = "CLICK";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 294);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.chkKiwi);
            this.Controls.Add(this.chkMango);
            this.Controls.Add(this.chkBanana);
            this.Controls.Add(this.chkApple);
            this.Controls.Add(this.lblSelectFruit);
            this.Name = "Form1";
            this.Text = "Checkbox Fruits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectFruit;
        private System.Windows.Forms.CheckBox chkApple;
        private System.Windows.Forms.CheckBox chkBanana;
        private System.Windows.Forms.CheckBox chkKiwi;
        private System.Windows.Forms.CheckBox chkMango;
        private System.Windows.Forms.Button btnClick;
    }
}

