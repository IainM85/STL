using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    /// <summary>
    /// Interface applied to any class that is carryable in a container (ammo, modules, crew etc)
    /// </summary>
    public interface IContainable
    {

        /// <summary>
        /// Used to determine how much of the container's capacity is consumed by carrying the item
        /// </summary>
        decimal Size { get; }
    }
}
