namespace MuOnline.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Items.Contracts;
    using MuOnline.Utilities;

    public class ItemFactory : IItemFactory
    {
        public IItem Create(string itemType)
        {
            var itemName = itemType.ToLower();

            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == itemName);

            Validator.ThrowAnExceptionIfObjectIsNull(type, nameof(IItem));

            var item = Activator.CreateInstance(type) as IItem;

            return item;
        }
    }
}
