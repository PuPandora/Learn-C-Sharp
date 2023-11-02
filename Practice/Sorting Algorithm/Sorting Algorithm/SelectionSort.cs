using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class SelectionSort : SortingAlgorithm
{
    public static SelectionSort Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SelectionSort();
            }
            return instance;
        }
    }
    private static SelectionSort instance;

    public override void Sort(int[] array)
    {
        // 1. 배열의 n번째 요소를 minNumberIndex에 저장한다.
        // 2. 배열의 n+1 인덱스 요소부터 비교를 시작하며,
        // 배열[minNumberIndex] 요소와 다음 인덱스 요소 값과 비교한다.
        // 2-1. 만약 다음 요소가 더 작다면, minNumberIndex를 다음 인덱스로 갱신한다.
        // 3. 전부 순회한 뒤, 배열[n] 요소와 배열[minNumberIndex] 요소를 서로 교환한다.
        // 4. n+1 하고 2~4 과정을 배열의 길이만큼 반복한다.

        algorithmName = "선택 정렬";
        comparisonCount = 0;
        swapCount = 0;

        PrintAlgorithmName();

        for (int i = 0; i < array.Length; i++)
        {
            int minNumberIndex = i;
            int temp = 0;

            for (int j = i + 1; j < array.Length; j++)
            {
                // Comparison
                if (array[j] < array[minNumberIndex])
                {
                    minNumberIndex = j;
                }
                comparisonCount++;
            }

            // Swap
            if (i != minNumberIndex)
            {
                temp = array[i];
                array[i] = array[minNumberIndex];
                array[minNumberIndex] = temp;
            }

            swapCount++;
        }

        PrintSortResult(array);
    }

    public override void PrintSortResult(int[] array)
    {
        MakeArray.PrintArray(array);
        PrintOperationCount();
    }
}
