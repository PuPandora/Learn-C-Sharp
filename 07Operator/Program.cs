using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 수의 연산 (Number Operation)
            // + , - , * , / , %
            Console.WriteLine("수의 연산 | Number Operation");
            Console.WriteLine("// + , - , * , / , %");

            Console.WriteLine($"5 + 5는 {5 + 5}입니다.");
            Console.WriteLine($"5 - 5는 {5 - 5}입니다.");
            Console.WriteLine($"5 x 5는 {5 * 5}입니다.");
            Console.WriteLine($"5 ÷ 5는 {5 / 5}입니다.");
            Console.WriteLine($"5 ÷ 3의 나머지는 {5 % 3}입니다.");

            // 대입 연산자
            int a = 0;
            // 뒤에 있는 연산을 한 뒤, 대입을 함
            // 뒤를 값, 앞을 변수로 인지함
            a = a + 2;

            Console.WriteLine();

            // 대입 연산자
            int b = 7;
            Console.WriteLine($"int b = 7");
            Console.WriteLine($"b += 5 = {b += 5}");
            Console.WriteLine($"b -= 5 = {b -= 5}");
            Console.WriteLine($"b *= 10 = {b *= 5}");
            Console.WriteLine($"b /= 2 = {b /= 5}");
            Console.WriteLine($"b %= 5 = {b %= 5}");

            Console.WriteLine();

            // 증가, 감소 연산자 (Increment, Decrement Operator)
            Console.WriteLine("증가, 감소 연산자 | Increment/Decrement Operator");
            int d = 1;
            Console.WriteLine("시작은 " + d + "입니다.");
            a++;
            Console.WriteLine("1 증가시켜 " + a + "가 되었습니다.");
            a--;
            Console.WriteLine("1 감소시켜 " + a + "가 되었습니다.");

            Console.WriteLine();

            // 전처리 후처리 (전치 후치) Pre-, Post-
            Console.WriteLine("전처리 후처리 | Pre- Post-");

            int PreIncrementA = 0;
            int PostIncrementB = 0;

            Console.WriteLine($"A = {PreIncrementA}, B = {PostIncrementB}");
            Console.WriteLine("A++ = " + PreIncrementA++);
            Console.WriteLine("++B = " + ++PostIncrementB);
            Console.WriteLine("A = " + PreIncrementA);

            Console.WriteLine();

            // 비교 연산자 | Comparison Operator
            Console.WriteLine("비교 연산자 | Comparison Operator");
            int comparisonA = 10;
            int comparisonB = 20;

            Console.WriteLine("A : " + comparisonA + "\nB : " + comparisonB);
            Console.WriteLine();
            Console.WriteLine("A > B = " + (comparisonA > comparisonB));
            Console.WriteLine("A < B = " + (comparisonA < comparisonB));
            Console.WriteLine("A == B = " + (comparisonA == comparisonB));
            Console.WriteLine("A >= B = " + (comparisonA >= comparisonB));
            Console.WriteLine("A <= B = " + (comparisonA <= comparisonB));
            Console.WriteLine("A != B = " + (comparisonA != comparisonB));

            Console.WriteLine();

            // 논리형 (bool)
            int compareIntA = 0;
            int compareIntB = 0;

            bool compareBoolA, compareBoolB, compareBoolC;

            compareBoolA = compareIntA < compareIntB;
            compareBoolB = compareIntA > compareIntB;
            compareBoolC = compareIntA == compareIntB;

            // 조건 연산자 (삼항 연산자 Conditional Operator)
            Console.WriteLine("삼항 연산자 | Conditional Operator");

            bool conditionalBoolA;
            int conditionalIntA;
            conditionalBoolA = true;

            // 조건식 ?(연산자) 값(true) : 값(false);
            conditionalIntA = conditionalBoolA ? 1 : 0;
            Console.WriteLine("Int A = Bool A ? 1 : 0;");
            Console.WriteLine("Bool A의 값이 true일 경우 = " + conditionalIntA);
            conditionalBoolA = false;
            conditionalIntA = conditionalBoolA ? 1 : 0;
            Console.WriteLine("Bool A의 값이 false일 경우 = " + conditionalIntA);

            Console.WriteLine();

            bool conditionalBoolB;
            string right = "정답", wrong = "오답";

            conditionalBoolB = true;
            string conditionalAnswer = conditionalBoolB ? right : wrong;

            // 논리 연산자 (Logical Operator)
            Console.WriteLine("논리 연산자 | Logical Operator");

            bool logicalBoolA, logicalBoolB;
            int logicalIntA = 3, logicalIntB = 4;
            Console.WriteLine($"A = {logicalIntA} / b = {logicalIntB}");

            logicalBoolA = (logicalIntA < 0);
            logicalBoolB = (logicalIntB > 0);
            Console.Write("A == 3 && B == 3 : ");
            Console.WriteLine((logicalIntA == 3) && (logicalIntB == 3));
            Console.Write("A == 3 || B == 3 : ");
            Console.WriteLine((logicalIntA == 3) || (logicalIntB == 3));

            Console.WriteLine();

            logicalBoolA = true; logicalBoolB = false;
            Console.WriteLine($"BoolA = {logicalBoolA} / BoolB = {logicalBoolB}");
            Console.Write("BoolA && BoolB : ");
            Console.WriteLine(logicalBoolA && logicalBoolB);
            Console.Write("BoolA || BoolB : ");
            Console.WriteLine(logicalBoolA || logicalBoolB);

            Console.WriteLine();

            //단락 평가 연산자
            // &&와 ||는 연산 효율을 위해 필요할 때 생략하지만, 단락 평가 연산자는 그러지 않고 모두 확인
            // Comment : 왜 필요할까?

            Console.WriteLine("단락 평가자 | &, |");
            Console.Write("logicalBoolA & logicalBoolB = ");
            Console.WriteLine(logicalBoolA & logicalBoolB);
            Console.Write("logicalBoolA && logicalBoolB = ");
            Console.WriteLine(logicalBoolA && logicalBoolB);
            Console.Write("logicalBoolB & logicalBoolA = ");
            Console.WriteLine(logicalBoolB & logicalBoolA);
            Console.Write("logicalBoolB && logicalBoolA = ");
            Console.WriteLine(logicalBoolB && logicalBoolA);
            Console.Write("logicalBoolA | logicalBoolB = ");
            Console.WriteLine(logicalBoolA | logicalBoolB);
            Console.Write("logicalBoolA || logicalBoolB = ");
            Console.WriteLine(logicalBoolA || logicalBoolB);
            Console.Write("logicalBoolB | logicalBoolA = ");
            Console.WriteLine(logicalBoolB | logicalBoolA);
            Console.Write("logicalBoolB || logicalBoolA = ");
            Console.WriteLine(logicalBoolB || logicalBoolA);



            // 형 변환
        }
    }
}
