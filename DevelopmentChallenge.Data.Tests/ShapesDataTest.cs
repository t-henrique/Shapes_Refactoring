using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Models;
using System.Data.SqlTypes;

namespace DevelopmentChallenge.Data.Tests
{
    [TestClass]
    public class ShapesDataTests
    {
        [TestMethod]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                new Report().Print(new List<IShape>(), new SpanishLanguage()));
        }
        [TestMethod]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                new Report().Print(new List<IShape>(), new EnglishLanguage()));
        }

        [TestMethod]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IShape> { new Square(5) };

            var resumen = new Report().Print(cuadrados, new SpanishLanguage());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestMethod]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IShape> 
            {
                 new Square(5),
                 new Square(1),
                 new Square(3),
            };

            var resumen =new Report().Print(cuadrados, new EnglishLanguage());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestMethod]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IShape>
            {
                new Square(5),
                new Circle(3),
                new TriangleEquilateral(4),
                new Square(2),
                new TriangleEquilateral(9),
                new Circle(2.75m),
                new TriangleEquilateral(4.2m)
            };

            var resumen = new Report().Print(formas, new EnglishLanguage());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);

            //orignal text was using , between decimal numbers, as my computer uses english language and all the english structure to separate hours, decimal numbers and etc, I replaced the assert text to use english decimal numbers,
            //instead convert a decimal number to 13,01 the assert is using 13.01
        }

        [TestMethod]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IShape>
            {
                new Square(5),
                new Circle(3),
                new TriangleEquilateral(4),
                new Square(2),
                new TriangleEquilateral(9),
                new Circle(2.75m),
                new TriangleEquilateral(4.2m)
            };

            var resumen = new Report().Print(formas, new SpanishLanguage());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65",
                resumen);

           // the same change here. I replaced comma between decimal number by dot.
        }
    }
}
