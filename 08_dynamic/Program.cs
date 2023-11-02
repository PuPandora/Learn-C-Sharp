using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dynamic 키워드
namespace _08_dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dynamic 키워드로 변수를 선언하면
            // 동적으로 형이 결정된다.
            dynamic x;
            bool isTrue = true;

            if (isTrue)
            {
                x = 10;
            }
            else
            {
                x = "문자";
            }

            x = 100;
            x = "문자";
            x = 3.141592d;
            x = new List<int>();
            // var 키워드와 달리 컴파일 시 한 번만 정해지지 않고
            // 동적으로 계속 형이 바뀔 수 있다. 동적 타입 (ex. Python, JS, GDC)

            // ExpandoObject
            dynamic pet = new ExpandoObject();
            pet.name = "타로";
            pet.age = 3;
            Console.WriteLine($"이름 : {pet.name}\n나이 : {pet.age}");
            // System.dynamic의 ExpandoObject를 사용하면
            // 동적 멤버를 추가할 수 있는 object를 만들 수 있다.
        }
    }
}
