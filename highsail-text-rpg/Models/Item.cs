using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highsail_text_rpg.Models
{
    enum ItemType
    {
        Weapon = 1,
        Armor,
        Accessory,
        Consumable,
        KeyItem,
        Misc
    }
    internal class Item
    {
        //properties
        private string mName;
        private string mDescription;
        private string mItemID;
        private ItemType mType;

        private int mWeight;
        private int mCost;

        //constructor
        public Item(string name, string description, string ItemID, ItemType type, int weight = 0, int cost = 0)
        {
            mName = name;
            mDescription = description;
            mItemID = ItemID;
            mType = type;
            mWeight = weight;
            mCost = cost;
        }
        //accessors
        public string Name() { return mName; }
        public string Description() { return mDescription; }
        public string ItemID() {  return mItemID; }
        public ItemType Type() { return mType; }
        public int Weight() { return mWeight; }
        public int Cost() { return mCost; }
        //mutators
        public void Name(string name) { mName = name; }
        public void SetDescription(string description) {  mDescription = description; }
        public void ItemID(string itemID) {  mItemID = itemID; }
        public void Type(ItemType type) { mType = type; }
        public void Weight(int weight) {  mWeight = weight; }
        public void Cost(int cost) {  mCost = cost; }
        
    }
}
