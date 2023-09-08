using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int HP = 100;

    public void Damage(int _Dmg)
    {
        // C#은 어떻게
        // 이 HP가 NewPlayer2의 HP라는걸 알 수 있을까?
        //HP -= _Dmg;

        // 위의 코드와 동일하다.
        // 단지 스킵됐을 뿐이다.
        this.HP -= _Dmg;
    }

    public static void Damage(Player _this, int _Dmg)
    {
        // Static 멤버함수는
        // 객체를 만들지 않고 사용할 수 있으므로
        // 자신이라는 자신이라는 개념이 없는 함수이다.
        // this
        // 그래서 HP (this.HP)를 사용할 수 없는 것이다.

        // 만약에 this라는 기능이 없었다면...
        _this.HP -= _Dmg;
    }
     
    // 멤버함수를 호출할 때
    // "어차피 넣을거 내가 대신 넣어줄게."

    public void Heal(/*Player this, */int _Heal)
    {
        // 멤버함수에서
        // 멤버변수를 쓴다면
        // 눈에 보이지는 않지만
        // 앞에 this.가 생략된 것이다.

        // this.HP라는 것을 잊으면 안되는데


        /*this.*/HP += _Heal;
    }

    // 정적 멤버변수만을 정적 멤버함수에서 사용할 수 있다.
    private static int Sttest = 100;

    public  void PVP (Player _Left, Player _Right)
    {
        // 객체에 영향을 받지 않는 것이
        // 정적 멤버함수의 정적 멤버변수
        // HP = 1000; // 누구의 HP를 뜻하는지 알 수 없음
        Sttest = 50;
    }
}

namespace _16This
{
    // [C# 강의 15화] !중요! this 레퍼런스
    // https://youtu.be/9HtZePD4GuY?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            // Player.PVP(NewPlayer1, NewPlayer2);

            NewPlayer2.Damage(100);
            Player.Damage(NewPlayer2, 100);

            NewPlayer2.Heal(100);
            // 만약 this 기능이 없었다면...
            NewPlayer2.Heal(/*NewPlayer2, */100);

            // 요약 정리
            // static 함수에는 static 변수만을 사용할 수 있다.
            // "자신'(this)이라는 개념이 없기 때문이다.

            // 일반 멤버함수에서는 일반 멤버변수만을 사용할 수 있다.
            // "자신"(this)이라는 개념이 있기 때문에.
        }
    }
}
