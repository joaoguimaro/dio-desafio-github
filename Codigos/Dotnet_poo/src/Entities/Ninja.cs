namespace Dotnet_poo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
            
        }

        public string Attack(int tipoAtaque)
        {
            if(tipoAtaque == 1)
            {
                return this.Name + " realizou um ataque com sua Katana";
            }
            else if(tipoAtaque == 2)
            {
                return this.Name + " lançou um ataque com suas shurikens";
            }
            else
                return this.Name + " acertou um golpe com suas próprias mãos";
        }
    }
}