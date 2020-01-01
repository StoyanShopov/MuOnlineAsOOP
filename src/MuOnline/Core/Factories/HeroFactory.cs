namespace MuOnline.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Utilities;

    public class HeroFactory : IHeroFactory
    {
        public IHero Create(string heroType, string username)
        {
            var heroName = heroType.ToLower();

            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == heroName);

            Validator.ThrowAnExceptionIfObjectIsNull(type, nameof(IHero));

            var hero = Activator.CreateInstance(type, username) as IHero;

            return hero;
        }
    }
}
