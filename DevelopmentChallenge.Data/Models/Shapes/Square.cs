using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models
{
    public class Square : ShapeBase, IShape
    {
        public Square(decimal side) : base(side)
        {
        }

        public EShapeType Type => EShapeType.Square;


        public decimal CalculatePerimeter()
        {
            return Side * 4;
        }

        public decimal CalculateArea()
        {
            return Side * Side;
        }
    }
}
