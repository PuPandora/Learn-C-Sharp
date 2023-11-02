using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 예외 처리
namespace _12_Exception
{
    class Calc
    {
        // try, catch, finally
        // 기본적인 예외 처리 문법 사용 예시
        public void PrintDivide(int x, int y)
        {
            int z;
            try
            {
                Console.WriteLine("PrintDivide 메소드를 실행합니다.\n");
                z = x / y;
                Console.WriteLine($"x / y : {z}");
                Console.WriteLine("PrintDivide 메소드를 정상적으로 마쳤습니다.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("PrintDivide 메소드에서 에러 예외 발생!");
                Console.WriteLine($"{e.Message}\n");
            }
            finally
            {
                Console.WriteLine("아무튼 PrintDivide 메소드를 마쳤습니다.\n");
            }
        }
    }

    internal class ExceptionSample
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.PrintDivide(30, 0);
            calc.PrintDivide(20, 4);
            Console.WriteLine("나누기 프로그램이 종료됐습니다.\n\n");

            ForceException();
            
        }

        // throw 문법
        static void ForceException()
        {
            try
            {
                try
                {
                    Console.WriteLine("강제로 오류를 발생시킵니다.");
                    List<int> ints = null;
                    ints[0] = 1;
                }
                catch
                {
                    Exception e = new Exception("커스텀 강제 오류!");
                    throw e;
                }
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
        }
    }
}
