namespace MuOnline.Models.Items.Weapons.Bows
{
    public class TrowBow : Item
    {
        private const int TrowBowStrengthPoints = 25;
        private const int TrowBowAgilityPoints = 5;
        private const int TrowBowEnergyPoints = 10;
        private const int TrowBowStaminaPoints = 0;

        public TrowBow()
            : base(TrowBowStrengthPoints, TrowBowAgilityPoints, TrowBowEnergyPoints, TrowBowStaminaPoints)
        {
        }
    }
}
