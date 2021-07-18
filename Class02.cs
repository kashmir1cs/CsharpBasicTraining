using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// class 활용
// 생성자, 소멸자, 상속
// this 키워드
// overriding : overloading과 다름 (상속받은 개체를 고칠 때 사용)
// overridie keyword : virtual, override
// sealed : 상속 봉인, method, class 둘다 가능

namespace CsharpBasicChaptor06_01
{
    class Animal
    {
        public void Eat (string food)
        {
            Console.WriteLine(food + "먹는 중");
        }
        public virtual void Sleep() // overring할 method에 virtual 키워드 입력
        {
            Console.WriteLine("잠자는 중");
        }

        //public void Sleep(string tName) // method 오버로딩
        //{
        //    Console.WriteLine(tName + "자는 중");
        //}
    }
    class Sonic : Dog
    {
        // method overriding
        public override void Sleep()
        {
            Console.WriteLine("Dog is Sleeping");
        }
    }
    class Human : Animal //클래스 "Animal" 상속
    {
        // 생성자 : class 이름과 동일하게
        // return이 없음
        // 소멸자 : 객체 소멸할 때 동작
        public Human()
        {
            Name="";
            BloodType="";
            Age=0;
            Gender = "";
        }

        // 소멸자 (~ 사용) : 생성자 들어있는 중괄호가 소멸되는 시점에 작동

        public Human(string Name, string tGender) // 생성자 오버로딩 (동일한 생성자 두개)
        {
            //Name = tName; //tName은 지역변수, 필드명과 지역변수가 이름이 같으면 에러 발생
            this.Name = Name; //this (현재 실행되는 개체 지정)키워드 활용하여 동일한 변수명 활용 가능
            BloodType = "";
            Age = 0;
            Gender = tGender;
        }
        ~Human()
        {
            Console.WriteLine("소멸자 동작");
        }

        // class 속성 정의

        public string Name; // public : 어느 클래스에서도 접근 가능
        public string BloodType;
        public int Age;
        public string Gender;


        // sleep method override
        public override void Sleep()
        {
            Console.WriteLine("man is Sleeping");
        }


    }
    class Dog : Animal // 맨 앞에 sealed 선언할 경우 class 상속 불가 
    {
        // method overriding
        /*      
       *public sealed override void Sleep() // sealed keyword 사용하면 상속안됨
        {
            Console.WriteLine("Dog is Sleeping");
        }
        */
        public override void Sleep()
        {
            Console.WriteLine("Dog is Sleeping");
        }
    }
    class Chap0601
    {
        static void Main(string[] args)
        {
            //객체 생성
            Human JSE = new Human(); // 생성자 오버로딩 미활용
            Human JDA = new Human(Name: "LEE", tGender: "Male"); // 오버로딩 활용
            Dog mini = new Dog();
            Sonic sonic = new Sonic();
            Console.WriteLine(JDA.Name);
            Console.WriteLine(JDA.Gender);
            JSE.Sleep();
            JSE.Eat("탕수육");
            mini.Eat("사료");
            mini.Sleep();
            JSE.Name = "KIM"; // 클래스 속성 입력
            JSE.Gender = "Male"; // 클래스 속성 입력
            Console.WriteLine(JSE.Name);
            Console.WriteLine(JSE.Gender);
            sonic.Sleep();

            Console.WriteLine("소멸자 동작 시작");

        }
    }
}
