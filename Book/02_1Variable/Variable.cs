using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Variable
    {
        static void Main(string[] args)
        {
            // 변수 선언의 기초
            VariableDeclarationBasic();
            Console.WriteLine("\n\n");

            // 다양한 변수 선언 방식
            VariableDeclarationAdvance();
            Console.WriteLine("\n\n");

            // 변수의 여러 자료형
            VariableDataType();
            Console.WriteLine("\n\n");

            // 변수 선언하는 방법들

            void VariableDeclarationBasic()
            {
                Console.WriteLine("\n##### ##### ##### ##### ##### ##### ");
                Console.WriteLine("변수 선언의 기초\n");

                // 변수 선언
                int a;
                int b;
                // 변수 초기화 (대입)
                a = 2;
                b = 3;
                // 변수 출력
                Console.WriteLine("a = 2;\nb = 3;");
                Console.WriteLine("a : " + a);
                Console.WriteLine("b : " + b);
                // 줄 바꿈
                Console.WriteLine();

                // a에 b를 대입 후 출ㄺ
                a = b;
                Console.WriteLine("a = b;");
                Console.WriteLine("a : " + a);
            }

            void VariableDeclarationAdvance()
            {
                // ;(세미콜론)을 기준으로 줄바꿈 없이 여러개의 변수 선언
                int a; int b;
                // 쉼표로 한 줄 선언
                int c, d;
                // 선언과 동시에 초기화
                int e = 5;
                // 여러개의 변수를 선언과 초기화
                int f = 6, g = 7;

                Console.WriteLine("\n##### ##### ##### ##### ##### ##### ");
                Console.WriteLine("변수 선언의 여러가지 방식\n");

                //Console.WriteLine(";(세미콜론)을 기준으로 줄바꿈 없이 여러개의 변수 선언\nint a; int b;");
                //Console.WriteLine();
                //Console.WriteLine("쉼표로 한 줄 선언\nint c, d;");

                //Console.WriteLine("선언과 동시에 초기화");
                //Console.WriteLine();
                //Console.WriteLine("int e = 5;");
            }
        }
    }
}
