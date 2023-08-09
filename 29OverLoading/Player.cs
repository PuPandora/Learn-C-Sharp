using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG,
}

class Player
{
    // 물리 방어
    int AttDef;
    // 불 방어
    int FireDef;
    // 얼음 방어
    int IceDef;

    int HP = 100;

    // 함수 오버로딩
    // 이름이 같아도 받는 매개변수 값이 다르면 다른 함수로 취급된다.
    // Damageint
    public void Damage(int _Damage)
    {
        HP -= _Damage;
    }
    // Damagefloatint
    public void Damage(float _Damage, int _Type)
    {

    }
    // Damageintint
    public void Damage(int _Damage, DMGTYPE _Type)
    {
        // switch 문을 int 같은 자료형으로 받으면 정해진 수 보다 크거나 작은 값을 받을 가능성이 있다.
        // enum을 쓰면 명시적으로 표현할 수 있어 좋다.
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            default:
                break;
        }
        Damage(_Damage);
    }

    public void Func(int _Value, int _Value2)
    {

    }

    public void Func(int _Value)
    {

    }
}

