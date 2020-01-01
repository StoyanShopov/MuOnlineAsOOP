namespace MuOnline.Core.Factories.Contracts
{
    using MuOnline.Models.Monsters.Contracts;

    public interface IMonsterFactory
    {
        IMonster Create(string monsterTypeName);
    }
}
