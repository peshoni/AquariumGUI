using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;

namespace Observer
{
    public abstract class Observer  
    {
       protected Warehouse _warehouse;

        /// <summary>
        /// Update all observers.
        /// </summary>
        public abstract void update();
    }
}
