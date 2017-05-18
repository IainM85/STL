using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interfaces
{
    public class StartingShip : IShip
    {
        public StartingShip()
        {
            Hardpoints = new List<IHardpoint>();
            Armours = new List<IArmourType>();
            Modules = new List<IModule>();
            ActionBars = new List<IActionBar>();
        }

       public  List<IActionBar> ActionBars { get; set; }

        public IEnumerable<IHardpoint> Hardpoints { get; set; }
        public IEnumerable<IArmourType> Armours { get; set; }
        public IEnumerable<IModule> Modules { get; set; }

        public decimal Hitpoints { get; set; }

        private string _name = "Enterprise";

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }


    }
}
