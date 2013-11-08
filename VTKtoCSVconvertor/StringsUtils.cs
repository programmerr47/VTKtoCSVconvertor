using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VTKtoCSVconvertor
{
    class StringsUtils
    {
        public static bool numberString(string sourceString)
        {
            bool result = true;
            string[] numStrArray = sourceString.Split(' ');

            for (int i = 0; i < numStrArray.Length; i++)
            {
                result = result && Regex.IsMatch(numStrArray[i], "-?\\d+(\\.\\d+)?");
            }

            return result;
        }

        public static string generateCSVString(Number number, string Bx, string By, string Bz)
        {
            return number.x + ";" + number.y + ";" + number.z + ";" + Bx + ";" + By + ";" + Bz;
        }
    }
}
