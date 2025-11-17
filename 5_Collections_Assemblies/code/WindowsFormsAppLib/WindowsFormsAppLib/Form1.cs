using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using catchaDemo;

namespace WindowsFormsAppLib
{
    public partial class Form1 : Form
    {
        Class1 c = new Class1 ();
        int a = 0;


        public Form1()
        {
            InitializeComponent();
            loadCaptchDemo();
        }

        private void loadCaptchDemo()
        {
            a = c.rand();
            var image = new Bitmap (this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage (image);
            graphics.DrawString(a.ToString(), font , Brushes.Green, new Point (0, 0));
            this.pictureBox1.Image = image;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            loadCaptchDemo();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == a.ToString())
            {
                MessageBox.Show("Text Matches with the Captcha image.");
            }
            else
                MessageBox.Show("Text does not Matches with the Captcha image!");
        }
    }
}
