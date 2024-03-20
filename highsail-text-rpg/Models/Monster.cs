using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highsail_text_rpg.Models
{
    internal class Monster
    {
        //properties
        private string mName;
        private string mDescription;

        //accessors
        public string Name() { return mName; }
        public string Description() { return mDescription; }
        
        //mutators
        public void Name(string name) { mName = name; }
        public void Description(string description) { mDescription = description; } 
    }
}
