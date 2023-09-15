using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# 강의 43화 테트리스 만들기 1차 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=Ygv48IyvADI&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=43&pp=iAQB
// [C# 강의 44화]테트리스 만들기 2차 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=kXz21sPzES8&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=44

internal class Program
{
    static void Main(string[] args)
    {
        TETRISSCREEN newSC = new TETRISSCREEN(10, 15);

        Block NewBlock = new Block(newSC);

        while (true)
        {
            for (int i = 0; i < 50000000; i++)
            {
                int a = 0;
            }
            Console.Clear();
            newSC.Render();
            newSC.Clear();
            NewBlock.Move();
        }

    }
}
