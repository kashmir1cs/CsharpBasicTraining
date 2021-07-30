using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 제네릭 프로그래밍 
// 일반화 : 특수한 개념에서 공통된 개념을 찾아 묶는 것
// 제네릭 클래스 : 데이터 타입을 일반화한 클래스
// 제네릭 메소드 : 데이터 타입을 일반화한 메소드
// 오버로딩 없이도 여러 타입의 변수 처리 가능
// 컴파일 시점에 타입을 알려준다
// 간결하게 코딩하는게 가능해진다.
namespace CsharpBasicChaptor1001
{
    class Human<T>
        where T:class // 구조체는 입력 방지 가능 , string은 class
    {
        public T name; // 필드
        public Human(T name) //제네릭 클래스 사용
        {
            this.name = name; // 메소드안에서 지역변수와 같은 이름의 필드를 참조할 때 사용
        }
    }
    class Chap1001
    {
        static void Main(string[] args)
        {
            Human<string> h1 = new Human<string>("답내만"); //타입을 알려줌 <type>
            // 구조체는 입력 방지 가능
/*            Human<int> h2 = new Human<int>(230); //타입을 알려줌 <type>
            Human<float> h3 = new Human<float>(230.45631321f); //타입을 알려줌 <type>
*/
            Console.WriteLine(h1.name);
/*            
            Console.WriteLine(h2.name);
            Console.WriteLine(h3.name);
*/
        }
    }
}
