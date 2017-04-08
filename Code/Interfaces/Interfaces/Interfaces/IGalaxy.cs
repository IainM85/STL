using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGalaxy
    {

        int GalaxyId { get; }


        IEnumerable<int> LinkedGalaxies { get; set; }
        IEnumerable<IStar> Stars{ get; set; }

    }
}
