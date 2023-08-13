using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 33화]인벤토리 만들기 2부+ break continue 설명 설명 [어소트락 게임아카데미 게임학원]
// https://youtu.be/mECMKruSzdI?list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5

class Program
{
    static void Main(string[] args)
    {
        // continue와
        // break는 가장 가까운 반복문의 for(증감문) while(조건문)
        // 으로 이동한다.

        for (int i = 0; i < 100; i++)
        {
            if (0 == i % 2)
            {
                // 만약 이 문장을 만나면
                // While문에서도 동일
                // 반복문의 증감문으로 바로 이동한다.
                continue;
            }
            Console.WriteLine(i);
        }

        for (int i = 0; i < 100; i++)
        {
            if (i == 50)
            {
                // 가장 가까이 있는 반복문을 나간다.
                break;
            }
            Console.WriteLine(i);
        }
    }
}
