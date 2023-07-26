using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18for
{
    // [C# 강의 16화] while & do while & for & if & switch
    // https://youtu.be/XkZpJAOb8g8?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

    internal class Program
    {
        static void Main(string[] args)
        {
            // for (초기화문; 조건문; 증감문)
            //{
            //    실행코드
            //}

            // for문은 필요없다.
            // 하지만 for문의 장점은 접근성.
            // While은 변수 선언, 내부에 증감과 조건을 설정해야 하지만
            // 하나의 for라는 키워드로 초기화와 조건, 증감

            // 한 방에 변수를 선언 후 초기화하고
            // 그걸로 조건을 비교하고
            // 그 변수를 변화시키는 코드를 한 줄에 다 담았다.

            // 변수 하나와 연산자만 있으면
            // 실행되는 연산자를 단항 연산자라고 하는데
            // 정수형일 때 ++를 하게 되면
            // 1 증가 하고
            // -- 를 하게 되면
            // 1 감소하게 된다.

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            // For문의 무한반복 While
            for (; true;)
            {
                Console.WriteLine(100);
            }
        }
    }
}
