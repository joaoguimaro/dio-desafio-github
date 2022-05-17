namespace Dotnet_poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
            
        }

        public string Attack()
        {
            return this.Name + " atacou com a sua espada";
        }
    }
}