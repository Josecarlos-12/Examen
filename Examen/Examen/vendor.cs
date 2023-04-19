using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class vendor
    {
        protected float money;

        protected vendor(float money)
        {
            this.money = money;
        }
    }
}
