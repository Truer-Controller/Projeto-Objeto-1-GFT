namespace JogoGFT.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Bola de fogo mega forte";
        }

        public string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name + " Muito efetivo quase desmontou o jorjim " + Bonus;
            }else
            {
                return this.Name + " Ta fraquinho filhote " + Bonus;
            }
            
        }
    }
}