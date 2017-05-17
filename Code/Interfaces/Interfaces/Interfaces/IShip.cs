using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public interface IShip
    {
        string Name { get; set; }
        IEnumerable<IHardpoint> Hardpoints { get; set; }
        decimal Hitpoints { get; set; }
        IEnumerable<IArmourType> Armours { get; set; }

        IEnumerable<IModule> Modules { get; set; }


    }
}
