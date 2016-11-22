using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToTheBook
{
    class Square : Polygon
    {
        public int Size { get; set; }

        public Square(int size)
        {
            Size = size;
            NumOfSides = 4;
            
        }
    }
}
