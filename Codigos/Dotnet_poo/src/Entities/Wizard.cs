namespace Dotnet_poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
            
        }

        public string Attack(int Bonus)
        {
            if(Bonus >= 6)
            {
                return this.Name + " lançou Magia super efetiva com bonus de " + Bonus;
            }
            else if(Bonus <= 5)
            {
                return this.Name + " lançou Magia com força franca com bonus de " + Bonus;
            }
            else
                return this.Name + " lançou Magia";
                
        }
    }
}