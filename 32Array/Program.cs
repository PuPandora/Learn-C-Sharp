using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.youtube.com/watch?v=V5LfeUcP520&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=31&t=527s&pp=iAQB
// [C# 강의 31화]배열 [어소트락 게임아카데미 게임학원]

internal class Program
{
    class Item
    {
        public string Name;
        public int AT;
        public int DF;
    }

    static void Main(string[] args)
    {
        // [0][0][0][0][0][0][0][0][0][0] (10)
        int[] ArrInt = new int[10];
        float[] ArrFloat = new float[10];

        // ArrInt는 int의 배열형이다. (int의 집합)
        // ArrInt[0]의 자료형은

        Console.WriteLine(ArrInt[0]);

        // C# 에서 모든 자료형은 클래스 혹은 구조체에 가깝다.
        // 맴버변수는 맴버 함수가 있다.

        // Array의 특징
        // 여러개가 모여있다.
        // 연속되어 있다.
        // 접근방법 인덱스 [i]
        // Arrary.Length (프로퍼티, 배열 요소의 길이 구하기)

        for (int i = 0; i < ArrInt.Length; i++)
        {
            Console.WriteLine("ArraryInt[" + i + "] : " + ArrInt[i]);
        }

        // new Item();
        // 이건 아이템을 만드는 것이 아니다.
        // 아이템을 100개 담을 수 있는 공간을 만든 것이다.
        // new Item[100];

        // Item NewItem : Item 자료형을 가르키는 것
        // new Item() : 실제로 Item이 만들어지는 것
        Item NewItem = new Item();
        Item NewItem2 = new Item();

        // 아이템이라는 참조형을
        // 담을 수 있는 공간이 10개가 생겼다.

        // 아이템이라는 메모리를
        // 가르킬 수 있는 참조형이 10개 생겼다.
        Item[] ArrItem = new Item[10];

        for (int i = 0; i < ArrItem.Length; i++)
        {
            ArrItem[i] = new Item();
        }

        // 1. Item을 가르키는 것을 담을 수 있는 공간을 만든다. (Item 자료형을 담을 수 있는 공간)
        // 2. i번 Item을 가르키는 것에 Item을 만든다. (각 ArrItem 배열에 있는 것의 Item 객체 생성)
        ArrItem[0].Name = "철검";
        ArrItem[1].Name = "전설의 검";
        ArrItem[2].Name = "갑옷";
        ArrItem[3].Name = "멋진 갑옷";
        ArrItem[4].Name = "포션";

        for (int i = 0; i < ArrItem.Length ; i++)
        {
            Console.WriteLine(ArrItem[i].Name);
        }
    }
}
