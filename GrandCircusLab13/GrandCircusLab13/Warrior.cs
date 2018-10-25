using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; }

        public Warrior(string name, int strength, int intelligence, string weaponType) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine(Name + " - Warrior");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(string.Format("{0,-17}", "Strength: ") + Strength);
            Console.WriteLine(string.Format("{0,-17}","Intelligence: ") + Intelligence);
            Console.WriteLine(string.Format("{0,-17}", "Weapon Type: ") + WeaponType);
        }
    }
}
