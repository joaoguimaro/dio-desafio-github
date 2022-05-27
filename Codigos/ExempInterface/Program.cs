using static System.Console;
using ExempInterface.Models;
using ExempInterface.Interfaces;

namespace ExempInterface
{
    class Program
    {
        static void Main()
        {
            ICalculadora calc = new Calculadora();
            WriteLine(calc.Somar(10, 20));
        }
    }
}
