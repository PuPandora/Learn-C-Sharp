using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Item : IComparable
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public void SetId(int value)
    {
        Id = value;
    }

    // IComparable 인터페이스의 CompareTo 추상 메소드 정의
    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        Item otherItem = obj as Item;
        if (otherItem != null)
            return this.Id.CompareTo(otherItem.Id);
        else
            throw new ArgumentException("Object is not a Item");
    }
}

internal class Program
{
    private static List<Item> items = new List<Item>();
    private static Random random = new Random();
    static void Main(string[] args)
    {
        int targetSpawnCount = 20;
        for (int i = 0; i < targetSpawnCount; i++)
        {
            Item newItem = new Item();
            newItem.SetId(random.Next(0, 100));
            items.Add(newItem);
        }

        Console.WriteLine("=== 생성된 리스트 ===");
        PrintItemsID();

        // items 리스트의 Item 클래스가 IComparable 인터페이스를 상속받아 구현했기에
        // List의 Sort 메소드를 호출하여 정렬이 가능하다.
        // 정렬 방식은 Item 클래스에 사용자가 직접 구현해놓는다.
        // 만약 IComparable을 상속받지 않았다면 예외가 발생한다.
        items.Sort();

        Console.WriteLine("\n=== 정렬된 리스트 ===");
        PrintItemsID();
    }

    static void PrintItemsID()
    {
        int index = 1;

        foreach (Item item in items)
        {
            Console.WriteLine($"{index}번째 아이템의 ID : {item.Id}");
            index++;
        }
    }
}
