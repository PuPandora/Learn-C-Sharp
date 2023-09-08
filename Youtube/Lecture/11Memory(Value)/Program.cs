using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;
    int ATT = 10;

    public void Test(int _Value)
    {
        _Value = 1000;
    }
    // 인자 값의 "값"을 "복사"해 받아와서 변경하거나 사용할 뿐.
    // Program 클래스의 Main에 있는 값에는 영향을 미치지 않는다.
    // _Value는 별개의 지역 변수이다.
    // 이것은 함수 호출 방식 중 Call by Value에 해당한다.
}

namespace _12Memory_reference_
{
    internal class Program
    {
        // [C# 강의 11화] !중요! 값형의 메모리 구조 및 처리 개념
        // https://www.youtube.com/watch?v=o7QyAiqGCyo&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=11&pp=iAQB

        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // 함수의 인자값
            int Value = 0;
            // 멤버함수 -> Value = 1000;
            NewPlayer.Test(Value);
            
            // 0 그대로 출력
            Console.WriteLine(Value);
        }
    }
}
