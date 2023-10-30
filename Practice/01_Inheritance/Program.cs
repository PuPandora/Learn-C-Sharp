using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player : Unit
{
    // 상속되는 클래스에서 선언 및 초기화 정보를 받고
    // 이 클래스의 멤버 변수와 함수(+생성자)를 실행한다 

    int Karma = 0;
    int Gold = 0;

    // 상속 부모의 생성자를 호출할려면
    // 상속 문법과 동일하게 생성자 뒤에
    // : base(매개변수)를 사용한다.
    public Player(string name, int dmg, int hp, int maxHp, int level) : base(name, dmg, hp, maxHp, level)
    {

    }
}

class Monster : Unit
{
    int Exp;
    int DropGold;

    public Monster(string name, int dmg, int hp, int maxHp, int level) : base(name, dmg, hp, maxHp, level)
    {
        this.Name = name;
    }
}

namespace _01Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("용사", 10, 100, 100, 5);
            Monster NewMonster = new Monster("오크", 5, 50, 50, 3);

            NewPlayer.PrintStatus();
            NewMonster.PrintStatus();

            NewPlayer.BattleUntilDead(NewMonster);

        }
    }
}
