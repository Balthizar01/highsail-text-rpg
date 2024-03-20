using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highsail_text_rpg.Models
{
    internal class Weapon
    {
        private string mName;
        private string mDescription;

        private int mDamage;
        private int mWeight;
        private int mCost;
        //constructor
        public Weapon(string name = "Iron Dagger", string description = "A Rusty Iron Dagger", int damage = 2, int weight = 2, int cost = 2)
        {
            mName = name;
            mDescription = description;
            mDamage = damage;
            mWeight = weight;
            mCost = cost;
        }
        //accessors
        public string Name() { return mName; }
        public string Description() { return mDescription; }

        public int Damage() { return mDamage; }
        public int Weight() {  return mWeight; }
        public int Cost() { return mCost; }
        //mutators
        public void Name(string name) { mName = name; } 
        public void Description(string description) {  mDescription = description; }
        
        public void Damage(int damage) { mDamage = damage; }
        public void Weight(int weight) { mWeight = weight; }
        public void Cost(int cost) {  mCost = cost; }
    }
}
