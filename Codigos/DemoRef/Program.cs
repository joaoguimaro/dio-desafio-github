﻿//arrumar e ordenar o código (ta muito confuso)
using static System.Console;
public class Program
{
    static void Demo6()
    {
        int[] numeros = new int[] {0,2,4,6,8};
        WriteLine($"Digite o número que gostaria de encontrar: ");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);

        if(idxEncontrado >= 0)
        {
            WriteLine($"O número digitado está na posição {idxEncontrado}");
        }
        else
        {
            WriteLine("O número digitado não foi encontrado.");
        }
    }
    static void Demo5()
    {
        int[] pares = new int[]{0,2,4,6,8};

        MudarParaImpar(pares);

        WriteLine($"Os impares {string.Join(",", pares)}");
    }
    static void Demo4()
    {
        string nome = "Ricardo";

        TrocarNome2(nome, "José");

        WriteLine($"O novo nome é {nome}");
    }
    static void Demo3()
    {
        StructPessoa p1 = new StructPessoa()
        {
            Documento = "1234",
            Idade = 30,
            Nome = "Ricardo"
        };

        var p2 = p1;

        p1 = TrocarNome1(p1, "João");

        WriteLine($@"
            Nome do p1 {p1.Nome}
            Nome do p2 {p2.Nome}");
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "José");

        WriteLine($@"
        O novo nome é: {p1.Nome}
        O novo nome é: {p2.Nome}");
    }
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    static StructPessoa TrocarNome1(StructPessoa p1, string nomeNovo1)
    {
        p1.Nome = nomeNovo1;
        return p1;
    }

    static void TrocarNome2(string nome, string nomeNovo2)
    {
        nome = nomeNovo2;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i ++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i= 0; i <numeros.Length; i++)
        {
            if(numeros[i] == numero)
                return i;
        }
        return -1;
    }

    static bool EncontarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach(var item in pessoas)
        {
            if(item.Nome == pessoa.Nome)
            {
                return true;
            }
        }
        return false;
    }
    public static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Ricardo"},
            new Pessoa(){Nome = "José"},
            new Pessoa(){Nome = "Maria"},
            new Pessoa(){Nome = "Fabiana"},
            new Pessoa(){Nome = "Eduardo"}
        };

        WriteLine("Digite a pessoa que gostaria de localizar: ");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontarPessoa(pessoas, pessoa);
        if(encontrado)
        {
            WriteLine("Pessoa localizada!");
        }
        else
        {
            WriteLine("Pessoa não localizada!");
        }
    }
}
