using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double MEDIA = 0;
            Console.WriteLine("Digite a nota A: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota B: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota C: ");
            C = double.Parse(Console.ReadLine());

            MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;
//TODO: Complete os espaços em branco com uma possível solução para o desafio
            Console.WriteLine("MEDIA = " + MEDIA.ToString("N1"));
            Console.ReadKey();
        }
    }
}
