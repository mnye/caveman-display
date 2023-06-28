using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caveman.Lib.UnitTest
{
  [TestFixture]
  public class TestExample
  {
    public static Point P(int x, int y)
    {
      return new Point(x, y);
    }

    [Test]
    public void Test_EG()
    {
      var components = new IScreenComponent[]
      {
        ScreenLine.Static(P(10, 0), P(10, 20)),
        ScreenLine.Static(P(20, 0), P(20, 20)),
        ScreenLine.Variable("crossLine", P(10, 0), P(20, 20)),
        new ScreenText(false, "title", "Hello World", 2, P(5, 5), ScreenText.TextAlign.Left),
        new ScreenText(false, "title", "Hello World", 2, P(30, 30), ScreenText.TextAlign.Right),
      };

      var coder = new AdafruitGFXGenerator();
      var code = coder.GenerateCode(components);

      Assert.IsNotNull(code);
      Assert.AreEqual(10, code.Length);
    }
  }
}
