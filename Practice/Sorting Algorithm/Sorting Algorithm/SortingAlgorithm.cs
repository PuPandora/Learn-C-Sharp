using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ISortingAlgorithm
{
    void Sort(int[] Sort);
}

public class SortingAlgorithm
{
    protected string algorithmName;
    protected int comparisonCount = 0;
    protected int swapCount = 0;

    protected void PrintAlgorithmName()
    {
        Console.WriteLine($"===== {algorithmName} =====");
    }

    public void PrintOperationCount()
    {
        Console.WriteLine($"비교 횟수 : {comparisonCount}\n교환 횟수 : {swapCount}\n");
        Console.WriteLine("===== ===== ===== =====\n");
    }
}
