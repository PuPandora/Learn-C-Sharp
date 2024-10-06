using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Youtuber
{
    public List<Subscriber> subscribers = new List<Subscriber>();

    public void AddSubscriber(Subscriber user)
    {
        subscribers.Add(user);
    }

    // 업로드
    public void Upload()
    {
        foreach (var s in subscribers)
        {
            s.Notify();
        }
    }
}

public class Subscriber
{
    // 구독
    public void Subscribe(Youtuber youtuber)
    {
        youtuber.AddSubscriber(this);
    }
    // 구독 해제

    public void Notify()
    {
        Console.WriteLine("유튜버가 영상을 업로드했습니다.");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Youtuber newYoutuer = new Youtuber();
        Subscriber newSubsriber = new Subscriber();

        newYoutuer.Upload();
        newSubsriber.Subscribe(newYoutuer);
        newYoutuer.Upload();
    }
}
