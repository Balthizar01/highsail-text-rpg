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
        string name;
        string description;

        List<Building> buildings;

        
        //constructors
        public Town(string name, string description, List<Building> buildings)
        {
            this.name = name;
            this.description = description;
            this.buildings = buildings;
        }

        public Town(string name, string description, Building []buildings)
        {
            this.name = name;
            this.description = description;
            this.buildings = buildings.ToList<Building>();
        }
        //accessors

        public string Name() {  return name; }
        public string Description() { return description; }
        public List<Building> Buildings() {  return buildings; }
        //mutators

        public void Name(string newName) { this.name = newName; }
        public void Description(string newDescription) { this.description = newDescription; }

        void RemoveBuilding(Building building)
        {
            buildings.Remove(building);
        }

        void AddBuildings(Building building)
        {
            buildings.Add(building);
        }



    }
}
