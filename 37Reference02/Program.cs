using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 37화]레퍼런스 2차 & 디버깅 방법 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=XWAeiNHKVsk&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=37&pp=iAQB

class Player
{
    public int HP = 100;
    public int AT = 10;

    public void PrintStatus()
    {
        Console.WriteLine($"HP : {HP}\nAT : {AT}\n");
    }

    public bool IsDeath()
    {
        Console.WriteLine("이 함수는 플레이어가 죽었는지 살았는지 체크하는 함수입니다.");
        Console.WriteLine("플레이어의 HP가 0보다 작거나 같으면 죽습니다.");
        return HP <= 0;
    }

    public void TestFunc(Player _Player)
    {
        TestFuncPart1(_Player);
    }

    public void TestFuncPart1(Player _Player)
    {
        TestFuncPart2(_Player);
    }

    public void TestFuncPart2(Player _Player)
    {
        _Player.AT = 20;
    }
}

internal class Program
{
    // 프로젝트를 다시 빌드하면
    // 37Reference02\Program.cs(31,16,31,22): warning CS0414: 'Program.Number' 필드가 할당되었지만 사용되지 않았습니다.
    // 와 같이 선언만 하고 사용하지 않는 변수를 찾아서 알려줄 정도로
    // 디버깅, IDE 기술이 매우 좋으니 활용하자.
    static int Number = 100;

    static void PlayerTest(Player _Test)
    {
        _Test.AT = 10000;
    }

    static void ArrayTest(int[] _ArrTest)
    {
        _ArrTest[0] = 99999;
    }

    static public void AtTest(Player player)
    {
        // null 에러 테스트
        Console.WriteLine("공격력을 테스트 해볼까요?");
        Console.WriteLine("그냥 해보는 겁니다.");

        player.AT = 10000;
        Console.WriteLine(player.AT);
    }

    static void Main(string[] args)
    {
        // Player NewPlayer 변수는 할 수 있는 일이
        // 어떤 녀석을 가르키는 일 밖에 하지 못한다.
        // 다른 녀석을 가르킬 수 있다.

        // new Player() << 이것은 과연 무엇일까? (new 키워드)
        // A라는 주소에 Player 객체 생성
        Player NewPlayer = new Player();
        // A Player 객체의 데이터 값 수정
        NewPlayer.AT = 50;
        NewPlayer.PrintStatus();



        // B라는 주소에 Player 객체 생성
        NewPlayer = new Player();
        // 기존에 가르키던 A 주소의 객체 데이터를 가르키는 변수가 없으니
        // C# 에서는 자동으로 메모리에서 제거해버린다.
        NewPlayer.PrintStatus();

        // 이전에 배우 내용
        // 클래스의 멤버 변수는 함수를 통해 변경하면
        // 실제로 그 값이 변경된다.
        PlayerTest(NewPlayer);
        NewPlayer.PrintStatus();

        // 배열을 만들자 마자
        // 아예 비워서 0으로 채우거나, 모든 값을 다 넣어줘야 한다.
        int[] ArrNumber = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // 리스트의 값을 함수를 통해 변경
        ArrayTest(ArrNumber);

        for (int i = 0; i < ArrNumber.Length; i++)
        {
            Console.WriteLine($"ArrNumber [{i}] : {ArrNumber[i]}");
        }

        // 이름이 다른 객체를 만들어 기존 객체를 대입시키고
        Player NewPlayer2 = NewPlayer;
        // 맴버 변수 값을 수정하면
        NewPlayer2.AT = 999;
        // 기존 객체의 값도 변경된다.
        NewPlayer.PrintStatus();

        // null 예외 오류
        //AtTest(null);
        //Player NewPlayer3 = null;
        //NewPlayer3.IsDeath();
        // 아무것도 없는(null) 상태이기 때문에
        // 안에 맴버 변수, 함수가 존재하지 않으니
        // 에러가 터지는 것이다.
        // 디버그 창에서 로컬(지역)창을 통해서 메모리 값을 쉽게 확인할 수 있다.
        // 실제로 NewPlayer3에 null을 대입할 경우
        // 다른 객체와 달리 맴버 변수, 함수가 전혀 존재하지 않는 것을 확인할 수 있다.

        //NewPlayer.AT = 50;
        // 고의로 null 예외 발생
        //NewPlayer.TestFunc(null);
        // TestFunc -> TestFuncPart1 -> TestFuncPart2 까지 들어가서
        // 값에 접근하자 예외가 터진다.
        // 디버그 창의 호출 스택으로 어떻게 이동해서, 어디에서 예외가 터졌는지
        // 쉽게 확인할 수 있다.
    }
}
