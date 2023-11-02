using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 객체 초기화자와 익명형
// C# 3.0
namespace _10_ObjectInitializerAnonymouseType
{
    class Player
    {
        public int age;
        public string name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 0. 객체 초기화자
            // 생성자 없이 public 같은 접근 제한자가 붙은 멤버를 초기화 할 수 있다.
            Player myPlayer = new Player { age = 17, name = "용사" };
            Console.WriteLine($"myPlayer.age : {myPlayer.age}\nmyPlayer.name : {myPlayer.name}");

            // 1. 익명 형
            // 이름이 없는(?) 클래스를 만들 수 있다.
            var myPlayer2 = new { age = 18, name = "버림받은 용사" };
            Console.WriteLine($"myPlayer2.age : {myPlayer2.age}\nmyPlayer2.name : {myPlayer2.name}");
            // myPlayer2.age = 17; // 하지만 읽기전용이므로 수정할 수 없다.
        }
    }
}
