using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Aerator 
    {
        private bool isAlive;
        private const int unitToAdd = 1;
        private Aquarium aquarium;

        public Aerator( Aquarium aAquarium ) {
            this.aquarium = aAquarium;
        }
        /// <summary>
        /// Increase oxigen level in the given aquarium.
        /// </summary>
        public void run() {
            isAlive = true;
            while (isAlive) {
                aquarium.increaseOxigenLevel(unitToAdd);
                System.Console.WriteLine(aquarium.OxigenLevel);
                System.Threading.Thread.Sleep(2000);
            }
        }
        public void stop() {
            isAlive = false;
        }     
    }
}
