using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Items : IShowData
    {
        protected string name;
        protected string type;
        protected float price;

        protected Items(string name, string type, float price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
    }
}
