using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 30화]인터페이스 [어소트락 게임아카데미 게임학원]
// https://youtu.be/qotJ9OcNsPU?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

// 클래스는 상속을 하나밖에 하지 못하는 점을 보완한 문법
// 인터페이스 또한 사용자 정의 자료형이다.

// *핵심*
// 인터페이스는 함수의 선언만 하고
// 인터페이스를 상속 받는 것은
// 반드시 동일한 이름의 함수를 구현(정의)해줘야한다.
interface QuestUnit
{
    // 멤버 변수 선언불가능
    //int A = 0;

    // 함수의 형태만 물려 줄 수 있는 문법이다.
    // 함수 정의 불가능
    // private 사용 불가능
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);
}

interface QuestUnit2
{
    // 다른 인터페이스, 같은 이름의 함수
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);
}

class SkillUnit
{
    int AT;
    // C#에서 다중상속을 막은 이유
    // 이름이 겹치는 경우가 있기에
}

class FightUnit
{
    int AT;
    int DMG;

    public void Damage(int _Damage)
    {

    }
}

class Player : FightUnit, QuestUnit, QuestUnit2
{
    // 인터페이스 함수는 public이어야 한다.
    public void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
}

class Monster : FightUnit
{

}

// 인터페이스는 함수 구현을 강제할 수 있다.
class NPC : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
}

internal class Interface
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();
        // 가진 속성이 없으니 만들 수 없다.
        //QuestUnit NewQuestUnit = new QuestUnit();
        
        // 받을 수는 있다.
        QuestUnit NewQuestUnit = NewNPC;

        // 업캐스팅이 가능하다.
        NewPlayer.Talk(NewNPC);
        NewNPC.Talk(NewPlayer);
    }
}
