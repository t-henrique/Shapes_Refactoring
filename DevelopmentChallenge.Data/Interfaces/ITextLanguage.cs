using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DevelopmentChallenge.Data.Interfaces
{

    //NOTE: the most correct here is to create a Resource Files to deal with multilanguage application. I put here in that way only to demonstrate how I would solve the multilanguage
    //on the application. but it's far from the correct way to do that. I would never approve a code containing it to translate applications to differnt languages.
    public interface ITextLanguage
    {
        string AppendEmptyList { get; }
        string AppendReportTitle { get; }

        string AppendReportDescription { get; }
        string AppendTotal { get; }
        string AppendAmount { get; }
        string AppendShape { get; }
        string AppendShapes { get; }
        string AppendSquare { get; }
        string AppendSquares { get; }
        string AppendCircle { get; }
        string AppendCircles { get; }
        string AppendTriangle { get; }
        string AppendTriangles { get; }
        string AppendAreaText { get; }
        string AppendPerimeterText { get; }

        string AppendShapesDescription(int numeroCuadrados, int numeroCirculos, int numeroTriangulos);

        string AppendPerimeter(decimal perimetroCuadrados, decimal perimetroTriangulos, decimal perimetroCirculos);

        string AppendArea(decimal areaCuadrados, decimal areaCirculos, decimal areaTriangulos);
        string AppendShapeReportDescription(int areaCuadrados, int areaCirculos, int areaTriangulos);

    }
}
