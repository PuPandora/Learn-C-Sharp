using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StringChar
{

    internal class Program
    {
        static string test;
        static int test2;

        static void Main(string[] args)
        {
            // string, char에 " ", "" 넣기 테스트, 길이 확인
            char[] myChar = { 'a', 'b', 'c' };

            Console.WriteLine("myChar 길이 : " + myChar.Length);
            Console.WriteLine("myChar 요소");
            //foreach (var c in myChar)
            //{
            //    Console.WriteLine(c);
            //}

            // Console.WriteLine("".Length); // 0
            // Console.WriteLine(test); // 빈칸
            // Console.WriteLine(test.Length); // NullReferenceException 에러

            //myChar[1] = ''; // 컴파일 에러
            string a = "";
            string b = "33";
            string c = " ";
            List<int> ints;

            Console.WriteLine(a.Length);
            Console.WriteLine(b.Length);
            Console.WriteLine(c.Length);

            // 입력받은 문자열에 e와 o를 빼서 출력하기
            string problem = "hello";
            string result1 = "";
            string result2 = "";

            char[] chars = problem.ToCharArray();
            // Solution 1
            foreach (char ca in problem)
            {
                if (ca != 'e' && ca != 'o')
                {
                    result1 += ca;
                }
            }

            // Solution 2
            foreach (char ca in chars)
            {
                if (ca != 'e' && ca != 'o')
                {
                    result1 += ca;
                }
            }

            Console.WriteLine("result1 : " + result1);
            Console.WriteLine("result2 : " + result2);
        }
    }
}
