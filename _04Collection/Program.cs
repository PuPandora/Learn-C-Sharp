using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List를 사용하기 위해서
            // using System.Collections.Generic;
            // 이 구문이 반드시 필요함

            // 기본적인 선언 + 요소 추가 구조
            List<int> a = new List<int>();
            a.Add(10);

            // 예제
            List<string> color = new List<string>();
            color.Add("Blue");
            color.Add("Red");
            Console.WriteLine("color[0] = " + color[0]);
            Console.WriteLine("color[1] = " + color[1]);

            // 컬렉션 선언과 초기화
            List<int> ListA = new List<int>() { 10, 20, 30 };
            Console.WriteLine("ListA[0] = " + ListA[0]);
            Console.WriteLine("ListA[1] = " + ListA[1]);
            Console.WriteLine("ListA[2] = " + ListA[2]);
            Console.WriteLine();

            // 요소 삭제
            ListA.RemoveAt(1);
            Console.WriteLine("ListA.RemoveAt(1) / ListA의 1번 요소 삭제");
            Console.WriteLine("ListA[0] = " + ListA[0]);
            Console.WriteLine("ListA[1] = " + ListA[1]);
        }
    }
}
