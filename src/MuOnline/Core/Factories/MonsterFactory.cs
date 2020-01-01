namespace MuOnline.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Utilities;

    public class MonsterFactory : IMonsterFactory
    {
        public IMonster Create(string monsterTypeName)
        {
            string monsterTypeToCheck = monsterTypeName.ToLower();

            var monsterType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == monsterTypeToCheck);

            Validator.ThrowAnExceptionIfObjectIsNull(monsterType, nameof(IMonster));

            var monster = Activator.CreateInstance(monsterType) as IMonster;

            return monster;
        }
    }
}
