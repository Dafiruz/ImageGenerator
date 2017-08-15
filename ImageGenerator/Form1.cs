using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGenerator
{
    public partial class ImageGenerator : Form
    {
        Graphics paper;
        private SolidBrush brush, brush2;
        int x = 0, y = 0, swap = 0;
        int max_height, max_width;

        public ImageGenerator()
        {
            InitializeComponent();
        }

        private void ImageGenerator_Load(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Black);
            brush2 = new SolidBrush(Color.White);
            max_height = this.Height;
            max_width = this.Width;
            this.Invalidate();
        }

        private void ImageGenerator_Paint(object sender, PaintEventArgs e)
        {
            for (int h = 0; h < max_height; h++)
            {
                for (int w = 0; w < max_width; w++)
                {
                    if (swap == 0)
                    {
                        e.Graphics.FillRectangle(brush, h, w, 1, 1);
                        swap = 1;
                    }
                    else
                    {
                        e.Graphics.FillRectangle(brush2, h, w, 1, 1);
                        swap = 0;
                    }
                }
            }
        }
    }
}
