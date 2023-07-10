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
        private int screenWidth, screenHeight, totalWidth, totalHeight, scale;
        private int[,] pixelBuffer;

        public Renderer(PictureBox pbIn, int widthIn, int heightIn, int scaleIn)
        {
            this.pb = pbIn;
            this.screenWidth = widthIn;
            this.screenHeight = heightIn;
            this.scale = scaleIn;
            this.totalWidth = widthIn * scaleIn;
            this.totalHeight = heightIn * scaleIn;

            pixelBuffer = new int[screenWidth, screenHeight];
            drawArea = new Bitmap(totalWidth,totalHeight);
            pb.Image = drawArea;
        }

        public void DrawPixel(int x, int y)
        {
            Graphics g;
            g = Graphics.FromImage(drawArea);
            SolidBrush pixelBrush = new SolidBrush(Color.Black);

            pixelBuffer[x, y] = 1;
            g.FillRectangle(pixelBrush, new Rectangle(x * scale, y * scale, scale, scale));

            // Draw image to picturebox
            pb.Image = drawArea;
            g.Dispose();
        }

        public void DrawLine(int x1, int y1, int x2, int y2)
        {

        }

        public void Clear()
        {
            // Clear pixel buffer
            for (int y = 0; y < screenHeight; y++)
            {
                for (int x = 0; x < screenWidth; x++)
                {
                    pixelBuffer[x,y] = 0;
                }
            }

            // Clear image area and set to white
            Graphics g;
            g = Graphics.FromImage(drawArea);
            Pen penFore = new Pen(Color.LightGray);
            Pen penBorder = new Pen(Color.Black);

            g.Clear(Color.White);
            
            g.DrawLine(penBorder, totalWidth, 0, totalWidth, totalHeight);
            g.DrawLine(penBorder, 0, totalHeight, totalWidth, totalHeight);

            for (int i = 1; i < screenWidth; i++)
            {
                g.DrawLine(penFore, scale * i, 0, scale * i, totalHeight);
            }
            for (int i = 1; i < screenHeight; i++)
            {
                g.DrawLine(penFore, 0, scale * i, totalWidth, scale * i);
            }

            // Draw image to picturebox
            pb.Image = drawArea;
            g.Dispose();
        }
    }
}