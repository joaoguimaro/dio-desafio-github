
using System;
using ExempColecoes.Helper;

namespace ExempColecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];
            string[] arraystring = op.ConverterParaArrayString(array);
        }

        static void matriz8()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];
            
            Console.WriteLine("Capacidade atual do array: {0}", array.Length);
            
            op.RedimensionarArray(ref array, array.Length * 2);
            Console.WriteLine("Capacidade atual do array após redimensionar: {0}", array.Length);
        }

        static void matriz7()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];

            int valorProcurado = 10;
            int indice = op.ObterIndice(array, valorProcurado);

            if (indice > -1)
            {
                Console.WriteLine("O índice do elemento {0} é {1}", valorProcurado, indice);
            }
            else
            {
                Console.WriteLine("Valor não existente no array");
            }
        }

        static void matriz6()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];

            int valorProcurado = 9;
            int valorAchado = op.ObterValor(array, valorProcurado);

            if (valorAchado > 0)
            {
                Console.WriteLine("Encontrei o valor");
            }
            else
            {
                Console.WriteLine("Não encontrei o valor");
            }
        }

        static void matriz5()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];

            int valorProcurado = 0;
            bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            if (todosMaiorQue)
            {
                Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            }
            else
            {
                Console.WriteLine("Existem valores que não são maiores que {0}", valorProcurado);
            }
        }

        static void matriz4()
        {
            //Console.Write("Array Original: \n");
            //op.ImpirmirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            //Console.WriteLine("Array ordenado: ");
            //op.ImpirmirArray(array);

            // Console.WriteLine("Array antes da cópia: ");
            // op.ImpirmirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // Console.WriteLine("Array após a cópia: ");
            // op.ImpirmirArray(arrayCopia);
        }

        static void matriz3()
        {
            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }
        }

        static void matriz2()
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;

            Console.WriteLine("Percorrendo o array pelo For");
            for(int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine(arrayInteiros[i]);
            }

            Console.WriteLine("Percorrendo o array pelo Foreach");
            foreach(int item in arrayInteiros)
            {
                Console.WriteLine(item);
            }
        }

        static void Matriz()
        {
            int[,] matriz = new int[4, 2]
                {
                    { 8, 8 },
                    { 10, 20 },
                    { 50, 100 },
                    { 90, 200 }
                };

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }
    }
}