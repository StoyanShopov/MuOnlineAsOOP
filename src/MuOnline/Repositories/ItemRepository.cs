namespace MuOnline.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using MuOnline.Models.Items.Contracts;
    using MuOnline.Repositories.Contracts;
    using MuOnline.Utilities;

    public class ItemRepository : IRepository<IItem>
    {
        private readonly ICollection<IItem> itemRepository;

        public ItemRepository()
        {
            this.itemRepository = new List<IItem>();
        }

        public IReadOnlyCollection<IItem> Repository
            => this.itemRepository.ToImmutableArray();

        public void Add(IItem item)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(item, nameof(item));
            this.itemRepository.Add(item);
        }

        public IItem Get(string item)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(item, nameof(item));

            var targetItem = this.itemRepository
                .FirstOrDefault(x => x.GetType().Name == item);

            return targetItem;
        }

        public bool Remove(IItem item)
        {
            Validator.ThrowAnExceptionIfObjectIsNull(item, nameof(item));
            bool isRemoved = this.itemRepository.Remove(item);

            return isRemoved;
        }
    }
}
