using static System.Console;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main()
        {
            
        }

        static void AbstracaoPessoa()
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Bob";
            p1.Idade = 20;

            p1.Apresentar();
        }

        static void EncapsulamentoRetangulo()
        {
            //valores validos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);
            WriteLine($"Área: {r.ObterArea()}");

            //valores invalidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 0);
            WriteLine($"Área: {r2.ObterArea()}");
        }

        static void HerancaPessoa()
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Bob";
            a1.Idade = 20;
            a1.Documento = "123456";
            a1.Nota = 9;
            a1.Apresentar();

            Professor p1 = new Professor();
            p1.Nome = "José";
            p1.Idade = 60;
            p1.Documento = "123457";
            p1.Salario = 4000;
            p1.Apresentar();
        }

        static void PolimorfismoTempoExec()
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Bob";
            a1.Idade = 20;
            a1.Documento = "123456";
            a1.Nota = 9;
            a1.Apresentar();

            Professor p1 = new Professor();
            p1.Nome = "José";
            p1.Idade = 60;
            p1.Documento = "123457";
            p1.Salario = 4000;
            p1.Apresentar();
        }

        static void PolimorfismoSobrec()
        {
            Calculadora calc = new Calculadora();
            WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));
        }

        static void ClasseObject()
        {
            Computador comp = new Computador();
            WriteLine(comp.ToString());
        }
    }
}
