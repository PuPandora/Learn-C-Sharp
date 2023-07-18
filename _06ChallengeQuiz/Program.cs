using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ChallengeQuiz
{
    internal class Program
    {

        static void Main(string[] args)
        {
            FirstQuiz();
            SecondQuiz();

            void FirstQuiz()
            {
                /*
                 * using system;
                 * class Hello {
                 *     public static void ㅁㅁㅁㅁ {
                 *         Console.ㅁㅁㅁㅁ("Hello World!");
                 *     }
                 * }
                 */
                Console.WriteLine("public static void \'Main\'");
                Console.WriteLine("Console.\'WriteLine\'(\"Hello World!\");");
            }

            void SecondQuiz()
            {
                /*
                 * 아래 코드를 최대한 간단하게 작성
                 * int a;
                 * int b;
                 * a = 2;
                 * b = 3
                 * a = b;
                 * 
                 * Console.WriteLine(a);
                 */
                int a = 2;
                int b = 3;
                a = b;

                Console.WriteLine(a);

            }
        }

        
    }
}
