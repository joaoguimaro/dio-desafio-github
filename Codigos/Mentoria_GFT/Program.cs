using System;
using Mentoria_GFT.Entities;
using static System.Console;

namespace Mentoria_GFT
{
    class Program
    {
        static void Main()
        {
            // string tipoMoradia = "Casa";
            // int metragem = 96;
            // string endereco = "Av GFT, 123";

            Imovel moradia = new Imovel("Av DIO, 123", "São Paulo", 96, 3, 600000);
            WriteLine(moradia);

            WriteLine("------------------------------");

            Apartamento moradia2 = new Apartamento("Av GFT, 2999", "Salvador", 86, 2, 80000, 9, "901", "B");
            WriteLine(moradia2);
        }
    }
}