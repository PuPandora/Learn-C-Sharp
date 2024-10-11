using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class A
{
    public A (string name)
    {
        this.name = name;
    }

    protected string name;

    public virtual void SayMyName()
    {
        Console.WriteLine($"나의 이름은 : {name}입니다. 이것은 A 클래스에서 재정의된 메소드입니다.");
    }
}

internal class B : A
{
    public B(string name) : base(name)
    {
        this.name = name;
    }
}

internal class C : A
{
    public C(string name) : base(name)
    {
        this.name = name;
    }

    public override void SayMyName()
    {
        Console.WriteLine($"나의 이름은 : {name}입니다. 이것은 C 클래스에서 재정의된 메소드입니다.");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        A a = new A("A");
        A b = new B("B");
        A c = new C("C");

        a.SayMyName();
        b.SayMyName();
        c.SayMyName();
    }
}
