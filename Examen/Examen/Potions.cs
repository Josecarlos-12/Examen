using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Potions:Items,IShowData
    {
        protected int capacity;
        public Potions(int capacity, string name, string type, float price) : base(name, type, price)
        {
            this.capacity = capacity;
        }
    }
}
