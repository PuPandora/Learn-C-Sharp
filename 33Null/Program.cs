using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int mAT;

    public int AT {
        get { return mAT; }
        set { mAT = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        // 가르키는게 없이 비워놓겠다.
        // 참조형의 데이터 구조를 가르키는 자료형들은
        // 클래스
        // new를 하게 되면 Heap에 생성되고 그것을 가르킬 뿐이다.
        // 아무것도 가르키고 싶지 않다면? null을 대입시켜주면 된다.
        Player NewPlayer2 = null;

        Console.WriteLine(NewPlayer.AT);
        Console.WriteLine(NewPlayer2.AT);
    }
}
