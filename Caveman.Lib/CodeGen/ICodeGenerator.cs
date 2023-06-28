using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caveman.Lib
{
  public interface ICodeGenerator
  {
    /// <summary>
    /// Input = components that need to go on the screen
    /// Output = TODO ?files ?lines of code ???
    /// </summary>
    string[] GenerateCode(IScreenComponent[] components);
  }

  public class AdafruitGFXGenerator : ICodeGenerator, IComponentVisitor
  {
    private List<string> _Code = new List<string>();

    public string[] GenerateCode(IScreenComponent[] components)
    {
      _Code.Clear();
      foreach(var c in components)
      {
        // Visitor pattern...
        c.Handle(this);
      }

      throw new NotImplementedException();
    }

    public void Handle(ScreenLine line)
    {
      if (line.VarType == VarType.Static)
        _Code.Add($"static line");
      else
        _Code.Add($"variable line bool {line.VarType} = true;");

      throw new NotImplementedException();
    }

    public void Handle(ScreenText text)
    {
      throw new NotImplementedException();
    }
  }
}
