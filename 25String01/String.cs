using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25String01
{
    internal class String
    {
        static void Main(string[] args)
        {
            // 프로그래밍 언어 아는 것은 기본이자 필수 (숨 쉬는 것)
            // 프로그래밍의 기본기는
            // 디버깅 95%, 파일 입출력(데이터 저장, 불러오기)

            // 코드를 짜다가 빨간 줄이 그어지는 이유를 알 수 있어야 한다.

            int IntA = 10;
            string StringA = "Hello";
            // C#은 자료형이 다르기에 대입이 되지 않는다.
            //StringA = IntA;
            StringA = IntA.ToString();
            // 사실 string, int 같은 것들은 '구조체'(Struct)이다.
            // 안에 객체가 사용할 수 있는 멤버 함수(메소드)가 존재한다.
            // 그것을 통해 int형을 string형으로 바꿔줄 수 있다.

            // 문자열
            string Left = "안녕하세요,";
            string Right = "오늘은 날씨가 좋네요.";
            // 문자
            char CharacterA = 'f';
            char CharacterB = 'H';

            // string의 Char형의 배열을 반환해주는 메소드
            char[] CharList = Left.ToCharArray();
            for (int i = 0;  i < CharList.Length; i++)
            {
                Console.WriteLine($"CharList[{i}] = {CharList[i]}");
            }
            

            Console.WriteLine(Left + Right);
        }
    }
}
