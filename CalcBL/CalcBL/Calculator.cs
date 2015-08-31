using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBL
{
    public static class Calculator
    {
         public static double Calculate(double x, double y, char action)
         {
            Console.WriteLine("Hui");
             if (action == '+')
                 return x + y;
             else
                 return x - y;
         }
    }
}
