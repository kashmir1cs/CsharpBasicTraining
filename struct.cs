using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// struct : class와 유사하나 상속/ 인터페이스 불가, int/ string 등이 struct (구조체)
namespace CsharpBasicChaptor07_01_1
{
    class Program
    {
        struct PointS
        {
            public int x;
            public int y;
            // 구조체안에 생성자 설정 가능
            public PointS(int x, int y ) // 구조체의 생성자는 매개변수를 넣어 만들어야 한다. 문법에 유의
            // Point 에서 int x, int y는 지역변수
            {
                // 지역변수이용하기 위해 this 사용
                this.x = x;
                this.y = y;
            }
        }
        class PointC
        {
            public int x;
            public int y;
            // 구조체안에 생성자 설정 가능
            public PointC(int x, int y) // 구조체의 생성자는 매개변수를 넣어 만들어야 한다. 문법에 유의
            // Point 에서 int x, int y는 지역변수
            {
                // 지역변수이용하기 위해 this 사용
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            PointS p1 = new PointS(1, 2);
            PointC p2 = new PointC(1, 2);
            PointS p3= p1; // 값에 의한 복사
            PointC p4 = p2; // 참조에 의한 복사 class는 참조에 의한 복사, 같은 곳을 참조하므로 p2변 값도 같이 변함
            
            Console.WriteLine(" {0}  {1} ", p1.x, p1.y);
            Console.WriteLine(" {0}  {1} ", p2.x, p2.y);
            p3.x = 11;
            p4.x = 11;

            Console.WriteLine(" {0}  {1} ", p1.x, p3.x);
            Console.WriteLine(" {0}  {1} ", p2.x, p4.x);
        }
    }
}
