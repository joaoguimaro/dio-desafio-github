using System.Collections.Generic;

namespace Colecoes_Genericas.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Índice {i}, Valor: {lista[i]}");
            }
        }
    }
}