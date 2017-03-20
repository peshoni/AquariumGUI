using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Residents
{
    class Crab : Shellfish
    {
        private String name;
        public Crab(String aName) {
            this.Name = aName;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public override void eat()
        {
            throw new NotImplementedException();
        }

        public override void move()
        {
            throw new NotImplementedException();
        }

        public override void reproduction()
        {
            throw new NotImplementedException();
        }
    }
}
