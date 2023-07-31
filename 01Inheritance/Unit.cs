using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Unit
{
    protected string Name = "None";
    protected int Level = 0;
    protected int Dmg = 0;
    protected int HP = 0;
    protected int MaxHP = 0;

    // protected 함수 Main에서 접근 불가
    public void PrintStatus()
    {
        Console.WriteLine($"{Name}의 정보 ---------------------");
        Console.WriteLine($"LV. {Level}");
        Console.WriteLine($"DMG : {Dmg} ");
        Console.WriteLine($"HP : {HP} / {MaxHP}");
        Console.WriteLine("---------------------------------\n\n");
    }

    public void Battle(Unit otherUnit)
    {
        this.HP -= otherUnit.Dmg;
        otherUnit.BattleMessage();
        this.PrintStatus();

        otherUnit.HP -= this.Dmg;
        BattleMessage();
        otherUnit.PrintStatus();
    }

    public void BattleMessage()
    {
        Console.WriteLine($"{this.Name}의 공격, {this.Dmg}만큼의 대미지를 입혔다.");
    }

    public void BattleUntilDead(Unit otherUnit)
    {
        while(this.HP > 0 && otherUnit.HP > 0)
        {
            Battle(otherUnit);
        }
    }

    public Unit(string name, int dmg, int hp, int maxHp, int level)
    {
        this.Name = name;
        this.Dmg = dmg;
        this.HP = hp;
        this.MaxHP = maxHp;
        this.Level = level;
    }
}

internal class UnitBuilder
{

}
