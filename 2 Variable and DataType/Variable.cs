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

            // 다양한 변수 선언 방식
            VariableDeclarationAdvance();

            // 변수의 여러 자료형
            VariableDataType();

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

            void VariableDataType()
            {
                Console.WriteLine("\n##### ##### ##### ##### ##### ##### ");
                Console.WriteLine("변수의 여러 자료형\n");

                Console.WriteLine("- 정수형 -");
                Console.WriteLine("형의 이름\t:\t크기(비트)\t:\t들어갈 수 있는 값의 범위");
                Console.WriteLine("sbyte\t:\t1 byte\t:\t-128 ~ -127");
                Console.WriteLine("byte\t:\t1 byte\t:\t0 ~ 255");
                Console.WriteLine("short\t:\t2 byte\t:\t-32768 ~ 32767");
                Console.WriteLine("ushort\t:\t2 byte\t:\t0 ~ 65535");
                Console.WriteLine("int\t:\t4 byte\t:\t-2147483648 ~ 2147483647");
                Console.WriteLine("uint\t:\t4 byte\t:\t0 ~ 4294967295");
                Console.WriteLine("long\t:\t8 byte\t:\t-923372036854775808 ~ -923372036854775807");
                Console.WriteLine("ulong \t:\t8 byte\t:\t0 ~ 8446744073709551615");

                Console.WriteLine("- 실수형 -");
                Console.WriteLine("형의 이름\t:\t크기(비트)\t:\t들어갈 수 있는 값의 범위");

                Console.WriteLine("float\t:\t4 byte" +
                    "\t:\t±1.5 x 10−45 ~ ±3.4 x 1038 (6 ~ 9 자릿수)");
                Console.WriteLine("double\t:\t8 byte\t:\t±5.0 × 10−324 ~ ±1.7 × 10308 (15 ~ 17 자릿수");
                Console.WriteLine("decimal\t:\t16 byte\t:\t±5.0 × 10−324 ~ ±1.7 × 10308 (28 ~ 29 자릿수)");
            }
        }
    }
}
