using System;
using System.Collections.Generic;

// 다형성 (Polymorphism)
namespace _05_Polymorphism
{
    class Unit
    {
        public string name = "Unknown";

        // virtual : 상속 받는 클래스에서 이 함수를 재정의 할 수 있다.
        public virtual void WhichClassMethod()
        {
            Console.WriteLine("Unit 클래스의 메소드!");
        }

        public void M()
        {
            Console.WriteLine("Unit 클래스의 메소드!");
        }
    }

    class Player : Unit
    {
        public new string name = "Player000";
        public int id = 000;

        // override : 부모 클래스의 virtual 메소드를 재정의 한다.
        public override void WhichClassMethod()
        {
            Console.WriteLine("Player 클래스의 메소드!");
        }

        public new void M()
        {
            Console.WriteLine("Player 클래스의 메소드!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 자식 클래스 객체를 부모 클래스 객체 취급을 할 수 있다.
            Unit newUnit = new Unit();
            Player newPlayer = new Player();

            // 반대로 부모 객체를 자식 객체로 취급할 수는 없다.
            //newPlayer = newUnit; // 컴파일 에러
            newUnit = newPlayer; // newPlayer가 참조하는 곳을 newUnit도 동일한 곳을 가르킨다.
            newUnit = new Unit(); // 초기화

            // 2. 부모 클래스의 객체에 자식 클래스 객체를 대입할 수 있다.
            Unit newUnit2 = new Player(); // 변수 자료형은 당연하게도 Unit이다.
            //Player playerUnit2 = new Unit(); // 컴파일 에러

            // 3. 메소드로 객체를 받을 때
            void SendUnit(Unit unit)
            {

            }

            void SendPlayer(Player player)
            {

            }

            // 메소드가 부모 클래스 객체를 요구하는 경우
            // 자식 객체도 들어갈 수 있다
            SendUnit(newUnit);
            SendUnit(newPlayer); // 자식 객체가 대신 들어갈 수 있다.
            //SendPlayer(newUnit); // 컴파일 에러
            SendPlayer(newPlayer);

            Console.WriteLine("\n===== ===== 4. Override ===== =====\n");

            // 4. Override
            // Override는 Unit, Player 클래스의 WhichClassMethod 메소드 참조

            Unit newUnit3 = new Unit();
            Player newPlayer3 = new Player();
            Unit newUnitPlayer = new Player();

            newUnit3.WhichClassMethod(); // Unit 클래스의 메소드!
            newPlayer3.WhichClassMethod(); // Player 클래스의 메소드!
            // override 메소드의 경우 자식 클래스의 메소드 호출
            newUnitPlayer.WhichClassMethod(); // Player 클래스의 메소드!

            Console.WriteLine("\n===== ===== 5. New ===== =====\n");

            // 5. new
            newUnit3.M(); // Unit
            newPlayer3.M(); // Player
            // New 키워드로 메소드를 작성할 경우 부모 클래스 메소드 호출
            newUnitPlayer.M(); // Unit
        }
    }
}
