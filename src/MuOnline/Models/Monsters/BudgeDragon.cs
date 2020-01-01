namespace MuOnline.Models.Monsters
{
    public class BudgeDragon : Monster
    {
        private const int BudgeDragonAttackPoints = 20;
        private const int BudgeDragonVitalityPoints = 50;

        public BudgeDragon()
            : base(BudgeDragonAttackPoints, BudgeDragonVitalityPoints)
        {
        }
    }
}
