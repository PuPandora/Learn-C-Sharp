using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int HP = 100;
    private int AT = 10;

    // 객체화를 하지 않아도 Player 클래스 내부이므로
    // Player 클래스 내부에서만큼은 접근 제한 지정자에서 자유롭다.
    // 아마 Private 조건에 이미 포함되어 있어서?)
    static public void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }

    public void Damage(Monster _Other)
    {
        // HP -= _Other.AT(); 문법 오류, 접근 보호수준 오류
    }

    public void Damage(Player _Other)
    {
        // 자기자신의 레퍼런스는 자신의 내부에서
        // 모두 Public인 상태이다.
        HP -= _Other.AT;
    }

    static public void PVE(Player _Me, Monster _Enemy)
    {
        // _Enemy.HP -= _Me.AT; 보호 수준 오류
    }
}

class Monster
{
    private int HP = 100;
    private int AT = 10;
}

namespace _14StaticFunc
{
    // [C# 강의 14화] static 함수 & static class
    // https://youtu.be/OP0Io2YpyWQ?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

    internal class Program
    {
        // Main도 클래스에 속한 정적 함수이다.
        // 어떤 클래스에 존재하는 Main의 이름을 가진
        // 정적 멤버 함수에서 C# 프로그램은 시작한다.
        static void Main(string[] args)
        {
            Console.WriteLine("Static 함수 배우고 있어요.");

            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            Player.PVP(NewPlayer1, NewPlayer2);
        }
    }
}
