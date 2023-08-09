using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected string Name = "";
    protected int AT = 10;
    int HP = 100;

    public void Damage(FightUnit _OtherFightUnit)
    {
        int AT = _OtherFightUnit.DMGAT;
        Console.WriteLine(_OtherFightUnit.Name + "에게 " + AT + "만큼의 대미지를 입었습니다.");
        HP -= AT;
    }

    // Player의 아이템에 따라 공격력을 증가시킬려고 하면
    // 오버로딩을 쓸 경우
    //public void Damage(Player _OtherFightUnit)
    //{
    //    Console.WriteLine(_OtherFightUnit.Name + "에게 " + _OtherFightUnit.AT + "만큼의 대미지를 입었습니다.");
    //    HP -= _OtherFightUnit.AT + _OtherFightUnit.ItemAT;
    //}

    //public void Damage(FightUnit _OtherFightUnit, int _DamagePlus)
    //{
    //    Console.WriteLine(_OtherFightUnit.Name + "에게 " + _OtherFightUnit.AT + _DamagePlus + "만큼의 대미지를 입었습니다.");
    //    HP -= AT + _DamagePlus;
    //}

    // 공격력을 끌어오는 방식이 달라 발생하는 문제
    // 오버로딩으로 구현하기에는 비효율적이다.

    // 상속의 개념은 코드의 재활용성(적게 치기)을 위해서인데
    // 오히려 함수를 많이 작성하면 의도와 다르게 된다.


    // 이 문법의 핵심
    // 자식에서 만약 나의 GetAT를 재구현했다면
    // 자식의 GetAT를 호출해 주세요.
    // 이것을 오버라이딩(Overriding)
    // 다향성 (동적바인딩)의 핵심 문법 중 하나이다.

    // 부모는 자식에게만 있는 내용을 전혀 알지 못한다.
    // FightUnit을 상속한 클래스면 다향성으로 받아
    // 업캐스팅으로 넘어오며, 자식이 가지고 있는 내용을 버리고 온다.
    // 그 때 사용되는 것이 virtual, override
    public virtual int GetAT()
    {
        Console.WriteLine("FIGHTUNIT의 GETAT");
        return AT;
    }

    // Virtual은 private 제한자가 될 수 없다.
    // 자식 클래스에서 Override는 부모의 Virtual와 온전히 동일해야 한다.
    protected virtual int TestVirtual(int _Value)
    {
        return AT;
    }

    // Property는 Virtual, Override가 가능하다.
    public virtual int DMGAT
    {
        get
        {
            return AT;
        }
    }

    //public static virtual void Test()
    //{
    //    // this가 없기에(static 이기에) virtual을 할 수 없다.
    //}
}

class Player : FightUnit
{
    public int ItemAT = 5;
    public Player(string _Name)
    {
        Name = _Name;
    }

    // 나는 부모의 GetAT()를 재구현 했다.
    public override int GetAT()
    {
        Console.WriteLine("플레이어의 GETAT");
        return AT;
    }
    public override int DMGAT
    {
        get
        {
            Console.WriteLine("플레이어의 DMGAT");
            return AT + ItemAT;
        }
    }

    protected override int TestVirtual(int _Value)
    {
        return _Value;
    }
}

class Monster : FightUnit
{
    int MonsterLv;

    public Monster(string _Name, int _MonsterLv)
    {
        Name = _Name;
        MonsterLv = _MonsterLv;
    }

    public override int GetAT()
    {
        Console.WriteLine("몬스터의 GETAT");
        return AT + MonsterLv;
    }

    public override int DMGAT
    {
        get
        {
            Console.WriteLine("몬스터의 DMGAT");
            return AT;
        }
    }
}

class Overriding
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player("플레이어");
        Monster NewMonster = new Monster("몬스터", 2);
        // FightUnit NewFightUnit = new FightUnit();

        // 업캐스팅
        //FightUnit NewUnit = NewMonster;

        //NewPlayer.GetAT();
        NewPlayer.Damage(NewMonster);
        NewMonster.Damage(NewPlayer);

        // *뭔가 추상적으로 이해돼서 정리*
        // 상속의 빈틈인 자식 클래스의 내용을 모른다는 것을
        // GetSet 문법을 virtual, override 문법을 사용하여

        // 업캐스팅 했을 때 호출할 수 있도록 (FightUnit 타입을 매개변수로 받는 함수일 때)
        // 부모 클래스의 함수, 자식 클래스 함수 이름을 같게하고
        // 부모는 virtual, 자식은 override하여
        // 만약 자식에게 override(재구현)된 함수가 있다면 
        // 그것을 호출하도록 한다.
        // ex) 플레이어와 몬스터의 공격력 산출 방식이 다를 경우에 사용

        // 핵심
        // 만약 자식에서 나의 [같은 이름의 함수나 프로퍼티]를 재구현 했다면
        // 자식 형태의 [같은 이름의 함수나 프로퍼티]를 호출하세요.
        // 이것이 Overriding

        // + 생성자는 Virtual, Override 할 수 없다.
        // + Property는 Virtual, Override 할 수 있다.
    }
}
