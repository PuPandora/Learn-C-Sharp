using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 17화] struct & enum
//https://youtu.be/_YWqlODLugI?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

// 기본 자료형 -> 이미 있다.

// 사용자 정의 자료형 중 하나
// class | 참조형 사용자정의
// struct | 값형 사용자 정의
// enum | 값형 사용자 정의

// 다른 언어에선 정수형 상수라고 하는데 C#에서는 아니다.
// 보통 어떤 상태를 표현하는 것 중
// 나만의 것을 가지고 싶을 때 사용한다.
// 열거형이라고 불리며 사용법
enum ITEMTYPE
{
    // 내가 값의 범위를 지정한 새로운 자료형을
    // 만들어 낼 수 있다는 장점이 있고
    // Switch문과 궁합이 정말 좋다.
    EQUIP,
    POTION,
    QUEST,
    NONSELECT
}

// 일일이 클래스를 만들지 않는다
// class PotionItem
// class QuestItem

class Item
{
    //int ItemType = 0;
    public ITEMTYPE ItemType = ITEMTYPE.NONSELECT;

    public void PotionTypeSetting()
    {
        ItemType = ITEMTYPE.POTION;
    }
}

namespace _22Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();
            // NewItem.ItemType = ITEMTYPE.POTION;
            NewItem.PotionTypeSetting();

            // POTION 출력
            Console.WriteLine(ITEMTYPE.POTION);

            ITEMTYPE Type = ITEMTYPE.POTION;

            switch (Type)
            {
                case ITEMTYPE.EQUIP:
                    break;
                case ITEMTYPE.POTION:
                    break;
                case ITEMTYPE.QUEST:
                    break;
                case ITEMTYPE.NONSELECT:
                    break;
            }
        }
    }
}