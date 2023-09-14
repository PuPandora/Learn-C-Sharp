using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int 형식의 변수는 컴파일러가 반드시 4비트의 값을 할당해준다.
            // (기본 값으로 0)
            // 하지만 때로 int 형 변수에 아무것도 없는(null) 값이 필요 할 때
            // Nullable 형식을 사용하면 된다.
            // 데이터_형식? 변수_이름;
            
            int? a = null;
            float? b = null;
            double? c = null;
            // int d = null; 문법 오류
            string test;

            // Nullable 타입에 있는 프로퍼티
            // HasValue, Value
            Console.WriteLine("a.HasValue : " + a.HasValue + "\n");

            Console.WriteLine("a = 37;\n");
            a = 37;

            Console.WriteLine("a.HasValue : " + a.HasValue);
            Console.WriteLine("a.Value : " + a.Value);
        }
    }
}
