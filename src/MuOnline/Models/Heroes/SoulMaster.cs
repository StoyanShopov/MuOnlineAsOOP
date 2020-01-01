namespace MuOnline.Models.Heroes
{
    public class SoulMaster : Hero
    {
        private const int SoulMasterStrength = 30;
        private const int SoulMasterAgility = 70;
        private const int SoulMasterStamina = 50;
        private const int SoulMasterEnergy = 80;

        public SoulMaster(string username) 
            : base(username, SoulMasterStrength, SoulMasterAgility, SoulMasterStamina, SoulMasterEnergy)
        {
        }
    }
}
