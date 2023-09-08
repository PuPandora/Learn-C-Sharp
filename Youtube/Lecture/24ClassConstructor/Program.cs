using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected int AT;

    public FightUnit()
    {

    }
}

class Player : FightUnit
{
    // 클래스 생성자
    // 만들어 질 때 한번 실행되어주는 함수

    // 눈에 보이지 않지만, 만들지 않아도
    // 이 함수는 만들어진다.
    // 무조건 자신의 클래스의 메모리를 티너해주는 함수이다.
    private Player()
    {
        AT = 100;

        int Number = 0;
    }
}

namespace _24ClassConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 생성자를 private으로 할 경우
            // 의미가 있다.
            Player NewPlayer = new Player();
        }
    }
}
