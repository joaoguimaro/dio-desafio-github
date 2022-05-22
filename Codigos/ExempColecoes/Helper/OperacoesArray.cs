using System;
namespace ExempColecoes.Helper
{
    public class OperacoesArray
    {
        //ordenação de vetor por meio do método bubble sort
        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for (int j = 0; j < array.Length; j++)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {
                    if (array[k] > array[k + 1])
                    {
                        temp = array[k + 1];
                        array[k + 1] = array[k];
                        array[k] = temp;
                    }
                }
            }
        }

        //método para imprimir o vetor
        public void ImpirmirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            Console.WriteLine(linha);
        }

        //método para ordenar vetor usando função do C#
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        //copiar dados de um vetor para outro
        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        //verificar se existe tal elemento no vetor
        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        //verificar se todos os numeros do vetor são maiores que tal número inserido
        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        //encontrar valor específico no vetor
        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, element => element == valor);
        }

        //obter indice de tal valor dentro do vetor
        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        //redimensionar o tamanho do vetor
        public void RedimensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        //conversão do vetor de int para um vetor de string
        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }
    }
}