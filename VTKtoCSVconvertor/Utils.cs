using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTKtoCSVconvertor
{
    class Utils
    {
        public static int getMinDevisor(int number)
        {
            int maxDevisor = (int) Math.Sqrt(number);
            int result = 2;
            while ((number % result != 0) && (result <= maxDevisor)){ result++; }
            if (result > maxDevisor) { result = number; }

            return result;
        }
    }
}
