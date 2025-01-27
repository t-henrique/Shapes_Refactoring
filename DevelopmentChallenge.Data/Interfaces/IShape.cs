using DevelopmentChallenge.Data.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IShape
    {
        EShapeType Type { get; }
        decimal CalculateArea();
        decimal CalculatePerimeter();
    }
}
