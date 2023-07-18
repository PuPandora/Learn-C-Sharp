using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataType
{
    internal class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("\n\n");

            Console.WriteLine("- 실수형 -");
            Console.WriteLine("형의 이름\t:\t크기(비트)\t:\t들어갈 수 있는 값의 범위");

            Console.WriteLine("float\t:\t4 byte" +
                "\t:\t±1.5 x 10−45 ~ ±3.4 x 1038 (6 ~ 9 자릿수)");
            Console.WriteLine("double\t:\t8 byte\t:\t±5.0 × 10−324 ~ ±1.7 × 10308 (15 ~ 17 자릿수");
            Console.WriteLine("decimal\t:\t16 byte\t:\t±5.0 × 10−324 ~ ±1.7 × 10308 (28 ~ 29 자릿수)");
        }
    }
}
