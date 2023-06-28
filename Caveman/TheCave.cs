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
    public TheCave()
    {
      InitializeComponent();


    }

    private void TheCave_Load(object sender, EventArgs e)
    {

    }

    private Pen _Fore = new Pen(Color.LightGray);
    private Pen _Back = new Pen(Color.White);

    private int ScreenW => int.Parse(txtWidth.Text);
    private int ScreenH => int.Parse(txtHeight.Text);

    private void pnlScreen_Paint(object sender, PaintEventArgs e)
    {
      var p = sender as Panel;
      if (p == null) throw new ArgumentException("need panel to paint");
      var g = e.Graphics;

      // Draw our grid for the screen pixels
      var screenW = ScreenW;
      var screenH = ScreenH;

      // TODO - remove the * 2 - work out scrolling / zooming
      var col = p.Width * 2 / screenW;
      var row = p.Height * 2 / screenH;

      var maxX = col * screenW;
      var maxY = row * screenH;

      var border = new Pen(Color.Black);
      g.DrawLine(border, maxX, 0, maxX, maxY);
      g.DrawLine(border, 0, maxY, maxX, maxY);

      for (int i = 1; i < screenW; i++)
      {
        g.DrawLine(_Fore, col * i, 0, col * i, maxY);
      }
      for (int i = 1; i < screenH; i++)
      {
        g.DrawLine(_Fore, 0, row * i, maxX, row * i);
      }

    }

    private void pnlScreen_MouseMove(object sender, MouseEventArgs e)
    {
      var p = sender as Panel;
      if (p == null) throw new ArgumentException("need panel to move");

      // Work out what pixel we are in
      var screenW = ScreenW;
      var screenH = ScreenH;

      // TODO - remove the * 2 - work out scrolling / zooming
      var col = p.Width * 2 / screenW;
      var row = p.Height * 2 / screenH;

      var x = 1 + (e.X / col);
      var y = 1 + (e.Y / row);

      if (x > screenW || y > screenH)
        lblCurrXY.Text = $"OOB";
      else
        lblCurrXY.Text = $"{x},{y}";
    }
  }
}
