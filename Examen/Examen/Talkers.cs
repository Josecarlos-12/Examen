using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Talkers : NPC, IShowData
    {
        protected string textList;
        public Talkers(string textList, string name, float life, string type) : base(name, life, type)
        {
            this.textList = textList;
        }
    }
}
