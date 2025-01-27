﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IReport
    {
        string Print(List<IShape> shapes, ITextLanguage language);
    }
}
