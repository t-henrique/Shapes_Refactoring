using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.ObjectValue;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models
{
    public class Report : IReport
    {
        public string Print(List<IShape> shapes, ITextLanguage language)
        {
            var sb = new StringBuilder();

            if (!shapes.Any())
            {
                sb.Append(language.AppendEmptyList);
            }
            else
            {
                sb.Append(language.AppendReportTitle);

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;

                for (var i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i].Type == EShapeType.Square)
                    {
                        numeroCuadrados++;
                        areaCuadrados += shapes[i].CalculateArea();
                        perimetroCuadrados += shapes[i].CalculatePerimeter();
                    }
                    if (shapes[i].Type == EShapeType.Circle)
                    {
                        numeroCirculos++;
                        areaCirculos += shapes[i].CalculateArea();
                        perimetroCirculos += shapes[i].CalculatePerimeter();
                    }
                    if (shapes[i].Type == EShapeType.TriangleEquilateral)
                    {
                        numeroTriangulos++;
                        areaTriangulos += shapes[i].CalculateArea();
                        perimetroTriangulos += shapes[i].CalculatePerimeter();
                    }
                }

                sb.Append(GetLine(numeroCuadrados, areaCuadrados, perimetroCuadrados, EShapeType.Square, language));
                sb.Append(GetLine(numeroCirculos, areaCirculos, perimetroCirculos, EShapeType.Circle, language));
                sb.Append(GetLine(numeroTriangulos, areaTriangulos, perimetroTriangulos, EShapeType.TriangleEquilateral, language));

                // FOOTER
                sb.Append(language.AppendTotal);
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " +language.AppendShapes + " ");
                sb.Append(language.AppendPerimeter(perimetroCuadrados, perimetroTriangulos, perimetroCirculos));
                sb.Append(language.AppendArea(areaCuadrados, areaCirculos , areaTriangulos));
            }

            return sb.ToString();
        }

        private string GetLine(int amount, decimal area, decimal perimeter, EShapeType type, ITextLanguage language)
        {
            if (amount > 0)
            {
                return string.Format($"{amount} " +
                    $"{TranslateShape(type, amount, language)} | " +
                    $"{language.AppendAreaText} {area:#.##} | " +
                    $"{language.AppendPerimeterText} {perimeter:#.##} <br/>");               
            }

            return string.Empty;
        }

        private string TranslateShape(EShapeType tipo, int cantidad, ITextLanguage language)
        {
            switch (tipo)
            {
                case EShapeType.Square:
                    return cantidad == 1 ? language.AppendSquare : language.AppendSquares;
                case EShapeType.Circle:
                    return cantidad == 1 ? language.AppendCircle : language.AppendCircles;
                case EShapeType.TriangleEquilateral:
                    return cantidad == 1 ? language.AppendTriangle : language.AppendTriangles;
            }

            return string.Empty;
        }

    }
}
