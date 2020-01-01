namespace MuOnline.Models.Items.Sets.ElfSets.BuffSet
{
    public class BuffArmor : Item
    {
        private const int BuffArmorStrengthPoints = 10;
        private const int BuffArmorAgilityPoints = 50;
        private const int BuffArmorEnergyPoints = 10;
        private const int BuffArmorStaminaPoints = 90;

        public BuffArmor()
            : base(BuffArmorStrengthPoints, BuffArmorAgilityPoints, BuffArmorEnergyPoints, BuffArmorStaminaPoints)
        {
        }
    }
}
