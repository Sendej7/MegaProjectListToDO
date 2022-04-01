using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProjectListToDO
{
    class Numbers
    {
        public static decimal EulerNumberMenu(int numberEntered)
        {
            decimal e = MathematicalOperations.calculatePowerOf(1.0m + 1.0m / 100000.0m, 100000);
                return Decimal.Round(e, numberEntered);
        }
        public static void FibbonacciSequence(int numberEntered)
        {
            double f0 = 0;
            double f1 = 0;
            double fn = 0;
            for (int i = 0; i < numberEntered; i++)
            {
                fn = f0 + f1;
                if (i == 0 || i == 1)
                {
                    f0 = 0;
                    f1 = 1;
                }
                else
                {
                    f0 = f1;
                    f1 = fn;
                }
                Console.WriteLine(fn);
            }
        }
        public static decimal PI(int number)
        {
            int i = 0;
            decimal a0 = 1.0m;
            decimal b0 = 1.0m / MathematicalOperations.calculateSquareRoot(2.0m);
            decimal t0 = 1.0m / 4.0m;
            decimal p0 = 1.0m;
            decimal an, bn, tn, pn;
            do
            {
                i++;
                an = (a0 + b0) / 2.0m;
                bn = MathematicalOperations.calculateSquareRoot(a0 * b0);
                tn = t0 - p0 * MathematicalOperations.calculatePowerOf(a0 - an, 2);
                pn = 2.0m * p0;
                a0 = an;
                b0 = bn;
                t0 = tn;
                p0 = pn;
            } while (i < 10);
            decimal pi = (MathematicalOperations.calculatePowerOf(an + bn, 2)) / (4.0m * tn);
            return Decimal.Round(pi, number);
        }

    }
}
