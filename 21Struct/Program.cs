using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 17화] struct & enum
// https://youtu.be/_YWqlODLugI?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

struct StructData
{
    // 클래스와 비슷한데 안되는 것이 있다.
    // int a = 100 안된다. (대입이 안 된다?)
    // 리터럴 초기화가 안 된다.

    public int a;
    public int b;

    public void Func()
    {
        a = 100;
        b = 100;
    }
}

namespace _21Struct
{
    internal class Program
    {
        static void Test(StructData _Data)
        {
            _Data.a = 1000;
        }

        static void TestNAumber(int _Number)
        {
            _Number = 1000;
        }

        static void Main(string[] args)
        {
            StructData NewData = new StructData();

            NewData.a = 10;
            NewData.b = 10;

            NewData.Func();


            // 디버깅으로 확인하면 NewData.a 의 값이 바뀌지 않는다!
            // = (Class와 다르다)

            // 참조형과 값형이 있다.
            // 클래스를 객체화 하면 그건 참조형
            Test(NewData);

            TestNAumber(NewData.a);

            // 구조체는 클래스 객체와 달리
            // 스택 영역에서 자신이 멤버 변수를 가지고 있다.
            // 그래서 인자값으로 전달하면 "값"만을 복사해 주는 것이다.

            // 복습 : 객체는 힙 영역에 값을 생성하고 위치를 가르킴
            // 객체는 반대로 "참조하는 주소 위치"를 전달해 함수에서 수정을 하면
            // 그 값이 주소 위치에 있는 값을 수정시켜 영향을 줄 수 있다.
        }
    }
}
