using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class SortingAlgorithm
{
    protected string algorithmName;
    protected int comparisonCount = 0;
    protected int swapCount = 0;

    public abstract void Sort(int[] array);
    public abstract void PrintSortResult(int[] array);

    protected void PrintAlgorithmName()
    {
        Console.WriteLine($"\n===== {algorithmName} =====\n");
    }

    public void PrintOperationCount()
    {
        Console.WriteLine("\n===== ===== ===== =====");
        Console.WriteLine($"\n비교 횟수 : {comparisonCount}\n교환 횟수 : {swapCount}\n");
        Console.WriteLine("===== ===== ===== =====\n");
    }
}
