namespace MuOnline.Core.Commands
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Repositories.Contracts;

    public class AddMonsterCommand : ICommand
    {
        private const string AddedMonsterMessage = "Successfully crated monster {0}";

        private readonly IRepository<IMonster> repository;
        private readonly IMonsterFactory factory;

        public AddMonsterCommand(IRepository<IMonster> repository, IMonsterFactory factory)
        {
            this.repository = repository;
            this.factory = factory;
        }

        public string Execute(string[] inputArgs)
        {
            string monsterType = inputArgs[0];
            var monster = this.factory.Create(monsterType);

            this.repository.Add(monster);

            string result = string.Format(AddedMonsterMessage, this.GetType().Name);

            return result;
        }
    }
}
