namespace dotnet___poo.src.Entities
{
    public class Wizard : Hero  
    {
        public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Lançou Magia";
    }

    public string Attack(int Bonus){

        if (Bonus > 6){
            return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
        }else{
            return this.Name + " Lançou uma Magia com força fraca com bonus de " + Bonus;
        }

        }
    }
}