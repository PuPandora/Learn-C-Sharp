using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Node
{
    public Node next;
    public Node previous;
    public int value;
}

public class LinkedList
{
    public Node first;
    public Node last;

    public void AddFirst(Node node)
    {
        // first 없냐
        if (first == null)
        {
            first = node;
            
            if (last == null)
            {
                last = node;
            }
        }
        // first 가 있다
        else
        {
            Node temp = first; // 기존 First를 저장
            first = node; // First 교체
            first.next = temp; // 저장한 노드를 First의 Next로 지정
            temp.previous = first; // 기존 First의 Previous를, 새 First로 지정
        }
    }

    public void AddLast(Node node)
    {
        // last 없냐
        if (last == null)
        {
            last = node;

            if (first == null)
            {
                first = node;
            }
        }
        // last 가 있다
        else
        {
            Node temp = last; // 기존 Last를 저장
            last = node; // Last 교체
            temp.next = last; // 기존 노드의 Next를 Last로 지정
            last.previous = temp; // 새 Last의 Previous를, 기존 Last로 지정
        }
    }

    public bool Contains(Node targetNode)
    {
        Node curNode = first;
        while (curNode != null)
        {
            if (curNode == targetNode)
            {
                return true;
            }
            else
            {
                curNode = curNode.next;
            }
        }
        return false;
    }

    public void Print()
    {
        Node curNode = first;
        int index = 0;

        while (curNode != null)
        {
            Console.WriteLine($"{index + 1}번 노드의 값은 : {curNode.value}");
            curNode = curNode.next;
            index++;
        }
    }

    public void ReversePrint()
    {
        Node curNode = last;
        int index = 0;

        while (curNode != null)
        {
            Console.WriteLine($"{index + 1}번째 반복의 노드의 값은 : {curNode.value}");
            curNode = curNode.previous;
            index++;
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        LinkedList myLinkedList = new LinkedList();

        for (int i = 0; i < 5; i++)
        {
            Node instantNode = new Node();
            instantNode.value = i;

            myLinkedList.AddLast(instantNode);
            // 4, 3, 2, 1, 0
            // 0, 1, 2, 3, 4
        }

        myLinkedList.Print();
        myLinkedList.ReversePrint();

        // 자료구조는 여러가지가 있는 만큼
        // 다양한 특징, 장점, 단점이 있다.
        // 어느 상황에서 어떤 자료구조를 써야 유리한지 이해하고 말할 수 있다가
        // "자료구조를 알고있다." 라는 것이다.
    }
}
