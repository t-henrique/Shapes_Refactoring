using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models
{
    //NOTE: the most correct here is to create a Resource Files to deal with multilanguage application. I put here in that way only to demonstrate how I would solve the multilanguage
    //on the application. but it's far from the correct way to do that. I would never approve a code containing it to translate applications to differnt languages.


    public class SpanishLanguage : ITextLanguage
    {
        public string AppendEmptyList => "<h1>Lista vacía de formas!</h1>";

        public string AppendReportTitle => "<h1>Reporte de Formas</h1>";

        public string AppendReportDescription => throw new NotImplementedException();

        public string AppendTotal => "TOTAL:<br/>";

        public string AppendArea(decimal areaCuadrados , decimal areaCirculos , decimal areaTriangulos)
        {
            return "Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##");
        }

        public string AppendPerimeter(decimal perimetroCuadrados, decimal perimetroTriangulos , decimal perimetroCirculos)
        {
            return "Perimetro " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ";
        }

        public string AppendShapesDescription(int numeroCuadrados, int numeroCirculos, int numeroTriangulos)
        {
            return numeroCuadrados + numeroCirculos + numeroTriangulos + " " + "formas"  + " ";
        }

        public string AppendShapeReportDescription(int areaCuadrados, int areaCirculos, int areaTriangulos)
        {
            throw new NotImplementedException();
        }

        public string AppendAmount => "cantidad";

        public string AppendShape => "forma";

        public string AppendShapes => "formas";

        public string AppendSquare => "Cuadrado";

        public string AppendSquares => "Cuadrados";

        public string AppendCircle => "Círculo";

        public string AppendCircles => "Círculos";

        public string AppendTriangle => "Triángulo";

        public string AppendTriangles => "Triángulos";

        public string AppendAreaText => "Area";

        public string AppendPerimeterText => "Perimetro";
    }
}
