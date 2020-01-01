namespace MuOnline.Models.Items.Sets.ElfSets.BuffSet
{
    public class BuffGloves : Item
    {
        private const int BuffGlovesStrengthPoints = 13;
        private const int BuffGlovesAgilityPoints = 15;
        private const int BuffGlovesEnergyPoints = 10;
        private const int BuffGlovesStaminaPoints = 0;

        public BuffGloves()
            : base(BuffGlovesStrengthPoints, BuffGlovesAgilityPoints, BuffGlovesEnergyPoints, BuffGlovesStaminaPoints)
        {
        }
    }
}
