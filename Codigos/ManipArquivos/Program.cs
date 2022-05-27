using ManipArquivos.Helper;
using static System.Console;

namespace ManipArquivos
{
    class Program
    {
        static void Main()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();

            helper.DeletarArquivo(caminhoArquivo);
        }

        static void ListarDiretorios()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";

            FileHelper helper = new FileHelper();

            //lista todos os diretorios
            helper.ListarDiretorios(caminho);
        }

        static void ListarArquivosDiretorios()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";

            FileHelper helper = new FileHelper();

            //lista todos os diretorios e arquivos presentes
            helper.ListarArquivosDiretorios(caminho);
        }

        static void CriarDiretorio()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3", "SubPasta Teste 3");

            FileHelper helper = new FileHelper();

            WriteLine("Criando diretório: " + caminhoPathCombine);
            helper.CriarDiretorio(caminhoPathCombine);
        }

        static void ApagarDiretorio()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3");

            FileHelper helper = new FileHelper();

            helper.ApagarDiretorio(caminhoPathCombine, true);
        }

        static void CriarArquivoTexto()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");

            FileHelper helper = new FileHelper();

            helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");
        }

        static void CriarArquivoTextoStream()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };

            FileHelper helper = new FileHelper();

            helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
        }

        static void AdicionarTextoStream()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();

            helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
        }

        static void LerArquivoStream()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();

            helper.LerArquivoStream(caminhoArquivo);
        }

        static void MoverArquivo()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();

            helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, true);
        }

        static void CopiarArquivo()
        {
            var caminho = "C:\\CursoDIO\\Repositorios\\DioDesafioGithub\\Codigos\\Testes";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();

            helper.CopiarArquivo(caminhoArquivo, novoCaminhoArquivo, false);
        }
    }
}