using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class Singleton
{
    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
    private static Singleton instance = null;

    public Object Object1 = new Object();
    public Object Object2 = new Object();

    private List<Object> objects = new List<Object>();

    public void Initialize()
    {
        objects.Add(Object1);
        objects.Add(Object2);

        Object1.Name = "캔";
        Object1.Value = 5;
        Object1.SetPos(3.2f, 4.7f);

        Object2.Name = "물병";
        Object2.Value = 7;
        Object2.SetPos(5.1f, 2.46f);
    }

    public void PrintObjectsInfo()
    {
        foreach (Object obj in objects)
        {
            obj.PrintInfo();
            Console.WriteLine("===== ===== ===== =====\n");
        }
    }
}

public class Object
{
    public float PosX { get { return posX; } }
    public float PosY { get { return posY; } }

    public string Name;
    public int Value;
    private float posX = 0;
    private float posY = 0;

    public void PrintInfo()
    {
        Console.WriteLine($"이름 : {Name}");
        Console.WriteLine($"가치 : {Value}");
        Console.WriteLine($"- 위치\nx : {posX}\ny : {posY}");
    }

    public void SetPos(float x, float y)
    {
        posX = x; posY = y;
    }

    public void SetXPos(float x)
    {
        posX = x;
    }

    public void SetYPos(float y)
    {
        posY = y;
    }

    public void MoveRight()
    {
        Console.WriteLine($"{Name} 오른쪽으로 1만큼 이동!\n");
        posX += 1;
    }

    public void MoveLeft()
    {
        Console.WriteLine($"{Name} 왼쪽으로 1만큼 이동!\n");
        posX -= 1;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Singleton.Instance.Initialize();
        Singleton.Instance.PrintObjectsInfo();

        Singleton manager = Singleton.Instance;
        manager.Object1.MoveRight();
        manager.Object2.MoveLeft();

        manager.PrintObjectsInfo();
    }
}
