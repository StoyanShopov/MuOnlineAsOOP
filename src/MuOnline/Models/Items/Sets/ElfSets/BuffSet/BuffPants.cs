namespace MuOnline.Models.Items.Sets.ElfSets.BuffSet
{
    public class BuffPants : Item
    {
        private const int BuffPantsStrengthPoints = 13;
        private const int BuffPantsAgilityPoints = 15;
        private const int BuffPantsEnergyPoints = 20;
        private const int BuffPantsStaminaPoints = 0;

        public BuffPants()
            : base(BuffPantsStrengthPoints, BuffPantsAgilityPoints, BuffPantsEnergyPoints, BuffPantsStaminaPoints)
        {
        }
    }
}
