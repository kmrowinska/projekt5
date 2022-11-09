using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select your image";
            openFileDialog1.Filter = "Image file *.jpg; *.jpeg; *.bmp; | *.jpg; *.jpeg; *.bmp;";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public bool process(Bitmap bmp)
        {
            for(int i=0; i<bmp.Width; i++)
            {
                for(int j=0; j<bmp.Height; j++)
                {
                    var pix = bmp.GetPixel(i, j);

                    if(pix.R >10 && pix.G>10 && pix.R >10)
                    {
                        bmp.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.Black);
                    }

                }
            }
            return true;
        }

        public bool process2(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    var pix = bmp.GetPixel(i, j);

                    if (pix.R > 120 && pix.G > 120 && pix.R > 120)
                    {
                        bmp.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.Green);
                    }

                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap copyImage = new Bitmap((Bitmap)pictureBox1.Image);
            process(copyImage);
            pictureBox1.Image = copyImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap copyImage = new Bitmap((Bitmap)pictureBox1.Image);
            process2(copyImage);
            pictureBox1.Image = copyImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
