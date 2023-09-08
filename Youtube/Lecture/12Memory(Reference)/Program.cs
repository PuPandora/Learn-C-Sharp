using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 메모리 힙 영역에 생성되는 멤버 변수
    public int HP = 100;
    public int AT = 10;

    // Monster 클래스가 객체화된 것을 받는다.
    // 레퍼런스 형을 인자값으로 받는다.
    public void Attack(Monster _Monster)
    {
        _Monster.HP -= AT;
    }
}

class Monster
{
    public int HP = 100;
    public int AT = 10;

    public void Attack(Player _Player)
    {
        _Player.HP -= AT;
    }
}

namespace _12Memory_Reference_
{
    // [C# 강의 12화] !중요! 레퍼런스의 메모리 구조 및 처리 개념
    // https://www.youtube.com/watch?v=Cq4olyGLk3g&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=12&t=368s&pp=iAQB

    internal class Program
    {
        static void Main(string[] args)
        {
            // 값형과 래퍼런스 형을 구분할 줄 알아야 한다.
            // 기본 자료형을 선언만 하면 그것은 값형이다.

            // 자기가 만든 클래스를 new 클래스명();
            // 이렇게 만든 것을 그 클래스명에 받으면 그것은 래퍼런스 형이다.

            // 클래스가 객체화 된 것은 레퍼런스 형이라고 한다.
            // 실체는 힙 영역에 생성된다.

            // 기본 자료형인 int, bool, float 이러한 자료형들은
            // 값형이라고 한다.

            // 레퍼런스는 "힙" 영역에 생성된 어떠한 메모리의 위치(주소)를 가르키는 값.

            // Player 설계도로 객체를 만들고
            // 객체의 크기는 Player 클래스에 있는 변수와 함수 크기의 크기를 가진다. (각각)
            // 이것이 힙 영역에 생성되어 NewPlayer는 레퍼런스 형이 된다.

            // HP 100, ATT 10
            Player NewPlayer = new Player();

            // HP 100, ATT 10
            Monster NewMonster = new Monster();

            // 힙 영역에 있는 NewPlayer의 HP 주소의 값을
            // 힙 영역에 있는 NewMonster의 AT 주소의 값만큼 깎겠다.
            // (100 - 10)
            NewMonster.Attack(NewPlayer);
            NewPlayer.Attack(NewMonster);
        }
    }
}
