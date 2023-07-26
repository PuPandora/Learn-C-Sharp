using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ElseIfTest = 50;
            // 조건문
            if (ElseIfTest == 10)
            {
                Console.WriteLine("Test는 10입니다.");
            }

            else if (ElseIfTest == 100)
            {
                // 위의 조건과 연계되어
                // 위의 조건이 "아니라면"(false) 이 조건으로 넘어온다.
                Console.WriteLine("Test는 100입니다.");
            }

            else
            {
                // 위의 조건이 모두 거짓이라면 실행한다.
                Console.WriteLine("모든 조건은 거짓입니다.");
            }
        }
    }
}
