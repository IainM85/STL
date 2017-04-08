using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class KineticArmour : IArmourType
    {
        public KineticArmour(decimal amount)
        {
            _ArmourAmount = amount;
        }

        private decimal _ArmourAmount;
        
        public DamageType DamageType { get { return DamageType.Kinetic; } }
        public decimal ArmourAmount { get { return _ArmourAmount; } }
    }
}
