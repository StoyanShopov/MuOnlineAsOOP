namespace MuOnline.Models.Monsters
{
    public class Agon : Monster
    {
        private const int AgonAttackPoints = 20;
        private const int AgonVitalityPoints = 50;

        public Agon()
            : base(AgonAttackPoints, AgonVitalityPoints)
        {
        }
    }
}
