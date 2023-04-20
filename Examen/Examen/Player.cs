using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Player
    {
        protected string name;
        protected string itemList;
        protected float experience;
        protected int level;
        protected float money;

        public Player(string name, string itemList, float experience, int level, float money)
        {
            this.name = name;
            this.itemList = itemList;
            this.experience = experience;
            this.level = level;
            this.money = money;
        }

        protected virtual string GetName()
        {
            return name;
        }
        protected virtual int GetLevel()
        {
            return level;
        }

        protected virtual float GetExperience()
        {
            return experience;
        }
        protected virtual string GetItemList()
        {
            return itemList;
        }
        protected virtual float GetMoney()
        {
            return money;
        }
        public string IShowData()
        {
            return $"Su nombre es{GetName()}, Su nivel es {GetLevel()}, su experiencia es {GetExperience()}, tiene con {GetMoney()} monedas y sus items son{GetItemList()}";
        }
    }
}
