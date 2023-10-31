using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MakeArray
{
    private static Random random = new Random();

    public static void SetArraySize(out int[] array)
    {
        Console.Write("생성할 배열 크기를 입력해주세요.\n >> ");
        int.TryParse(Console.ReadLine(), out int inputSize);

        array = new int[inputSize];
    }

    public static void SetArraySize(int[] array, int size)
    {
        array = new int[size];
    }

    public static void PrintArrayLength(int[] array)
    {
        Console.WriteLine("intArr의 크기 : " + array.Length);
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Array[{i}] : {array[i]}");
        }
    }

    public static void MakeRandomArray(int[] array, int min, int max)
    {
        Console.WriteLine("\n===== 랜덤 배열 생성 =====\n");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max);
        }
    }

    public static void MakeRandomArray(int[] array, int max)
    {
        MakeRandomArray(array, 0, max);
    }

    public static void MakeSortedArray(int[] array)
    {
        Console.WriteLine("\n===== 정렬 배열 생성 =====\n");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
    }
}
