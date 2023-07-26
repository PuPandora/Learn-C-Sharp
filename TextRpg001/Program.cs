using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 18화] Text RPG 만들기 시작 & 숙제
// https://youtu.be/x7KkH9aoMfM?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

enum STARTSELECT
{
    SELECTOWN,
    SELECTBATTLE,
}

namespace TextRpg001
{
    internal class Program
    {
        static void StartSelect()
        {

        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Test.TenReturn());
            while (true)
            {
                // 마을과 싸움터를 나눠서 
                // 입장하게 하고 싶다면

                // 반복문과 조건문 중

                // 객체화 하지 않고도 사용할 수 있는 함수
                // Static 함수, 정적맴버함수

                // ReadKey 함수 위에 커서를 올렸을 때
                // 설명에 ConsoleKeyInfo 형을 반환한다고 하여
                // 그러한 자료형에 받아줬을 뿐
                // ConsolKeyInfo는 구조체

                ConsoleKeyInfo KeyInfo = Console.ReadKey();

                Console.WriteLine($"\t:\t{KeyInfo.Key}");
            }
        }
    }
}
