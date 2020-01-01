namespace MuOnline.Core.Commands
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Repositories.Contracts;

    public class AttackMonsterCommand : ICommand
    {
        private const string AttackMonsterOutputMessage = "{0} is dead!";

        private readonly IRepository<IHero> heroRepository;
        private readonly IRepository<IMonster> monsterRepository;

        public AttackMonsterCommand(IRepository<IHero> heroRepository, IRepository<IMonster> monsterRepository)
        {
            this.heroRepository = heroRepository;
            this.monsterRepository = monsterRepository;
        }

        public string Execute(string[] inputArgs)
        {
            string heroUsername = inputArgs[0];
            string monsterName = inputArgs[1];

            var hero = this.heroRepository
                .Get(heroUsername);

            var monster = this.monsterRepository
                .Get(monsterName);

            var heroAttackPoints = hero.TotalAttackPoints;
            var monsterAttackPoints = monster.AttackPoints;

            while (hero.IsAlive && monster.IsAlive)
            {
                hero.TakeDamage(monsterAttackPoints);

                if (!hero.IsAlive)
                {
                    break;
                }

                var experience = monster.TakeDamage(heroAttackPoints);

                (hero as IProgress)?.AddExperience(experience);
            }

            string deadName = !hero.IsAlive ? monsterName : heroUsername;

            string result = string.Format(AttackMonsterOutputMessage, deadName);

            return result;
        }
    }
}
