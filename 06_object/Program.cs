using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// object 클래스
namespace _06_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0. 박싱
            // object는 모든 클래스의 기본이 되는 클래스
            // 참조형 + 값형 모두 대입 가능
            int a = 11;
            object ob;
            ob = a;
            // 이와 같이 값형의 데이터를 객체형 변수에 대입하는 것을
            // 박싱(boxing)이라고 한다.

            // 1. 언박싱
            int b = (int)ob;
            // 반대로 값형에 object 데이터를 대입하는 행위를
            // 언박싱(unboxing)이라고 한다.

            float c = 3.14f;
            float d;
            object obj;

            Console.WriteLine($"c : {c}");
            obj = c;
            d = (float)obj;
            Console.WriteLine($"d : {d}");
        }
    }
}
