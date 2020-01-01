namespace MuOnline.Core.Factories.Contracts
{
    using MuOnline.Models.Items.Contracts;

    public interface IItemFactory
    {
        IItem Create(string itemType);
    }
}
