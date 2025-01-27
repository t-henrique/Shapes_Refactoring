using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models
{
    public abstract class ShapeBase
    {
        public decimal Side { get; set; }
        public ShapeBase(decimal side) { Side = side; }        

    }
}
