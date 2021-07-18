using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// class 활용
namespace CsharpBasicChaptor06_01
{
    class Human
    {
        // 생성자 : class 이름과 동일하게
        // return이 없음
        public Human()
        {
            Name="";
            BloodType="";
            Age=0;
            Gender = "";
        }
        public Human(string tName, string tGender) // 생성자 오버로딩 (동일한 생성자 두개)
        {
            Name = tName;
            BloodType = "";
            Age = 0;
            Gender = tGender;
        }


        // class 속성 정의

        public string Name; // public : 어느 클래스에서도 접근 가능
        public string BloodType;
        public int Age;
        public string Gender;

        public void Sleep()
        {
            Console.WriteLine("잠자는 중");
        }
        // sleep method 오버로딩

        public void Sleep(string tName)
        {
            Console.WriteLine(tName+"자는 중");
        }

    }
    class Chap0601
    {
        static void Main(string[] args)
        {
            //객체 생성
            Human JSE = new Human(); // 생성자 오버로딩 미활용
            Human JDA = new Human(tName: "LEE", tGender: "Male"); // 오버로딩 활용
            Console.WriteLine(JDA.Name);
            Console.WriteLine(JDA.Gender);
            JSE.Sleep("Jay");
            JSE.Name = "KIM"; // 클래스 속성 입력
            JSE.Gender = "Male"; // 클래스 속성 입력
            Console.WriteLine(JSE.Name);
            Console.WriteLine(JSE.Gender);
        }
    }
}
