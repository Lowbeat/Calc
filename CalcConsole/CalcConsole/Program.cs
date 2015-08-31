using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcBL;

namespace CalcConsole
{
    internal class Program
    {
        private const string ErrorMessage = "\nIncorrect value. Try again, please.";

        private static void Main(string[] args)
        {
            Console.WriteLine("Type first number");
            var x = GetNumber();
            Console.WriteLine("\nType action symbol");
            var action = GetActionSymbol();
            Console.WriteLine("\nType second number");
            var y = GetNumber();
            Console.WriteLine(Calculator.Calculate(x, y, action));
            Console.ReadKey();
        }

        private static double GetNumber()
        {
            while (true)
            {
                double number;
                if (double.TryParse(Console.ReadLine(), out number))
                    return number;
                Console.WriteLine(ErrorMessage);
            }
        }

        private static char GetActionSymbol()
        {
            while (true)
            {
                char symbol = Console.ReadKey().KeyChar;
                if (symbol == '+' || symbol == '-')
                    return symbol;
                Console.WriteLine(ErrorMessage);
            }
        }
    }
}
