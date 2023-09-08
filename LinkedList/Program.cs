using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 41화]LinkedList 학습 및 응용맵이동 시스템 [어소트락 게임아카데미 게임학원]
// https://www.youtubehttps://youtu.be/TlWw_-oVXlQcom/@AssortRockGameAcademy

class Zone
{
    public string Name = "None";
    public List<Zone> LinkZone = new List<Zone>();

    public Zone (string _Name)
    {
        Name = _Name;
    }
}

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

        // 노드를 관리해주는 자
        // LinkedList<int>;
        // LList.First;
        // LList.Last;
        // 노드 사이사이를 타고 다니는 클래스
        // LinkedListNode<int>

        LinkedList<int> LList = new LinkedList<int>();

        // 처음엔 First, Last 의미가 없다.
        LList.AddFirst(10);
        //LList.AddLast(10);

        LList.AddFirst(20);
        LList.AddFirst(33);

        // 33 -> 20 -> 10

        // 지우는 함수
        LList.Remove(10);
        LList.Remove(30);
        // 첫 번째 노드 삭제
        LList.RemoveFirst();
        // 마지막 노드 삭제
        LList.RemoveLast();
        // 모든 노드 삭제
        LList.Clear();

        LList.AddFirst(50);
        LList.AddFirst(10);
        LList.AddFirst(90);
        LList.AddFirst(70);

        // 노드 중간에에 넣는 함수
        LinkedListNode<int> curNode = LList.First;
        curNode = curNode.Next;
        // 현재 노드 Previous에 추가
        LList.AddBefore(curNode, 8888);
        // 현재 노드 Next에 추가
        LList.AddAfter(curNode, 9999);

        Console.WriteLine("\nForward");
        for (LinkedListNode<int> StartNode = LList.First
            ; StartNode != null
            ; StartNode = StartNode.Next)
        {
            Console.WriteLine(StartNode.Value);
        }

        Console.WriteLine("\nReverse");
        for (LinkedListNode<int> StartNode = LList.Last
            ; StartNode != null
            ; StartNode = StartNode.Previous)
        {
            Console.WriteLine(StartNode.Value);
        }

        // - 노드형 자료구조의 특징
        // 노드형과 배열형의 큰 차이점
        // 배열형은 연결되어 있는 상태이고 (메모리 크기부터 연결)
        // 노드는 서로 개별적인 존재이고 이전과 다음 노드를 가르키기만 하기 때문에
        // 배열형에서 중간 요소에 추가/삭제가 일어날 경우 복잡하고
        // 배열이 클 수록 처리 규모가 커지지만
        // 노드형은 단지 가르키는 방향, 즉 가르키는 노드를 바꿔주면
        // 추가/삭제 작업이 매우 수월하다.

        // 하지만 노드의 특성상 중간에서 시작할 수 없다.
        // 처음에서 다음, 끝에서 이전 같이 처음과 끝에서만 시작할 수 있다.
        // (= 순회할 수만 있다)
    }
}
