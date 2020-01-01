﻿namespace MuOnline.Models.Inventories.Contracts
{
    using System.Collections.Generic;
    using MuOnline.Models.Items.Contracts;

    public interface IInventory
    {
        IReadOnlyCollection<IItem> Items { get; }

        void AddItem(IItem item);

        bool RemoveItem(IItem item);

        IItem GetItem(string item);
    }
}
