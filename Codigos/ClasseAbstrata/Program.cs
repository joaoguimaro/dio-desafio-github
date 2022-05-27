using static System.Console;
using ClasseAbstrata.Models;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main()
        {
            
        }

        static void Conta()
        {
            Corrente corr = new Corrente();
            corr.Creditar(100);
            corr.ExibirSaldo();
        }
    }
}