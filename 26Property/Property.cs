using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int AT = 10;

    public int ATProperty
    {
        get
        {
            if (AT > 20)
            {
                Console.WriteLine("20 이상입니다.");
                return AT;
            }
            else
            {
                Console.WriteLine("19 이하는 get 할 수 없습니다.");
                return 0;
            }
                
        }
        set
        {
            if (value > 30)
            {
                Console.WriteLine("31 이상은 set 할 수 없습니다.");
                return;
            }

            else if (value < 30)
                AT = value;
        }
    }
    public int readOnly { get; }

    int GetAT()
    {
        return AT;
    }

    void SetAT(int _value)
    {
        AT = _value;
    }
}

namespace _26Property
{
    internal class Property
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Console.WriteLine(NewPlayer.ATProperty); // << Get
            NewPlayer.ATProperty = 32; // << Set
        }
    }
}
