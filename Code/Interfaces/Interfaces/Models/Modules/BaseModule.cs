using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public class BaseModule : IModule
    {
        private List<IArmourType> _Armour;
        public IEnumerable<IArmourType> Armour
        {
            get
            {
                return _Armour;
            }

            set
            {
                _Armour = value.ToList();
            }
        }
        private decimal _BasePurchasePrice = 100;
        private decimal _BaseSalePrice = 100;

        public decimal CapacitorUsed
        {
            get
            {
                return 1;
            }
        }
        private List<IContainable> _Containables;

        public IEnumerable<IContainable> Containables
        {

            get
            {
                return _Containables;
            }

            set
            {
                _Containables = value.ToList();
            }
        }
        private decimal _MaxHitpoints = 100;
        private decimal _DamageTaken = 0;
        public decimal Hitpoints
        {
            get
            {
                return _MaxHitpoints - _DamageTaken;
            }
        }

        private decimal _Integrity = 1;

        public decimal Integrity
        {
            get
            {
                return _Integrity;
            }
        }

        private bool _IsOnline;

        public bool IsOnline
        {
            get
            {
                return _IsOnline && (Integrity > 0) && Hitpoints > 0;
            }
        }

        private bool _IsSellable;

        public bool IsSellable
        {
            get
            {
                return _IsSellable && (Integrity > 0) && Hitpoints > 0;
            }
        }

        private bool _IsTargettable;

        public bool IsTargettable
        {
            get
            {
                return _IsTargettable;
            }
        }


        public string Name
        {
            get;

            set;
        }



        public decimal PowerAsg
        {
            get
            {
                return IsOnline ? PowerRequired : 0;
            }
        }

        private decimal _PowerRequired = 1;

        public decimal PowerRequired
        {
            get
            {
                return _PowerRequired;
            }
        }

        public IShip ShipFitted
        {
            get;

            set;
        }

        private bool _Upgradeable;

        public bool Upgradeable
        {
            get
            {
                return _Upgradeable && (Integrity > 0) && Hitpoints > 0;
            }
        }

        public decimal BasePurchasePrice
        {
            get
            {
                return _BasePurchasePrice;
            }

            set
            {
                _BasePurchasePrice = value;
            }
        }

        public decimal BaseSalePrice
        {
            get
            {
                return _BaseSalePrice;
            }

            set
            {
                _BaseSalePrice = value;
            }
        }

        public decimal ApplyDamage(IEnumerable<Damage> damageIEnumerable)
        {
            decimal totalDamageDone = 0;

            foreach (Damage damageItem in damageIEnumerable)
            {
                IArmourType armour = Armour.FirstOrDefault(x => x.DamageType == damageItem.DamageType);

                decimal damageAmount = damageItem.Amount;

                if (armour != null)
                {
                    // If there is an applicable armour then reduce incoming damage by the appropriate amount
                    damageAmount = damageAmount - armour.ArmourAmount;
                }
                //Make sure minimum damage is 0
                if (damageAmount < 0)
                {
                    damageAmount = 0;
                }

                _DamageTaken = _DamageTaken + damageAmount;
                totalDamageDone= totalDamageDone + damageAmount;
                // make sure the damage taken never exceeds hitpoint
                if (_DamageTaken > _MaxHitpoints)
                {
                    _DamageTaken = _MaxHitpoints;
                }
            }

            return totalDamageDone;
        }

        public bool AssignPower()
        {
            if (Hitpoints > 0 && Integrity > 0)
            {
                _IsOnline = true;
            }
            return IsOnline;
        }

        public bool DeassignPower()
        {
                _IsOnline = false;
            return IsOnline;
        }

        public decimal Repair(decimal amount)
        {
            // make sure the amount repaired isnt negative (those shoddy engineers!)
            if (amount < 0)
            {
                amount = 0;
            }

            _DamageTaken = _DamageTaken - amount;

            // make sure the damage taken never exceeds hitpoint
            if (_DamageTaken > _MaxHitpoints)
            {
                _DamageTaken = _MaxHitpoints;
            }
            if (_DamageTaken < 0                 )
            {
                _DamageTaken = 0;
            }

            return amount;
        }

        public bool SetOffline()
        {
            if (_IsOnline )
            {
                _IsOnline = false;
                return true;
            }
            return false;
                }

        public bool SetOnline()
        {

            if (!_IsOnline)
            {
                _IsOnline = true;
                return true;
            }
            return false;
        }
    }
}
