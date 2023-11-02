using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 확장 메소드
// C# 3.0
namespace _09_ExpandMethod
{
    class Animal
    {
        public int age = 10;
    }

    static class AnimalEx
    {
        // this 키워드와 확장할 클래스를 첫 번째 인자로 설정한다.
        // 그 뒤에 호출할 때 첫 번째로 올 인자를 추가한다.
        public static void print2(this Animal a, string addStr)
        {
            Console.WriteLine($"{a.age}{addStr}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 확장 메소드는 상속을 하지 않고도 기존 클래스에
            // 메소드를 추가할 수 있는 기능이다.
            Animal a = new Animal();
            a.print2("살입니다");
        }
    }
}
