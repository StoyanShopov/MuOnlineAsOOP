namespace MuOnline.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Repositories.Contracts;
    using MuOnline.Utilities;

    public class HeroRepository : IRepository<IHero>
    {
        private readonly ICollection<IHero> heroes;

        public HeroRepository()
        {
            this.heroes = new List<IHero>();
        }

        public IReadOnlyCollection<IHero> Repository
            => this.heroes.ToImmutableArray();

        public void Add(IHero hero)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(hero, nameof(hero));
            this.heroes.Add(hero);
        }

        public IHero Get(string hero)
        {
            var targetHero = this.heroes.
                FirstOrDefault(h => (h as IIdentifiable)?.Username == hero);

            Validator.ThrowAnExceptionIfObjectIsNull(targetHero, nameof(targetHero));

            return targetHero;
        }

        public bool Remove(IHero hero)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(hero, nameof(hero));

            bool isRemoved = this.heroes.Remove(hero);

            return isRemoved;
        }
    }
}
