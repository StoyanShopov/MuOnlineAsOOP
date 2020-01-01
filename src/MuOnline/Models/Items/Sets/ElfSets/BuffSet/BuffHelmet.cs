namespace MuOnline.Models.Items.Sets.ElfSets.BuffSet
{
    public class BuffHelmet : Item
    {
        private const int BuffHelmetStrengthPoints = 3;
        private const int BuffHelmetAgilityPoints = 5;
        private const int BuffHelmetEnergyPoints = 0;
        private const int BuffHelmetStaminaPoints = 0;

        public BuffHelmet()
            : base(BuffHelmetStrengthPoints, BuffHelmetAgilityPoints, BuffHelmetEnergyPoints, BuffHelmetStaminaPoints)
        {
        }
    }
}
