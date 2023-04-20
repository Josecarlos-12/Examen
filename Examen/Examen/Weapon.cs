﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Weapon : Items, IShowData
    {
        protected float damage;
        public Weapon(float damage, string name, string type, float price) : base(name, type, price)
        {
            this.damage = damage;
        }
    }
}   
