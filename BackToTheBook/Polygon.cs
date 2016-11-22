using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToTheBook
{
    class Polygon
    {
        public int NumOfSides { get; set; }

        public Polygon()
        {
            NumOfSides = 0;
        }

        public Polygon(int numberOfSides)
        {
            NumOfSides = numberOfSides;
        }
    }
}
