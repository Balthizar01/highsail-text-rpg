using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highsail_text_rpg.Models
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
