using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 42화]Dictionary, foreach 알아보기 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=-E9LduyfGtU&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=42

class DicTest
{
    // 딕셔너리는 for문을 돌릴려고 하면
    // 다른 자료구조에 비해 효율이 떨어진다.
    // + foreach문 사용
    // 딕셔너리는 Containskey를 매우 많이 쓰게된다.

    public Dictionary<string, int> NewDic = new Dictionary<string, int>();

    public void Print(string _Name)
    {
        // 키 값이 있을 때만 입력한 키값의 데이터를 출력
        if (false == NewDic.ContainsKey(_Name))
        {
            return;
        }
        Console.WriteLine(NewDic[_Name]);
    }

    // 주로 클래스, 함수에 ContainsKey를 확인하는 것으로 감싸서
    // 딕셔너리를 사용하는 편이다.
    public void Add(string _Name, int _Value)
    {
        // 키 값이 없을 때만 입력한 키값과 데이터를 추가
        if (true == NewDic.ContainsKey(_Name))
        {
            return;
        }

        NewDic.Add(_Name, _Value);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        DicTest NewTest = new DicTest();
        NewTest.Add("aaa", 12);
        NewTest.Add("aaa", 123);
        NewTest.Add("aaa1", 451);
        NewTest.Add("bbb", 3452);

        Console.WriteLine(NewTest.NewDic["aaa1"]);
    }

    static void First()
    {
        // 연관 복합
        // string 키
        // int 값(value) (데이터)
        Dictionary<string, int> NewDic = new Dictionary<string, int>();

        // 키와 값이 붙어있는 자료구조
        NewDic.Add("일이에요", 1);
        NewDic.Add("이에요", 2);
        NewDic.Add("뭘까요?", 852344);

        // 키 값을 배열의 인덱스처럼 사용할 수 있다.
        // 딕셔너리는 찾는 작업에 특화된 자료구조이다.
        Console.WriteLine(NewDic["일이에요"]);
        Console.WriteLine(NewDic["뭘까요?"]);
        // Key Not Found Execption, 키가 없는 예외
        // Console.WriteLine(NewDic["없는키값"]);

        NewDic.Add("와와", 23425);
        // Argument Exeception
        // 같은 키값을 2번 이상 넣어주는 것은 불가능하다.
        // 딕셔너리에 같은 키를 넣어줄 일이 있다면
        // 사용하면 안되는 자료구조이다. (다른 자료구조를 사용하는게 낫다.)
        //NewDic.Add("와와", 64351);

        // Add 방어코드
        if (NewDic.ContainsKey("와와") == false)
        {
            NewDic.Add("와와", 35690);
        }

        string TestKey = "당연히 없는 값 테스트용";
        if (NewDic.ContainsKey(TestKey))
        {
            Console.WriteLine(NewDic[TestKey]);
        }
        else
        {
            Console.WriteLine("[" + TestKey.ToString() + "] 키 값은 없습니다.");
        }
    }
}
