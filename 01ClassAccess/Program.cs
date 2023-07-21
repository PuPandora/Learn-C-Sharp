using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 유튜브 내용 따라치기
class Player
{
    // 선언되는 동안 메모리화 (RAM에 올림)
    public int HP; // 외부에도 공개
    protected int Damage; // 자식에게만 공개
    private int Defense; // 이 클래스 내부에만 공개
    
    public void Fight()
    {
        Console.WriteLine($"플레이어는 싸운다! 체력은 {HP}, 대미지는 {Damage}, 방어력은 {Defense}이다!");
    }

    void Drink()
    {
        Console.WriteLine("플레이어는 마신다!");
    }
} // 클래스의 끝

// 응용 코드
class Stock
{
    int ID;
    string Name;
    int Price;
    int OwnedCount = 0;



    public Stock(int SetId, string SetName, int SetPrice, int SetOwnedCount) // 함수 생성 시 함수
    {
        ID = SetId;
        Name = SetName;
        Price = SetPrice;
        OwnedCount = SetOwnedCount;
    }

    public void DisplayStockInformation()
    {
        Console.WriteLine("ID : {0}, Name : {1}, Price : {2:#,0}, OwnedCount : {3}", ID, Name, Price, OwnedCount);
    }

    public void RandomRandom()
    {
        Random rand = new Random();
        rand.NextDouble();

        for (int i = 0; i < 100 ; i++)
        {
            double a = rand.NextDouble();
            Console.WriteLine(a);
        }
    }

}

namespace _01ClassAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player MyPlayer = new Player(); // 객체화, 클래스를 기반으로 만든다.

            MyPlayer.Fight(); // 클래스 메소드 호출
            MyPlayer.HP = 10; // 클래스 맴버변수 접근
            MyPlayer.Fight();

            // MyPlayer.Damage = 10; MyPlayer.Defense = 10;
            // protected, private 접근제한 지정자 조건에 맞지 않아 접근하지 못함.

            // MyPlayer.Drink();
            // 아무런 값이 없다면 기본적으로 private. 위와 같이 접근하지 못함

            Console.WriteLine();

            // AMD라는 객체 만들기
            Stock AMD = new Stock(0, "AMD", 60000, 0);
            AMD.DisplayStockInformation(); // AMD 객체의 메소드 호출

            Stock Intel = new Stock(1, "Intel", 30000, 0);
            Stock NVIDIA = new Stock(2, "Nvidia", 150000, 0);
            Console.WriteLine();
            Intel.DisplayStockInformation();
            NVIDIA.DisplayStockInformation();

            Console.WriteLine();

            // for문을 통한 출력 (함수 호출)
            Stock[] stocks = new Stock[] {AMD, Intel, NVIDIA}; // 객체들 배열화
            for (int i = 0; i < stocks.Length; i++)
            {
                stocks[i].DisplayStockInformation();
            }
        }
    }
}
