using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProjectListToDO
{
    class MathematicalOperations
    {
        public static decimal calculatePowerOf(decimal number, int power)
        {
            decimal result = 1.0m;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
        public static decimal calculateSquareRoot(decimal number)
        {
            decimal x = number;
            decimal y = 1.0m;
            decimal e = 0.000000000000000000000001m;
            do
            {
                x = (x + y) / 2;
                y = number / x;
            } while (x - y > e);
            return x;
        }
    }
}
