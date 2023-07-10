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
        struct GridPoint
        {
            public int x, y;
        }
        private enum DrawingState
        {
            None,
            DrawPixels,          // User has selected to draw a pixels and mouse is down
            DrawLine,            // User has selected line tool and mouse is down
            TextEntry            // User has selected location to draw text
        }

        private Renderer? renderer;
        private int scale = 5; 
        private int ScreenW, ScreenH;


        private DrawingState currentDrawingState = DrawingState.None;
        private GridPoint elementStartLocation;     // Start location when drawing an element

        public TheCave()
        {
            InitializeComponent();
        }

        private void TheCave_Load(object sender, EventArgs e)
        {
            ScreenW = int.Parse(txtWidth.Text);
            ScreenH = int.Parse(txtHeight.Text);

            // Initialise component list
            listViewComponents.Items.Add("Pen");
            listViewComponents.Items.Add("Line");
            listViewComponents.Items.Add("Text");

            renderer = new Renderer(pbPixels, ScreenW, ScreenH, scale);
            renderer.Clear();
        }

        private void pbPixels_MouseMove(object sender, MouseEventArgs e)
        {
            var x = (e.X / scale);
            var y = (e.Y / scale);

            if (x < 0 || x >= ScreenW || y < 0 || y >= ScreenH) { return; }

            if (currentDrawingState == DrawingState.DrawPixels)
            {
                renderer.DrawPixel(x, y);
            }
            else if (currentDrawingState == DrawingState.DrawLine)
            {
                renderer.DrawLine(elementStartLocation.x, elementStartLocation.y, x, y);
            }
            else if (currentDrawingState == DrawingState.None)
            {
                UpdateLocation(e.X, e.Y);
            }
        }

        private void pbPixels_MouseDown(object sender, MouseEventArgs e)
        {
            if (listViewComponents.SelectedItems.Count == 0)
            {
                return;
            }

            var x = (e.X / scale);
            var y = (e.Y / scale);

            if (listViewComponents.SelectedItems[0].Text == "Pen")
            {
                currentDrawingState = DrawingState.DrawPixels;
                renderer.DrawPixel(x, y);
                lblCurrXY.Text = " ";
            }
            else if (listViewComponents.SelectedItems[0].Text == "Line")
            {
                currentDrawingState = DrawingState.DrawLine;
                elementStartLocation.x = x;
                elementStartLocation.y = y;

            }
        }

        private void pbPixels_MouseUp(object sender, MouseEventArgs e)
        {
            if (listViewComponents.SelectedItems.Count == 0) { return; }

            var x = (e.X / scale);
            var y = (e.Y / scale);

            if (x < 0 || x >= ScreenW || y < 0 || y >= ScreenH) 
            { 
                currentDrawingState = DrawingState.None;
                return; 
            }

            if (currentDrawingState == DrawingState.DrawPixels)
            {
                currentDrawingState = DrawingState.None;
                renderer.DrawPixel(x, y);
            }
            else if (currentDrawingState == DrawingState.DrawLine)
            {
                currentDrawingState = DrawingState.None;
                renderer.DrawLine(elementStartLocation.x, elementStartLocation.y, x, y);
            }
        }

        private void UpdateLocation(int xIn, int yIn)
        {
            var x = (xIn / scale);
            var y = (yIn / scale);

            if (x > ScreenW || y > ScreenH)
                lblCurrXY.Text = $"OOB";
            else
                lblCurrXY.Text = $"{x},{y}";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            renderer.Clear();
        }
    }
}
