using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 32화]인벤토리 만들기 1부+ null 레퍼런스 설명 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=IuibSYe6qV0&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=32&pp=iAQB

// [C# 강의 33화]인벤토리 만들기 2부+ break continue 설명 설명 [어소트락 게임아카데미 게임학원]
// https://youtu.be/mECMKruSzdI?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

class Program
{
    static void Main(string[] args)
    {
        // *****
        // *****
        // *****
        Inven NewInven = new Inven(5, 3);

        //Inven NewInven2 = null;
        //NewInven2.ItemIn(null, 10);
        
        // 뭐가 있어야 겠다.
        // 클래스
        // 속성들이 있다.
        // 아이템 배열을 맴버변수로 가졌다.

        // 넣는다. 동사
        // 인벤에 아이템을 넣는다.

        NewInven.ItemIn(new Item("철검", 100));
        NewInven.ItemIn(new Item("갑옷", 100));

        // 알아서 처리해 줄거라는 생각 자체를 하지 말라.
        NewInven.ItemIn(new Item("포션", 100), 6);

        while (true)
        {
            Console.Clear();
            NewInven.Render();
            Console.ReadKey();
        }
    }
}
