namespace MuOnline.Models.Inventories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MuOnline.Models.Inventories.Contracts;
    using MuOnline.Models.Items.Contracts;
    using MuOnline.Utilities;

    public class Inventory : IInventory
    {
        private readonly List<IItem> items;

        public Inventory()
        {
            this.items = new List<IItem>();
        }

        public IReadOnlyCollection<IItem> Items =>
            this.items.AsReadOnly();

        public void AddItem(IItem item)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(item, nameof(item));

            this.items.Add(item);
        }

        public bool RemoveItem(IItem item)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(item, nameof(item));

            bool isRemove = this.items.Remove(item);

            return isRemove;
        }

        public IItem GetItem(string item)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(item, nameof(item));

            var targetItem = this.items
                .FirstOrDefault(i => i.GetType().Name == item);

            return targetItem;
        }
    }
}
