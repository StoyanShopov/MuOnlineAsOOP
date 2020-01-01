namespace MuOnline.Models.Items.Sets.DarkKnightSets.BloodSet
{
    public class BloodPants : Item
    {
        private const int BloodPantStrengthPoints = 0;
        private const int BloodPantAgilityPoints = 5;
        private const int BloodPantEnergyPoints = 10;
        private const int BloodPantStaminaPoints = 50;

        public BloodPants()
            : base(BloodPantStrengthPoints, BloodPantAgilityPoints, BloodPantEnergyPoints, BloodPantStaminaPoints)
        {
        }
    }
}
