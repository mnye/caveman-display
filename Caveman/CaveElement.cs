using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Some classes to store the Cave Elements
// Uses inheritence for each element type

namespace Caveman
{
    enum ElementType
    {
        Line,
        Text
    }

    internal abstract class CaveElement
    {
        public ElementType elementType;
        public Point startLocation;
        
        public CaveElement(ElementType my_elementType, Point my_startLocation) 
        {
            elementType = my_elementType;
            startLocation = my_startLocation;
        }

        public abstract String GenerateCpp();
    }

    class LineElement : CaveElement
    {
        public Point endLocation;
        public LineElement(Point my_startLocation, Point my_endLocation) 
            : base(ElementType.Line, my_startLocation)
        { 
            endLocation = my_endLocation;
        }

        public override string GenerateCpp() 
        {
            return "display.drawLine(BLACK);";
        }
    }
    class TextElement : CaveElement
    {
        public TextElement(Point my_startLocation)
            : base(ElementType.Text, my_startLocation)
        {

        }

        public override string GenerateCpp()
        {
            return "hello, I am a text object :)";
        }
    }
}
