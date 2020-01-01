namespace MuOnline.Models.Monsters
{
    public class BoneScorpion : Monster
    {
        private const int BoneScorpionAttackPoints = 1000;
        private const int BoneScorpionVitalityPoints = 80;

        public BoneScorpion()
            : base(BoneScorpionAttackPoints, BoneScorpionVitalityPoints)
        {
        }
    }
}
