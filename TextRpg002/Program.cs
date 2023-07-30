using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 20화]상속 기초
// https://youtu.be/exqTQxQqkUk?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5
// [C# 강의 21화]생성자 & Text RPG 숙제
// https://youtu.be/bh_-kWCvK4w?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

// 코드 재활용성이 떨어진다는 표현을 사용하게 된다.
// 이 코드 재활용성을 향상시키기 위한 문법이
// 상속이다.

// 클래스는 웬만하면 자기의 일은 스스로 하자.

class FightUnit
{
    protected string Name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int MAXHP = 50;

    public void SetName(string _Name)
    {
        Name = _Name;
    }

    public void StatusRender()
    {
        Console.Write(Name);
        Console.WriteLine("의 능력치 ------------------------------------");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);
        Console.WriteLine("------------------------------------");
        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("------------------------------------");
    }
}

class Player : FightUnit
{
    public void Heal(int value)
    {
        HP += value;
        if (HP > MAXHP)
        {
            HP = MAXHP;
        }
    }

    public void MaxHeal()
    {
        // 함수는 비대하지 않을 수록 좋다.
        // 10~5줄 짜리 함수를 만들고
        if (HP >= MAXHP)
        {
            Console.WriteLine("");
            Console.WriteLine("체력이 모두 회복되어있어서 회복할 필요가 없습니다.");
            Console.ReadKey();
        }
        else
        {
            HP = MAXHP;
            PrintHP();
        }
        return;
    }

    public void PrintHP()
    {
        // 그 객체의 맴버변수와 관련된 코드를 2번 이상 치면
        // 함수로 만들어라.
        Console.Write("현재 플레이어의 HP는 ");
        Console.Write(HP);
        Console.WriteLine("입니다.");
    }

    public Player()
    {
        Name = "플레이어";
    }
}

class Monster : FightUnit
{
    // 인자값을 만들어 줄 수도 있다.
    public Monster(string _Name)
    {
        Name = _Name;
    }
}

namespace TextRpg002
{
    internal class Program
    {
        // 에러나 혹은 잘못된 선택에 관한 것도 만든다.
        enum STARTSELECT
        {
            SELECTOWN,
            SELECTBATTLE,
            NONSELECT,
        }

        static void Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨일을 하시겠습니까?");
                Console.ReadKey();
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                // 초반에 프로그래밍의 전부
                // 객체를 선언해야 할 때
                // 함수의 분기
                // 함수의 통홥
                // 함수를 합칠 때와 쪼갤 때가 있다.

                // ConsoleKey CK = Console.ReadKey().key;
                // 리턴되는 함수를 직접 인자값으로 줄 수도 있다.
                // 개인 Style
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        // Player 클래스의 체력을 어떻게든 채우는 코드
                        //_Player.Heal(100);
                        _Player.MaxHeal();
                        //_Player.PrintHP();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:

                    case ConsoleKey.D3:
                        break;
                    default:
                        break;
                }
            }
        }

        static void Battle()
        {
            Console.WriteLine("아직 개장하지 않았습니다.");
            Console.ReadKey();
        }

        static STARTSELECT StartSelect()
        {
            // 분명히 있다.
            // 분명히 있다. // 분명히 있다. // 분명히 있다. // 분명히 있다. // 분명히 있다. // 분명히 있다. 
            // 없을리가 없다.
            // 내가 못찾으면 내가 능력이 부족한거다.
            // 나는 콘솔 화면을 모조리 지우는 함수를 찾고 싶다.
            // 인터넷 어딘가에 내가 며칠을 짜서 만든 것 보다
            // 더 빠르고 더 좋은 함수가 분명히 존재할 것이다.

            // 프로그래머들은 대부분 이성적이고
            // 이름을 엉망진창으로 짓지 않는다.
            // 쉽고 간결한 이름을 쓴다.
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("어디로 가시겠습니까?");
            // return이란 리턴이 되는순간
            // 함수를 완전히 종료시킨다.
            // 즉 리턴을 한 번 했다면 그 아래
            // 아무리 많은 코드가 있어도
            // 사용이 없다.

            ConsoleKeyInfo CKI = Console.ReadKey();
            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.ReadKey();
                    return STARTSELECT.SELECTOWN;
                case ConsoleKey.D2:
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    return STARTSELECT.NONSELECT;

            }
        }

        static void Main(string[] args)
        {
            // 객체지향 프로그래밍이란
            // 결국. 클래스로 설게하고
            // 객체로 만들어 나가는 것.

            Player NewPlayer = new Player();
            Monster NewMonster = new Monster("오크");

            // ** 둘 중 누군가 죽을 때 까지 싸우는 기능 구현 숙제
            while(/*둘 중 누군가 죽을 때 까지*/true)
            {
                NewPlayer.StatusRender();
                NewMonster.StatusRender();
                // 1. 죽을 때 까지 싸우게 만들어라
                // 1-1. 권장, 플레이어 한대, 몬스터 한대
                // 2. 한 쪽이 죽으면(나간다) 마을로 자동 이송
                // 2-1. 그냥 나간다.
                // 2-2. 마을로 나간다.

                // 한 번에 모든 걸 끝낼려고 하는 것 보다
                // 쪼개서, 분리해서 구현

                // 상속은 객체지향에서 매우 필수적인 개념이다.
                // 꼭 외워라. 계속 응용해보아라.

                // 가장 기본적인 것이 되면 그 다음부터 하라.
                // 가장 단순한 부분부터 만들어가라.
                // 수단과 방법을 가리지 않고 (구현)
                // 싸우게 만들어보기.
                Console.ReadKey();
            }

            //while (true)
            //{
            //    STARTSELECT SelectCheck = StartSelect();

            //    switch (SelectCheck)
            //    {
            //        case STARTSELECT.SELECTOWN:
            //            Town(NewPlayer);
            //            break;
            //        case STARTSELECT.SELECTBATTLE:
            //            Battle();
            //            break;
            //    }

            //}
        }
    }
}
