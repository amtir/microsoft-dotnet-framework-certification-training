using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtb_username.Text == "James" && txtb_passw.Text == "Password")
            {
                    MessageBox.Show("Hi James! How are you doing?" , "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password. \nPlease Try agin.", "Log-In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_clicked_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message: Button Click enabled!");
        }
        private void Do_Checked()
        {
            btn_clicked.Enabled = cb_enabled.Checked;
        }

        private void cb_enabled_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Do_Checked();
            picbx_img.Image = Image.FromFile("D:\\NET\\image.jpg");
            picbx_img.SizeMode = PictureBoxSizeMode.StretchImage;

            lbx_list.Items.Add("Sunday");
            lbx_list.Items.Add("Monday");
            lbx_list.Items.Add("Tuesday");
            lbx_list.Items.Add("Wednesday");
            lbx_list.Items.Add("Thursday");
            lbx_list.Items.Add("Friday");
            lbx_list.Items.Add("Saturday");
            lbx_list.SelectionMode = SelectionMode.MultiSimple;

            refreschdata();
        }


        private void refreschdata()
        {
            Console.WriteLine("SQL Get data from DB.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            cbx_collection.Items.Clear();
            cbx_collection.Items.Add("Chennai");
            string[] items =
            {   
                "Delhi",
                "Cochin",
                "Bangalor"
            };
            cbx_collection.Items.AddRange(items);
        }

        private void btn_viewItemIdex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbx_collection.SelectedIndex.ToString());
        }

        private void btn_viewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbx_collection.SelectedItem.ToString());
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            foreach (object o in lbx_list.SelectedItems)
            {
                MessageBox.Show(o.ToString());
            }
        }

        private void btn_showDiaCol_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            //cd.ShowDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = cd.Color.Name;
                MessageBox.Show(str);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToString();
        }
    }
}
