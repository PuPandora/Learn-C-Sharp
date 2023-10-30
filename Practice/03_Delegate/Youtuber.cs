using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _03_Delegate.Youtuber;

namespace _03_Delegate
{
    public class Youtuber
    {
        public List<YoutubeVideo> YoutubeVideos { get; private set; } = new List<YoutubeVideo>();

        public delegate void UploadVideoEventHandler(YoutubeVideo video);
        public event UploadVideoEventHandler OnUploadVideo = delegate { };
        public event Action OnUploadPost = delegate { };

        public string name { get; private set; }
        public int subscriberCount { get; private set; }

        public Youtuber(string name)
        {
            this.name = name;
        }

        public void UploadVideo(string videoName)
        {
            YoutubeVideo newVideo = new YoutubeVideo(this, videoName);
            YoutubeVideos.Add(newVideo);
            newVideo.videoIndex = YoutubeVideos.Count;

            Console.WriteLine($"{name}은/는 영상을 업로드했습니다.");
            Console.WriteLine($"영상 제목 : {videoName}\n");

            OnUploadVideo(newVideo);
        }

        public void RemoveVideo(YoutubeVideo video)
        {
            if (!video.owner.name.Equals(this.name))
            {
                Console.WriteLine($"\"{video.name}\" 영상은 {name}이/가 소유자가 아닙니다.\n");
                return;
            }

            YoutubeVideos.Remove(video);
            Console.WriteLine($"{name}이/가 {video.name} 영상을 삭제했습니다.\n");
        }

        public void UploadPost()
        {
            OnUploadPost();
        }

        public void AddSubscriber()
        {
            subscriberCount++;
        }

        public void MinusSubscriber()
        {
            subscriberCount--;
        }
    }

    public class YoutubeVideo
    {
        public Youtuber owner { get; }
        public string name { get; set; } = "UNKNOWN-VIDEO";
        public int viewCount { get; private set; } = 0;
        public int likeCount { get; private set; } = 0;
        public int videoIndex { get; set; } = -1;

        public YoutubeVideo(Youtuber videoOwner, string videoName)
        {
            owner = videoOwner;
            name = videoName;
        }

        public void Watch()
        {
            viewCount++;
        }
    }
}
