using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// [C# 강의 41화]LinkedList 학습 및 응용맵이동 시스템 [어소트락 게임아카데미 게임학원]
// https://www.youtubehttps://youtu.be/TlWw_-oVXlQcom/@AssortRockGameAcademy

class Zone
{
    public string Name = "None";
    // 갈 수 있는, 이어진 노드의 정보 List
    public List<Zone> LinkZone = new List<Zone>();

    public Zone(string _Name)
    {
        Name = _Name;
    }

    public Zone Update()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("이곳은 " + Name + "입니다.");

            Console.WriteLine("이동할 수 있는 장소 리스트.");

            // 연결된 노드 리스트 출력
            for (int i = 0; i < LinkZone.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + LinkZone[i].Name);
            }

            // enum은 int가 아니다.
            //ConsoleKey.D1;
            
            // 형변환, 형변환이 가능한 것이 있고, 불가능 한 것이 있다.
            // enum은 int로 변환이 가능하다.
            int Number = (int)Console.ReadKey().Key;
            Number -= 49;

            // 간단하게 입력으로 노드 정보를 반환. 잘못 입력하면 인덱스 에러
            return LinkZone[Number];
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Zone NewZone0 = new Zone("태초마을");
        Zone NewZone1 = new Zone("초보사냥터");
        Zone NewZone2 = new Zone("중급사냥터");
        Zone NewZone3 = new Zone("중급마을");
        Zone NewZone4 = new Zone("고급사냥터");

        // 한 노드에서, 다른 곳의 노드로 갈 수 있는 정보를
        // 각 노드 List에 저장

        // 태초마을 -> 초보사냥터, 중급사냥터
        NewZone0.LinkZone.Add(NewZone1);
        NewZone0.LinkZone.Add(NewZone2);

        // 초보사냥터, 중급사냥터 -> 중급마을, -> 초급마을
        NewZone1.LinkZone.Add(NewZone3);
        NewZone1.LinkZone.Add(NewZone0);
        NewZone2.LinkZone.Add(NewZone3);
        NewZone2.LinkZone.Add(NewZone0);

        // 중급 마을 -> 초급사냥터, 중급사냥터, 고급사냥터
        NewZone3.LinkZone.Add(NewZone1);
        NewZone3.LinkZone.Add(NewZone2);
        NewZone3.LinkZone.Add(NewZone4);

        Zone StartZone = NewZone0;

        while (true)
        {
            // 반환된 노드 정보를 현재 노드에 대입
            // A -> B / A <- B -> C, D...
            StartZone = StartZone.Update();
        }
    }
}
