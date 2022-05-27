using static System.Console;

namespace Mentoria_GFT.Entities

{
    public class Imovel
    {
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public int Metragem { get; set; }
        public byte qtdQuartos { get; set; }
        public int valorImovel { get; set; }
        public string tipoResidencia { get; set; }
        public byte andarCasa { get; set; }

        public Imovel(string Endereco, string Cidade, int Metragem, byte qtdQuartos, int valorImovel)
        {
            this.Endereco = Endereco;
            this.Cidade = Cidade;
            this.Metragem = Metragem;
            this.qtdQuartos = qtdQuartos;
            this.valorImovel = valorImovel;
        }

        public virtual double taxaCorretor()
        {
            return valorImovel * 1.1;
        }

        public override string ToString()
        {
            return "\nEndereço: " + Endereco + "\nCidade: " + Cidade +
            "\nMetragem: " + Metragem + "\nQuantidade de quartos: " + 
            qtdQuartos + "\nValor do Imóvel: R$" + valorImovel + 
            "\nValor com a Taxa do corretor: R$" + taxaCorretor();
        }
    }
}