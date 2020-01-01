namespace MuOnline.Models.Monsters
{
    using System;
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Utilities;

    public class Monster : IMonster
    {
        private int attackPoints;
        private int vitalityPoints;

        public Monster(int attackPoints, int vitalityPoints)
        {
            this.AttackPoints = attackPoints;
            this.VitalityPoints = vitalityPoints;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.AttackPoints), value);

                this.attackPoints = value;
            }
        }

        public int VitalityPoints
        {
            get
            {
                return this.vitalityPoints;
            }

            private set
            {
                Validator.ThrowAnExceptionIfIntIsLessThanZero(nameof(this.VitalityPoints), value);

                this.vitalityPoints = value;
            }
        }

        public bool IsAlive
            => this.VitalityPoints > 0;

        public int TakeDamage(int inputAttackPoints)
        {
            if (!this.IsAlive)
            {
                return 0;
            }

            var exp = Math.Abs(this.VitalityPoints - inputAttackPoints);
            this.VitalityPoints -= inputAttackPoints;

            return exp;
        }
    }
}
