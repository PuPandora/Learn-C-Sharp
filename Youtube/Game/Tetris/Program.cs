using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# 강의 43화 테트리스 만들기 1차 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=Ygv48IyvADI&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=43&pp=iAQB

enum TBLOCK
{
    WALL,
    VOID,
    BLOCK,
}

internal class Program
{
    static void Main(string[] args)
    {
        TScreen newSC = new TScreen(10, 15);

        Block NewBlock = new Block();

        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                newSC.SetBlock(y, x, TBLOCK.BLOCK);
            }
        }

        newSC.Render();
    }
}
