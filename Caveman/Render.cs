// This class is used to render the pixel display on the Form (pbPixels)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Caveman
{
    class Renderer
    {
        public PictureBox pb;
        public Bitmap drawArea;
        private int width, height, scale;

        public Renderer(PictureBox pbIn, int widthIn, int heightIn, int scaleIn)
        {
            this.pb = pbIn;
            this.width = widthIn;
            this.height = heightIn;
            this.scale = scaleIn;
            drawArea = new Bitmap(width * scale, height * scale);
            pb.Image = drawArea;
        }

        public void DrawPixel(int x, int y)
        {
            Graphics g;
            g = Graphics.FromImage(drawArea);
            SolidBrush pixelBrush = new SolidBrush(Color.Black);

            g.FillRectangle(pixelBrush, new Rectangle(x * scale, y * scale, scale, scale));

            // Draw image to picturebox
            pb.Image = drawArea;
            g.Dispose();
        }

        public void Clear()
        {
            // Clear image area and set to white
            Graphics g;
            g = Graphics.FromImage(drawArea);
            Pen _Fore = new Pen(Color.LightGray);

            // Draw our grid for the screen pixels
            var maxX = width * scale;
            var maxY = height * scale;

            var border = new Pen(Color.Black);

            g.Clear(Color.White);
            
            g.DrawLine(border, maxX, 0, maxX, maxY);
            g.DrawLine(border, 0, maxY, maxX, maxY);

            for (int i = 1; i < width; i++)
            {
                g.DrawLine(_Fore, scale * i, 0, scale * i, maxY);
            }
            for (int i = 1; i < height; i++)
            {
                g.DrawLine(_Fore, 0, scale * i, maxX, scale * i);
            }

            // Draw image to picturebox
            pb.Image = drawArea;
            g.Dispose();
        }
    }
}