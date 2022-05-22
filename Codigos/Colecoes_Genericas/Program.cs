using System;
using System.Collections.Generic;
using Colecoes_Genericas.Helper;

namespace Colecoes_Genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");  //ou { "SP", "MG", "BA" }
            string[] estadosArray = new string[2] { "SC", "MT" };

            Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            opLista.ImprimirListaString(estados);

            // Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");
            
            // Console.WriteLine("Adicionando dados no final da lista:");
            // estados.AddRange(estadosArray);
            // opLista.ImprimirListaString(estados);

            Console.WriteLine("Adicionado valor em um índice específico da lista");
            estados.Insert(1, "RJ");
            opLista.ImprimirListaString(estados);
        }
    }
}
