using System.Collections.Generic;
using System.Linq;

namespace lab3.Models
{
    public class MyRandom
    {
        private const int a = 134279;
        private const int r0 = 1;
        private const int m = 313107;
        private IList<double> Rn;

        public MyRandom()
        {
            Rn = new List<double> { r0 };
        }

        public double GenerateNextDoube()
        {
            Rn.Add(Generate());
            return Rn.Last() / m;
        }

        private double Generate()
        {
            double temp = a * Rn.Last();
            return temp % m;
        }
    }
}
