using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class item : vendor
    {
        protected item(float money, float potion) : base(money)
        {

        }

        protected virtual float getmoney()
        {
            return money;
        }
    }
}
