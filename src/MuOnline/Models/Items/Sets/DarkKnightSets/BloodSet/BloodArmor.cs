namespace MuOnline.Models.Items.Sets.DarkKnightSets.BloodSet
{
    public class BloodArmor : Item
    {
        private const int BloodArmorStrengthPoints = 10;
        private const int BloodArmorAgilityPoints = 30;
        private const int BloodArmorEnergyPoints = 0;
        private const int BloodArmorStaminaPoints = 25;

        public BloodArmor()
            : base(BloodArmorStrengthPoints, BloodArmorAgilityPoints, BloodArmorEnergyPoints, BloodArmorStaminaPoints)
        {
        }
    }
}
