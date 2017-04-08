using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IHardpoint
    {
        string Name { get; set; }
        IModule Module { get; set; }

    }
}
