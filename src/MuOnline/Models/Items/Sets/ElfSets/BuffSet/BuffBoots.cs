namespace MuOnline.Models.Items.Sets.ElfSets.BuffSet
{
    public class BuffBoots : Item
    {
        private const int BuffBootsStrengthPoints = 3;
        private const int BuffBootsAgilityPoints = 5;
        private const int BuffBootsEnergyPoints = 0;
        private const int BuffBootsStaminaPoints = 10;

        public BuffBoots()
            : base(BuffBootsStrengthPoints, BuffBootsAgilityPoints, BuffBootsEnergyPoints, BuffBootsStaminaPoints)
        {
        }
    }
}
