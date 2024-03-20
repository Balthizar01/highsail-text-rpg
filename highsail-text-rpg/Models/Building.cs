using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace highsail_text_rpg.Models
{
    enum BuildingType
    {
        Shop = 1,
        House,
        Library,
        Tavern,
        DiplomaticBuilding
    }
    internal class Building
    {
        //properties
        private string mName;
        private BuildingType mType;
        private int mFloorsNumbie; 
        private List<NPC> mPeopleInside;
        private NPC mOwner;
        //Constructors
        Building(string name, BuildingType type, int floors, NPC owner, List<NPC> PeopleInside = null)
        {
            mName = name;
            mType = type;
            mFloorsNumbie = floors;
            mOwner = owner;
            if (PeopleInside == null)
                mPeopleInside = new List<NPC>();
            else
                mPeopleInside = PeopleInside;
        }

        Building(string name, BuildingType type, int floors, NPC owner, NPC[] PeopleInside = null)
        {
            mName = name;
            mType = type;
            mFloorsNumbie = floors;
            if (PeopleInside == null)
                mPeopleInside = new List<NPC>();
            else
                mPeopleInside = PeopleInside.ToList<NPC>();
            mPeopleInside = PeopleInside.ToList<NPC>();
            mOwner = owner;
        }



        //accessors
        public string Name() {  return mName; }
        public BuildingType Type() { return mType; }
        public int NumbiOfFloors() {  return mFloorsNumbie; }
        public List<NPC> PeopleInside() {  return mPeopleInside; }
        public NPC Owner() { return mOwner; }

        //mutators
        public void Name(string name) { mName = name; }
        public void Type(BuildingType type) { mType = type; }
        public void FloorsNumbie(int numbie) { mFloorsNumbie = numbie; }
        public void AddPerson(NPC personToAdd) {  mPeopleInside.Add(personToAdd); }
        public void RemovePerson(NPC personToRemove) {  mPeopleInside.Remove(personToRemove); }

    }
}
