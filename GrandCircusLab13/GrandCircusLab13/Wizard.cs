using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; }

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            SpellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine(Name + " - Wizard");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(string.Format("{0,-17}", "Strength: ") + Strength);
            Console.WriteLine(string.Format("{0,-17}", "Intelligence: ") + Intelligence);
            Console.WriteLine(string.Format("{0,-17}", "Magical Energy: ") + MagicalEnergy);
            Console.WriteLine(string.Format("{0,-17}", "Spell Number: ") + SpellNumber);
        }
    }
}
