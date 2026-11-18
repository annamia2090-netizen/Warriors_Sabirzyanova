using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors_Sabirzyanova.Classes
{
    public class LightWarrior : Warrior
    {
        public double Coefficient { get; set; }
        public LightWarrior(double Health, double Coefficient) : base(Health)
        {
            this.Coefficient = Coefficient;
        }
        public override void TakeDamage(double damage)
        {
            Health -= damage * Coefficient;
            if (Health < 0) Health = 0;
        }
    }
}
