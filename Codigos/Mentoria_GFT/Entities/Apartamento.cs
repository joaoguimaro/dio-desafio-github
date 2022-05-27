namespace Mentoria_GFT.Entities
{
    public class Apartamento : Imovel
    {
        public Apartamento(string Endereco, string Cidade, int Metragem, byte qtdQuartos, int valorImovel, byte Andar, string numeroApartamento, string Torre) : base(Endereco, Cidade, Metragem, qtdQuartos, valorImovel)
        {
            this.Andar = Andar;
            this.numeroApartamento = numeroApartamento;
            this.Torre = Torre;
        }

        public byte Andar { get; set; }
        public string numeroApartamento { get; set; }
        public string Torre { get; set; }

        public override double taxaCorretor()
        {
            return valorImovel * 1.2;
        }

        public override string ToString()
        {
            return "\nEndereço: " + Endereco + "\nCidade: " + Cidade +
            "\nMetragem: " + Metragem + "\nQuantidade de quartos: " + 
            qtdQuartos + "\nAndar" + Andar + "\nNúmero do apartamento: " + 
            numeroApartamento + "\nTorre: " + Torre + "\nValor do Imóvel: R$" + valorImovel + 
            "\nValor do apartamento com a Taxa do corretor: R$" + taxaCorretor();
        }
    }
}