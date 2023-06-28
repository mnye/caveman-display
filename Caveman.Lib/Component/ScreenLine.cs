using System.Drawing;

namespace Caveman.Lib
{
  /// <summary>
  /// A simple line drawn on the screen
  /// Name is the variable name used in the generated code
  /// VarType = bool (the line is either on or off)
  /// </summary>
  public class ScreenLine : IScreenComponent
  {
    private readonly bool _IsStatic;
    private readonly string _Name;
    private readonly Point _Start;
    private readonly Point _End;

    public VarType VarType => _IsStatic ? VarType.Static : VarType.Bool;
    public string VarName => _Name;
    public Point Start => _Start;
    public Point End => _End;

    private ScreenLine(bool isStatic, string varName, Point start, Point end)
    {
      _IsStatic = isStatic;
      _Name = varName;
      _Start = start;
      _End = end;
    }

    public static ScreenLine Static(Point start, Point end)
    {
      return new ScreenLine(true, string.Empty, start, end);
    }

    public static ScreenLine Variable(string name, Point start, Point end)
    {
      return new ScreenLine(false, name, start, end);
    }

    public void Handle(IComponentVisitor coder)
    {
      coder.Handle(this);
    }
  }
}
