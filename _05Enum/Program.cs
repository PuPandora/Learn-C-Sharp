using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Enum
{
    internal class Program
    {
        // 정수에 식별자 붙이기 // 기본은 int 형
        enum Animal { mouse, cat, dog = 100, bird, koala, pig = 200, lion };

        // int형 외 자료형 예제
        enum Weapon:byte { sword, axe, pickaxe, whip, bat, gun, bow}

        static void Main(string[] args)
        {
            Animal animalDog;
            animalDog = Animal.dog;

            Console.WriteLine(Animal.cat);
            Console.WriteLine((int)Animal.cat);
            Console.WriteLine((int)Animal.dog);
            Console.WriteLine((int)Animal.lion);
            Console.WriteLine(animalDog);

            Console.WriteLine();

            Weapon weaponSword;
            weaponSword = Weapon.sword;

            Console.WriteLine(Weapon.whip); // 식별자 참조
            Console.WriteLine((int)Weapon.whip); // 해당 식별자의 정수
            Console.WriteLine((int)Weapon.bat);
            Console.WriteLine((int)Weapon.sword);
            Console.WriteLine(weaponSword);
            
        }
    }
}
