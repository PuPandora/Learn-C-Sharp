using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{
    internal class Program
    {
        // Test Func
        static int Number100()
        {
            return 100;
        }
            
        static void Main(string[] args)
        {
            int Left = 100;
            int Right = 10;

            if (Left == Right)
            {

            }

            // Test Code
            if (Number100() == 100) {
                Console.WriteLine("함수 리턴 100, 100 비교 결과 true");
            }


            //int Test1 = 50;
            int SwitchTest = 1;

            switch (SwitchTest)
            {
                //case Test1: // 변수는 안 된다. 상수와만 비교할 수 있다.
                    //break;
                case 0:
                case 1:
                    Console.WriteLine("SwitchTest는 0 또는 1 입니다..");
                    break;
                case 100:
                    Console.WriteLine("SwitchTest는 100 입니다.");
                    break;
                default:
                    break;
            }
        }
    }
}
