using System;

namespace _04_Func
{
    public class MyClass
    {
        // 매개변수가 있는 대리자 객체 생성
        // int 매개변수 2개를 받고
        // int 자료형을 반환하는 대리자
        public event Func<int, int, int> OnCalculate;

        public void Calculate(int a, int b)
        {
            // 체인이 걸린 메소드가 있다면
            if (OnCalculate != null)
            {
                // OnCalculate 객체에 체인이 걸린 메소드를 a, b를 전달하며 실행
                int result = OnCalculate(a, b);
                Console.WriteLine($"Result : {result}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            // a, b가 매개변수로 와서 반환 값으로 a + b 을 반환하는 람다식
            myClass.OnCalculate += (a, b) => a + b;
            myClass.Calculate(5, 7);

            // 반대로 a - b 값을 반환하는 람다식
            myClass.OnCalculate += (a, b) => a - b;
            myClass.Calculate(15, 8);

            // 람다가 아닌 메소드를 사용한 체인
            myClass.OnCalculate += AddNum;
            myClass.Calculate(15, 8);
        }

        static int AddNum(int a, int b)
        {
            return a + b;
        }
    }
}
