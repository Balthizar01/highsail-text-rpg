using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highsail_text_rpg.Models
{
    internal class Weapon : Item
    {
        

        private int mDamage;
        ]
        //constructor
        public Weapon(string name, string description, string itemID, int damage = 1, int weight = 0, int cost = 0) 
            : base(name, description, itemID, ItemType.Weapon, weight, cost)
        {
            mDamage = damage;
        }

        //accessor
        public int Damage() { return mDamage; }
        //mutator
        public void Damage(int damage) { mDamage = damage; }
        
    }
}
