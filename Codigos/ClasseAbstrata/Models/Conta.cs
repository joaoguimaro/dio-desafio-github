using static System.Console;

namespace ClasseAbstrata.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            WriteLine("Seu saldo é de R$" + saldo);
        }
    }
}