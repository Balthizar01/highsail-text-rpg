using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highsail_text_rpg
{
    internal class Player
    {
        private int Level;
        private string Name;
        private int CurrentHealth;
        private int MaxHealth;

        //accessors
        public int GetLevel() { return Level; }
        public string GetName() { return Name; }
        public int GetCurrentHealth() {  return CurrentHealth; }
        public int GetMaxHealth() {  return MaxHealth; }



    }
}
