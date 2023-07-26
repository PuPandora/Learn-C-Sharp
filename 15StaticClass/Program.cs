using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적 클래스란
// 정적 멤버변수와
// 정적 멤버함수만을 가질 수 있는 클래스이다.
static class StClass
{
    // 일반 멤버변수는 선언만해도 오류가 발생한다.
    // int TEST = 10;
}

namespace _15StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONSOLE WRITELINE은...");
        }
    }
}
