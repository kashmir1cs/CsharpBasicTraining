using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 추상클래스 : 구현코드 가능, class와 유사
// interface는 구현 불가 
// interface와 class 중간 성격
// instance를 가질 수 없음

namespace CsharpBasicChaptor07_02_1
{
    // 추상클래스
    public abstract class Employee
    {
        protected string name; // 추상클래스는 필드 선언이 가능 (인터페이스는 불가)
        public Employee(string name)
        {
            this.name = name; //this 키워드 활용하여 지역변수와 구분
        }

        public abstract void Display(); 
        // 추상메소드, 상속받은 클래스는 반드시 이 메소드를 구현해야 한다.

    }

    public class Manager : Employee
    {
        public Manager(string name) :base(name) //base는 부모 클래스의 생성자를 호출
        {
            
        }
        // 부모클래스 활용하기 위해 override 이용
        public override void Display()
        {
            Console.WriteLine("성명은 : " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("2kd");
            // 추상메소드
            //Employee e1 = new Employee("sda"); 
            //에러 발생 인스턴스 생성 불가 (클래스와 달리 인스턴스를 생성할 수 없다)
            //Console.WriteLine(m1.name); //protected라 접근 불가
            m1.Display(); // 추상 메소드를 이용하면 protected 변수에도 접근 가능
            // 추상 메소드는 인터페이스처럼 한번 선언하면 자식 클래스에서 
            // 오버라이드를 이용하여 반드시 정의하고 사용해야 한다.
            Employee e1 = new Manager("2K sports"); //자식클래스선언
            e1.Display();//추상클래스 실행 가능 
        }
    }
}
