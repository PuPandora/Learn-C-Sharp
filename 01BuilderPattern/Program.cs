using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01BuilderPattern
{
    // Date
    // 2023-07-23

    // Reference
    // https://math-development-geometry.tistory.com/60
    // https://youtu.be/Pzy_MPfGixg

    // Constructor
    class Student
    {
        // Field
        // Personal Info
        public int number;
        public string name;
        public float height;
        public float weight;

        // Constructor
        public Student(int number, string name, float height, float weight)
        {
            this.number = number;
            this.name = name;
            this.height = height;
            this.weight = weight;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("=== 학생 정보 ===");
            Console.WriteLine($"번호 : {number}\n이름 : {name}\n키 : {height}\n몸무게 : {weight}\n");
        }
    }

    // Builder-Pattern
    class StudentBuilder
    {        
        private Student student;

        public StudentBuilder()
        {
            student = new Student(0, "", 0, 0);
        }

        public StudentBuilder SetNumber(int value)
        {
            student.number = value;
            return this;
        }

        public StudentBuilder SetName(string value)
        {
            student.name = value;
            return this;
        }

        public StudentBuilder SetHieght(float value)
        {
            student.height = value;
            return this;
        }

        public StudentBuilder SetWeight(float value)
        {
            student.weight = value;
            return this;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("=== 학생 정보 ===");
            Console.WriteLine($"번호 : {student.number}\n이름 : {student.name}\n키 : {student.height}\n몸무게 : {student.weight}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Use Constructor
            Student one = new Student(1, "나일번", 173.4f, 67.2f);
            one.DisplayStudentInfo();

            // Use Builder-Pattern
            StudentBuilder two = new StudentBuilder();
            two.SetNumber(2).SetName("나이번").SetHieght(179.2f).SetWeight(81.4f);
            two.DisplayStudentInfo();

            StudentBuilder three = new StudentBuilder();
            three.SetNumber(3).SetName("나삼번").SetHieght(158.6f).SetWeight(54.7f);
            three.DisplayStudentInfo();

            // 빌더 패턴을 사용하면 코드 가독성이 향상된다.
            // 하지만 클래스 혹은 코드 규모가 커지면 코드 길이가 길어진다.
        }
    }
}
