using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum SKILLTYPE
{
    FIRE,
    ICE,
    LIGHTNING,
    POSION,
    NONE,
}

internal class Enum
{
    static void Main(string[] args)
    {
        // enum 열거형 자료형 최대 수 만큼 접근하기
        // ex) Arrary.Length, List.Count

        //foreach (SKILLTYPE types in SKILLTYPE)

        //for (int i = 0; i < SKILLTYPE.)

        Console.WriteLine("SKILLTYPE의 총 개수는 : " + GetEnumCountMethod());
    }

    private static int GetEnumCountMethod()
    {
        int count = 0;
        count = System.Enum.GetValues(typeof(SKILLTYPE)).Length;
        return count;
    }
}
