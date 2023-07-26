using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Static

class Monster
{
    // 몬스터가 100마리 죽었을 때 무언가 할려고 할 때
    // 안 좋은 예시
    // 각 객체에 MonsterDeathCount가 생기고
    // 각 객체의 MonsterDeathCount가 감소한다.
    int MonsterDeathCount;

    public void Death()
    {
        MonsterDeathCount++;
    }
}

class Player
{
    // 일반 멤버변수와 다른 static이 붙은 정적 멤버변수
    // 다른 클래스에서 객체화하지 않고 사용할 수 있다.
    // [클래스명.변수명] 으로 사용할 수 있다.
    public static int PlayerCount = 0;

    public int AT = 10;
    public int HP = 100;

    public void Setting(int _AT, int _HP)
    {
        AT = _AT;
        HP = _HP;
    }
}

namespace _13StaticVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 정적 멤버변수는 데이터 영역에 생성된다.
            // 객체를 아무리 만들어도
            // 정적 멤버는 그 객체와의 관련성은
            // 객체 내부에서 사용할 수 있다 뿐이지
            // 객체의 개수만큼 만들어지는 것은 아니다.
            // 즉 모든 객체가 공유하는 하나의 변수가 되어준다.

            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 3;

            // 객체들은 정적 멤버변수를 사용할 수 없다.
            // NewPlayer3.PlayerCount = 0; // 불가능

            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            NewMonster1.Death();
            NewMonster2.Death();
            NewMonster3.Death();
        }
    }
}
