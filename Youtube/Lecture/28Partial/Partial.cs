using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// namespace를 미리 입력. 이 namespace에 있는 것들을 사용하겠다.
using _28Partial;

// [C# 강의 27화]partial [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=FMNOUVi-ARY&t=6s&pp=ygUXQyMg7Ja07IaM7Yq46529IHBhcnRpYWw%3D

namespace _28Partial
{
    internal class Partial
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.Func1();
            _28Partial.Player NewPlayer2 = new _28Partial.Player();

            // 클래스 이름이 같아도 partial을 붙이면 컴파일 할 때 하나의 클래스로 합쳐진다.
            // 개발할 때 개별 파일로 정리하기 위한 용도, 편의성.
            // 아마도 지금도 C#에만 있는 클래스 기능

            // Player.Fight.cs
            NewPlayer.Damage(10);
            // Player.Quest.cs
            NewPlayer.EventStart();
            // Player.cs
            NewPlayer.Func1();

        }
    }
}
