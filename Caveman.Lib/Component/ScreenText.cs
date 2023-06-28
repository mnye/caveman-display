using System.Drawing;

namespace Caveman.Lib
{
  public class ScreenText : IScreenComponent
  {
    /// <summary>
    /// Text align will rely on fixed space font?
    /// </summary>
    public enum TextAlign { Left, Right, Middle }

    private readonly bool _IsStatic;
    private readonly string _Name;
    private readonly string _DefaultValue;
    private readonly int _FontSize;
    // TODO - bold, underline, etc ?if boards will support it 

    /// <summary>
    /// The point to align the text from
    /// e.g., will be left/right edge or midpoint
    /// Will have to calculate out where to draw from here, using the fixed font spacing
    /// </summary>
    private readonly Point _AlignPoint;
    private readonly TextAlign _Align;

    public VarType VarType => _IsStatic ? VarType.Static : VarType.Text;
    public string VarName => _Name;

    public ScreenText(bool isStatic, string name, string defaultValue, int fontSize, Point alignPoint, TextAlign align)
    {
      _IsStatic = isStatic;
      _Name = name;
      _DefaultValue = defaultValue;
      _FontSize = fontSize;
      _AlignPoint = alignPoint;
      _Align = align;
    }

    public void Handle(IComponentVisitor coder)
    {
      coder.Handle(this);
    }
  }
}
