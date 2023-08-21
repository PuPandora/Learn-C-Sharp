using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 35화]이너 클래스 이너 enum [어소트락 게임아카데미 게임학원]
// https://www.youtube.com/watch?v=MBg_D2FWH-c&list=PL4SIC1d_ab-Y-bBKojxhtFWwNpawMM1h5&index=35&t=221s&pp=iAQB



class Player
{
    // 그 클래스가 자기만 사용할 때 가장 많이 사용한다.
    // enum을 class 내부에 넣어줄 수도 있다.
    // 직업과 관련된 멤버변수
    public enum PLAYERJOB
    {
        NOIVCE,
        KNIGHT,
        FIGHTER,
        BERSERKER,
        FIREMAGE,
    }

    // 직업을 바꾸는 함수
    void ClassChange()
    {

    }
}

class Inven
{
    private int SelectIndex = 0;

    public void InnerClassTest()
    {
        InvenSlot NewInvenSlot = new InvenSlot();

        // 반대로 이너클래스의 private 변수는 접근하지 못함
        // NewInvenSlot.Index = 100;

        // public 접근은 당연히 가능하다
        NewInvenSlot.Select(this);
    }


    // public을 썼을 때 남들이 알면 짜증나는 일이 있다면 private을 사용하라.
    // 일단 private을 사용하고 이건 무조건 외부에서 알아야겠다 하면 public을 사용

    // 자기 클래스 내부에 클래스 소유
    // 이러한 것을 이너클래스(Inner Class)라고 한다.
    // 자기 클래스 내부에 있는 다른 클래스일 뿐이다.
    // 자기 클래스 내부에 있다고
    public class InvenSlot
    {
        int Index;

        public void Select(Inven _inven)
        {

            // 상위 클래스의 private 변수 접근 불가능
            // SelectIndex = 100;
            // 한 줄 알았는데...? 가능하다. 객체가 아니어서 못했던 것
            _inven.SelectIndex = 100;
        }
    }

    // 이럴거면 밖에 있건 안에 있건 무슨 상관인가?
    // 장점1. 이름 겹침에서 자유롭다.

    // 온전히 하나의 클래스가 자신의 내부에서
    // 모든걸 처리할 수 있게 하려면
    // 자신과 밀접히 관련된 자료형들도
    // 자신 내부에 들고 있는게 좋다.
    public enum INVENDIR
    {
        ID_LEFT,
        ID_RIGHT,
        ID_TOP,
        ID_BOTTOM,
    }

    void SelectMove(/* 방향을 의미할 인자값 */)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        Inven NewInven = new Inven();
        NewInven.InnerClassTest();
        Inven.INVENDIR IDIR = Inven.INVENDIR.ID_RIGHT;

    }
}
