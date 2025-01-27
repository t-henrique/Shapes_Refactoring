using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models
{
    public class EnglishLanguage : ITextLanguage
    {
        public string AppendEmptyList => "<h1>Empty list of shapes!</h1>";

        public string AppendReportTitle => "<h1>Shapes report</h1>";

        public string AppendReportDescription => throw new NotImplementedException();

        public string AppendTotal => "TOTAL:<br/>";

        public string AppendAmount => "Amount";

        public string AppendShape => "Shape";

        public string AppendShapes => "shapes";

        public string AppendSquare => "Square";

        public string AppendSquares => "Squares";

        public string AppendCircle => "Circle";

        public string AppendCircles => "Circles";

        public string AppendTriangle => "Triangle";

        public string AppendTriangles => "Triangles";

        public string AppendAreaText => "Area";

        public string AppendPerimeterText => "Perimeter";

        public string AppendArea(decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos)
        { 
            return "Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##");
        }

        public string AppendPerimeter(decimal perimetroCuadrados, decimal perimetroTriangulos, decimal perimetroCirculos)
        {
            return "Perimeter " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ";
        }

        public string AppendShapeReportDescription(int areaCuadrados, int areaCirculos, int areaTriangulos)
        {
            throw new NotImplementedException();
        }

        public string AppendShapesDescription(int numeroCuadrados, int numeroCirculos, int numeroTriangulos)
        {
            return numeroCuadrados + numeroCirculos + numeroTriangulos + " " + "shapes" + " ";
        }
    }
}
