using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Chetyrehugolnik
    {
        public double A { get; set; }
        public double B { get; set; }
        public int H { get; set; }

        public double kvadrat()
        {
            double plosh = A * B;
            return plosh;
        }
        public double trapetzia()
            {
            double trapes = 0.5 * (A + B) * H;
            return trapes;
        }
        public double paralelogram()
        {
            double paral = A * H;
            return paral;
        }

    }
}
