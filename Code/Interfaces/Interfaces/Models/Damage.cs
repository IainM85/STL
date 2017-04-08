using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Damage
    {
        public Damage(DamageType damageType, decimal amount)
        {
            DamageType = damageType;
            Amount = amount;
        }
        public DamageType DamageType { get; set; }
        public decimal Amount { get; set; }
    }
}
