namespace ClasseAbstrata.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            //base significa que o saldo esta vindo da classe Conta
            base.saldo = valor;
        }
    }
}