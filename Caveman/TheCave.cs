using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            DrawPixels,          // User has selected to draw a pixels and mouse is down
            DrawLine,            // User has selected line tool and mouse is down
            DrawBox,             // User has selected box tool and mouse is down
            DrawText             // User has entered text and is choosing where to place it
        }

        private Renderer? renderer;
        private Generator? generator;
        private int scale = 5;
        private int ScreenW, ScreenH;

        private DrawingState currentDrawingState = DrawingState.None;
        private Point currentMouseLocation;     // Current mouse location on the grid
        private Point elementStartLocation;     // Start location when drawing an element

        private List<CaveElement> caveElements = new List<CaveElement>();
        
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
            listViewComponents.Items.Add("Box");

            renderer = new Renderer(pbPixels, ScreenW, ScreenH, scale);
            generator = new Generator(); // Use dynamic allocation for now
            renderer.Clear();
        }

        private void pbPixels_MouseMove(object sender, MouseEventArgs e)
        {
            var x = e.X / scale;
            var y = e.Y / scale;
            Point newMouseLocation = new(x, y);

            // Check if the grid location has changed
            if (currentMouseLocation == newMouseLocation) { return; }
            currentMouseLocation = newMouseLocation;

            if (x < 0 || x >= ScreenW || y < 0 || y >= ScreenH) { return; }

            if (currentDrawingState == DrawingState.DrawPixels)
            {
                renderer.DrawPixel(x, y);
            }
            else if (currentDrawingState == DrawingState.DrawLine)
            {
                renderer.DrawLine(elementStartLocation.X, elementStartLocation.Y, x, y);
            }
            else if (currentDrawingState == DrawingState.DrawBox)
            {
                renderer.DrawBox(elementStartLocation.X, elementStartLocation.Y, x, y);
            }
            else if (currentDrawingState == DrawingState.None)
            {
                lblCurrXY.Text = $"{x},{y}";
            }
        }

        private void pbPixels_MouseDown(object sender, MouseEventArgs e)
        {
            if (listViewComponents.SelectedItems.Count == 0) { return; }

            var x = e.X / scale;
            var y = e.Y / scale;

            if (listViewComponents.SelectedItems[0].Text == "Pen")
            {
                currentDrawingState = DrawingState.DrawPixels;
                renderer.DrawPixel(x, y);
                lblCurrXY.Text = " ";
            }
            else if (listViewComponents.SelectedItems[0].Text == "Line")
            {
                currentDrawingState = DrawingState.DrawLine;
                elementStartLocation = new Point(x, y);

            }
            else if (listViewComponents.SelectedItems[0].Text == "Box")
            {
                currentDrawingState = DrawingState.DrawBox;
                elementStartLocation = new Point(x, y);

            }
        }

        private void pbPixels_MouseUp(object sender, MouseEventArgs e)
        {
            if (listViewComponents.SelectedItems.Count == 0) { return; }

            var x = e.X / scale;
            var y = e.Y / scale;

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
                renderer.commitElement();
                
                Point tempStartLocation = elementStartLocation;
                Point tempEndLocation = new(x, y);

                LineElement newLine = new(tempStartLocation, tempEndLocation);
                caveElements.Add(newLine);
            }
            else if (currentDrawingState == DrawingState.DrawBox)
            {
                currentDrawingState = DrawingState.None;
                renderer.commitElement();

                Point tempStartLocation = elementStartLocation;
                Point tempEndLocation = new(x, y);

                BoxElement newBox = new(tempStartLocation, tempEndLocation);
                caveElements.Add(newBox);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            renderer.Clear();
        }

        private void listViewComponents_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewComponents.SelectedItems.Count == 0) { return; }

            if (listViewComponents.SelectedItems[0].Text == "Text")
            {
                textBoxTextEntry.Enabled = true;
            }
            else
            {
                textBoxTextEntry.Enabled = false;
                textBoxTextEntry.Clear();
            }
        }
    }
}
