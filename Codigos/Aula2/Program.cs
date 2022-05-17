using static System.Console;

class Aula2
{
    static void Demo1()
    {
        int a = 5;
        Adicionar20(ref a);
        WriteLine($"O valor de a é {a}");
    }
    static void Adicionar20(ref int a)
    {
        a += 20;
    }

    static void Demo2()
    {
        var nomes = new string[]{"José", "Maria", "Ricardo", "Alice", "Pedro"};

        WriteLine($@"A lista de nomes atual é: 
            {string.Join(", \n", nomes)}");

        WriteLine("Digite o nome a ser substituído: ");
        var nome = ReadLine();
        WriteLine("Digite o nome novo: ");
        var nomeNovo = ReadLine();

        AlterarNome(nomes, nome, nomeNovo);

        WriteLine($@"A lista de nomes Alterada é: 
            {string.Join(", \n", nomes)}");
    }

    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {
        for(int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }
    }

    static void Demo3()
    {
        var nomes = new string[]{"José", "Maria", "Ricardo", "Alice", "Pedro"};

        WriteLine($@"A lista de nomes atual é: 
            {string.Join(", \n", nomes)}");

        WriteLine("Digite o nome a ser substituído: ");
        var nome = ReadLine();
        WriteLine("Digite o nome novo: ");
        var nomeNovo = ReadLine();

        var indice = LocalizarNome(nomes, nome);
        if(indice >= 0)
        {
            nomes[indice] = nomeNovo;

            WriteLine($@"A lista de nomes Alterada é: 
            {string.Join(", \n", nomes)}");
        }
        else
        {
            WriteLine("Nome não encontrado!");
        }
    }

    static int LocalizarNome(string[] nomes, string nome)
    {
        for(int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
                return i;
        }
        return -1;
    }

    static void Main()
    {
        
    }
}
