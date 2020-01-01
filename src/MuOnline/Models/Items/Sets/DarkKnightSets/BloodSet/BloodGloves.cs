namespace MuOnline.Models.Items.Sets.DarkKnightSets.BloodSet
{
    public class BloodGloves : Item
    {
        private const int BloodGlovesStrengthPoints = 5;
        private const int BloodGlovesAgilityPoints = 0;
        private const int BloodGlovesEnergyPoints = 10;
        private const int BloodGlovesStaminaPoints = 0;

        public BloodGloves()
            : base(BloodGlovesStrengthPoints, BloodGlovesAgilityPoints, BloodGlovesEnergyPoints, BloodGlovesStaminaPoints)
        {
        }
    }
}
