﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class BubbleSort : SortingAlgorithm, ISortingAlgorithm
{
    public void Sort(int[] array)
    {
        // 1. (배열의 길이-1) * (배열의 길이-1) 만큼 비교한다.
        // 2. n번째 요소를 n+1번째 요소와 비교
        // 2-1. n번째 요소가 크다면 위치 교환
        // 3. 첫 반복이 끝났다면 가장 큰 숫자가 가장 뒤에 위치 됨
        // 4. 반복 횟수가 늘어나면, 가장 뒤에 정렬되는 요소 개수가 동일하게 증가한다

        comparisonCount = 0;
        swapCount = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;

                    swapCount++;
                }
                comparisonCount++;
            }
        }

        PrintOperationCount(comparisonCount, swapCount);
    }
}
