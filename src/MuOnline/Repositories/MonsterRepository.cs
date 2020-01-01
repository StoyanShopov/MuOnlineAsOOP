namespace MuOnline.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Repositories.Contracts;
    using MuOnline.Utilities;

    public class MonsterRepository : IRepository<IMonster>
    {
        private readonly ICollection<IMonster> monsters;

        public MonsterRepository()
        {
            this.monsters = new List<IMonster>();
        }

        public IReadOnlyCollection<IMonster> Repository
            => this.monsters.ToImmutableArray();

        public void Add(IMonster monster)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(monster, nameof(monster));
            this.monsters.Add(monster);
        }

        public bool Remove(IMonster monster)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(monster, nameof(monster));

            bool isRemoved = this.monsters.Remove(monster);

            return isRemoved;
        }

        public IMonster Get(string monster)
        {
            var targetMonster = this.monsters
                .FirstOrDefault(m => m.GetType().Name == monster);

            Validator.ThrowAnExceptionIfObjectIsNull(targetMonster, nameof(targetMonster));

            return targetMonster;
        }
    }
}
