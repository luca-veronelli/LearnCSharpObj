using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpObj
{
    static class LengthConverter
    {
        public static double FeetToMeters(double ft) => ft / 3.28084;
        public static double MetersToFeet(double m) => m / 3.28084;
    }
}
