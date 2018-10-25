using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class GameCharacter
    {
        public string Name { get; }
        public int Strength { get; }
        public int Intelligence { get; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine(Name);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(string.Format("{0,-17}", "Strength: ") + Strength);
            Console.WriteLine(string.Format("{0,-17}", "Intelligence: ") + Intelligence);
        }

    }
}
