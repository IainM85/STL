using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IShip
    {
        string Name { get; set; }
        IEnumerable<IHardpoint> Hardpoints { get; set; }
        decimal Hitpoints { get; set; }
    }
}
