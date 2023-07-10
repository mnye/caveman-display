using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caveman
{
    public partial class TheCave : Form
    {
        private enum DrawingState
        {
            None,
            DrawPixel,          // User has selected to draw a pixel
            SquareStarted,      // User has selected top-left point of square
            TextEntry           // User has selected location to draw text
        }

        private Renderer? renderer;           // Our Render class object
        private int scale = 5;                // Scaling factor for the pixels
        private int ScreenW => int.Parse(txtWidth.Text);
        private int ScreenH => int.Parse(txtHeight.Text);

        public TheCave()
        {
            InitializeComponent();
        }

        private void TheCave_Load(object sender, EventArgs e)
        {
            // Initialise component list
            listViewComponents.Items.Add("Pixel");
            listViewComponents.Items.Add("Square");
            listViewComponents.Items.Add("Text");

            renderer = new Renderer(pbPixels, ScreenW, ScreenH, scale);
            renderer.Clear();
        }

        private void pbPixels_MouseMove(object sender, MouseEventArgs e)
        {
            var p = sender as PictureBox;
            if (p == null) throw new ArgumentException("need panel to move");

            // Work out what pixel we are in
            var screenW = ScreenW;
            var screenH = ScreenH;

            var col = p.Width / screenW;
            var row = p.Height / screenH;

            var x = (e.X / col);
            var y = (e.Y / row);

            if (x > screenW || y > screenH)
                lblCurrXY.Text = $"OOB";
            else
                lblCurrXY.Text = $"{x},{y}";
        }

        private void pbPixels_MouseUp(object sender, MouseEventArgs e)
        {
            if (listViewComponents.SelectedItems.Count == 0) {
                return;
            }

            var x = (e.X / scale);
            var y = (e.Y / scale);

            if (listViewComponents.SelectedItems[0].Text == "Pixel")
            {
                renderer.DrawPixel(x, y);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            renderer.Clear();
        }
    }
}
