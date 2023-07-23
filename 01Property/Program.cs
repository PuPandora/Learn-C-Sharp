using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01Property
{
    class Player
    {
        // Field
        private float money = 0;

        // Property
        public string Name { get; set; } = "AAA";
        public int HP { get; set; } = 0;
        public int DMG { get; set; } = 0;
        private int DEF { get; set; } = 0;
        // 프로퍼티, set 조건
        public float Money
        {
            get
            {
                return money;
            }
            set
            {
                // 0보다 크거나, 100,000 보다 작을 경우만 set 가능
                if (value > 0 && value < 100000)
                    money = value;
            }
        }

        public void DisplayPlayerInfo()
        {
            // 기본 값이 설정되어있지 않을 때 접근하면 에러가 떠버림
            Console.WriteLine($"이름 : \"[{Name}]\"\nHP : [{HP}]\nDMG : [{DMG}]\nDEF : [{DEF}]\n소지금 : [{Money}]\n\n");
        }

        public void DisplayPlayerMoney()
        {
            Console.WriteLine($"[{Name}]의 소지 금액은 [{money}]G 입니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작");

            Player newPlayer = new Player();
            newPlayer.DisplayPlayerInfo();

            Console.WriteLine("newPlayer 클래스 멤버변수 값 변경\n");

            newPlayer.Name = "용사";
            newPlayer.HP = 100;
            newPlayer.DMG = 10;
            newPlayer.Money = 100.3141592f;

            // newPlayer.DEF = 50; // private 제한자라 접근 불가
            newPlayer.DisplayPlayerInfo();

            // Property Get
            float playerMoney = newPlayer.Money;
            Console.WriteLine("float playerMoney = newPlayer.Money;");
            Console.WriteLine($"Program 클래스의 playerMoney 변수의 값은 : {playerMoney}\n\n");

            Console.WriteLine($"NewPlayer.Money + 255 = {newPlayer.Money + 255}\n\n");
            // 다른 클래스에 있는 값을 가져와서 대입하거나 사용이 가능하다


            // Property Set
            // 만약 Property의 Set 조건이 맞지 않는 값을 넣음면 변경되지 않음
            Console.WriteLine("Money 값 -100, 21470000으로 변경 시");
            newPlayer.Money = -100;
            newPlayer.DisplayPlayerMoney();
            newPlayer.Money = 21470000;
            newPlayer.DisplayPlayerMoney();
            // Property 조건에 맞는 값을 넣을 경우 변경 됨
            Console.WriteLine("\nMoney 값 500으로 변경 시");
            newPlayer.Money = 500;
            newPlayer.DisplayPlayerMoney();

            // 이런 방식으로 원하는 조건으로 세팅을 하도록 하거나
            // get이나 set만 적용하여 값을 불러오거나, 세팅하게만 할 수 있다.
            // private의 경우 이 클래스에선 하지 못하고, 해당 클래스에서만 접근이 가능하다.
        }
    }
}