using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Triangle
    {
        public double Storona1 { get; set; }
        public double Storona2 { get; set; }
        public double Storona3 { get; set; }
        public double PoluPerimetr { get; set; }
        public double TrianSq { get; set; }
        public double Plosh { get; set; }
       
        public double TrianSquare()
        {
            PoluPerimetr = (Storona1 + Storona2 + Storona3) / 2;
            TrianSq = Math.Sqrt(PoluPerimetr*(PoluPerimetr - Storona1) * (PoluPerimetr - Storona2) * (PoluPerimetr - Storona3));
            return TrianSq;
        }
        public double Ploshad()
        {
            Plosh = 0.5 * Storona1 * Storona2;
            return Plosh;
        }
    }
}
