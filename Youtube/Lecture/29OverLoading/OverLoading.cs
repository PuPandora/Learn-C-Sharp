using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 28화]오버로딩 [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=_N7mccAyXag&t=58s&pp=ygUcQyMg7Ja07IaM7Yq46529IOyYpOuyhOuhnOuUqQ%3D%3D

class OverLoading
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NewPlayer.Damage(50);
        NewPlayer.Damage(50, DMGTYPE.FIREDMG);
    }
}
