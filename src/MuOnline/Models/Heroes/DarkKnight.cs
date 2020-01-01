namespace MuOnline.Models.Heroes
{
    public class DarkKnight : Hero
    {
        private const int DarkKnightStrength = 60;
        private const int DarkKnightAgility = 40;
        private const int DarkKnightStamina = 30;
        private const int DarkKnightEnergy = 20;

        public DarkKnight(string username)
            : base(username, DarkKnightStrength, DarkKnightAgility, DarkKnightStamina, DarkKnightEnergy)
        {
        }
    }
}
