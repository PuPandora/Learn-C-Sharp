using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        char[] a = new char[20];

        SetCharArray(ref a, "ABCDEFEFGHIJKLMNOPQRSTUVWXYZ");
        Console.WriteLine(a);
    }

    private static void SetCharArray(ref char[] array, string value)
    {
        for (int i = 0; i < array.Length && i < value.Length; i++)
        {
            array[i] = value[i];
        }
    }
}
