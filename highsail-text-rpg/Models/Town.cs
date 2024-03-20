using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highsail_text_rpg.Models
    ///<summary>
    ///This is the Town Class. Currently it holds a string for name, string for description,
    ///and a list of "Building" objects. It has two constructors, one constructing with a list of buildings
    ///and the other constructing with a normal array of buildings. 
    ///</summary>
{
    internal class Town
    {
        string mName;
        string mDescription;

        List<Building> mBuildings;
        //constructors
        public Town(string name, string description, List<Building> buildings)
        {
            mName = name;
            mDescription = description;
            mBuildings = buildings;
        }

        public Town(string name, string description, Building []buildings)
        {
            mName = name;
            mDescription = description;
            mBuildings = buildings.ToList<Building>();
        }
        //accessors

        public string Name() {  return mName; }
        public string Description() { return mDescription; }
        public List<Building> Buildings() {  return mBuildings; }
        public Building []BuildingsArray() {  return mBuildings.ToArray(); }
        //mutators

        public void Name(string newName) { mName = newName; }
        public void Description(string newDescription) { mDescription = newDescription; }

        public void RemoveBuilding(Building building)
        {
            mBuildings.Remove(building);
        }

        public void AddBuilding(Building building)
        {
            mBuildings.Add(building);
        }
    }
}
