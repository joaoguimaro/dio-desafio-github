using static System.Console;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        

        public override void Apresentar()
        {
            WriteLine($"Diretor");
        }
    }
}