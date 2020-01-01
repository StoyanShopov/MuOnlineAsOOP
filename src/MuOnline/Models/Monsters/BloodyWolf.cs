namespace MuOnline.Models.Monsters
{
    public class BloodyWolf : Monster
    {
        private const int BloodyWolfAttackPoints = 80;
        private const int BloodyWolfVitalityPoints = 50;

        public BloodyWolf()
            : base(BloodyWolfAttackPoints, BloodyWolfVitalityPoints)
        {
        }
    }
}
