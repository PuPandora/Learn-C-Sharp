using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 수의 연산
            // + , - , * , / , %
            Console.WriteLine($"5 + 5는 {5 + 5}입니다.");
            Console.WriteLine($"5 - 5는 {5 - 5}입니다.");
            Console.WriteLine($"5 x 5는 {5 * 5}입니다.");
            Console.WriteLine($"5 ÷ 5는 {5 / 5}입니다.");
            Console.WriteLine($"5 ÷ 3의 나머지는 {5 % 3}입니다.");

            // 대입 연산자
            int a = 0;
            // 뒤에 있는 연산을 한 뒤, 대입을 함
            // 뒤를 값, 앞을 변수로 인지함
            a = a + 2;

            Console.WriteLine();

            // 대입 연산자
            int b = 7;
            Console.WriteLine($"int b = 7");
            Console.WriteLine($"b += 5 = {b += 5}");
            Console.WriteLine($"b -= 5 = {b -= 5}");
            Console.WriteLine($"b *= 10 = {b *= 5}");
            Console.WriteLine($"b /= 2 = {b /= 5}");
            Console.WriteLine($"b %= 5 = {b %= 5}");

            Console.WriteLine();

            // 증가, 감소 연산자
            int d = 1;
            Console.WriteLine("시작은 " + d + "입니다.");
            a++;
            Console.WriteLine("1 증가시켜 " + a + "가 되었습니다.");
            a--;
            Console.WriteLine("1 감소시켜 " + a + "가 되었습니다.");

        }
    }
}
