namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.gb_usercredent = new System.Windows.Forms.GroupBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txtb_username = new System.Windows.Forms.TextBox();
            this.lbl_passw = new System.Windows.Forms.Label();
            this.txtb_passw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.cb_enabled = new System.Windows.Forms.CheckBox();
            this.btn_clicked = new System.Windows.Forms.Button();
            this.cbx_collection = new System.Windows.Forms.ComboBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_viewItemIdex = new System.Windows.Forms.Button();
            this.btn_viewItem = new System.Windows.Forms.Button();
            this.lbl_col = new System.Windows.Forms.Label();
            this.picbx_img = new System.Windows.Forms.PictureBox();
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_showDiaCol = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.gb_usercredent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_usercredent
            // 
            this.gb_usercredent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_usercredent.Controls.Add(this.btn_login);
            this.gb_usercredent.Controls.Add(this.txtb_passw);
            this.gb_usercredent.Controls.Add(this.lbl_passw);
            this.gb_usercredent.Controls.Add(this.txtb_username);
            this.gb_usercredent.Controls.Add(this.lbl_username);
            this.gb_usercredent.Location = new System.Drawing.Point(511, 58);
            this.gb_usercredent.Name = "gb_usercredent";
            this.gb_usercredent.Size = new System.Drawing.Size(252, 184);
            this.gb_usercredent.TabIndex = 0;
            this.gb_usercredent.TabStop = false;
            this.gb_usercredent.Text = "User Credentials";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(6, 50);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 16);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "User Name";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // txtb_username
            // 
            this.txtb_username.Location = new System.Drawing.Point(125, 60);
            this.txtb_username.Name = "txtb_username";
            this.txtb_username.Size = new System.Drawing.Size(100, 22);
            this.txtb_username.TabIndex = 1;
            // 
            // lbl_passw
            // 
            this.lbl_passw.AutoSize = true;
            this.lbl_passw.Location = new System.Drawing.Point(6, 99);
            this.lbl_passw.Name = "lbl_passw";
            this.lbl_passw.Size = new System.Drawing.Size(67, 16);
            this.lbl_passw.TabIndex = 1;
            this.lbl_passw.Text = "Password";
            // 
            // txtb_passw
            // 
            this.txtb_passw.Location = new System.Drawing.Point(125, 99);
            this.txtb_passw.Name = "txtb_passw";
            this.txtb_passw.PasswordChar = '*';
            this.txtb_passw.Size = new System.Drawing.Size(100, 22);
            this.txtb_passw.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(80, 137);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(93, 32);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cb_enabled
            // 
            this.cb_enabled.AutoSize = true;
            this.cb_enabled.Location = new System.Drawing.Point(360, 12);
            this.cb_enabled.Name = "cb_enabled";
            this.cb_enabled.Size = new System.Drawing.Size(80, 20);
            this.cb_enabled.TabIndex = 1;
            this.cb_enabled.Text = "Enabled";
            this.cb_enabled.UseVisualStyleBackColor = true;
            this.cb_enabled.CheckedChanged += new System.EventHandler(this.cb_enabled_CheckedChanged);
            // 
            // btn_clicked
            // 
            this.btn_clicked.Location = new System.Drawing.Point(446, 2);
            this.btn_clicked.Name = "btn_clicked";
            this.btn_clicked.Size = new System.Drawing.Size(86, 39);
            this.btn_clicked.TabIndex = 2;
            this.btn_clicked.Text = "Clicked";
            this.btn_clicked.UseVisualStyleBackColor = true;
            this.btn_clicked.Click += new System.EventHandler(this.btn_clicked_Click);
            // 
            // cbx_collection
            // 
            this.cbx_collection.FormattingEnabled = true;
            this.cbx_collection.Location = new System.Drawing.Point(126, 22);
            this.cbx_collection.Name = "cbx_collection";
            this.cbx_collection.Size = new System.Drawing.Size(158, 24);
            this.cbx_collection.TabIndex = 3;
            this.cbx_collection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(11, 52);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 23);
            this.btn_addItem.TabIndex = 4;
            this.btn_addItem.Text = "Add items by code";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_viewItemIdex
            // 
            this.btn_viewItemIdex.Location = new System.Drawing.Point(98, 52);
            this.btn_viewItemIdex.Name = "btn_viewItemIdex";
            this.btn_viewItemIdex.Size = new System.Drawing.Size(124, 23);
            this.btn_viewItemIdex.TabIndex = 5;
            this.btn_viewItemIdex.Text = "View Item Index";
            this.btn_viewItemIdex.UseVisualStyleBackColor = true;
            this.btn_viewItemIdex.Click += new System.EventHandler(this.btn_viewItemIdex_Click);
            // 
            // btn_viewItem
            // 
            this.btn_viewItem.Location = new System.Drawing.Point(250, 52);
            this.btn_viewItem.Name = "btn_viewItem";
            this.btn_viewItem.Size = new System.Drawing.Size(75, 23);
            this.btn_viewItem.TabIndex = 6;
            this.btn_viewItem.Text = "View Item";
            this.btn_viewItem.UseVisualStyleBackColor = true;
            this.btn_viewItem.Click += new System.EventHandler(this.btn_viewItem_Click);
            // 
            // lbl_col
            // 
            this.lbl_col.AutoSize = true;
            this.lbl_col.Location = new System.Drawing.Point(33, 25);
            this.lbl_col.Name = "lbl_col";
            this.lbl_col.Size = new System.Drawing.Size(76, 16);
            this.lbl_col.TabIndex = 7;
            this.lbl_col.Text = "City Names";
            // 
            // picbx_img
            // 
            this.picbx_img.Location = new System.Drawing.Point(511, 248);
            this.picbx_img.Name = "picbx_img";
            this.picbx_img.Size = new System.Drawing.Size(239, 137);
            this.picbx_img.TabIndex = 8;
            this.picbx_img.TabStop = false;
            // 
            // lbx_list
            // 
            this.lbx_list.FormattingEnabled = true;
            this.lbx_list.ItemHeight = 16;
            this.lbx_list.Location = new System.Drawing.Point(11, 107);
            this.lbx_list.Name = "lbx_list";
            this.lbx_list.Size = new System.Drawing.Size(164, 84);
            this.lbx_list.TabIndex = 9;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(12, 197);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(87, 37);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_showDiaCol
            // 
            this.btn_showDiaCol.Location = new System.Drawing.Point(11, 295);
            this.btn_showDiaCol.Name = "btn_showDiaCol";
            this.btn_showDiaCol.Size = new System.Drawing.Size(120, 53);
            this.btn_showDiaCol.TabIndex = 12;
            this.btn_showDiaCol.Text = "Show Color Dialog";
            this.btn_showDiaCol.UseVisualStyleBackColor = true;
            this.btn_showDiaCol.Click += new System.EventHandler(this.btn_showDiaCol_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(228, 319);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(199, 29);
            this.lbl_timer.TabIndex = 13;
            this.lbl_timer.Text = "Time: HH:MM:SS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.btn_showDiaCol);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbx_list);
            this.Controls.Add(this.picbx_img);
            this.Controls.Add(this.lbl_col);
            this.Controls.Add(this.btn_viewItem);
            this.Controls.Add(this.btn_viewItemIdex);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.cbx_collection);
            this.Controls.Add(this.btn_clicked);
            this.Controls.Add(this.cb_enabled);
            this.Controls.Add(this.gb_usercredent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_usercredent.ResumeLayout(false);
            this.gb_usercredent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_usercredent;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txtb_passw;
        private System.Windows.Forms.Label lbl_passw;
        private System.Windows.Forms.TextBox txtb_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox cb_enabled;
        private System.Windows.Forms.Button btn_clicked;
        private System.Windows.Forms.ComboBox cbx_collection;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_viewItemIdex;
        private System.Windows.Forms.Button btn_viewItem;
        private System.Windows.Forms.Label lbl_col;
        private System.Windows.Forms.PictureBox picbx_img;
        private System.Windows.Forms.ListBox lbx_list;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_showDiaCol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
    }
}

