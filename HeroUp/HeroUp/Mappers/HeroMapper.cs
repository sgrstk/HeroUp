using HeroUp.Models.Heroes;

namespace HeroUp.Mappers
{
    public static class HeroMapper
    {
        public static Assasin MapAssasinFrom(HeroBase hero)
        {
            return new Assasin(hero.Name)
            {
                Agility = hero.Agility,
                Def = hero.Def,
                Dexterity = hero.Dexterity,
                Experience = hero.Experience,
                HeroCategory = hero.HeroCategory,
                CreatedAt = hero.CreatedAt,
                HP = hero.HP,
                Intelligence = hero.Intelligence,
                Level = hero.Level,
                MP = hero.MP,
                Name = hero.Name,
                Power = hero.Power,
                Id = hero.Id
            };
        }

        public static Support MapSupportFrom(HeroBase hero)
        {
            return new Support(hero.Name)
            {
                Agility = hero.Agility,
                Def = hero.Def,
                Dexterity = hero.Dexterity,
                Experience = hero.Experience,
                HeroCategory = hero.HeroCategory,
                CreatedAt = hero.CreatedAt,
                HP = hero.HP,
                Intelligence = hero.Intelligence,
                Level = hero.Level,
                MP = hero.MP,
                Name = hero.Name,
                Power = hero.Power,
                Id = hero.Id
            };
        }
    }
}
