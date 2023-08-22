using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 36화]제네릭 함수 제네릭 클래스 설명 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=qCXfWgbtmB0&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=36&t=29s&pp=iAQB

// 정적 클래스 - 정적 변수와 함수만 가능
public static class GTest
{
    // 정적 클래스는 생성자를 만들 수 없다.
    //public GTest()
    //{

    //}

    // 우리가 이제껏 배운 기능
    // 함수와 전달, 오버로딩
    public static void ConsolePrint(int _Value)
    {
        Console.WriteLine(_Value);
    }

    public static void ConsolePrint(string _Text)
    {
        Console.WriteLine(_Text);
    }
    // 제네릭 함수
    // 멤버함수에도 통용된다.
    // 자료형을 변수처럼 사용하고 싶을 때
    // 함수의 식별자에 <다양한 자료형을 대표할 이름>
    // 자료형을 정적으로 두지 않고 함수를 사용할 때 자유롭게 이용할 수 있는 문법
    // 굳이 오버로딩을 하지 않고 코드를 덜 치는 문법 (늘 그렇듯)
    public static void ConsolePrintGeneric<T>(T _Value)
    {
        Console.WriteLine(_Value);
    }
    // Return 자료형으로도 지정이 가능하다.
    public static T ConsolePrintGenericReturn<T>(T _Value)
    {
        Console.WriteLine(_Value);
        return _Value;
    }

    // 오버로딩이 가능하며, 2가지 매개변수를 받을 수 있다.
    public static void ConsolePrintGeneric<T,U>(T _Value1, U _Value2)
    {
        Console.WriteLine(_Value1);
        Console.WriteLine(_Value2);
    }

    // 테스트
    public static void ConsolePrintGeneric<A, B, C, D, E, F, G, H, I, J, K, L, M, N, AA, ABC, QWER>
        (A _Value1, B _Value2, C _Value3, D _Value4, E _Value5, F _Value6, G _Value7, H _Value8, I _Value9,
        J _Value10, K _Value11, L _Value12, M _Value13, N _Value14, AA aa, ABC abc, QWER qwer)
        // 진짜 무한대로 별에별게 다 들어가네...
    { 

    }
}

class CashItem
{

}

class GameItem
{

}

// 제네릭 클래스
class Inven<T>
{
    // 제네릭 이름은 자유롭게 정해줄 수 있다.
    T[] ArrInvenItem;

    public void ItemIn(T _Item)
    {

    }


    //GameItem[] ArrGameItems;
    //CashItem[] ArrCashItems;

}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- 일반 함수 -----");
        GTest.ConsolePrint(12345);
        GTest.ConsolePrint("테스트 테스트 테스트 테스트 테스트.");

        Console.WriteLine();

        Console.WriteLine("----- 제네릭 함수 -----");
        // GTest.ConsolePrintGeneric<string>(string _Value);
        // 함수에 마우스를 올려보면 (Visual Studio) 매개변수의 자료형이 설명으로 나온다.
        GTest.ConsolePrintGeneric("문자열문자열문자열"); // string 문자열
        GTest.ConsolePrintGeneric(433); // int 정수
        GTest.ConsolePrintGeneric(3.141592f); // float 실수
        GTest.ConsolePrintGeneric(1.414141414); // double 실수
        Console.WriteLine(GTest.ConsolePrintGenericReturn("제네릭 함수 리턴 테스트"));

        Console.WriteLine();

        Console.WriteLine("----- 제네릭 함수 (2개의 매개변수) -----");
        GTest.ConsolePrintGeneric("문자열1", 3.141592);
        // int, string, float 등 기본 자료형은 이미 명시되어 있기에
        // <> 부분을 생략해도 괜찮다.
        GTest.ConsolePrintGeneric<string>("<string> 문자열 테스트");
        GTest.ConsolePrintGeneric<string, string>("<string> 문자열 테스트1", "<string> 문자열 테스트2");

        Console.WriteLine();

        Console.WriteLine("----- 제네릭 클래스 -----");
        // 기본 자료형과 달리 무조건 명시적으로 <> 지정해줘야한다.
        Inven<GameItem> NewGameItemInven = new Inven<GameItem>();
        GameItem NewGameItem = new GameItem();
        NewGameItemInven.ItemIn(NewGameItem);
        // NewGameItemInven.ItemIn(new CashItem());

        Inven<CashItem> NewCashItemInven = new Inven<CashItem>();
        CashItem NewCashItem = new CashItem();
        NewCashItemInven.ItemIn(NewCashItem);
        
        // 의문점 : 이러면 dynamic, var, object 같은 동적 변수랑 차이점이 뭘까?
    }
}
