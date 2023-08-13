﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 나는 아이템을 담아두는 인벤토리를 만들고 싶다.
// 인벤토리를 만들어 질 때
// 인벤토리가 최대 몇개를 담을 수 있는지부터 정해야한다.
// + 정하지 않으면 인벤토리를 만들 수도 없어야 한다.

// 이 때 숫자가 2개 필요한데, x와 y이다.
// 그럼 담을 수 있는 아이템의 총 개수는??? x * y

class Inven
{
    Item[] ArrItem;
    int ItemX;

    // 숙제 - Select 만들기
    // 선택한 곳의 아이템 만들기 (선택 전환 가능)
    int SelectIndex = 0;

    // 잘못쓰기 힘들게 하는 것이 좋다.
    // 생성자를 이용하여 특정하게 제한하는 방식
    // 인벤토리를 new 하려면, int X와 Y를 넣어줘야 한다.
    public Inven(int _X, int _Y)
    {
        // 초보 프로그래머가 가장 주의해야할 것.
        // 방어코드는 선택이 아니라 필수이다.
        // 방어코드란 무엇인가?
        // switch문의 default같은 존재이다.
        // 혹은 프로그램이 터지거나 오작동하지 않게
        // 들어오는 값들을 체크해서 문제가 없도록 만드는 코드
        // 함수나 이런 곳에서 인자값을 받을 때
        // 이걸 검사하고 사용한다.

        // 1미만 (0, 음수인 값으로 인벤토리를 생성하지 못하도록 막기)
        if (1 > _X)
        {
            _X = 1;
        }

        if (1 > _Y)
        {
            _Y = 1;
        }

        ItemX = _X;

        ArrItem = new Item[(_X * _Y)];
    }

    // 객체의 교류
    // 인벤은 아이템이 필요하다.
    public void ItemIn(Item _Item)
    {
        int Index = 0;
        // 인덱스만 몇번이 될지 잘 정하면 된다.

        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (ArrItem[i] == null)
            {
                Index = i;
                break;
            }
        }
        ArrItem[Index] = _Item;
    }

    public void ItemIn(Item _Item, int _Order)
    {
        // System.IndexOutOfRangeException 방어코드 만들기

        // 방어코드
        if (ArrItem[_Order] != null)
        {
            return;
        }

        ArrItem[_Order] = _Item;
    }

    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            // 0 1 2 3 4
            // 5 6 7 8 9
            // 10 11 12 13 14

            // i % 5
            // 0도 5와 나눌 경우 0이 되기에 0이 아니라는 조건 추가
            // 조건이야 늘려주면 되긴 한다.
            // 프로그램을 구현할 때는 구현에 신경을 쓰자.
            // 프로그램의 최적화, 효율은 나중에 생각해도 되는 문제이다. (너무 신경 안 쓰진 말고...)
            if (0 != i && 0 == i % ItemX)
            {
                Console.WriteLine();
            }

            if (SelectIndex == i)
            {
                Console.Write("▣");
            }

            // 인벤토리 n번째 칸에 아이템이 없다면
            else if (ArrItem[i] == null)
            {
                Console.Write("□");
            }
            // 아이템이 있다면
            else
            {
                Console.Write("■");
            }

            Console.WriteLine("");

            Console.WriteLine("현재 선택한 아이템");
            Console.WriteLine("이름 : " + ArrItem[SelectIndex].Name);
            Console.WriteLine("가격 : " + ArrItem[SelectIndex].Gold);
        }
    }
}
