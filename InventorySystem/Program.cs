using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 32화]인벤토리 만들기 1부+ null 레퍼런스 설명 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=IuibSYe6qV0&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=32&pp=iAQB

class Program
{
    static void Main(string[] args)
    {
        // *****
        // *****
        // *****
        Inven NewInven = new Inven(5, 3);

        while (true)
        {
            Console.Clear();
            NewInven.Render();
            Console.ReadKey();
        }
    }
}
