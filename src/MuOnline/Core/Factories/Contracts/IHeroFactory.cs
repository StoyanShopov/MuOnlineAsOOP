namespace MuOnline.Core.Factories.Contracts
{
    using MuOnline.Models.Heroes.HeroContracts;

    public interface IHeroFactory
    {
        IHero Create(string heroType, string username);
    }
}
