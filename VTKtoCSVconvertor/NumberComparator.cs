using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTKtoCSVconvertor
{
    class NumberComparator
    {
        public static int compareNumber(Number x, Number y)
        {
            if (x.number > y.number)
            {
                return 1;
            }
            else if (x.number < y.number)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
