using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 37화]레퍼런스 2차 & 디버깅 방법 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=XWAeiNHKVsk&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=37&pp=iAQB

class Player
{
    public int HP = 100;
    public int AT = 10;
}

internal class Program
{
    static void Main(string[] args)
    {
        // Player NewPlayer 변수는 할 수 있는 일이
        // 어떤 녀석을 가르키는 일 밖에 하지 못한다.

        Player NewPlayer = new Player();
        NewPlayer.AT = 50;
        Console.WriteLine(NewPlayer.AT);

        NewPlayer = new Player();
        Console.WriteLine(NewPlayer.AT);
    }
}
