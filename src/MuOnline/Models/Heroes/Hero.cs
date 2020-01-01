namespace MuOnline.Models.Heroes
{
    using System;
    using System.Linq;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Models.Inventories;
    using MuOnline.Models.Inventories.Contracts;
    using MuOnline.Utilities;

    public abstract class Hero : IHero, IIdentifiable, IProgress
    {
        private string username;
        private int strength;
        private int agility;
        private int stamina;
        private int energy;
        private int experience;
        private int level;
        private int resets;
        private int totalAgilityPoints;
        private int totalEnergyPoints;
        private int totalStaminaPoints;

        protected Hero(string username, int strength, int agility, int stamina, int energy)
        {
            this.Username = username;
            this.Strength = strength;
            this.Agility = agility;
            this.Stamina = stamina;
            this.Energy = energy;
            this.Inventory = new Inventory();
            this.TotalStaminaPoints = this.GetTotalStaminaPoints();
            this.TotalAgilityPoints = this.GetTotalAgilityPoints();

            this.Experience = 0;
            this.Level = 0;
            this.Resets = 0;
        }

        public IInventory Inventory { get; }

        public bool IsAlive
            => this.TotalStaminaPoints > 0;

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                Validator.ThrowAnExceptionIfObjectIsNull(value, nameof(this.Username));

                this.username = value;
            }
        }

        public int Strength
        {
            get
            {
                return this.strength;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.Strength), value);

                this.strength = value;
            }
        }

        public int Agility
        {
            get
            {
                return this.agility;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.Agility), value);

                this.agility = value;
            }
        }

        public int Stamina
        {
            get
            {
                return this.stamina;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.Stamina), value);

                this.stamina = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.Energy), value);

                this.energy = value;
            }
        }

        public int Experience
        {
            get
            {
                return this.experience;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.Experience), value);

                this.experience = value;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.Level), value);

                this.level = value;
            }
        }

        public int Resets
        {
            get
            {
                return this.resets;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.Resets), value);

                this.resets = value;
            }
        }

        public int TotalAttackPoints
            => this.Strength +
               (this.Agility * 10 / 100) +
               (this.Energy * 5 / 100) +
               this.Inventory.Items.Sum(x => x.Strength);

        public int TotalEnergyPoints
            => this.Energy +
               this.Inventory.Items.Sum(x => x.Energy);

        public int TotalAgilityPoints
        {
            get
            {
                return this.totalAgilityPoints;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.TotalAgilityPoints), value);

                this.totalAgilityPoints = value;
            }
        }

        public int TotalStaminaPoints
        {
            get
            {
                return this.totalStaminaPoints;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.TotalStaminaPoints), value);

                this.totalStaminaPoints = value;
            }
        }

        public void TakeDamage(int inputDamagePoints)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Hero is not alive!");
            }

            if (this.TotalAgilityPoints > 0)
            {
                this.TotalAgilityPoints -= inputDamagePoints;
            }
            else
            {
                this.TotalStaminaPoints -= inputDamagePoints;
            }
        }

        public void AddExperience(int inputExperience)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Hero is not alive!");
            }

            this.Experience += inputExperience;

            if (this.Experience >= 9000)
            {
                this.Level++;
            }

            if (this.Level >= 400)
            {
                this.Resets++;
            }
        }

        private int GetTotalStaminaPoints()
            => this.totalStaminaPoints = this.Stamina +
                                         this.Inventory.Items.Sum(x => x.Stamina);

        private int GetTotalAgilityPoints()
            => this.totalAgilityPoints = this.Agility +
                                         this.Inventory.Items.Sum(x => x.Agility);
    }
}
