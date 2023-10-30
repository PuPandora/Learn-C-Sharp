using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate
{
    public class Subscriber
    {
        public List<Youtuber> Youtubers { get; private set; } = new List<Youtuber>();

        public string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Subscribe(Youtuber youtuber)
        {
            Console.WriteLine($"{name}은/는 {youtuber.name} 유튜버 채널 구독을 시도합니다.");

            if (Youtubers.Contains(youtuber))
            {
                Console.WriteLine($"{youtuber.name}은/는 이미 구독 중인 유튜버입니다.\n");
                return;
            }

            Youtubers.Add(youtuber);
            youtuber.AddSubscriber();
            youtuber.OnUploadVideo += Notifications;

            Console.WriteLine($"{name}은/는 {youtuber.name} 유튜버를 구독했습니다.\n");
        }

        public void DeSubscribe(Youtuber youtuber)
        {
            Console.WriteLine($"{name}은/는 {youtuber.name} 유튜버 채널 구독 취소를 시도합니다.");

            if (!Youtubers.Contains(youtuber))
            {
                Console.WriteLine($"{youtuber.name}은/는 구독 중인 유튜버가 아닙니다.\n");
                return;
            }

            Youtubers.Remove(youtuber);
            youtuber.MinusSubscriber();
            youtuber.OnUploadVideo -= Notifications;

            Console.WriteLine($"{youtuber.name} 유튜버를 구독 취소했습니다.\n");
        }

        public void Notifications(YoutubeVideo video )
        {
            Console.WriteLine($"{name}의 알림 : {video.owner.name}의 영상이 올라왔습니다.");
            Console.WriteLine($"영상 제목 : {video.name}\n");
        }

        public void WatchVideo(YoutubeVideo video)
        {
            video.Watch();
            Console.WriteLine($"{name}은/는 \"{video.owner.name}\"의 \"{video.name}\"을/를 시청합니다\n");
        }
    }
}
