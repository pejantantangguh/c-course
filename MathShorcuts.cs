using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp
{
    public class MathShorcuts
    {
        public static double Add(double x, double y)
        {

            double output = x + y;
            return output;
        }

        public static void AddAll(double[] values)
        {
            double result = 0;
            foreach (double value in values) 
            {
                result += value;
            }
            Console.WriteLine($"The total is {result}");
        }
    }
}
