namespace MuOnline.Core.Commands
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Items.Contracts;
    using MuOnline.Repositories.Contracts;

    public class AddItemCommand : ICommand
    {
        private const string SuccessfullyAddedMessage = "Successfully created new: {0}!";

        private readonly IRepository<IItem> itemRepository;
        private readonly IItemFactory itemFactory;

        public AddItemCommand(IRepository<IItem> itemRepository, IItemFactory itemFactory)
        {
            this.itemRepository = itemRepository;
            this.itemFactory = itemFactory;
        }

        public string Execute(string[] inputArgs)
        {
            var itemType = inputArgs[0];

            var item = this.itemFactory.Create(itemType);

            this.itemRepository.Add(item);

            string result = string.Format(SuccessfullyAddedMessage, this.GetType().Name);

            return result;
        }
    }
}
