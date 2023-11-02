using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// var 키워드
// C# 3.0
namespace _07_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var 키워드를 사용하면 자료형을 지정하지 않고
            // 변수나 객체를 생성할 수 있다.
            // 이런 경우에 C#이 컴파일을 할 때 형을 추측한다.
            var a = 10;
            var b = "string";
            var c = 3.141592d;
            var d = new System.Collections.Generic.List<int[]>();
            var e = new string[] { "AAA", "BBB", "CCC" };

            // 위와 같이 대입할 자료형이 긴 경우에 용이하게 사용할 수 있다.
            // 사실 코드 작성을 줄이기 위한 키워드에 가깝다.
        }
    }
}
