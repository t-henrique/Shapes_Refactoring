using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models
{
    public class Circle : ShapeBase, IShape
    {
        public Circle(decimal side) : base(side)
        {
        }

        public EShapeType Type => EShapeType.Circle;

        public decimal CalculateArea()
        {
            return (decimal)Math.PI * (Side / 2) * (Side / 2);
        }

        public decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * Side;
        }
    }
}
