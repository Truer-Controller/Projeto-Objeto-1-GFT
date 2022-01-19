namespace JogoGFT.src.Entities
{
    public class DarkWizard : Hero
    {
        public DarkWizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Buraco Negro";
        }

        public string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name + " Muito efetivo quase desmontou o Apocalipitico com o Bonus de " + Bonus;
            }else
            {
                return this.Name + " Ta fraquinho filhote come mais feijão " + Bonus;
            }
        }
    }
}