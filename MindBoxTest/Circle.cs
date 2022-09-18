using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Circle
    {
        public double Radius { get; set; }
        double Area { get; set; }

        public double Square()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
    }
}
