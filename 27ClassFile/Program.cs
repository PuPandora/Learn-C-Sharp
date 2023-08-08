using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ctrl + K + F / 자동 코드 정렬
// 네임스페이스 없어도 된다.
class Program
{
    static void Main(string[] args)
    {
        // 다른 파일에 있는 클래스를 불러올 수 있다.
        Player NewPlayer = new Player();
        Town NewTown = new Town();
        // 정상적으로 메소드 호출이 가능하다.
        NewTown.InTown(NewPlayer);
    }
}
