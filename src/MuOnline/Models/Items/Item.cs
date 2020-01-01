namespace MuOnline.Models.Items
{
    using System;
    using MuOnline.Models.Items.Contracts;
    using MuOnline.Utilities;

    public abstract class Item : IItem
    {
        private int strength;
        private int agility;
        private int stamina;
        private int energy;

        protected Item(int strength, int agility, int stamina, int energy)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Stamina = stamina;
            this.Energy = energy;
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
    }
}
