using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int ATProperty
    {
        get
        {
            if (AT > 20)
            {
                Console.WriteLine("20 이상입니다.");
                return AT;
            }
            else
            {
                Console.WriteLine("19 이하는 get 할 수 없습니다.");
                return 0;
            }
                
        }
        set
        {
            if (value > 30)
            {
                Console.WriteLine("31 이상은 set 할 수 없습니다.");
                return;
            }

            else if (value < 30)
                AT = value;
        }
    }
    private int AT = 10;
    public float HpPercent;

    public int hp
    {
        get
        {
            return _hp;
        }
        set
        {
            if (value < 0)
                value = 0;

            _hp = value;
        }
    }
    private int _hp = 100;


    public int readOnly { get; }

    int GetAT()
    {
        return AT;
    }

    void SetAT(int _value)
    {
        AT = _value;
    }

    public int GetHp()
    {
        return _hp;
    }

    public void SetHp(int _value)
    {
        _hp = _value;
    }

    public void AddHP(int _value)
    {
        _hp = _hp + _value;
    }
}

public class Monster
{
    public int AttackDamage = 10;
}

namespace _26Property
{
    internal class Property
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            /*
            Console.WriteLine(NewPlayer.ATProperty); // << Get
            NewPlayer.ATProperty = 32; // << Set
            */
            NewPlayer.hp = 5;
            int hp = NewPlayer.GetHp();
            Console.WriteLine(hp);
            NewPlayer.SetHp(150);
            Console.WriteLine(NewPlayer.GetHp());

            // get
            Console.WriteLine(NewPlayer.hp);
            // set
            NewPlayer.hp = 170;
            // get
            Console.WriteLine(NewPlayer.hp);

            // return 값으로 활용할 때는 get 함수가 실행되고
            // 값을 대입할 때는 set 함수가 실행된다.
            // 값을 가져올 때 : get
            // 값을 수정할 때 : set

            Monster newMonster = new Monster();

            NewPlayer.hp -= newMonster.AttackDamage;
            NewPlayer.HpPercent = (float)NewPlayer.hp * 0.01f;
            NewPlayer.hp = (int)NewPlayer.HpPercent;
        }
    }
}
