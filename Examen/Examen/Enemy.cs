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

        protected virtual float GetDamage()
        {
            return damage;
        }
        protected virtual int GetLevel()
        {
            return level;
        }

        protected virtual float GetExperience()
        {
            return givenExperience;
        }
        protected virtual string GetItemList()
        {
            return itemList;
        }
        public override string IShowData()
        {
            return $"{name}: Es nivel {GetLevel()}, da {GetExperience()} de experiencia, tiene{GetDamage()} de daño y Sus items son{GetItemList()}";
        }
    }
}

