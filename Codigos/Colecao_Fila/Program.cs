using System;
using System.Collections.Generic;

namespace Colecao_Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Leonardo");
            fila.Enqueue("Eduardo");
            fila.Enqueue("André");

            Console.WriteLine($"Pessoas na fila: {fila.Count}");

            while (fila.Count > 0)
            {
                Console.WriteLine($"Vez de: {fila.Peek()}");
                Console.WriteLine($"{fila.Dequeue()} atendido");
            }

            Console.WriteLine($"Pessoas na fila: {fila.Count}");
        }
    }
}
