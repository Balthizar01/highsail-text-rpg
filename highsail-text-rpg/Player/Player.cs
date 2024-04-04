using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace highsail_text_rpg
{
    enum pClass
    {
        Warrior = 1,
        Rogue,
        Wizard,
        Cleric
    }
    
    internal class Player
    {
        /// properties  
        //bio
        private int Level;
        private string Name;
        private int EXP;
        private pClass Job;
        public string Species;
        //vitals
        private int CurrentHealth;
        private int MaxHealth;
        private int MaxMana;
        private int CurrentMana;
        //attributes
        private int Strength;
        private int Agility;
        private int Endurance;
        private int Intellect;
        /// accessors
        //bio
        public int GetLevel() { return Level; }
        public string GetName() { return Name; }
        public int GetEXP() { return EXP; }
        public pClass GetJob() { return Job; }
        public string GetSpecies() { return Species; }
        //vitals
        public int GetCurrentHealth() {  return CurrentHealth; }
        public int GetMaxHealth() {  return MaxHealth; }
        public int GetCurrentMana() { return CurrentMana; }
        public int GetMaxMana() {  return MaxMana; }
        
        //attributes
        public int GetStrength() { return Strength; }
        public int GetAgility() {  return Agility; }
        public int GetEndurance() {  return Endurance;}
        public int GetIntellect() { return Intellect; }
        


    }
}
