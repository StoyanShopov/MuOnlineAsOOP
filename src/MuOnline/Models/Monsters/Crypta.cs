namespace MuOnline.Models.Monsters
{
    public class Crypta : Monster
    {
        private const int CryptaAttackPoints = 10;
        private const int CryptaVitalityPoints = 10;

        public Crypta()
            : base(CryptaAttackPoints, CryptaVitalityPoints)
        {
        }
    }
}
