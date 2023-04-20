using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Item : IShowData
    {
        protected string name;
        protected string type;
        protected float price;

        protected Item(string name, string type, float price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }

        protected virtual string GetName()
        {
            return name;
        }

        protected virtual float GetPrice()
        {
            return price;
        }

        protected virtual string WhatType()
        {
            return type;
        }
        public virtual string IShowData()
        {
            return $"Su nombre es{GetName()}, Su precio es de {GetPrice()} y su tipo es {WhatType()}";
        }
    }
}
