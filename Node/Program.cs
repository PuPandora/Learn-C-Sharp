using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//[C# 강의 41화]LinkedList 학습 및 응용맵이동 시스템 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=TlWw_-oVXlQ&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=41&pp=iAQB

// 노드는 단순히 자료구조에서만 사용하는 것은 아니다.
class Node<T>
{
    public T Data;

    // 자신안에 자기 자신을 또 가지는 형태로
    // 되어있는 클래스를 노드라고 할 수 있다.
    public Node<T> Next = null;
    public Node<T> Prev = null;

    public Node(T _Data)
    {
        Data = _Data;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Node<int> Node1 = new Node<int>(10);
        Node<int> Node2 = new Node<int>(999);
        Node<int> Node3 = new Node<int>(578);

        // 노드1 -> 노드2 -> 노드3 참조하는 구조
        Node1.Next = Node2;
        Node2.Next = Node3;

        // 노드3 -> 노드2 -> 노드1
        Node3.Prev = Node2;
        Node2.Prev = Node1;

        // 현재 노드 변수
        Node<int> CurNode = Node1;
        while (CurNode != null)
        {
            Console.WriteLine(CurNode.Data);
            CurNode = CurNode.Next;
        }

        Console.WriteLine();

        // 반대로 진행되는 노드도 가능하다
        Node<int> RCurNode = Node3;
        while (RCurNode != null)
        {
            Console.WriteLine(RCurNode.Data);
            RCurNode = RCurNode.Prev;
        }

        // 연결되어 있는 노드형 자료구조
    }
}
