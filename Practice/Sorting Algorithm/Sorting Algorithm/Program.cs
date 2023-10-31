using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static int[] intRandArr;
    static int[] intSortedArr;

    static void Main(string[] args)
    {
        // 1. 배열 크기 선택
        // 2. 정렬 알고리즘 선택 (정렬 전 랜덤으로 섞음)
        // 3. 프로그램 종료
        bool programRun = true;
        while (programRun)
        {
            Console.Clear();
            Console.WriteLine("- 정렬 알고리즘 프로그램 -\n");
            Console.WriteLine("1. 배열 크기 설정");
            Console.WriteLine("2. 정렬 알고리즘");
            Console.WriteLine("3. 프로그램 종료");

            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    MakeArray.SetArraySize(out intRandArr);
                    Console.Clear();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    SelectSortAlgorithm();
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("프로그램을 종료합니다...\n\n");
                    programRun = false;
                    break;

                default:
                    break;
            }
        }
    }

    static void SelectSortAlgorithm()
    {
        bool isRun = true;
        bool isExit = false;
        bool isDefault = false;

        while (isRun)
        {
            MakeArray.MakeRandomArray(intRandArr, 10);

            Console.WriteLine("1. 선택 정렬");
            Console.WriteLine("2. 버블 정렬");
            Console.WriteLine("3. 삽입 정렬");
            Console.WriteLine("4. 나가기");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    MakeArray.PrintArray(intRandArr);
                    SortingAlgorithm.Instance.SelectionSort(intRandArr);
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    MakeArray.PrintArray(intRandArr);
                    SortingAlgorithm.SortingAlgorithm.BubbleSort(intRandArr);
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    MakeArray.PrintArray(intRandArr);
                    SortingAlgorithm.SortingAlgorithm.InsertionSort(intRandArr);
                    break;

                case ConsoleKey.D4:
                    Console.Clear();
                    isRun = false;
                    isExit = true;
                    break;

                default:
                    Console.Clear();
                    isDefault = true;
                    break;
            }
            if (!isExit && !isDefault)
                MakeArray.PrintArray(intRandArr);
        }
    }
}
