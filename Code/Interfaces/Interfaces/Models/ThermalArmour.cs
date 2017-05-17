using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public class ThermalArmour : IArmourType
    {
        public ThermalArmour(decimal amount)
        {
            _ArmourAmount = amount;
        }

        private decimal _ArmourAmount;

        public DamageType DamageType { get { return DamageType.Thermal; } }
        public decimal ArmourAmount { get { return _ArmourAmount; } }
    }
}
