using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열형
            // 시퀀스

            // 내가 만든 클래스가 아니지만
            // 자료구조가 원래 너무나 자주 쓰이기 때문에
            // C# 언어에서 이미 만들어진 자료구조 클래스이다.
            List<int> NewList = new List<int>();
            // 어느 자료형이든 들어갈 수 있는 제네릭 클래스이다.

            for (int i =0; i < 10; i++)
            {
                Console.WriteLine((NewList.Count + 1).ToString() + " Add");
                Console.WriteLine("Capacity" + NewList.Capacity); // 배열의 크기
                Console.WriteLine("Count" + NewList.Count); // 자료의 크기
                NewList.Add(i);
                Console.WriteLine();
            }
        }
    }
}
