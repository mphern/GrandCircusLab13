using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength ,intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine(Name);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(string.Format("{0,-17}", "Strength: ") + Strength);
            Console.WriteLine(string.Format("{0,-17}", "Intelligence: ") + Intelligence);
            Console.WriteLine(string.Format("{0,-17}", "Magical Energy: ") + MagicalEnergy);
        }

    }
}
