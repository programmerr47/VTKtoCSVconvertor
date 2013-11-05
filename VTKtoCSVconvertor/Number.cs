using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTKtoCSVconvertor
{
    class Number
    {
        public const int X = 1;
        public const int Y = 2;
        public const int Z = 3;

        public int number;
        public int x;
        public int y;
        public int z;

        public int getCoord(int index)
        {
            if (index == X)
                return x;
            else if (index == Y)
                return y;
            else
                return z;
        }

        public void generateNumber(int max)
        {
            number = x * max * max + y * max + z;
        }
    }
}
