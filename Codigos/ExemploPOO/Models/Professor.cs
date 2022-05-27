using static System.Console;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public override void Apresentar()
        {
            WriteLine($"Olá, meu nome é {Nome} e sou um professor, e ganho R$ {Salario}");
        }
    }
}