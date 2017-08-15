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
        private SolidBrush brush;
        int x = 0, y = 0, swap = 0;
        int max_height, max_width;

        public ImageGenerator()
        {
            InitializeComponent();
        }

        private void ImageGenerator_Load(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Black);
            max_height = this.Height;
            max_width = this.Width;
        }

        private void ImageGenerator_Paint(object sender, PaintEventArgs e)
        {
            
            paper = e.Graphics;
            draw(paper);
        }

        private void draw(Graphics paper)
        {
            for (int h = 0; h < max_height; h++)
			{
                for (int w = 0; w < max_width; w++)
			    {

			    }
			}
            if (swap == 0)
            {
                paper.FillRectangle(brush, x, y, 1, 1);
                swap = 1;
            }
            else
            {
                paper.FillRectangle(brush2, x, y, 1, 1);
                swap = 0;
            }

        }
    }
}
