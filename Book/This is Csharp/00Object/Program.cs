using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        // Object 자료형
        // 박싱과 언박싱
        // 모든 기본 자료형 + 사용자 정의 자료형이
        // object 형식으로부터 상속받기에
        // 컴파일러는 어떤 데이터 자료라도 object 형으로 담아 처리가 가능하다.
        // (아마도 업캐스팅)

        // 1. object a = 20;
        // 2. 20을 포장(박싱)해서 힙에 할당
        // 3. 스택에서 a는 힙에 할당한 20의 주소를 참조

        int a = 123;
        object b = a;       // a에 담긴 값을 박싱해서 힙에 저장
        int c = (int)b;     // b에 담긴 값을 언박싱해서 스택에 저장
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        double x = 3.141592;
        object y = x;           // x에 담긴 값을 박싱해서 힙에 저장
        double z = (double)y;   // y에 담긴 값을 언박싱해서 스택에 저장
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }
}
