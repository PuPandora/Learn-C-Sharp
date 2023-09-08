using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 함수 안에서만 사용할 수 있다.
// 함수 밖에서는 사용할 수 없다.
// 모르는 경우는 일단 써보고, 안 되면 문법이라고 생각한다.
//while (true)
//{

//}

namespace _17While
{
    // [C# 강의 16화] while & do while & for & if & switch
    // https://youtu.be/XkZpJAOb8g8?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

    internal class Program
    {
        // 당연히란 없다.
        // 함수의 인자값은 메모리화 되고 값이 변할 수 있어야 하는데.
        // while 문은 반환하거나 저장하는 기능을 내포하는 구문이 아님.

        //void Func(while(true))
        //{
        
        //}

        static void Main(string[] args)
        {
            // 반복문 3가지
            // while
            // do while
            // for

            // bool 값 true/false
            // while (참/거짓)
            bool Check = true;

            // 조건문 -> 실행코드 -> 조건문 -> 실행코드 -> ...
            // Check
            // 조건문(true) -> 실행코드(false) -> 조건문 -> 종료
            while (Check)
            {
                Console.WriteLine("무한 출력\n\n");
                Check = false;
            }

            // while 문은 쓸 때
            // 일반적인 프로그램에서는
            // 항상 빠져나올 수 있는
            // 조건을 넣어놓고 실행해줘야 한다.

            // 상수를 넣어주면

            int Count = 0;
            do
            {
                Console.Write(Count + " ");
                Count++;
            } while (Count < 5);

            // DEBUGGING 으로 흐름을 쉽게 파악할 수 있다!!!
            Count = 0;
            while (Count < 5)
            {
                //Count++;
                Console.WriteLine(Count);
                Count++;
            }
        }
    }
}
