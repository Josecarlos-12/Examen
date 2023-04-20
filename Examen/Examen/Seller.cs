using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Seller : NPC, IShowData
    {
        protected float money;
        protected string itemList;

        public Seller(float money, string itemList, string name, float life, string type) : base(name, life, type)
        {
            this.money = money;
            this.itemList = itemList;
        }
        protected virtual float GetMoney()
        {
            return money;
        }

        protected virtual string GetItemList()
        {
            return itemList;
        }
        public override string IShowData()
        {
            return $"{name}: tiene{GetMoney()} de dinero y sus items son {GetItemList()}";
        }
    }
}
