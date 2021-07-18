using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// method 실습
// 변수 전달 방식
// OOP에서는 function을 method라고 표현
// void ?  : 메소드에서 리턴값이 없을 경ㅇ
// return : 출력하는 값이 있을 경우 (파이썬도 동일)


namespace CsharpBasicChaptor05_01
{

    class Animal
    {
        public static void Eat(string food) //파라미터 지정하면 입력된 값 출력 가능
        {
            Console.WriteLine("{0}을 먹는다",food);
        }
        public static string Sleep()
        {
            Console.WriteLine("잠을 잔다");
            return "수면중";
            // Animal.Sleep() 메소드 실행 시 "수면중"이라는 string 개체 반환
            // Console.WriteLine(Animal.Sleep()); == Console.WriteLine("수면중");
        }
    }

    class Chap0501
    {
        // 캡슐화 관련 지시어 public

        public static void FirstMethod()
        {
            // Main Method가 아닌 다른 메소드를 정의
            // 동작을 수행 (verb)
            // function과 유사한 역할
            Console.WriteLine("C# method");
        }

        static void Main(string[] args) //main method
        {
            Chap0501.FirstMethod();
            Animal.Eat("개밥");
            Animal.Sleep();
            Console.WriteLine(Animal.Sleep());
        }
    }
}
