namespace MuOnline.Models.Items.Sets.DarkKnightSets.BloodSet
{
    public class BloodHelmet : Item
    {
        private const int BloodHelmetStrengthPoints = 50;
        private const int BloodHelmetAgilityPoints = 10;
        private const int BloodHelmetEnergyPoints = 0;
        private const int BloodHelmetStaminaPoints = 0;

        public BloodHelmet()
            : base(BloodHelmetStrengthPoints, BloodHelmetAgilityPoints, BloodHelmetEnergyPoints, BloodHelmetStaminaPoints)
        {
        }
    }
}
