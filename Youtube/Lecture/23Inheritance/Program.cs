using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 방법은
// 공통되는 기능을 하는 멤버변수와
// 멤버함수를 걷어낸다. (이 때 부터 시작한다.)
// 새로운 클래스에 그 모든 멤버변수와 함수를 넣는다.
// 상속시킨다.
// * 특정 클래스만 가지는 것은 걷어내면 안 된다.

class FightUnit
{
    //            public       protected    privfate(Default)
    // 범위       외부까지  /  자식까지  /  나까지

    protected int AT = 10;
    protected int HP = 100;
    /*private*/int PrivateVar = 0;

    public void Damage(/*FightUnit this,*/ FightUnit _OtherUnit)
    {
        // 나는 FightUnit이지만
        // 이 안에서 플레이어의 기능을 쓰고 싶은 것.
        // 다운캐스팅
        // 다운캐스팅은 최대한 지양(피하라)하라.
        // 플레이어를 실수로 몬스터로 변경할 수도 있게 된다.
        //Player OtherPlayer = _OtherUnit;

        // 다운캐스팅을 써야할 순간이 올 수도 있지만
        // 그 외에 방법도 엄청 많다.

        // this.HP -= _OtherUnit.AT;
    }
}

// 내려준다, 상속시킨다고 말합니다. 
// C# 에서 '클래스' 상속이란 오직 하나만 가능하다.
// 상속이 여러개를 받는 언어들도 존재하지만 (대표적 C++)
// C#은 아니다.

// [상속받을 클래스명 : 상속할 클래스명]
// 상속할 클래스가 가진 모든 멤버 변수, 멤버 함수를 가지게 된다.
class Player : FightUnit
{
    int Lv = 1;

    void Heal()
    {
        HP = 100; // protected 제한자라 접근 가능
        //PrivateVar = 10; // 접근 불가
    }
}

class Monster : FightUnit
{
    int Exp = 10;
}

namespace _23Inheritance
{
    // 상속이란
    // 코드 재활용성을 향상시키기 위해서
    // (똑같은 코드 2번 치기 싫다. 함수도 마찬가지)
    // 어떤 계열이 있느냐를 파악하는 감. 

    internal class Program
    {
        static void Main(string[] args)
        {
            // 변환이란 작업을 거치지 않으면
            // 이런일은 발생할 수 없다.,
            //int Value = 500;
            //string strValue = Value;
            // 메모리 구조를 따라간다.

            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();
            //NewPlayer = NewMonster;

            NewPlayer.Damage(NewPlayer);
            
            // NewPlayer를 넣는 것과 다름이 없다.
            // 오히려 메모리 낭비다. FightUnit의 지역변수를 만들기 때문에
            // 의미없는 행동이다.

            // + 상속은 FightUnit + @ 가 Player와 Monster이다.
            // + 플레이어의 부분을 모두 다 포기하겠다.
            // 업캐스팅
            // 자식이 부모형이 되는 것.
            // 그러므로 자식의 능력을 버린다.
            //FightUnit FU = NewPlayer;
            //NewPlayer.Damage(FU);

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}
