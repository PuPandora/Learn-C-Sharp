using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    // 필드 (Field) : 클래스 내 변수
    int FieldVar = 10;
    int WheelSpeed = 0;
    int Price = 0;
}

class Method
{
    // 메소드 (Method) : 클래스 내 함수
    // 인자값, 반환값이 있는 함수
    static public int Add(int a, int b)
    {
        int result = a + b;
        return result;
    }

    // 인자값만 있는 메소드
    static public void OnlyParameter(int a, int b)
    {
        Console.WriteLine($"함수에 넣은 인자값은 {a}, {b}입니다.");
    }

    // + 인자값이 다른 같은 이름의 메소드 (오버로딩)
    static public void OnlyParameter(int a, int b, int c)
    {
        Console.WriteLine($"함수에 넣은 인자값은 {a}, {b}, {c}입니다.");
    }

    // 반환값만 있는 메소드
    static public double PI()
    {
        double pi = Math.PI;
        return pi;
    }

    // 인자값, 반환값 둘 다 없는 메소드
    static public void NoParamNoReturn()
    {
        Console.WriteLine("인자값, 반환값 둘 다 없는 메소드입니다.");
    }
}


namespace _08Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 객체의 생성
            // [클래스명] [이름] = new [클래스명]
            Car Ada = new Car();
            Car Con = new Car();

        }
    }
}
