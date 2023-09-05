using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Node<T>
{
    public Node<T> Next;
    public Node<T> Prev;
}

class MyLinkList<T>
{
    // LinkedList는 First와 Last를 기억하고 있어 바로 전달해줄 수 있다.
    public Node<T> First;
    public Node<T> Last;
}

internal class Program
{
    static void Main(string[] args)
    {
        // 시퀀스 배열형 = 그냥 List
        // 시퀀스 노드형 = LinkedList

        LinkedList<int> LList = new LinkedList<int>();

        // 처음엔 First, Last 의미가 없다.
        LList.AddFirst(10);
        //LList.AddLast(10);

        LList.AddFirst(20);
        LList.AddFirst(33);

        // 33 -> 20 -> 10

        Console.WriteLine("Forward");
        for (LinkedListNode<int> StartNode = LList.First
            ; StartNode != null
            ; StartNode = StartNode.Next)
        {
            Console.WriteLine(StartNode.Value);
        }

        Console.WriteLine("Reverse");
        for (LinkedListNode<int> StartNode = LList.Last
            ; StartNode != null
            ; StartNode = StartNode.Previous)
        {
            Console.WriteLine(StartNode.Value);
        }
    }
}
