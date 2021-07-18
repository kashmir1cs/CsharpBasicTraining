using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Metho 값 전달
// Call by reference
namespace CsharpBasicChaptor05_03
{
    class Chap0503
    {
/*        // 값에 의한 호출
        static void Change(int c, int d) // 숫자 두개를 바꾸는 Method
        // c=a, d=b가 입력
        {
            int t; // c를 저장할 임시 변수 선언
            t = c; // t==55
            c = d; // c==-9
            d = t; // d==55
            Console.WriteLine("{0} {1}", c, d);
        }
        static void Main(string[] args)
        {
            int a = 55, b = -9;
            Console.WriteLine("{0} {1}", a,b);
            Change(a, b); // Call by Value
            Console.WriteLine("{0} {1}", a, b);
        }
*/
/*        // 참조에 의한 호출 : 키워드 ref 사용
        static void Change(ref int c, ref int d) // 숫자 두개를 바꾸는 Method
        // c는 a를 참조, d는 b를 참조
        {
            int t; // c를 저장할 임시 변수 선언
            t = c; // main method의 a의 값을 지역 변수 t에 할당, t==55
            c = d; // main method의 b의 값을 main method의 변수 a에 대입
            d = t; // 지역변수 t에 들어있는 55를 main method의 b 변수에 대힙
            Console.WriteLine("{0} {1}", c, d);
        }
        static void Main(string[] args)
        {
            int a = 55, b = -9;
            Console.WriteLine("{0} {1}", a, b);
            Change(ref a, ref b); // Call by Ref.
            Console.WriteLine("{0} {1}", a, b);
        }*/
        // 이름에 의한 파라미터 호출
        // 선택적 호출(Optional parameter)
        // 선택적 매개변수는 필수 매개변수 다음에 나와야한다 (에러발생)
        static void Animal(string type, string gender="Male")
        {
            Console.WriteLine("종류 : {0} / 성별 : {1}", type, gender);
        }
        static void Main(string[] args)
        {
            Animal("Dog", "Male");
            Animal("Cat", "Female");
            Animal(gender:"Male", type:"Tiger");// 변수명을 지정하여 순서 지정가능
            Animal("리트리버");
        }
    }
}
