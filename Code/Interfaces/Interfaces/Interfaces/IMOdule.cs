using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IModule
    {
        // TODO : Fix Error
        IShip ShipFitted { get; set; }

        string Name { get; set; }

        // Hit points are readonly so that damage/repair is run through the appropriate method (where special abilities might reduce/increase it)
        decimal Hitpoints { get; }

        // Is Online is readonly to prevent changes other than through methods
        bool IsOnline { get; }

        // Indicates if a module can be specifically targetted
        bool IsTargettable { get; }

        bool IsSellable { get; }

        decimal PowerRequired { get; }
        decimal CapacitorUsed { get; }
        // TODO - Not sure what this is : Needs Review
        decimal PowerAsg { get; }       //HunterK: Comment: Power Assigned to Module. Need to incorporate min/max power available - possibly tie in with upgrades
        decimal Integrity { get; }      //HunterK: Comment: Refers to integrity of module hull (an idea to incorporate hull breach e.g. start with 10 when 0, then breached and leaking 02) - May be redundant
        bool Upgradeable { get; }       //HunterK: Comment: Can the module be upgraded - propably should be its own class=/interface associated with the module

        IEnumerable<IContainable> Containables { get; set; }

        // IEnumerable of applied armours, could be empty or multiple layers
        IEnumerable<IArmourType> Armour { get; set; }

        // Price for use in shops when buying the item
        decimal BasePurchasePrice { get; set; }

        // Price for use in shops when selling the item
        decimal BaseSalePrice { get; set; }

        /// <summary>
        /// Method that applies damage to the module's hitpoints based on a IEnumerable of provided "Damages"
        /// </summary>
        /// <param name="damageIEnumerable"></param>
        /// <returns></returns>
        decimal ApplyDamage(IEnumerable<Damage> damageIEnumerable);

        /// <summary>
        /// Method that restores hitpoints based on an amount supplied
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        decimal Repair(decimal amount);


        bool SetOnline();
        bool SetOffline();
        bool AssignPower( );
        bool DeassignPower();


    }
}
