using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors_Sabirzyanova.Classes
{
    public class Warrior
    {
        public double Health { get; set; }
        public Warrior(double Health)
        {
            this.Health = Health;
        }
        public virtual void TakeDamage(double damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }
    }
}
