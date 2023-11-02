using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 식 본문(형식) 멤버
// C# 6.0
namespace _11_ExpressionBodiedMember
{
    class Player
    {
        public string name = "용사";

        // 일반적인 메소드 정의
        public void PrintName()
        {
            Console.WriteLine($"이름 : {name}");
        }
        // "=>"를 활용한 메소드 정의
        public void PrintName2() => Console.WriteLine($"이름 : {name}");
        // 하나의 식만 있을 경우 간편하게 정의할 수 있다
    }

    class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        // 값을 반환하는 메소드의 경우
        public int Add2(int a, int b) => a + b; // return 생략
    }

    class Monster
    {
        // 프로퍼티 문법에 활용
        // C# 7.0

        // 기존 방식
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // 식을 활용한 방식
        private string name2;
        public string Name2
        {
            get => name2;
            set => name = value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            new Player().PrintName2();
        }
    }
}
