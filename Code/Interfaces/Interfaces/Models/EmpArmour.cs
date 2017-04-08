using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class EmpArmour : IArmourType
    {
        public EmpArmour(decimal amount)
        {
            _ArmourAmount = amount;
        }

        private decimal _ArmourAmount;

        public DamageType DamageType { get { return DamageType.Emp; } }
        public decimal ArmourAmount { get { return _ArmourAmount; } }
    }
}
