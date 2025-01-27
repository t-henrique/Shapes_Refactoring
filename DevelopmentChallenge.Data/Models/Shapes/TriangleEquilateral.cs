using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models
{
    public class TriangleEquilateral : ShapeBase, IShape
    {
        public TriangleEquilateral(decimal side) : base(side)
        {
        }

        public  EShapeType Type => EShapeType.TriangleEquilateral;

        public decimal CalculateArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Side * Side;
        }

        public decimal CalculatePerimeter()
        {
            return Side * 3;
        }
    }
}
