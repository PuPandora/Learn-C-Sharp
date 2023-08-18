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

// [C# 강의 34화]인벤토리 인터페이스 제작 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=CmcE_oqA8WI&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=34&t=1233s&pp=iAQB

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

        // 알아서 컴퓨터, 언어가 자동으로 오류나 예외를 처리해 줄거라는 생각 자체를 하지 말라.
        NewInven.ItemIn(new Item("포션", 50), 6);

        NewInven.ItemIn(new Item("레나의 장미꽃", 1), 8);
        NewInven.ItemIn(new Item("월광관 고교 완장", 1), 12);
        NewInven.ItemIn(new Item("야소가미 고교 교복", 1), 13);
        NewInven.ItemIn(new Item("슈진 고교 체육복", 1), 14);
        NewInven.ItemIn(new Item("아르카나 카드", 1), 15);
        NewInven.ItemIn(new Item("르블랑 수제 커피", 70), 16);
        NewInven.ItemIn(new Item("언터쳐블 모델건 MK.II", 350), 24);

        while (true)
        {
            Console.Clear();
            NewInven.RenderInventory();
            ConsoleKey PlayerInput = PlayerInputKey();

            // 화살표 입력을 받아 인벤토리 칸 이동
            switch(PlayerInput)
            {
                case ConsoleKey.LeftArrow:
                    NewInven.MoveSelectLeft();
                    break;
                case ConsoleKey.RightArrow:
                    NewInven.MoveSelectRight();
                    break;
                case ConsoleKey.UpArrow:
                    NewInven.MoveSelectUp();
                    break;
                case ConsoleKey.DownArrow:
                    NewInven.MoveSelectDown();
                    break;
            }
        }
    }

    static private ConsoleKey PlayerInputKey()
    {
        ConsoleKeyInfo CKI;
        CKI = Console.ReadKey();
        return CKI.Key;
    }
}
