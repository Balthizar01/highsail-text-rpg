using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///<summary>
///This is the NPC class. Currently has a field for a name, and a bio.
/// </summary>
namespace highsail_text_rpg.Models
{
    internal class NPC
    {
        string mName;
        string mBio;
        //accessors
        public string Name() {  return mName; }
        public string Bio() { return mBio; }
        //mutators
        public void Name(string newName) { mName = newName; }
        public void Bio(string newBio) { mBio = newBio; }
        //constructors
        public NPC(string name, string bio)
        {
            mName = name;
            mBio = bio;
        }
    }
}
