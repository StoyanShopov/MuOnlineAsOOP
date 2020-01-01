namespace MuOnline.Models.Items.Weapons.Swords
{
    public class BoneSword : Item
    {
        private const int BoneSwordStrengthPoints = 25;
        private const int BoneSwordAgilityPoints = 5;
        private const int BoneSwordEnergyPoints = 10;
        private const int BoneSwordStaminaPoints = 0;

        public BoneSword()
            : base(BoneSwordStrengthPoints, BoneSwordAgilityPoints, BoneSwordEnergyPoints, BoneSwordStaminaPoints)
        {
        }
    }
}
