namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType, int HP)
        {
           this.Name = Name; 
           this.Level = Level;
           this.HeroType = HeroType; 
           this.HP = HP;
        }
    }
}