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
        Random randomColor = new Random();
        Color color;

        private SolidBrush brush;
        int x = 0, y = 0, swap = 0;
        int max_height, max_width;

        public ImageGenerator()
        {
            InitializeComponent();
        }

        private void ImageGenerator_Load(object sender, EventArgs e)
        {
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
                    //get a random colour
                    color = Color.FromArgb(randomColor.Next(256), randomColor.Next(256), randomColor.Next(256));
                    brush = new SolidBrush(color);

                    //paint the pixel
                    e.Graphics.FillRectangle(brush, h, w, 1, 1);
                }
            }
        }
    }
}
