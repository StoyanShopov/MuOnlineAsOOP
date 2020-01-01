namespace MuOnline.Core.Commands
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Models.Items.Contracts;
    using MuOnline.Repositories.Contracts;

    public class AddItemToHeroCommand : ICommand
    {
        private const string SuccessfulMessage = "Successfuly added {0} to {1}";

        private readonly IRepository<IHero> heroRepository;
        private readonly IRepository<IItem> itemRepository;

        public AddItemToHeroCommand(IRepository<IHero> heroRepository, IRepository<IItem> itemRepository)
        {
            this.heroRepository = heroRepository;
            this.itemRepository = itemRepository;
        }

        public string Execute(string[] inputArgs)
        {
            string itemName = inputArgs[1];
            string heroUsername = inputArgs[0];

            var hero = this.heroRepository
                .Get(heroUsername);
            var item = this.itemRepository
                .Get(itemName);

            hero.Inventory.AddItem(item);

            string result = string.Format(SuccessfulMessage, this.GetType().Name, heroUsername);

            return result;
        }
    }
}
