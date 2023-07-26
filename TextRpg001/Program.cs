using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 18화] Text RPG 만들기 시작 & 숙제
// https://youtu.be/x7KkH9aoMfM?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

// 클래스는 웬만하면 자기의 일은 스스로 하자.
class Player
{
    int AT = 10;
    int HP = 50;
    int MAXHP = 100;

    public void  StatusRender()
    {
        Console.WriteLine("------------------------------------");
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

namespace TextRpg001
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

                // ConsoleKey CK = Console.ReadKey().key;
                // 리턴되는 함수를 직접 인자값으로 줄 수도 있다.
                // 개인 Style
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        
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

            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle();
                        break;
                }

            }
        }
    }
}
