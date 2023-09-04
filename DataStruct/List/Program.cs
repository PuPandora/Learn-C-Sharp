using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{

    // 간단하게 만들며 리스트 구조 파악해보기
    class MyList<T>
    {
        int[] Arr = new int[0];
        int Capa = 0;
        int Count = 0;

        public void Add(T _Add)
        {
            if (Count + 1 >= Capa)
            {

            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> NewInt = new MyList<int>();
            NewInt.Add(10);

            // - 기본적인 함수들
            // 넣는 함수
            // 찾는 함수
            // 지우는 함수
            // 확장

            // 배열형
            // 시퀀스

            // 내가 만든 클래스가 아니지만
            // 자료구조가 원래 너무나 자주 쓰이기 때문에
            // C# 언어에서 이미 만들어진 자료구조 클래스이다.
            List<int> NewList = new List<int>();
            // 어느 자료형이든 들어갈 수 있는 제네릭 클래스이다.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((NewList.Count + 1).ToString() + " Add");
                Console.WriteLine("Capacity" + NewList.Capacity); // 배열의 크기
                Console.WriteLine("Count" + NewList.Count); // 자료의 크기
                NewList.Add(i);
                Console.WriteLine();
            }

            // 탐색에는 유리하지 않은 자료구조
            // 하지만 인덱스로 표현할 수 있다면 탐색에 가장 유리한 자료구조다.
            // 내부에 자료가 있는지 없는지 확인 (존재 여부)
            if (NewList.Contains(8))
                Console.WriteLine("내부에 8이 있습니다.");

            if (NewList.Contains(9999))
                Console.WriteLine("내부에 9999가 있습니다.");
            else
                Console.WriteLine("내부에 9999가 없습니다.");

            // 인덱서 혹은 연산자 겹지정이라고 부른다.
            Console.WriteLine(NewList[5]);

            NewList.Remove(10); // 10이 있다면 지운다. 없으면? 못 지운다.

            NewList.RemoveAt(0); // 첫번째(0번째)를 지운다

            // NewList.RemoveAll
            // 다른 리스트 혹은 배열을 넣어줬을 때
            // 비교해서 중복이면 지운다.

            NewList.RemoveRange(0, 4); // 0번째 부터 4개 지운다.

            for (int i =0; i < NewList.Count; i++)
                Console.Write(NewList[i]);

            // 배열과 달리 List는 원하는 것, 원하는 위치를 골라서 제거하거나 추가할 수 있다.

            // List 형을 Array로 바꿔주는 함수
            int[] Arr = NewList.ToArray();

            // System.ArgumentOutOfRangeException
            // * Out Of Range *
            // 자료의 개수로 판단하지
            // 배열의 크기는 중요하지 않다.
            // 가지고 있는 자료 개수의 인덱스를 초과하면 에러가 난다.
            //Console.WriteLine(NewList[999]);
            //Console.WriteLine(NewList[16]);

            // 단순히 편리한 배열형일 뿐이다.
        }
    }
}
