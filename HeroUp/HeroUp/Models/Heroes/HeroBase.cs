using HeroUp.Models.Enums;
using HeroUp.Models.Generic;

namespace HeroUp.Models.Heroes
{
    public class HeroBase : Entity
    {
        public HeroBase(string name)
        {
            Name = name;
            Level = 1;
            Experience = 0;
            HP = 1000;
            MP = 700;
            Def = 100;
            Power = 40;
            Agility = 15;
            Intelligence = 15;
            Dexterity = 30;
        }

        public bool IsDead { get => HP <= 0; }
        public string Name { get; set; }
        public int Level { get; set; }
        public double Experience { get; set; }

        public double HP { get; set; }
        public double MP { get; set; }

        public double Def { get; set; }
        public double Power { get; set; }
        public double Agility { get; set; }
        public double Intelligence { get; set; }
        public double Dexterity { get; set; }
        public HeroCategory HeroCategory { get; set; }

        public virtual void GetToFullStats()
        {
            HP = 1000;
            MP = 700;
            Def = 100;
            Power = 40;
            Agility = 15;
            Intelligence = 15;
            Dexterity = 30;
        }

        public virtual void Attack(HeroBase attackedHero)
        {
            attackedHero.HP -= ((attackedHero.Def * 0.15) - Power);
        }

        public virtual void Defence(HeroBase attackerHero)
        {
            HP -= ((HP * 0.15) - attackerHero.Power);
        }

        public void GainExp(double gainedExp)
        {
            if (Experience + gainedExp >= 100)
            {
                LevelUp();
                Experience = (Experience + gainedExp) % 100;
            }
            else
            {
                Experience += gainedExp;
            }
        }

        public virtual void LevelUp()
        {
            Level++;
        }
    }
}
