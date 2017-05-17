using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    /// <summary>
    /// Interface applied to any class that can contain other classes, has a IEnumerable defining what specifically it can contain
    /// </summary>
    public interface IContainer
    {
        string Name { get; set; }

        /// <summary>
        /// Controls the soecific items that can be carried, 
        /// </summary>
        IEnumerable<IContainable> CanContain { get; set; }

        decimal Capacity { get; set; }

        IEnumerable<IContainable> Cargo { get; }

        bool AddCargo(IContainable itemToAdd);

        bool RemoveCargo(IContainable itemToRemove);

        bool JettisonCargo(IContainable itemToRemove);

        bool IsJettisonable { get; }

    }
}
