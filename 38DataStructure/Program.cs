using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 38화]자료구조 개념잡기 1차 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=KFeFq7gcGVQ&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=38&pp=iAQB

// 자료구조를 직접 만들어 보는 건
// 게임 프로그래머의 언어를 배우는 것과 같은 기초소양

// 총알이 1000발 발사된다. 어떻게 관리하지?
// NPC가 500명이 있다. 그 중에서 "피오나"라는 이름의 NPC를 어떻게 찾지?
class MyDataStructure<T>
{
    // 만약 자료구조를 직접 만든다면 주로 클래스로 만든다.
    // 넣기, 탐색, 확장
    // 제네릭 클래스로 만들어 어느 자료형이든 쉽게 객체를 만들 수 있게 한다.

    public void Push(T _Data)
    {
        if (/*이 자료가 들어왔을 때, 사이즈가 오버되면*/true)
        {
            Extend(10/*적절한 수로 늘린다*/);
        }
    }

    public void Find(T _Data)
    {

    }

    public void Extend(T _Size)
    {

    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // 배열도 자료구조이다.
        int[] Arr = new int[10];

        // 자료구조에는 보통 컨테이너라는 용어를 사용한다.
        // 시퀀스 컨테이너, 연관 컨테이너, 어뎁터 컨테이너라고 분류.

        // 자료구조에는
        // 다음의 구조나 인터페이스를 지원한다.
        // 함수로 표현한다.

        // 넣기. (ex. 삽입)
        // 탐색. ()
        // 확장. ()

        Arr[0] = 0;
        Arr[1] = 1;
        // 배열은 LINQ 지원이 되긴 하지만 함수나 기능이 빈약하기에
        // 사용하기 어렵기 (몰라서)때문에... 일단은 스킵
        // 또한 배열은 프로그램 중간에 확장 기능이 없다.
        // 그렇기 때문에 배열은 별로 좋지 않은 자료구조이다.

        // 이것은 기존 배열을 버리고 새로 배열을 만드는 것이다.
        Arr = new int[15];

        // 만약에 한다면 다른 배열에 복사해서 저장하고
        // 배열의 크기를 늘린 다음, 다시 값을 가져와야 하는
        // 번거로움과 불편함이있다.
        int[] Arr2 = Arr;
        Arr = new int[15];

        // 자료구조 만드는 예시
        MyDataStructure<int> MDS = new MyDataStructure<int>();

        // 100을 넣어줘
        MDS.Push(100);

        // 50을 찾아줘
        MDS.Find(50);

        //// 5000칸으로 늘려줘
        //MDS.Extend(5000);
        // 요즘 자료구조는 자동으로 늘어난다.
        // Push 같은 추가 함수에서 자료구조 크기를 늘려준다.
    }
}
