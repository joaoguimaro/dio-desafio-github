using System;
using System.Collections.Generic;

namespace Colecao_Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            string valorProcurado = "BA";

            if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            {
                Console.WriteLine(estadoEncontrado);
            }
            else
            {
                Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            }
        }

        static void LINQ()
        {
            int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

            //encontrando valores minimo, maximo e medio dentro do array
            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine($"Máximo: {maximo}");
            Console.WriteLine($"Médio: {medio}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Array Original: {string.Join(", ", arrayNumeros)}");
            Console.WriteLine($"Array Distinto: {string.Join(", ", arrayUnico)}");


            //definir numeros pares do array
            var numerosParesQuery = 
                    from num in arrayNumeros
                    where num % 2 == 0
                    orderby num 
                    select num;

            var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
            Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));
        }

        static void Colecao_Dicionario()
        {
            
            
            
            // Console.WriteLine($"Removendo o valor: {valorProcurado}");
            // estados.Remove(valorProcurado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }
            
            
            // Console.WriteLine("Valor original: ");
            // Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "BA - teste atualização";

            // Console.WriteLine("Valor atualizado: ");
            // Console.WriteLine(estados[valorProcurado]);
        }

        static void Colecao_Pilha()
        {
            Stack<string> pilhaLivros = new Stack<string>();

            pilhaLivros.Push(".NET");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Código Limpo");

            Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            while (pilhaLivros.Count > 0)
            {
                Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
                Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            }

            Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
        }

        static void Colecao_Fila()
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
