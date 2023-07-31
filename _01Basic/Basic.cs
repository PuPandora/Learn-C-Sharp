// using도 사실은 namespace이다.
// 누군가 쳐놓은 코드이다.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 네임스페이스
namespace Basic
{
    // 어셈블리 한정 public 기능을 하는 internal
    internal class Basic
    {
        // 프로그램을 실행할 때 인수를 받는 기능 (string[] args)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("문자열을 출력하고 줄바꿈을 하는 메소드");
            Console.Write("문자열을 출력하고 줄바꿈을 하지 않는 메소드");
        }
    }
}

