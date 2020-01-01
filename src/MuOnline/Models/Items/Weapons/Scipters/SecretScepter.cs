namespace MuOnline.Models.Items.Weapons.Scipters
{
    public class SecretScepter : Item
    {
        private const int SecretScepterStrengthPoints = 10;
        private const int SecretScepterAgilityPoints = 10;
        private const int SecretScepterEnergyPoints = 50;
        private const int SecretScepterStaminaPoints = 20;

        public SecretScepter()
            : base(SecretScepterStrengthPoints, SecretScepterAgilityPoints, SecretScepterEnergyPoints, SecretScepterStaminaPoints)
        {
        }
    }
}
