using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IStar
    {
        int StarId { get; }

        StarType StarType { get; }

        IEnumerable<IPlanet> Planets { get; set; }
        IEnumerable<int> LinkedStars { get; set; }

        
    }
}
