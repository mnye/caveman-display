using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caveman.Lib
{
  public enum VarType { Static, Bool, Text }

  public interface IScreenComponent
  {
    VarType VarType { get; }

    string VarName { get; }

    void Handle(IComponentVisitor visitor);
  }

  public interface IComponentVisitor
  {
    void Handle(ScreenLine line);
    void Handle(ScreenText text);
  }
}
