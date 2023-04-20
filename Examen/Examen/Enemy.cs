using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Enemy : NPC, IShowData
    {
        protected float damage;
        protected string itemList;
        protected int level;
        protected float givenExperience;
        public Enemy(float damage, string itemList, int level, float givenExperience, string name, float life, string type) : base(name, life, type)
        {
            this.damage = damage;
            this.itemList = itemList;
            this.level = level;
            this.givenExperience = givenExperience;
        }
    }
}

