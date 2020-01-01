namespace MuOnline.Models.Heroes
{
    public class Elf : Hero
    {
        private const int ElfStrength = 15;
        private const int ElfAgility = 30;
        private const int ElfStamina = 60;
        private const int ElfEnergy = 80;

        public Elf(string username)
            : base(username, ElfStrength, ElfAgility, ElfStamina, ElfEnergy)
        {
        }
    }
}
