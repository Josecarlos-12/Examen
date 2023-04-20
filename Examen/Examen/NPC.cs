using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{    
        abstract class NPC : IShowData
        {
            protected string name;
            protected float life;
            protected string type;

            protected NPC(string name, float life, string type)
            {
                this.name = name;
                this.life = life;
                this.type = type;

            }

        protected virtual string GetName()
        {
            return name;
        }

        protected virtual float GetLife()
        {
            return life;
        }

        protected virtual string WhatType()
        {
            return type;
        }
        public virtual string IShowData()
        {
            return $"Su nombre es{GetName()}, Su vida es de {GetLife()} y su tipo es {WhatType()}";
        }
    }
}
