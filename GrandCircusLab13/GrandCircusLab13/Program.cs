using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class Program
    {
        static void Main()
        {
            GameCharacter[] characterList = GetCharacterList();
            Console.WriteLine("MEET OUR MIGHTY HEROES!\n");
            foreach (GameCharacter character in characterList)
            {
                character.Play();
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }

        static GameCharacter[] GetCharacterList()
        {
            GameCharacter[] characterList = new GameCharacter[5];
            characterList[0] = new Warrior("Magni Bronzebeard", 75, 45, "Mallet");
            characterList[1] = new Warrior("Garrosh Hellscream", 85, 35, "Axe");
            characterList[2] = new Wizard("Medivh", 35, 85, 75, 5);
            characterList[3] = new Wizard("Jaina Proudmoore", 25, 95, 85, 4);
            characterList[4] = new Wizard("Khadgar", 45, 75, 65, 6);
            return characterList;
        }

    }

  
}
