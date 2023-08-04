using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _09AbstractClass
{
    abstract class Animal
    {
        protected string name;
        protected string sound;
        protected int age;

        public abstract void Cry();

        // 추상 메소드를 쓰는 이유?
        // 같은 이름, 같은 인자를 강제로 받게 하기 위해?
        // 기능적이라기보다 다른 사람이 사용했을 때
        // 내가 의도한대로 강제하기 위해서?
        abstract public void Introduce();
        // 추상 클래스에서만 추상 메소드 선언 가능

        // 강사님의 답변
        // 추상 클래스, 메소드
        // Ex) 체스.
        // 각 말마다 이동 방식이 다를 때
        // 정해진 메소드 이름과 매개변수로
        // 각 말에 알맞는 이동 방식을 지정해줘서
        // '추상화'를 '구체화'해주게 됨.
    }


    class Dog : Animal
    {
        public override void Cry()
        {
            Console.WriteLine("Bark!");
            
        }
        override public void Introduce()
        {
            Console.WriteLine($"Dog name is {name}");
        }
        public void asdff()
        {
            Console.WriteLine();
        }

    }

    class Cat : Animal
    {
        public override void Cry()
        {
            Console.WriteLine("Meow!");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Cat name is {name}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Cry();
            cat.Cry();

        }
    }
}
