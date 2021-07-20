using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 클래스 지정자
// public : 내부/외부/파생클래스, 프로젝트
// internal : 내부/외부/파생 클래스
// protected : 내부/파생 클래스
// private : 내부 클래스
// protected internal : 내부 클래스, 파생 클래스, 외부 클래스 중에서 사용하는 클래스가 같은 어셈블리 안에 있을 때 접근 가능
// struct : 클래스와 유사하나 상속 불가, 안정성은 높음, 인터페이스는 사용 불가
namespace CsharpBasicChaptor07_01
{

    class Chap0701
    {
        // 상속관계 만들기
        class Animal
        {
            private void A() {  }
            protected void B() { }
            public void C() { }
            public void AnimalMethod()
            {
                A(); 
                B(); 
                C(); 
            }
        }
        class Human : Animal
        {
            public void HumanMethod()
            {
                A(); // private 접근 지시어로 선언한 메소드 접근은 같은 클래스 안에서만 접근 가능
                B(); // protected는 파생 클래스에선 사용 가능 
                C(); // protected internal은 파생클래스에서 사용 가능
            }
        }
        static void Main(string[] args)
        {
            int a = 10; // int : struct 중 하나
            Human JS = new Human();
            // C(), AnimalMethod()만 사용 가능, 그외 Method는 사용 불가
            JS.C();
            JS.AnimalMethod();
        }
    }
}
