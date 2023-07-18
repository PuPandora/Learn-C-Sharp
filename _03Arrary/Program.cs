using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Arrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열 (Arrary)

            // 4칸 크기의 int형 배열 선언
            int[] a = new int[4];

            // 4칸 크기의 int형 배열 초기화
            // []가 비워져 있으면 { } 요소 수 만큼 자동 지정
            int[] b = new int[] { 1, 2, 3, 4 };

            // 줄여서 작성
            int[] c = { 1, 2, 3, 4 };

            // 배열 요소 출력
            Console.WriteLine("\'c\'배열의 0번째 요소 : " + c[0]);
            Console.WriteLine("\'c\'배열의 1번째 요소 : " + c[1]);
            Console.WriteLine("\'c\'배열의 2번째 요소 : " + c[2]);
            Console.WriteLine("\'c\'배열의 3번째 요소 : " + c[3]);
            Console.WriteLine();

            // for문을 통한 출력
            for (int i = 0; i < b.Length; i++)
                Console.WriteLine($"\'b\'배열의 {i}번째 요소 : " + b[i]);

            Console.WriteLine();

            // foreach문 연습
            foreach (int i in c)
            {
                Console.WriteLine($"\'b\'배열의 {i}번째 요소 : " + i);
            }

            Console.WriteLine();

            // 다차원 배열

            // 2차원 배열
            // 쉼표로 차원 구분
            int[,] _2dArrary = new int[4, 3];

            // 3차원 배열
            int[,,] _3dArrary = new int[4, 3, 3];

            // 다차원 배열 초기화, 대입, 출력

            // 초기화
            int[,] _2dArrary2 =
            {
                {10, 20 },
                {30, 40 },
                {50, 60 },
            };
            // 대입
            _2dArrary2[1, 1] = 0;
            Console.WriteLine("\n_2dArray2 [1, 1] = 0;\n");
            // 출력
            Console.WriteLine("a [0,0] : " + _2dArrary2[0, 0] + "\t" + "a [0,1] : " + _2dArrary2[0, 1]);
            Console.WriteLine("a [1,0] : " + _2dArrary2[1, 0] + "\t" + "a [1,1] : " + _2dArrary2[1, 1]);
            Console.WriteLine("a [2,0] : " + _2dArrary2[2, 0] + "\t" + "a [2,1] : " + _2dArrary2[2, 1]);

            Console.WriteLine();

            // for문 사용
            // GetLength 한 차원의 길이를 구할 수 있는 함수인듯
            for (int i = 0; i < _2dArrary2.GetLength(0); i++)
            {
                for (int j = 0; j < _2dArrary2.GetLength(1); j++)
                {
                    Console.WriteLine($"_2dArrary2 배열의 [{i},{j}]위치의 요소 : {_2dArrary2[i, j]}");
                }
                Console.WriteLine();
            }

            // 가변(재그) 배열
            // 선언 및 초기화
            int[][] JaggedArarryA = new int[3][];
            JaggedArarryA[0] = new int[3] { 10, 20, 30 };
            JaggedArarryA[1] = new int[2] { 40, 50 };
            JaggedArarryA[2] = new int[1] { 60 };

            // 선언과 동시에 초기화
            int[][] JaggedArrayB = new int[][]
            {
                    new int [] { 10, 20, 30 },
                    new int [] { 40, 50 },
                    new int [] { 60 },
            };

            // 배열의 요소 수 구하기
            int[] _1dArraryA = new[] { 4, 8, 16, 32, 64, 128 };
            Console.WriteLine("_1dArraryA 배열의 길이는 : " + _1dArraryA.Length);

            Console.WriteLine();

            // 다차원 배열 요소 수 구하기
            int[,] _2dArraryA =
            {
                    { 6, 12, 18, 24, 30, 36},
                    { 7, 14, 21, 28, 35, 42 },
                };
            Console.WriteLine("_2dArraryA 배열의 길이는 : " + _2dArraryA.Length);

            Console.WriteLine();

            // 재그 배열 요소 수 구하기
            int[][] JaggedArrayC = new int[][]
            {
                    new int [] { 214, 215, 216 },
                    new int [] { 341, 342 },
                    new int [] { 651 },
            };
            int JaggedArrayCLength = JaggedArrayC.Length;
            int JaggedArrayCLength0 = JaggedArrayC[0].Length;
            int JaggedArrayCLength1 = JaggedArrayC[1].Length;
            int JaggedArrayCLength2 = JaggedArrayC[2].Length;
            Console.WriteLine("JaggedArraryC의 요소 수 : " + JaggedArrayCLength);
            Console.WriteLine("JaggedArraryC[0]의 요소 수 : " + JaggedArrayCLength0);
            Console.WriteLine("JaggedArraryC[1]의 요소 수 : " + JaggedArrayCLength1);
            Console.WriteLine("JaggedArraryC[2]의 요소 수 : " + JaggedArrayCLength2);
        }
    }
}
