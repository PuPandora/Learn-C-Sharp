using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

internal class Program
{

    static void Main(string[] args)
    {
        List<string> nameList = new List<string>();
        string[] nameArr = new string[] { "강동한", "강민혜", "곽상윤", "김동재", "김소희", "김수아", "김우룡", "김현주", "김홍진","김효원",
                                    "나하준", "문승호", "민지혜", "박은하", "박재필", "안성진", "이경훈", "임정민", "임창묵", "전여름",
                                    "최제희", "황인성"};

        Console.WriteLine("아무 키나 누르면 랜덤으로 순번이 정해집니다.");
        Console.ReadKey();
        Console.Clear();

        // 리스트 셔플
        nameList = nameArr.OrderBy(a => Guid.NewGuid()).ToList();

        // 섞인 리스트 출력
        for (int i = 0; i < nameList.Count; i++)
        {
            Console.WriteLine($"{i+1}. {nameList[i]}");
        }

        // 결과 텍스트 파일로 출력
        // 바탕 화면 경로 설정
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // 출력할 파일 경로 설정
        string filePath = Path.Combine(desktopPath, "ETL 유니티 3기 발표 순서 랜덤.txt");

        // 파일 생성 및 데이터 쓰기
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(" - 랜덤으로 정해진 이름 목록 -");
            for (int i = 0; i < nameList.Count; i++)
            {
                writer.WriteLine($"{i + 1}. {nameList[i]}");
            }
        }

        while (true)
        {
            Console.ReadKey();
        }
    }
}
