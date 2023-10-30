using System;

namespace _03_Delegate
{
    public delegate void MyDelegate(string message);
    public delegate void NoReturnDelegate();
    public delegate string HasReturnDelegate();
    public delegate void NoParameterDelegate();
    public delegate void HasParameterDelegate(string message);

    internal class Program
    {
        public static void MyMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void NoReturnMethod()
        {
            Console.WriteLine("- NoReturnMethod");
            Console.WriteLine("반환이 없는 대리자\n");
        }

        public static string HasReturnMethod()
        {
            Console.WriteLine("- HasReturnMethod");
            return "반환이 있는 대리자\n";
        }

        public static void HasParameterMethod(string message)
        {
            Console.WriteLine("- HasParameterMethod");
            Console.WriteLine(message);
        }

        public static void NoParameterMethod()
        {
            Console.WriteLine("- NoParameterMethod");
            Console.WriteLine("매개변수가 없는 대리자\n");
        }

        static void Main(string[] args)
        {
            //MyDelegate myDeledage = new MyDelegate(MyMethod);
            //myDeledage("Hello, World");

            // 반환 없음
            NoReturnDelegate noReturn = new NoReturnDelegate(NoReturnMethod);
            noReturn();

            // 반환 있음
            HasReturnDelegate hasReturn = new HasReturnDelegate(HasReturnMethod);
            Console.WriteLine(hasReturn());

            // 매개변수 없음
            NoParameterDelegate noParam = new NoParameterDelegate(NoParameterMethod);
            noParam();

            // 매개변수 있음
            HasParameterDelegate hasParam = new HasParameterDelegate(HasParameterMethod);
            hasParam("매개변수가 있는 대리자\n");
        }
    }
}
