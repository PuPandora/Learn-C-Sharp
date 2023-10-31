using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InsertionSort : SortingAlgorithm, ISortingAlgorithm
{
    public void Sort(int[] array)
    {
        // 1. 배열의 길이만큼 반복한다
        // 2. 현재 인덱스 요소(i)와 현재 진행 중인 인덱스-1 요소(j)를 비교한다.
        // 3. 만약 i가 작다면 서로 교환한다.
        // 3-1. i-1 요소와 j-1 요소를 비교하고, i가 작다면 교환한다.
        // 4. 만약 i가 작지 않다면, 다음 요소 검사로 넘어간다.

        Console.WriteLine("\n===== 삽입 정렬 =====\n");

        int comparisonCount = 0;
        int swapCount = 0;

        for (int i = 1; i < array.Length; i++)
        {
            int curIndex = i;
            for (int j = i - 1; j >= 0; j--)
            {
                // Comparison
                comparisonCount++;

                if (array[curIndex] < array[j])
                {
                    int temp = array[j];
                    array[j] = array[curIndex];
                    array[curIndex] = temp;

                    curIndex--;
                    swapCount++;
                }
                else
                {
                    break;
                }
            }
        }

        PrintOperationCount(comparisonCount, swapCount);
    }
}
